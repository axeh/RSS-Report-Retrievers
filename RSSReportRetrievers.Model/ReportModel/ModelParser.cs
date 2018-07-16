using System.Collections.Generic;
using System.Xml;

namespace RSSReportRetrievers.Model.ReportModel
{
    internal class ModelParser
    {
        private readonly XmlDocument doc = new XmlDocument();
        private readonly Dictionary<string, string> guids = new Dictionary<string, string>();
        private readonly XmlNamespaceManager myNamespaceMgr = new XmlNamespaceManager(new NameTable());

        public bool LoadSMDL(string smdl)
        {
            myNamespaceMgr.AddNamespace("ds", "http://schemas.microsoft.com/sqlserver/2004/10/semanticmodeling");
            doc.LoadXml(smdl);
            var dictionary = new Dictionary<string, string>();
            AddEntityIDs();
            AddEntityAttributeIDs();
            AddEntityRoleIDs();
            AddIdentifyingAttributes();
            return true;
        }

        public bool ContainsGUID(string guid)
        {
            return guids.ContainsKey(guid);
        }

        private void AddEntityIDs()
        {
            AddIDValue("//ds:SemanticModel/ds:Entities/ds:Entity");
        }

        private void AddEntityAttributeIDs()
        {
            AddIDValue("//ds:SemanticModel/ds:Entities/ds:Entity/ds:Fields/ds:Attribute");
        }

        private void AddEntityRoleIDs()
        {
            AddIDValue("//ds:SemanticModel/ds:Entities/ds:Entity/ds:Fields/ds:Role");
        }

        private void AddIdentifyingAttributes()
        {
            foreach (XmlNode selectNode in doc.SelectNodes(
                "//ds:Entity/ds:IdentifyingAttributes/ds:AttributeReference/ds:AttributeID", myNamespaceMgr))
            {
                var innerText = selectNode.InnerText;
                if (!guids.ContainsKey(innerText))
                    guids.Add(innerText, "Exists...");
            }
        }

        private void AddIDValue(string xPath)
        {
            foreach (XmlNode selectNode in doc.SelectNodes(xPath, myNamespaceMgr))
            {
                var key = selectNode.Attributes["ID"].Value;
                if (!guids.ContainsKey(key))
                    guids.Add(key, "Exists...");
            }
        }
    }
}
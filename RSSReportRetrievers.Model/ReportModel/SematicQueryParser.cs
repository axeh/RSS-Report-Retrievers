using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RSSReportRetrievers.Model.ReportModel
{
    public class SematicQueryParser
    {
        public static ICollection<string> ExtractQueryReferenceGUIDs(string rdlFile)
        {
            var xmlNodeList = ExtractCommandXML(rdlFile).SelectNodes("//ns:EntityID|//ns:AttributeID|//ns:RoleID",
                GetNSNameSpaceMgr("http://schemas.microsoft.com/sqlserver/2004/10/semanticmodeling"));
            var dictionary = new Dictionary<string, string>();
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                var innerXml = xmlNode.InnerXml;
                if (!dictionary.ContainsKey(innerXml))
                    dictionary.Add(innerXml, "exists...");
            }

            return dictionary.Keys;
        }

        private static XmlNamespaceManager GetNSNameSpaceMgr(string nameSpace)
        {
            var namespaceManager = new XmlNamespaceManager(new NameTable());
            namespaceManager.AddNamespace("ns", nameSpace);
            return namespaceManager;
        }

        private static XmlDocument ExtractCommandXML(string rdlFile)
        {
            var nsNameSpaceMgr =
                GetNSNameSpaceMgr("http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition");
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(rdlFile);
            return ConstructXMLFromEscapedString(xmlDocument
                .SelectSingleNode("/ns:Report/ns:DataSets/ns:DataSet/ns:Query/ns:CommandText", nsNameSpaceMgr)
                .InnerText);
        }

        private static XmlDocument ConstructXMLFromEscapedString(string escapedXML)
        {
            return (XmlDocument) new XmlSerializer(typeof(XmlDocument)).Deserialize(new StringReader(escapedXML));
        }
    }
}
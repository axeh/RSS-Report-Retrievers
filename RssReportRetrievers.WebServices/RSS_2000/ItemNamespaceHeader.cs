
// Type: RSS_Report_Retrievers.RSS_2000.ItemNamespaceHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class ItemNamespaceHeader : SoapHeader
  {
    private ItemNamespaceEnum itemNamespaceField;

    public ItemNamespaceEnum ItemNamespace
    {
      get
      {
        return this.itemNamespaceField;
      }
      set
      {
        this.itemNamespaceField = value;
      }
    }
  }
}

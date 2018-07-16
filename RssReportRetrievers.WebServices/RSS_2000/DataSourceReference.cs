
// Type: RSS_Report_Retrievers.RSS_2000.DataSourceReference




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class DataSourceReference : DataSourceDefinitionOrReference
  {
    private string referenceField;

    public string Reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }
}

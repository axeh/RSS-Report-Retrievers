
// Type: RSS_Report_Retrievers.RSS_2000.DataSource




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class DataSource
  {
    private string nameField;
    private DataSourceDefinitionOrReference itemField;

    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    [XmlElement("InvalidDataSourceReference", typeof (InvalidDataSourceReference))]
    [XmlElement("DataSourceReference", typeof (DataSourceReference))]
    [XmlElement("DataSourceDefinition", typeof (DataSourceDefinition))]
    public DataSourceDefinitionOrReference Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }
}

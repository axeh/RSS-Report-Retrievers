
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.DataSource




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
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

    [XmlElement("DataSourceReference", typeof (DataSourceReference))]
    [XmlElement("DataSourceDefinition", typeof (DataSourceDefinition))]
    [XmlElement("InvalidDataSourceReference", typeof (InvalidDataSourceReference))]
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

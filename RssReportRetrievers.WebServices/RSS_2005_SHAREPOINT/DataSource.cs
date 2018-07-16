
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.DataSource




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DesignerCategory("code")]
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

    [XmlElement("DataSourceDefinition", typeof (DataSourceDefinition))]
    [XmlElement("DataSourceReference", typeof (DataSourceReference))]
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

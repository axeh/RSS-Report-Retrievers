
// Type: RSS_Report_Retrievers.RSS_2000.DataRetrievalPlan




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
  public class DataRetrievalPlan
  {
    private DataSourceDefinitionOrReference itemField;
    private DataSetDefinition dataSetField;

    [XmlElement("InvalidDataSourceReference", typeof (InvalidDataSourceReference))]
    [XmlElement("DataSourceDefinition", typeof (DataSourceDefinition))]
    [XmlElement("DataSourceReference", typeof (DataSourceReference))]
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

    public DataSetDefinition DataSet
    {
      get
      {
        return this.dataSetField;
      }
      set
      {
        this.dataSetField = value;
      }
    }
  }
}

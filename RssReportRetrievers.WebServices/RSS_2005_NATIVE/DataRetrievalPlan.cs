
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.DataRetrievalPlan




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [Serializable]
  public class DataRetrievalPlan
  {
    private DataSourceDefinitionOrReference itemField;
    private DataSetDefinition dataSetField;

    [XmlElement("DataSourceReference", typeof (DataSourceReference))]
    [XmlElement("InvalidDataSourceReference", typeof (InvalidDataSourceReference))]
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

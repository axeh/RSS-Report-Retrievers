
// Type: RSS_Report_Retrievers.RSS_2000.DataSourcePrompt




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class DataSourcePrompt
  {
    private string nameField;
    private string dataSourceIDField;
    private string promptField;

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

    public string DataSourceID
    {
      get
      {
        return this.dataSourceIDField;
      }
      set
      {
        this.dataSourceIDField = value;
      }
    }

    public string Prompt
    {
      get
      {
        return this.promptField;
      }
      set
      {
        this.promptField = value;
      }
    }
  }
}

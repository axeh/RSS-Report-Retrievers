
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.QueryDefinition




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class QueryDefinition
  {
    private string commandTypeField;
    private string commandTextField;
    private int timeoutField;
    private bool timeoutFieldSpecified;

    public string CommandType
    {
      get
      {
        return this.commandTypeField;
      }
      set
      {
        this.commandTypeField = value;
      }
    }

    public string CommandText
    {
      get
      {
        return this.commandTextField;
      }
      set
      {
        this.commandTextField = value;
      }
    }

    public int Timeout
    {
      get
      {
        return this.timeoutField;
      }
      set
      {
        this.timeoutField = value;
      }
    }

    [XmlIgnore]
    public bool TimeoutSpecified
    {
      get
      {
        return this.timeoutFieldSpecified;
      }
      set
      {
        this.timeoutFieldSpecified = value;
      }
    }
  }
}

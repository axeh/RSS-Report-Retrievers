
// Type: RSS_Report_Retrievers.RSS_2000.Task




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
  public class Task
  {
    private string taskIDField;
    private string nameField;
    private string descriptionField;

    public string TaskID
    {
      get
      {
        return this.taskIDField;
      }
      set
      {
        this.taskIDField = value;
      }
    }

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

    public string Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }
  }
}

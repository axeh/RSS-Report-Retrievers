
// Type: RSS_Report_Retrievers.RSS_2000.Job




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
  public class Job
  {
    private string jobIDField;
    private string nameField;
    private string pathField;
    private string descriptionField;
    private string machineField;
    private string userField;
    private DateTime startDateTimeField;
    private JobActionEnum actionField;
    private JobTypeEnum typeField;
    private JobStatusEnum statusField;

    public string JobID
    {
      get
      {
        return this.jobIDField;
      }
      set
      {
        this.jobIDField = value;
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

    public string Path
    {
      get
      {
        return this.pathField;
      }
      set
      {
        this.pathField = value;
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

    public string Machine
    {
      get
      {
        return this.machineField;
      }
      set
      {
        this.machineField = value;
      }
    }

    public string User
    {
      get
      {
        return this.userField;
      }
      set
      {
        this.userField = value;
      }
    }

    public DateTime StartDateTime
    {
      get
      {
        return this.startDateTimeField;
      }
      set
      {
        this.startDateTimeField = value;
      }
    }

    public JobActionEnum Action
    {
      get
      {
        return this.actionField;
      }
      set
      {
        this.actionField = value;
      }
    }

    public JobTypeEnum Type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }

    public JobStatusEnum Status
    {
      get
      {
        return this.statusField;
      }
      set
      {
        this.statusField = value;
      }
    }
  }
}

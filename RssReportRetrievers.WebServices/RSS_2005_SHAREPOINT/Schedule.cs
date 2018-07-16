
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.Schedule




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
  public class Schedule
  {
    private string scheduleIDField;
    private string nameField;
    private ScheduleDefinition definitionField;
    private string descriptionField;
    private string creatorField;
    private DateTime nextRunTimeField;
    private bool nextRunTimeFieldSpecified;
    private DateTime lastRunTimeField;
    private bool lastRunTimeFieldSpecified;
    private bool referencesPresentField;
    private ScheduleStateEnum stateField;

    public string ScheduleID
    {
      get
      {
        return this.scheduleIDField;
      }
      set
      {
        this.scheduleIDField = value;
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

    public ScheduleDefinition Definition
    {
      get
      {
        return this.definitionField;
      }
      set
      {
        this.definitionField = value;
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

    public string Creator
    {
      get
      {
        return this.creatorField;
      }
      set
      {
        this.creatorField = value;
      }
    }

    public DateTime NextRunTime
    {
      get
      {
        return this.nextRunTimeField;
      }
      set
      {
        this.nextRunTimeField = value;
      }
    }

    [XmlIgnore]
    public bool NextRunTimeSpecified
    {
      get
      {
        return this.nextRunTimeFieldSpecified;
      }
      set
      {
        this.nextRunTimeFieldSpecified = value;
      }
    }

    public DateTime LastRunTime
    {
      get
      {
        return this.lastRunTimeField;
      }
      set
      {
        this.lastRunTimeField = value;
      }
    }

    [XmlIgnore]
    public bool LastRunTimeSpecified
    {
      get
      {
        return this.lastRunTimeFieldSpecified;
      }
      set
      {
        this.lastRunTimeFieldSpecified = value;
      }
    }

    public bool ReferencesPresent
    {
      get
      {
        return this.referencesPresentField;
      }
      set
      {
        this.referencesPresentField = value;
      }
    }

    public ScheduleStateEnum State
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }
  }
}

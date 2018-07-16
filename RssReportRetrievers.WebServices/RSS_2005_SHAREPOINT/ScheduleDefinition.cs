
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ScheduleDefinition




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
  public class ScheduleDefinition : ScheduleDefinitionOrReference
  {
    private DateTime startDateTimeField;
    private DateTime endDateField;
    private bool endDateFieldSpecified;
    private RecurrencePattern itemField;

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

    public DateTime EndDate
    {
      get
      {
        return this.endDateField;
      }
      set
      {
        this.endDateField = value;
      }
    }

    [XmlIgnore]
    public bool EndDateSpecified
    {
      get
      {
        return this.endDateFieldSpecified;
      }
      set
      {
        this.endDateFieldSpecified = value;
      }
    }

    [XmlElement("MonthlyRecurrence", typeof (MonthlyRecurrence))]
    [XmlElement("MinuteRecurrence", typeof (MinuteRecurrence))]
    [XmlElement("MonthlyDOWRecurrence", typeof (MonthlyDOWRecurrence))]
    [XmlElement("DailyRecurrence", typeof (DailyRecurrence))]
    [XmlElement("WeeklyRecurrence", typeof (WeeklyRecurrence))]
    public RecurrencePattern Item
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

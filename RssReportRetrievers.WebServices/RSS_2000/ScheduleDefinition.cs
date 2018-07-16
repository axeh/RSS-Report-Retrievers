
// Type: RSS_Report_Retrievers.RSS_2000.ScheduleDefinition




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
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
    [XmlElement("DailyRecurrence", typeof (DailyRecurrence))]
    [XmlElement("WeeklyRecurrence", typeof (WeeklyRecurrence))]
    [XmlElement("MonthlyDOWRecurrence", typeof (MonthlyDOWRecurrence))]
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

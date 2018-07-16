
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ScheduleDefinition




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
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
    [XmlElement("WeeklyRecurrence", typeof (WeeklyRecurrence))]
    [XmlElement("MonthlyDOWRecurrence", typeof (MonthlyDOWRecurrence))]
    [XmlElement("DailyRecurrence", typeof (DailyRecurrence))]
    [XmlElement("MinuteRecurrence", typeof (MinuteRecurrence))]
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

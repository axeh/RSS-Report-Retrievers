
// Type: RSS_Report_Retrievers.RSS_2000.WeeklyRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DesignerCategory("code")]
  [Serializable]
  public class WeeklyRecurrence : RecurrencePattern
  {
    private int weeksIntervalField;
    private bool weeksIntervalFieldSpecified;
    private DaysOfWeekSelector daysOfWeekField;

    public int WeeksInterval
    {
      get
      {
        return this.weeksIntervalField;
      }
      set
      {
        this.weeksIntervalField = value;
      }
    }

    [XmlIgnore]
    public bool WeeksIntervalSpecified
    {
      get
      {
        return this.weeksIntervalFieldSpecified;
      }
      set
      {
        this.weeksIntervalFieldSpecified = value;
      }
    }

    public DaysOfWeekSelector DaysOfWeek
    {
      get
      {
        return this.daysOfWeekField;
      }
      set
      {
        this.daysOfWeekField = value;
      }
    }
  }
}

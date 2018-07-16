
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.MonthlyDOWRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [Serializable]
  public class MonthlyDOWRecurrence : RecurrencePattern
  {
    private WeekNumberEnum whichWeekField;
    private bool whichWeekFieldSpecified;
    private DaysOfWeekSelector daysOfWeekField;
    private MonthsOfYearSelector monthsOfYearField;

    public WeekNumberEnum WhichWeek
    {
      get
      {
        return this.whichWeekField;
      }
      set
      {
        this.whichWeekField = value;
      }
    }

    [XmlIgnore]
    public bool WhichWeekSpecified
    {
      get
      {
        return this.whichWeekFieldSpecified;
      }
      set
      {
        this.whichWeekFieldSpecified = value;
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

    public MonthsOfYearSelector MonthsOfYear
    {
      get
      {
        return this.monthsOfYearField;
      }
      set
      {
        this.monthsOfYearField = value;
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.MonthlyRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class MonthlyRecurrence : RecurrencePattern
  {
    private string daysField;
    private MonthsOfYearSelector monthsOfYearField;

    public string Days
    {
      get
      {
        return this.daysField;
      }
      set
      {
        this.daysField = value;
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

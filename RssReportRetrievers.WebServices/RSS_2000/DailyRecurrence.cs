
// Type: RSS_Report_Retrievers.RSS_2000.DailyRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DailyRecurrence : RecurrencePattern
  {
    private int daysIntervalField;

    public int DaysInterval
    {
      get
      {
        return this.daysIntervalField;
      }
      set
      {
        this.daysIntervalField = value;
      }
    }
  }
}

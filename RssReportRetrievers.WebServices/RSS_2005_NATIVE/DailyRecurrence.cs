
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.DailyRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
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

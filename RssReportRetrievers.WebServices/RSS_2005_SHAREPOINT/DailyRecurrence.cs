
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.DailyRecurrence




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

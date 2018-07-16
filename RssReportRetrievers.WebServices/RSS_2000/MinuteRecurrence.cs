
// Type: RSS_Report_Retrievers.RSS_2000.MinuteRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class MinuteRecurrence : RecurrencePattern
  {
    private int minutesIntervalField;

    public int MinutesInterval
    {
      get
      {
        return this.minutesIntervalField;
      }
      set
      {
        this.minutesIntervalField = value;
      }
    }
  }
}

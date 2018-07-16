
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.MinuteRecurrence




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
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

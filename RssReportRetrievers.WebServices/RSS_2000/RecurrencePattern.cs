
// Type: RSS_Report_Retrievers.RSS_2000.RecurrencePattern




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlInclude(typeof (WeeklyRecurrence))]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [XmlInclude(typeof (MinuteRecurrence))]
  [XmlInclude(typeof (DailyRecurrence))]
  [XmlInclude(typeof (MonthlyRecurrence))]
  [XmlInclude(typeof (MonthlyDOWRecurrence))]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class RecurrencePattern
  {
  }
}

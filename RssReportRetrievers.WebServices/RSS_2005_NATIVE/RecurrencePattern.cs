
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.RecurrencePattern




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [XmlInclude(typeof (MonthlyRecurrence))]
  [XmlInclude(typeof (DailyRecurrence))]
  [XmlInclude(typeof (WeeklyRecurrence))]
  [XmlInclude(typeof (MinuteRecurrence))]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlInclude(typeof (MonthlyDOWRecurrence))]
  [DesignerCategory("code")]
  [Serializable]
  public class RecurrencePattern
  {
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.RecurrencePattern




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [XmlInclude(typeof (DailyRecurrence))]
  [XmlInclude(typeof (MonthlyDOWRecurrence))]
  [XmlInclude(typeof (MinuteRecurrence))]
  [XmlInclude(typeof (WeeklyRecurrence))]
  [XmlInclude(typeof (MonthlyRecurrence))]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [Serializable]
  public class RecurrencePattern
  {
  }
}

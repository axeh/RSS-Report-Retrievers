
// Type: RSS_Report_Retrievers.RSS_2000.ScheduleStateEnum




using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public enum ScheduleStateEnum
  {
    Ready,
    Running,
    Paused,
    Expired,
    Failing,
  }
}

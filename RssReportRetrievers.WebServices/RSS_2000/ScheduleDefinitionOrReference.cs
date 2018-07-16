
// Type: RSS_Report_Retrievers.RSS_2000.ScheduleDefinitionOrReference




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlInclude(typeof (ScheduleReference))]
  [XmlInclude(typeof (ScheduleDefinition))]
  [XmlInclude(typeof (NoSchedule))]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class ScheduleDefinitionOrReference
  {
  }
}

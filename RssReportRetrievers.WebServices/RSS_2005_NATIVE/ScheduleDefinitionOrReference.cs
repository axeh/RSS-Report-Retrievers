
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ScheduleDefinitionOrReference




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [XmlInclude(typeof (ScheduleReference))]
  [XmlInclude(typeof (ScheduleDefinition))]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlInclude(typeof (NoSchedule))]
  [DesignerCategory("code")]
  [Serializable]
  public class ScheduleDefinitionOrReference
  {
  }
}

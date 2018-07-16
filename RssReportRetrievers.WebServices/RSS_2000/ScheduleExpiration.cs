
// Type: RSS_Report_Retrievers.RSS_2000.ScheduleExpiration




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class ScheduleExpiration : ExpirationDefinition
  {
    private ScheduleDefinitionOrReference itemField;

    [XmlElement("ScheduleReference", typeof (ScheduleReference))]
    [XmlElement("ScheduleDefinition", typeof (ScheduleDefinition))]
    public ScheduleDefinitionOrReference Item
    {
      get
      {
        return this.itemField;
      }
      set
      {
        this.itemField = value;
      }
    }
  }
}

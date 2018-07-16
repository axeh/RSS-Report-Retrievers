
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ScheduleReference




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [Serializable]
  public class ScheduleReference : ScheduleDefinitionOrReference
  {
    private string scheduleIDField;
    private ScheduleDefinition definitionField;

    public string ScheduleID
    {
      get
      {
        return this.scheduleIDField;
      }
      set
      {
        this.scheduleIDField = value;
      }
    }

    public ScheduleDefinition Definition
    {
      get
      {
        return this.definitionField;
      }
      set
      {
        this.definitionField = value;
      }
    }
  }
}

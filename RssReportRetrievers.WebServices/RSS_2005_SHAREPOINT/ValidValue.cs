
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ValidValue




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [Serializable]
  public class ValidValue
  {
    private string labelField;
    private string valueField;

    public string Label
    {
      get
      {
        return this.labelField;
      }
      set
      {
        this.labelField = value;
      }
    }

    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }
}

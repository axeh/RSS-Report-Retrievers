
// Type: RSS_Report_Retrievers.RSS_2000.ValidValue




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
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

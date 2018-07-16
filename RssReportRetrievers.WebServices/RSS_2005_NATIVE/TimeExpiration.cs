
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.TimeExpiration




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [Serializable]
  public class TimeExpiration : ExpirationDefinition
  {
    private int minutesField;

    public int Minutes
    {
      get
      {
        return this.minutesField;
      }
      set
      {
        this.minutesField = value;
      }
    }
  }
}

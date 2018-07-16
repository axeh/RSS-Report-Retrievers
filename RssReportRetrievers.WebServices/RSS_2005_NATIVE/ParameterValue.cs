
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ParameterValue




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [Serializable]
  public class ParameterValue : ParameterValueOrFieldReference
  {
    private string nameField;
    private string valueField;
    private string labelField;

    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
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
  }
}

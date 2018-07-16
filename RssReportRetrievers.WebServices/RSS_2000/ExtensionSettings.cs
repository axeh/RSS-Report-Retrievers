
// Type: RSS_Report_Retrievers.RSS_2000.ExtensionSettings




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ExtensionSettings
  {
    private string extensionField;
    private ParameterValueOrFieldReference[] parameterValuesField;

    public string Extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    [XmlArrayItem(typeof (ParameterFieldReference))]
    [XmlArrayItem(typeof (ParameterValue))]
    public ParameterValueOrFieldReference[] ParameterValues
    {
      get
      {
        return this.parameterValuesField;
      }
      set
      {
        this.parameterValuesField = value;
      }
    }
  }
}

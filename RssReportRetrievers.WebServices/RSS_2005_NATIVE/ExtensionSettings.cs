
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ExtensionSettings




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
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

    [XmlArrayItem(typeof (ParameterValue))]
    [XmlArrayItem(typeof (ParameterFieldReference))]
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

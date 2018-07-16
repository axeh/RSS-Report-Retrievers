
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ReportParameter




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class ReportParameter
  {
    private string nameField;
    private ParameterTypeEnum typeField;
    private bool typeFieldSpecified;
    private bool nullableField;
    private bool nullableFieldSpecified;
    private bool allowBlankField;
    private bool allowBlankFieldSpecified;
    private bool multiValueField;
    private bool multiValueFieldSpecified;
    private bool queryParameterField;
    private bool queryParameterFieldSpecified;
    private string promptField;
    private bool promptUserField;
    private bool promptUserFieldSpecified;
    private string[] dependenciesField;
    private bool validValuesQueryBasedField;
    private bool validValuesQueryBasedFieldSpecified;
    private ValidValue[] validValuesField;
    private bool defaultValuesQueryBasedField;
    private bool defaultValuesQueryBasedFieldSpecified;
    private string[] defaultValuesField;
    private ParameterStateEnum stateField;
    private bool stateFieldSpecified;
    private string errorMessageField;

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

    public ParameterTypeEnum Type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }

    [XmlIgnore]
    public bool TypeSpecified
    {
      get
      {
        return this.typeFieldSpecified;
      }
      set
      {
        this.typeFieldSpecified = value;
      }
    }

    public bool Nullable
    {
      get
      {
        return this.nullableField;
      }
      set
      {
        this.nullableField = value;
      }
    }

    [XmlIgnore]
    public bool NullableSpecified
    {
      get
      {
        return this.nullableFieldSpecified;
      }
      set
      {
        this.nullableFieldSpecified = value;
      }
    }

    public bool AllowBlank
    {
      get
      {
        return this.allowBlankField;
      }
      set
      {
        this.allowBlankField = value;
      }
    }

    [XmlIgnore]
    public bool AllowBlankSpecified
    {
      get
      {
        return this.allowBlankFieldSpecified;
      }
      set
      {
        this.allowBlankFieldSpecified = value;
      }
    }

    public bool MultiValue
    {
      get
      {
        return this.multiValueField;
      }
      set
      {
        this.multiValueField = value;
      }
    }

    [XmlIgnore]
    public bool MultiValueSpecified
    {
      get
      {
        return this.multiValueFieldSpecified;
      }
      set
      {
        this.multiValueFieldSpecified = value;
      }
    }

    public bool QueryParameter
    {
      get
      {
        return this.queryParameterField;
      }
      set
      {
        this.queryParameterField = value;
      }
    }

    [XmlIgnore]
    public bool QueryParameterSpecified
    {
      get
      {
        return this.queryParameterFieldSpecified;
      }
      set
      {
        this.queryParameterFieldSpecified = value;
      }
    }

    public string Prompt
    {
      get
      {
        return this.promptField;
      }
      set
      {
        this.promptField = value;
      }
    }

    public bool PromptUser
    {
      get
      {
        return this.promptUserField;
      }
      set
      {
        this.promptUserField = value;
      }
    }

    [XmlIgnore]
    public bool PromptUserSpecified
    {
      get
      {
        return this.promptUserFieldSpecified;
      }
      set
      {
        this.promptUserFieldSpecified = value;
      }
    }

    [XmlArrayItem("Dependency")]
    public string[] Dependencies
    {
      get
      {
        return this.dependenciesField;
      }
      set
      {
        this.dependenciesField = value;
      }
    }

    public bool ValidValuesQueryBased
    {
      get
      {
        return this.validValuesQueryBasedField;
      }
      set
      {
        this.validValuesQueryBasedField = value;
      }
    }

    [XmlIgnore]
    public bool ValidValuesQueryBasedSpecified
    {
      get
      {
        return this.validValuesQueryBasedFieldSpecified;
      }
      set
      {
        this.validValuesQueryBasedFieldSpecified = value;
      }
    }

    public ValidValue[] ValidValues
    {
      get
      {
        return this.validValuesField;
      }
      set
      {
        this.validValuesField = value;
      }
    }

    public bool DefaultValuesQueryBased
    {
      get
      {
        return this.defaultValuesQueryBasedField;
      }
      set
      {
        this.defaultValuesQueryBasedField = value;
      }
    }

    [XmlIgnore]
    public bool DefaultValuesQueryBasedSpecified
    {
      get
      {
        return this.defaultValuesQueryBasedFieldSpecified;
      }
      set
      {
        this.defaultValuesQueryBasedFieldSpecified = value;
      }
    }

    [XmlArrayItem("Value")]
    public string[] DefaultValues
    {
      get
      {
        return this.defaultValuesField;
      }
      set
      {
        this.defaultValuesField = value;
      }
    }

    public ParameterStateEnum State
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    [XmlIgnore]
    public bool StateSpecified
    {
      get
      {
        return this.stateFieldSpecified;
      }
      set
      {
        this.stateFieldSpecified = value;
      }
    }

    public string ErrorMessage
    {
      get
      {
        return this.errorMessageField;
      }
      set
      {
        this.errorMessageField = value;
      }
    }
  }
}

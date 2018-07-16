
// Type: RSS_Report_Retrievers.RSS_2000.ExtensionParameter




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class ExtensionParameter
  {
    private string nameField;
    private string displayNameField;
    private bool requiredField;
    private bool requiredFieldSpecified;
    private bool readOnlyField;
    private string valueField;
    private string errorField;
    private bool encryptedField;
    private bool isPasswordField;
    private ValidValue[] validValuesField;

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

    public string DisplayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    public bool Required
    {
      get
      {
        return this.requiredField;
      }
      set
      {
        this.requiredField = value;
      }
    }

    [XmlIgnore]
    public bool RequiredSpecified
    {
      get
      {
        return this.requiredFieldSpecified;
      }
      set
      {
        this.requiredFieldSpecified = value;
      }
    }

    public bool ReadOnly
    {
      get
      {
        return this.readOnlyField;
      }
      set
      {
        this.readOnlyField = value;
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

    public string Error
    {
      get
      {
        return this.errorField;
      }
      set
      {
        this.errorField = value;
      }
    }

    public bool Encrypted
    {
      get
      {
        return this.encryptedField;
      }
      set
      {
        this.encryptedField = value;
      }
    }

    public bool IsPassword
    {
      get
      {
        return this.isPasswordField;
      }
      set
      {
        this.isPasswordField = value;
      }
    }

    [XmlArrayItem("Value")]
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
  }
}

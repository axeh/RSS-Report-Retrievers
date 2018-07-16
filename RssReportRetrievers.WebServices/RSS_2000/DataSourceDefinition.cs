
// Type: RSS_Report_Retrievers.RSS_2000.DataSourceDefinition




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
  public class DataSourceDefinition : DataSourceDefinitionOrReference
  {
    private string extensionField;
    private string connectStringField;
    private CredentialRetrievalEnum credentialRetrievalField;
    private bool windowsCredentialsField;
    private bool impersonateUserField;
    private bool impersonateUserFieldSpecified;
    private string promptField;
    private string userNameField;
    private string passwordField;
    private bool enabledField;
    private bool enabledFieldSpecified;

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

    public string ConnectString
    {
      get
      {
        return this.connectStringField;
      }
      set
      {
        this.connectStringField = value;
      }
    }

    public CredentialRetrievalEnum CredentialRetrieval
    {
      get
      {
        return this.credentialRetrievalField;
      }
      set
      {
        this.credentialRetrievalField = value;
      }
    }

    public bool WindowsCredentials
    {
      get
      {
        return this.windowsCredentialsField;
      }
      set
      {
        this.windowsCredentialsField = value;
      }
    }

    public bool ImpersonateUser
    {
      get
      {
        return this.impersonateUserField;
      }
      set
      {
        this.impersonateUserField = value;
      }
    }

    [XmlIgnore]
    public bool ImpersonateUserSpecified
    {
      get
      {
        return this.impersonateUserFieldSpecified;
      }
      set
      {
        this.impersonateUserFieldSpecified = value;
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

    public string UserName
    {
      get
      {
        return this.userNameField;
      }
      set
      {
        this.userNameField = value;
      }
    }

    public string Password
    {
      get
      {
        return this.passwordField;
      }
      set
      {
        this.passwordField = value;
      }
    }

    public bool Enabled
    {
      get
      {
        return this.enabledField;
      }
      set
      {
        this.enabledField = value;
      }
    }

    [XmlIgnore]
    public bool EnabledSpecified
    {
      get
      {
        return this.enabledFieldSpecified;
      }
      set
      {
        this.enabledFieldSpecified = value;
      }
    }
  }
}

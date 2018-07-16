
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.DataSourceDefinition




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DataSourceDefinition : DataSourceDefinitionOrReference
  {
    private string extensionField;
    private string connectStringField;
    private bool useOriginalConnectStringField;
    private bool originalConnectStringExpressionBasedField;
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

    public bool UseOriginalConnectString
    {
      get
      {
        return this.useOriginalConnectStringField;
      }
      set
      {
        this.useOriginalConnectStringField = value;
      }
    }

    public bool OriginalConnectStringExpressionBased
    {
      get
      {
        return this.originalConnectStringExpressionBasedField;
      }
      set
      {
        this.originalConnectStringExpressionBasedField = value;
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

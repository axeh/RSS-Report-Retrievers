
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.DataSourceCredentials




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class DataSourceCredentials
  {
    private string dataSourceNameField;
    private string userNameField;
    private string passwordField;

    public string DataSourceName
    {
      get
      {
        return this.dataSourceNameField;
      }
      set
      {
        this.dataSourceNameField = value;
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
  }
}

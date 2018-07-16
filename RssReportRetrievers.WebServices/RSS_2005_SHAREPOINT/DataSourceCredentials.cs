
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.DataSourceCredentials




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
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


// Type: RSS_Report_Retrievers.RSS_2000.Policy




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class Policy
  {
    private string groupUserNameField;
    private Role[] rolesField;

    public string GroupUserName
    {
      get
      {
        return this.groupUserNameField;
      }
      set
      {
        this.groupUserNameField = value;
      }
    }

    public Role[] Roles
    {
      get
      {
        return this.rolesField;
      }
      set
      {
        this.rolesField = value;
      }
    }
  }
}

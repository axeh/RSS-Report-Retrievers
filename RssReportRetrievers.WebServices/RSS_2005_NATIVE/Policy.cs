
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.Policy




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
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

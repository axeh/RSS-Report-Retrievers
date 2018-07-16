
// Type: RSS_Report_Retrievers.RSS_2000.SessionHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class SessionHeader : SoapHeader
  {
    private string sessionIdField;
    private bool isNewExecutionField;
    private string executionDateTimeField;
    private string expirationDateTimeField;

    public string SessionId
    {
      get
      {
        return this.sessionIdField;
      }
      set
      {
        this.sessionIdField = value;
      }
    }

    public bool IsNewExecution
    {
      get
      {
        return this.isNewExecutionField;
      }
      set
      {
        this.isNewExecutionField = value;
      }
    }

    public string ExecutionDateTime
    {
      get
      {
        return this.executionDateTimeField;
      }
      set
      {
        this.executionDateTimeField = value;
      }
    }

    public string ExpirationDateTime
    {
      get
      {
        return this.expirationDateTimeField;
      }
      set
      {
        this.expirationDateTimeField = value;
      }
    }
  }
}

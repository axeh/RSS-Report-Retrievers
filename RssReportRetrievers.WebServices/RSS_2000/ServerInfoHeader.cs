
// Type: RSS_Report_Retrievers.RSS_2000.ServerInfoHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [Serializable]
  public class ServerInfoHeader : SoapHeader
  {
    private string reportServerVersionNumberField;
    private string reportServerEditionField;

    public string ReportServerVersionNumber
    {
      get
      {
        return this.reportServerVersionNumberField;
      }
      set
      {
        this.reportServerVersionNumberField = value;
      }
    }

    public string ReportServerEdition
    {
      get
      {
        return this.reportServerEditionField;
      }
      set
      {
        this.reportServerEditionField = value;
      }
    }
  }
}

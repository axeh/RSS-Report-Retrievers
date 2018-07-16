
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ServerInfoHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [Serializable]
  public class ServerInfoHeader : SoapHeader
  {
    private string reportServerVersionNumberField;
    private string reportServerEditionField;
    private string reportServerVersionField;
    private string reportServerDateTimeField;
    private TimeZoneInformation reportServerTimeZoneInfoField;
    private XmlAttribute[] anyAttrField;

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

    public string ReportServerVersion
    {
      get
      {
        return this.reportServerVersionField;
      }
      set
      {
        this.reportServerVersionField = value;
      }
    }

    public string ReportServerDateTime
    {
      get
      {
        return this.reportServerDateTimeField;
      }
      set
      {
        this.reportServerDateTimeField = value;
      }
    }

    public TimeZoneInformation ReportServerTimeZoneInfo
    {
      get
      {
        return this.reportServerTimeZoneInfoField;
      }
      set
      {
        this.reportServerTimeZoneInfoField = value;
      }
    }

    [XmlAnyAttribute]
    public XmlAttribute[] AnyAttr
    {
      get
      {
        return this.anyAttrField;
      }
      set
      {
        this.anyAttrField = value;
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ServerInfoHeader




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class ServerInfoHeader : SoapHeader
  {
    private string reportServerVersionNumberField;
    private string reportServerEditionField;
    private string reportServerVersionField;
    private string reportServerDateTimeField;
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

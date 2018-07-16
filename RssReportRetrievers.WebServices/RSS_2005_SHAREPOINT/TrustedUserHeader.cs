
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.TrustedUserHeader




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
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlRoot(IsNullable = false, Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [Serializable]
  public class TrustedUserHeader : SoapHeader
  {
    private string userNameField;
    private byte[] userTokenField;
    private XmlAttribute[] anyAttrField;

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

    [XmlElement(DataType = "base64Binary")]
    public byte[] UserToken
    {
      get
      {
        return this.userTokenField;
      }
      set
      {
        this.userTokenField = value;
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

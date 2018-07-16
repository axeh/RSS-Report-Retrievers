
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.CredentialRetrievalEnum




using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [Serializable]
  public enum CredentialRetrievalEnum
  {
    Prompt,
    Store,
    Integrated,
    None,
  }
}

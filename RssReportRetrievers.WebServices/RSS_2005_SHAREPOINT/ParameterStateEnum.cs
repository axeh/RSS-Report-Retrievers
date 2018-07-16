
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ParameterStateEnum




using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public enum ParameterStateEnum
  {
    HasValidValue,
    MissingValidValue,
    HasOutstandingDependencies,
    DynamicValuesUnavailable,
  }
}

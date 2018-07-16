
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ModelItemTypeEnum




using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public enum ModelItemTypeEnum
  {
    Model,
    EntityFolder,
    FieldFolder,
    Entity,
    Attribute,
    Role,
  }
}

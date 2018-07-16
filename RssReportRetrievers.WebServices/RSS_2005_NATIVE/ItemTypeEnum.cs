﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ItemTypeEnum




using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public enum ItemTypeEnum
  {
    Unknown,
    Folder,
    Report,
    Resource,
    LinkedReport,
    DataSource,
    Model,
  }
}
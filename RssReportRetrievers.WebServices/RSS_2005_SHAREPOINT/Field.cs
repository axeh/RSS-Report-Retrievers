﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.Field




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class Field
  {
    private string aliasField;
    private string nameField;

    public string Alias
    {
      get
      {
        return this.aliasField;
      }
      set
      {
        this.aliasField = value;
      }
    }

    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }
}

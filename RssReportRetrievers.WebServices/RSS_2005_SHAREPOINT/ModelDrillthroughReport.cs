
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ModelDrillthroughReport




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ModelDrillthroughReport
  {
    private string pathField;
    private DrillthroughType typeField;

    public string Path
    {
      get
      {
        return this.pathField;
      }
      set
      {
        this.pathField = value;
      }
    }

    public DrillthroughType Type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }
}

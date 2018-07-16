
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ModelCatalogItem




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class ModelCatalogItem
  {
    private string modelField;
    private string descriptionField;
    private ModelPerspective[] perspectivesField;

    public string Model
    {
      get
      {
        return this.modelField;
      }
      set
      {
        this.modelField = value;
      }
    }

    public string Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    public ModelPerspective[] Perspectives
    {
      get
      {
        return this.perspectivesField;
      }
      set
      {
        this.perspectivesField = value;
      }
    }
  }
}

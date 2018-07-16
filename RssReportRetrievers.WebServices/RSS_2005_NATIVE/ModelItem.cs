
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ModelItem




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class ModelItem
  {
    private string idField;
    private string nameField;
    private ModelItemTypeEnum typeField;
    private string descriptionField;
    private ModelItem[] modelItemsField;

    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
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

    public ModelItemTypeEnum Type
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

    public ModelItem[] ModelItems
    {
      get
      {
        return this.modelItemsField;
      }
      set
      {
        this.modelItemsField = value;
      }
    }
  }
}

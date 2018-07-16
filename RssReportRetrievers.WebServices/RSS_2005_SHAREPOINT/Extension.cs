
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.Extension




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class Extension
  {
    private ExtensionTypeEnum extensionTypeField;
    private string nameField;
    private string localizedNameField;
    private bool visibleField;
    private bool isModelGenerationSupportedField;

    public ExtensionTypeEnum ExtensionType
    {
      get
      {
        return this.extensionTypeField;
      }
      set
      {
        this.extensionTypeField = value;
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

    public string LocalizedName
    {
      get
      {
        return this.localizedNameField;
      }
      set
      {
        this.localizedNameField = value;
      }
    }

    public bool Visible
    {
      get
      {
        return this.visibleField;
      }
      set
      {
        this.visibleField = value;
      }
    }

    public bool IsModelGenerationSupported
    {
      get
      {
        return this.isModelGenerationSupportedField;
      }
      set
      {
        this.isModelGenerationSupportedField = value;
      }
    }
  }
}

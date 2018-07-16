
// Type: RSS_Report_Retrievers.RSS_2000.CatalogItem




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class CatalogItem
  {
    private string idField;
    private string nameField;
    private string pathField;
    private string virtualPathField;
    private ItemTypeEnum typeField;
    private int sizeField;
    private bool sizeFieldSpecified;
    private string descriptionField;
    private bool hiddenField;
    private bool hiddenFieldSpecified;
    private DateTime creationDateField;
    private bool creationDateFieldSpecified;
    private DateTime modifiedDateField;
    private bool modifiedDateFieldSpecified;
    private string createdByField;
    private string modifiedByField;
    private string mimeTypeField;
    private DateTime executionDateField;
    private bool executionDateFieldSpecified;

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

    public string VirtualPath
    {
      get
      {
        return this.virtualPathField;
      }
      set
      {
        this.virtualPathField = value;
      }
    }

    public ItemTypeEnum Type
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

    public int Size
    {
      get
      {
        return this.sizeField;
      }
      set
      {
        this.sizeField = value;
      }
    }

    [XmlIgnore]
    public bool SizeSpecified
    {
      get
      {
        return this.sizeFieldSpecified;
      }
      set
      {
        this.sizeFieldSpecified = value;
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

    public bool Hidden
    {
      get
      {
        return this.hiddenField;
      }
      set
      {
        this.hiddenField = value;
      }
    }

    [XmlIgnore]
    public bool HiddenSpecified
    {
      get
      {
        return this.hiddenFieldSpecified;
      }
      set
      {
        this.hiddenFieldSpecified = value;
      }
    }

    public DateTime CreationDate
    {
      get
      {
        return this.creationDateField;
      }
      set
      {
        this.creationDateField = value;
      }
    }

    [XmlIgnore]
    public bool CreationDateSpecified
    {
      get
      {
        return this.creationDateFieldSpecified;
      }
      set
      {
        this.creationDateFieldSpecified = value;
      }
    }

    public DateTime ModifiedDate
    {
      get
      {
        return this.modifiedDateField;
      }
      set
      {
        this.modifiedDateField = value;
      }
    }

    [XmlIgnore]
    public bool ModifiedDateSpecified
    {
      get
      {
        return this.modifiedDateFieldSpecified;
      }
      set
      {
        this.modifiedDateFieldSpecified = value;
      }
    }

    public string CreatedBy
    {
      get
      {
        return this.createdByField;
      }
      set
      {
        this.createdByField = value;
      }
    }

    public string ModifiedBy
    {
      get
      {
        return this.modifiedByField;
      }
      set
      {
        this.modifiedByField = value;
      }
    }

    public string MimeType
    {
      get
      {
        return this.mimeTypeField;
      }
      set
      {
        this.mimeTypeField = value;
      }
    }

    public DateTime ExecutionDate
    {
      get
      {
        return this.executionDateField;
      }
      set
      {
        this.executionDateField = value;
      }
    }

    [XmlIgnore]
    public bool ExecutionDateSpecified
    {
      get
      {
        return this.executionDateFieldSpecified;
      }
      set
      {
        this.executionDateFieldSpecified = value;
      }
    }
  }
}

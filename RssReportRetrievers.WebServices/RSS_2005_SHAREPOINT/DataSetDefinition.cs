
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.DataSetDefinition




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
  public class DataSetDefinition
  {
    private Field[] fieldsField;
    private QueryDefinition queryField;
    private SensitivityEnum caseSensitivityField;
    private bool caseSensitivityFieldSpecified;
    private string collationField;
    private SensitivityEnum accentSensitivityField;
    private bool accentSensitivityFieldSpecified;
    private SensitivityEnum kanatypeSensitivityField;
    private bool kanatypeSensitivityFieldSpecified;
    private SensitivityEnum widthSensitivityField;
    private bool widthSensitivityFieldSpecified;
    private string nameField;

    public Field[] Fields
    {
      get
      {
        return this.fieldsField;
      }
      set
      {
        this.fieldsField = value;
      }
    }

    public QueryDefinition Query
    {
      get
      {
        return this.queryField;
      }
      set
      {
        this.queryField = value;
      }
    }

    public SensitivityEnum CaseSensitivity
    {
      get
      {
        return this.caseSensitivityField;
      }
      set
      {
        this.caseSensitivityField = value;
      }
    }

    [XmlIgnore]
    public bool CaseSensitivitySpecified
    {
      get
      {
        return this.caseSensitivityFieldSpecified;
      }
      set
      {
        this.caseSensitivityFieldSpecified = value;
      }
    }

    public string Collation
    {
      get
      {
        return this.collationField;
      }
      set
      {
        this.collationField = value;
      }
    }

    public SensitivityEnum AccentSensitivity
    {
      get
      {
        return this.accentSensitivityField;
      }
      set
      {
        this.accentSensitivityField = value;
      }
    }

    [XmlIgnore]
    public bool AccentSensitivitySpecified
    {
      get
      {
        return this.accentSensitivityFieldSpecified;
      }
      set
      {
        this.accentSensitivityFieldSpecified = value;
      }
    }

    public SensitivityEnum KanatypeSensitivity
    {
      get
      {
        return this.kanatypeSensitivityField;
      }
      set
      {
        this.kanatypeSensitivityField = value;
      }
    }

    [XmlIgnore]
    public bool KanatypeSensitivitySpecified
    {
      get
      {
        return this.kanatypeSensitivityFieldSpecified;
      }
      set
      {
        this.kanatypeSensitivityFieldSpecified = value;
      }
    }

    public SensitivityEnum WidthSensitivity
    {
      get
      {
        return this.widthSensitivityField;
      }
      set
      {
        this.widthSensitivityField = value;
      }
    }

    [XmlIgnore]
    public bool WidthSensitivitySpecified
    {
      get
      {
        return this.widthSensitivityFieldSpecified;
      }
      set
      {
        this.widthSensitivityFieldSpecified = value;
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

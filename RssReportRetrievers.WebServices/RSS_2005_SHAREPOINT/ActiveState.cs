
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ActiveState




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [Serializable]
  public class ActiveState
  {
    private bool deliveryExtensionRemovedField;
    private bool deliveryExtensionRemovedFieldSpecified;
    private bool sharedDataSourceRemovedField;
    private bool sharedDataSourceRemovedFieldSpecified;
    private bool missingParameterValueField;
    private bool missingParameterValueFieldSpecified;
    private bool invalidParameterValueField;
    private bool invalidParameterValueFieldSpecified;
    private bool unknownReportParameterField;
    private bool unknownReportParameterFieldSpecified;

    public bool DeliveryExtensionRemoved
    {
      get
      {
        return this.deliveryExtensionRemovedField;
      }
      set
      {
        this.deliveryExtensionRemovedField = value;
      }
    }

    [XmlIgnore]
    public bool DeliveryExtensionRemovedSpecified
    {
      get
      {
        return this.deliveryExtensionRemovedFieldSpecified;
      }
      set
      {
        this.deliveryExtensionRemovedFieldSpecified = value;
      }
    }

    public bool SharedDataSourceRemoved
    {
      get
      {
        return this.sharedDataSourceRemovedField;
      }
      set
      {
        this.sharedDataSourceRemovedField = value;
      }
    }

    [XmlIgnore]
    public bool SharedDataSourceRemovedSpecified
    {
      get
      {
        return this.sharedDataSourceRemovedFieldSpecified;
      }
      set
      {
        this.sharedDataSourceRemovedFieldSpecified = value;
      }
    }

    public bool MissingParameterValue
    {
      get
      {
        return this.missingParameterValueField;
      }
      set
      {
        this.missingParameterValueField = value;
      }
    }

    [XmlIgnore]
    public bool MissingParameterValueSpecified
    {
      get
      {
        return this.missingParameterValueFieldSpecified;
      }
      set
      {
        this.missingParameterValueFieldSpecified = value;
      }
    }

    public bool InvalidParameterValue
    {
      get
      {
        return this.invalidParameterValueField;
      }
      set
      {
        this.invalidParameterValueField = value;
      }
    }

    [XmlIgnore]
    public bool InvalidParameterValueSpecified
    {
      get
      {
        return this.invalidParameterValueFieldSpecified;
      }
      set
      {
        this.invalidParameterValueFieldSpecified = value;
      }
    }

    public bool UnknownReportParameter
    {
      get
      {
        return this.unknownReportParameterField;
      }
      set
      {
        this.unknownReportParameterField = value;
      }
    }

    [XmlIgnore]
    public bool UnknownReportParameterSpecified
    {
      get
      {
        return this.unknownReportParameterFieldSpecified;
      }
      set
      {
        this.unknownReportParameterFieldSpecified = value;
      }
    }
  }
}

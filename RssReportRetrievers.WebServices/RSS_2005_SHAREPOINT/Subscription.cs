
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.Subscription




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
  public class Subscription
  {
    private string subscriptionIDField;
    private string ownerField;
    private string pathField;
    private string virtualPathField;
    private string reportField;
    private ExtensionSettings deliverySettingsField;
    private string descriptionField;
    private string statusField;
    private ActiveState activeField;
    private DateTime lastExecutedField;
    private bool lastExecutedFieldSpecified;
    private string modifiedByField;
    private DateTime modifiedDateField;
    private string eventTypeField;
    private bool isDataDrivenField;

    public string SubscriptionID
    {
      get
      {
        return this.subscriptionIDField;
      }
      set
      {
        this.subscriptionIDField = value;
      }
    }

    public string Owner
    {
      get
      {
        return this.ownerField;
      }
      set
      {
        this.ownerField = value;
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

    public string Report
    {
      get
      {
        return this.reportField;
      }
      set
      {
        this.reportField = value;
      }
    }

    public ExtensionSettings DeliverySettings
    {
      get
      {
        return this.deliverySettingsField;
      }
      set
      {
        this.deliverySettingsField = value;
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

    public string Status
    {
      get
      {
        return this.statusField;
      }
      set
      {
        this.statusField = value;
      }
    }

    public ActiveState Active
    {
      get
      {
        return this.activeField;
      }
      set
      {
        this.activeField = value;
      }
    }

    public DateTime LastExecuted
    {
      get
      {
        return this.lastExecutedField;
      }
      set
      {
        this.lastExecutedField = value;
      }
    }

    [XmlIgnore]
    public bool LastExecutedSpecified
    {
      get
      {
        return this.lastExecutedFieldSpecified;
      }
      set
      {
        this.lastExecutedFieldSpecified = value;
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

    public string EventType
    {
      get
      {
        return this.eventTypeField;
      }
      set
      {
        this.eventTypeField = value;
      }
    }

    public bool IsDataDriven
    {
      get
      {
        return this.isDataDrivenField;
      }
      set
      {
        this.isDataDrivenField = value;
      }
    }
  }
}

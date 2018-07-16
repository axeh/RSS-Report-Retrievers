using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using RSSReportRetrievers.WebServices;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [WebServiceBinding(Name = "ReportingService2006Soap", Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [XmlInclude(typeof (ScheduleDefinitionOrReference))]
  [XmlInclude(typeof (RecurrencePattern))]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlInclude(typeof (DataSourceDefinitionOrReference))]
  [XmlInclude(typeof (ExpirationDefinition))]
  public class ReportingService2006 : SoapHttpClientProtocol
  {
    private TrustedUserHeader trustedUserHeaderValueField;
    private ServerInfoHeader serverInfoHeaderValueField;
    private SendOrPostCallback ListSecureMethodsOperationCompleted;
    private SendOrPostCallback GetSystemPropertiesOperationCompleted;
    private SendOrPostCallback SetSystemPropertiesOperationCompleted;
    private SendOrPostCallback DeleteItemOperationCompleted;
    private SendOrPostCallback MoveItemOperationCompleted;
    private SendOrPostCallback ListChildrenOperationCompleted;
    private SendOrPostCallback ListParentsOperationCompleted;
    private SendOrPostCallback ListDependentItemsOperationCompleted;
    private SendOrPostCallback GetPropertiesOperationCompleted;
    private SendOrPostCallback SetPropertiesOperationCompleted;
    private SendOrPostCallback GetItemTypeOperationCompleted;
    private SendOrPostCallback CreateFolderOperationCompleted;
    private SendOrPostCallback CreateReportOperationCompleted;
    private SendOrPostCallback GetReportDefinitionOperationCompleted;
    private SendOrPostCallback SetReportDefinitionOperationCompleted;
    private SendOrPostCallback CreateResourceOperationCompleted;
    private SendOrPostCallback SetResourceContentsOperationCompleted;
    private SendOrPostCallback GetResourceContentsOperationCompleted;
    private SendOrPostCallback GetReportParametersOperationCompleted;
    private SendOrPostCallback SetReportParametersOperationCompleted;
    private SendOrPostCallback SetExecutionOptionsOperationCompleted;
    private SendOrPostCallback GetExecutionOptionsOperationCompleted;
    private SendOrPostCallback SetCacheOptionsOperationCompleted;
    private SendOrPostCallback GetCacheOptionsOperationCompleted;
    private SendOrPostCallback UpdateReportExecutionSnapshotOperationCompleted;
    private SendOrPostCallback FlushCacheOperationCompleted;
    private SendOrPostCallback CreateDataSourceOperationCompleted;
    private SendOrPostCallback GetDataSourceContentsOperationCompleted;
    private SendOrPostCallback SetDataSourceContentsOperationCompleted;
    private SendOrPostCallback EnableDataSourceOperationCompleted;
    private SendOrPostCallback DisableDataSourceOperationCompleted;
    private SendOrPostCallback SetItemDataSourcesOperationCompleted;
    private SendOrPostCallback GetItemDataSourcesOperationCompleted;
    private SendOrPostCallback GetItemDataSourcePromptsOperationCompleted;
    private SendOrPostCallback CreateReportHistorySnapshotOperationCompleted;
    private SendOrPostCallback GetReportHistoryOptionsOperationCompleted;
    private SendOrPostCallback SetReportHistoryLimitOperationCompleted;
    private SendOrPostCallback GetReportHistoryLimitOperationCompleted;
    private SendOrPostCallback ListReportHistoryOperationCompleted;
    private SendOrPostCallback DeleteReportHistorySnapshotOperationCompleted;
    private SendOrPostCallback CreateScheduleOperationCompleted;
    private SendOrPostCallback DeleteScheduleOperationCompleted;
    private SendOrPostCallback SetSchedulePropertiesOperationCompleted;
    private SendOrPostCallback GetSchedulePropertiesOperationCompleted;
    private SendOrPostCallback ListScheduledReportsOperationCompleted;
    private SendOrPostCallback ListSchedulesOperationCompleted;
    private SendOrPostCallback PauseScheduleOperationCompleted;
    private SendOrPostCallback ResumeScheduleOperationCompleted;
    private SendOrPostCallback CreateSubscriptionOperationCompleted;
    private SendOrPostCallback SetSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback GetSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback DeleteSubscriptionOperationCompleted;
    private SendOrPostCallback PrepareQueryOperationCompleted;
    private SendOrPostCallback GetExtensionSettingsOperationCompleted;
    private SendOrPostCallback ValidateExtensionSettingsOperationCompleted;
    private SendOrPostCallback ListAllSubscriptionsOperationCompleted;
    private SendOrPostCallback ListMySubscriptionsOperationCompleted;
    private SendOrPostCallback ListReportSubscriptionsOperationCompleted;
    private SendOrPostCallback ListExtensionsOperationCompleted;
    private SendOrPostCallback ListEventsOperationCompleted;
    private SendOrPostCallback FireEventOperationCompleted;
    private SendOrPostCallback ListTasksOperationCompleted;
    private SendOrPostCallback ListRolesOperationCompleted;
    private SendOrPostCallback GetRolePropertiesOperationCompleted;
    private SendOrPostCallback GetPoliciesOperationCompleted;
    private SendOrPostCallback SetPoliciesOperationCompleted;
    private SendOrPostCallback InheritParentSecurityOperationCompleted;
    private SendOrPostCallback GetPermissionsOperationCompleted;
    private SendOrPostCallback CreateModelOperationCompleted;
    private SendOrPostCallback GetModelDefinitionOperationCompleted;
    private SendOrPostCallback SetModelDefinitionOperationCompleted;
    private SendOrPostCallback ListModelPerspectivesOperationCompleted;
    private SendOrPostCallback GetUserModelOperationCompleted;
    private SendOrPostCallback ListModelItemChildrenOperationCompleted;
    private SendOrPostCallback GetModelItemPermissionsOperationCompleted;
    private SendOrPostCallback GetModelItemPoliciesOperationCompleted;
    private SendOrPostCallback SetModelItemPoliciesOperationCompleted;
    private SendOrPostCallback InheritModelItemParentSecurityOperationCompleted;
    private SendOrPostCallback RemoveAllModelItemPoliciesOperationCompleted;
    private SendOrPostCallback SetModelDrillthroughReportsOperationCompleted;
    private SendOrPostCallback ListModelDrillthroughReportsOperationCompleted;
    private SendOrPostCallback GenerateModelOperationCompleted;
    private SendOrPostCallback RegenerateModelOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public ReportingService2006()
    {
        this.Url = Settings.Default.RSSSHAREPOINT;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public TrustedUserHeader TrustedUserHeaderValue
    {
      get
      {
        return this.trustedUserHeaderValueField;
      }
      set
      {
        this.trustedUserHeaderValueField = value;
      }
    }

    public ServerInfoHeader ServerInfoHeaderValue
    {
      get
      {
        return this.serverInfoHeaderValueField;
      }
      set
      {
        this.serverInfoHeaderValueField = value;
      }
    }

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event ListSecureMethodsCompletedEventHandler ListSecureMethodsCompleted;

    public event GetSystemPropertiesCompletedEventHandler GetSystemPropertiesCompleted;

    public event SetSystemPropertiesCompletedEventHandler SetSystemPropertiesCompleted;

    public event DeleteItemCompletedEventHandler DeleteItemCompleted;

    public event MoveItemCompletedEventHandler MoveItemCompleted;

    public event ListChildrenCompletedEventHandler ListChildrenCompleted;

    public event ListParentsCompletedEventHandler ListParentsCompleted;

    public event ListDependentItemsCompletedEventHandler ListDependentItemsCompleted;

    public event GetPropertiesCompletedEventHandler GetPropertiesCompleted;

    public event SetPropertiesCompletedEventHandler SetPropertiesCompleted;

    public event GetItemTypeCompletedEventHandler GetItemTypeCompleted;

    public event CreateFolderCompletedEventHandler CreateFolderCompleted;

    public event CreateReportCompletedEventHandler CreateReportCompleted;

    public event GetReportDefinitionCompletedEventHandler GetReportDefinitionCompleted;

    public event SetReportDefinitionCompletedEventHandler SetReportDefinitionCompleted;

    public event CreateResourceCompletedEventHandler CreateResourceCompleted;

    public event SetResourceContentsCompletedEventHandler SetResourceContentsCompleted;

    public event GetResourceContentsCompletedEventHandler GetResourceContentsCompleted;

    public event GetReportParametersCompletedEventHandler GetReportParametersCompleted;

    public event SetReportParametersCompletedEventHandler SetReportParametersCompleted;

    public event SetExecutionOptionsCompletedEventHandler SetExecutionOptionsCompleted;

    public event GetExecutionOptionsCompletedEventHandler GetExecutionOptionsCompleted;

    public event SetCacheOptionsCompletedEventHandler SetCacheOptionsCompleted;

    public event GetCacheOptionsCompletedEventHandler GetCacheOptionsCompleted;

    public event UpdateReportExecutionSnapshotCompletedEventHandler UpdateReportExecutionSnapshotCompleted;

    public event FlushCacheCompletedEventHandler FlushCacheCompleted;

    public event CreateDataSourceCompletedEventHandler CreateDataSourceCompleted;

    public event GetDataSourceContentsCompletedEventHandler GetDataSourceContentsCompleted;

    public event SetDataSourceContentsCompletedEventHandler SetDataSourceContentsCompleted;

    public event EnableDataSourceCompletedEventHandler EnableDataSourceCompleted;

    public event DisableDataSourceCompletedEventHandler DisableDataSourceCompleted;

    public event SetItemDataSourcesCompletedEventHandler SetItemDataSourcesCompleted;

    public event GetItemDataSourcesCompletedEventHandler GetItemDataSourcesCompleted;

    public event GetItemDataSourcePromptsCompletedEventHandler GetItemDataSourcePromptsCompleted;

    public event CreateReportHistorySnapshotCompletedEventHandler CreateReportHistorySnapshotCompleted;

    public event GetReportHistoryOptionsCompletedEventHandler GetReportHistoryOptionsCompleted;

    public event SetReportHistoryLimitCompletedEventHandler SetReportHistoryLimitCompleted;

    public event GetReportHistoryLimitCompletedEventHandler GetReportHistoryLimitCompleted;

    public event ListReportHistoryCompletedEventHandler ListReportHistoryCompleted;

    public event DeleteReportHistorySnapshotCompletedEventHandler DeleteReportHistorySnapshotCompleted;

    public event CreateScheduleCompletedEventHandler CreateScheduleCompleted;

    public event DeleteScheduleCompletedEventHandler DeleteScheduleCompleted;

    public event SetSchedulePropertiesCompletedEventHandler SetSchedulePropertiesCompleted;

    public event GetSchedulePropertiesCompletedEventHandler GetSchedulePropertiesCompleted;

    public event ListScheduledReportsCompletedEventHandler ListScheduledReportsCompleted;

    public event ListSchedulesCompletedEventHandler ListSchedulesCompleted;

    public event PauseScheduleCompletedEventHandler PauseScheduleCompleted;

    public event ResumeScheduleCompletedEventHandler ResumeScheduleCompleted;

    public event CreateSubscriptionCompletedEventHandler CreateSubscriptionCompleted;

    public event SetSubscriptionPropertiesCompletedEventHandler SetSubscriptionPropertiesCompleted;

    public event GetSubscriptionPropertiesCompletedEventHandler GetSubscriptionPropertiesCompleted;

    public event DeleteSubscriptionCompletedEventHandler DeleteSubscriptionCompleted;

    public event PrepareQueryCompletedEventHandler PrepareQueryCompleted;

    public event GetExtensionSettingsCompletedEventHandler GetExtensionSettingsCompleted;

    public event ValidateExtensionSettingsCompletedEventHandler ValidateExtensionSettingsCompleted;

    public event ListAllSubscriptionsCompletedEventHandler ListAllSubscriptionsCompleted;

    public event ListMySubscriptionsCompletedEventHandler ListMySubscriptionsCompleted;

    public event ListReportSubscriptionsCompletedEventHandler ListReportSubscriptionsCompleted;

    public event ListExtensionsCompletedEventHandler ListExtensionsCompleted;

    public event ListEventsCompletedEventHandler ListEventsCompleted;

    public event FireEventCompletedEventHandler FireEventCompleted;

    public event ListTasksCompletedEventHandler ListTasksCompleted;

    public event ListRolesCompletedEventHandler ListRolesCompleted;

    public event GetRolePropertiesCompletedEventHandler GetRolePropertiesCompleted;

    public event GetPoliciesCompletedEventHandler GetPoliciesCompleted;

    public event SetPoliciesCompletedEventHandler SetPoliciesCompleted;

    public event InheritParentSecurityCompletedEventHandler InheritParentSecurityCompleted;

    public event GetPermissionsCompletedEventHandler GetPermissionsCompleted;

    public event CreateModelCompletedEventHandler CreateModelCompleted;

    public event GetModelDefinitionCompletedEventHandler GetModelDefinitionCompleted;

    public event SetModelDefinitionCompletedEventHandler SetModelDefinitionCompleted;

    public event ListModelPerspectivesCompletedEventHandler ListModelPerspectivesCompleted;

    public event GetUserModelCompletedEventHandler GetUserModelCompleted;

    public event ListModelItemChildrenCompletedEventHandler ListModelItemChildrenCompleted;

    public event GetModelItemPermissionsCompletedEventHandler GetModelItemPermissionsCompleted;

    public event GetModelItemPoliciesCompletedEventHandler GetModelItemPoliciesCompleted;

    public event SetModelItemPoliciesCompletedEventHandler SetModelItemPoliciesCompleted;

    public event InheritModelItemParentSecurityCompletedEventHandler InheritModelItemParentSecurityCompleted;

    public event RemoveAllModelItemPoliciesCompletedEventHandler RemoveAllModelItemPoliciesCompleted;

    public event SetModelDrillthroughReportsCompletedEventHandler SetModelDrillthroughReportsCompleted;

    public event ListModelDrillthroughReportsCompletedEventHandler ListModelDrillthroughReportsCompleted;

    public event GenerateModelCompletedEventHandler GenerateModelCompleted;

    public event RegenerateModelCompletedEventHandler RegenerateModelCompleted;

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListSecureMethods", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public string[] ListSecureMethods()
    {
      return (string[]) this.Invoke(nameof (ListSecureMethods), new object[0])[0];
    }

    public void ListSecureMethodsAsync()
    {
      this.ListSecureMethodsAsync((object) null);
    }

    public void ListSecureMethodsAsync(object userState)
    {
      if (this.ListSecureMethodsOperationCompleted == null)
        this.ListSecureMethodsOperationCompleted = new SendOrPostCallback(this.OnListSecureMethodsOperationCompleted);
      this.InvokeAsync("ListSecureMethods", new object[0], this.ListSecureMethodsOperationCompleted, userState);
    }

    private void OnListSecureMethodsOperationCompleted(object arg)
    {
      if (this.ListSecureMethodsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSecureMethodsCompleted((object) this, new ListSecureMethodsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetSystemProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("Values")]
    public Property[] GetSystemProperties(Property[] Properties)
    {
      return (Property[]) this.Invoke(nameof (GetSystemProperties), new object[1]
      {
        (object) Properties
      })[0];
    }

    public void GetSystemPropertiesAsync(Property[] Properties)
    {
      this.GetSystemPropertiesAsync(Properties, (object) null);
    }

    public void GetSystemPropertiesAsync(Property[] Properties, object userState)
    {
      if (this.GetSystemPropertiesOperationCompleted == null)
        this.GetSystemPropertiesOperationCompleted = new SendOrPostCallback(this.OnGetSystemPropertiesOperationCompleted);
      this.InvokeAsync("GetSystemProperties", new object[1]
      {
        (object) Properties
      }, this.GetSystemPropertiesOperationCompleted, userState);
    }

    private void OnGetSystemPropertiesOperationCompleted(object arg)
    {
      if (this.GetSystemPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetSystemPropertiesCompleted((object) this, new GetSystemPropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetSystemProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    public void SetSystemProperties(Property[] Properties)
    {
      this.Invoke(nameof (SetSystemProperties), new object[1]
      {
        (object) Properties
      });
    }

    public void SetSystemPropertiesAsync(Property[] Properties)
    {
      this.SetSystemPropertiesAsync(Properties, (object) null);
    }

    public void SetSystemPropertiesAsync(Property[] Properties, object userState)
    {
      if (this.SetSystemPropertiesOperationCompleted == null)
        this.SetSystemPropertiesOperationCompleted = new SendOrPostCallback(this.OnSetSystemPropertiesOperationCompleted);
      this.InvokeAsync("SetSystemProperties", new object[1]
      {
        (object) Properties
      }, this.SetSystemPropertiesOperationCompleted, userState);
    }

    private void OnSetSystemPropertiesOperationCompleted(object arg)
    {
      if (this.SetSystemPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetSystemPropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/DeleteItem", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void DeleteItem(string Item)
    {
      this.Invoke(nameof (DeleteItem), new object[1]
      {
        (object) Item
      });
    }

    public void DeleteItemAsync(string Item)
    {
      this.DeleteItemAsync(Item, (object) null);
    }

    public void DeleteItemAsync(string Item, object userState)
    {
      if (this.DeleteItemOperationCompleted == null)
        this.DeleteItemOperationCompleted = new SendOrPostCallback(this.OnDeleteItemOperationCompleted);
      this.InvokeAsync("DeleteItem", new object[1]
      {
        (object) Item
      }, this.DeleteItemOperationCompleted, userState);
    }

    private void OnDeleteItemOperationCompleted(object arg)
    {
      if (this.DeleteItemCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DeleteItemCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/MoveItem", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void MoveItem(string Item, string Target)
    {
      this.Invoke(nameof (MoveItem), new object[2]
      {
        (object) Item,
        (object) Target
      });
    }

    public void MoveItemAsync(string Item, string Target)
    {
      this.MoveItemAsync(Item, Target, (object) null);
    }

    public void MoveItemAsync(string Item, string Target, object userState)
    {
      if (this.MoveItemOperationCompleted == null)
        this.MoveItemOperationCompleted = new SendOrPostCallback(this.OnMoveItemOperationCompleted);
      this.InvokeAsync("MoveItem", new object[2]
      {
        (object) Item,
        (object) Target
      }, this.MoveItemOperationCompleted, userState);
    }

    private void OnMoveItemOperationCompleted(object arg)
    {
      if (this.MoveItemCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.MoveItemCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListChildren", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("CatalogItems")]
    public CatalogItem[] ListChildren(string Item)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListChildren), new object[1]
      {
        (object) Item
      })[0];
    }

    public void ListChildrenAsync(string Item)
    {
      this.ListChildrenAsync(Item, (object) null);
    }

    public void ListChildrenAsync(string Item, object userState)
    {
      if (this.ListChildrenOperationCompleted == null)
        this.ListChildrenOperationCompleted = new SendOrPostCallback(this.OnListChildrenOperationCompleted);
      this.InvokeAsync("ListChildren", new object[1]
      {
        (object) Item
      }, this.ListChildrenOperationCompleted, userState);
    }

    private void OnListChildrenOperationCompleted(object arg)
    {
      if (this.ListChildrenCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListChildrenCompleted((object) this, new ListChildrenCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListParents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    public CatalogItem[] ListParents(string Item)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListParents), new object[1]
      {
        (object) Item
      })[0];
    }

    public void ListParentsAsync(string Item)
    {
      this.ListParentsAsync(Item, (object) null);
    }

    public void ListParentsAsync(string Item, object userState)
    {
      if (this.ListParentsOperationCompleted == null)
        this.ListParentsOperationCompleted = new SendOrPostCallback(this.OnListParentsOperationCompleted);
      this.InvokeAsync("ListParents", new object[1]
      {
        (object) Item
      }, this.ListParentsOperationCompleted, userState);
    }

    private void OnListParentsOperationCompleted(object arg)
    {
      if (this.ListParentsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListParentsCompleted((object) this, new ListParentsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListDependentItems", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("CatalogItems")]
    public CatalogItem[] ListDependentItems(string Item)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListDependentItems), new object[1]
      {
        (object) Item
      })[0];
    }

    public void ListDependentItemsAsync(string Item)
    {
      this.ListDependentItemsAsync(Item, (object) null);
    }

    public void ListDependentItemsAsync(string Item, object userState)
    {
      if (this.ListDependentItemsOperationCompleted == null)
        this.ListDependentItemsOperationCompleted = new SendOrPostCallback(this.OnListDependentItemsOperationCompleted);
      this.InvokeAsync("ListDependentItems", new object[1]
      {
        (object) Item
      }, this.ListDependentItemsOperationCompleted, userState);
    }

    private void OnListDependentItemsOperationCompleted(object arg)
    {
      if (this.ListDependentItemsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListDependentItemsCompleted((object) this, new ListDependentItemsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("Values")]
    public Property[] GetProperties(string Item, Property[] Properties)
    {
      return (Property[]) this.Invoke(nameof (GetProperties), new object[2]
      {
        (object) Item,
        (object) Properties
      })[0];
    }

    public void GetPropertiesAsync(string Item, Property[] Properties)
    {
      this.GetPropertiesAsync(Item, Properties, (object) null);
    }

    public void GetPropertiesAsync(string Item, Property[] Properties, object userState)
    {
      if (this.GetPropertiesOperationCompleted == null)
        this.GetPropertiesOperationCompleted = new SendOrPostCallback(this.OnGetPropertiesOperationCompleted);
      this.InvokeAsync("GetProperties", new object[2]
      {
        (object) Item,
        (object) Properties
      }, this.GetPropertiesOperationCompleted, userState);
    }

    private void OnGetPropertiesOperationCompleted(object arg)
    {
      if (this.GetPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetPropertiesCompleted((object) this, new GetPropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetProperties(string Item, Property[] Properties)
    {
      this.Invoke(nameof (SetProperties), new object[2]
      {
        (object) Item,
        (object) Properties
      });
    }

    public void SetPropertiesAsync(string Item, Property[] Properties)
    {
      this.SetPropertiesAsync(Item, Properties, (object) null);
    }

    public void SetPropertiesAsync(string Item, Property[] Properties, object userState)
    {
      if (this.SetPropertiesOperationCompleted == null)
        this.SetPropertiesOperationCompleted = new SendOrPostCallback(this.OnSetPropertiesOperationCompleted);
      this.InvokeAsync("SetProperties", new object[2]
      {
        (object) Item,
        (object) Properties
      }, this.SetPropertiesOperationCompleted, userState);
    }

    private void OnSetPropertiesOperationCompleted(object arg)
    {
      if (this.SetPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetPropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetItemType", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("Type")]
    public ItemTypeEnum GetItemType(string Item)
    {
      return (ItemTypeEnum) this.Invoke(nameof (GetItemType), new object[1]
      {
        (object) Item
      })[0];
    }

    public void GetItemTypeAsync(string Item)
    {
      this.GetItemTypeAsync(Item, (object) null);
    }

    public void GetItemTypeAsync(string Item, object userState)
    {
      if (this.GetItemTypeOperationCompleted == null)
        this.GetItemTypeOperationCompleted = new SendOrPostCallback(this.OnGetItemTypeOperationCompleted);
      this.InvokeAsync("GetItemType", new object[1]
      {
        (object) Item
      }, this.GetItemTypeOperationCompleted, userState);
    }

    private void OnGetItemTypeOperationCompleted(object arg)
    {
      if (this.GetItemTypeCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetItemTypeCompleted((object) this, new GetItemTypeCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateFolder", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("ItemInfo")]
    public CatalogItem CreateFolder(string Folder, string Parent)
    {
      return (CatalogItem) this.Invoke(nameof (CreateFolder), new object[2]
      {
        (object) Folder,
        (object) Parent
      })[0];
    }

    public void CreateFolderAsync(string Folder, string Parent)
    {
      this.CreateFolderAsync(Folder, Parent, (object) null);
    }

    public void CreateFolderAsync(string Folder, string Parent, object userState)
    {
      if (this.CreateFolderOperationCompleted == null)
        this.CreateFolderOperationCompleted = new SendOrPostCallback(this.OnCreateFolderOperationCompleted);
      this.InvokeAsync("CreateFolder", new object[2]
      {
        (object) Folder,
        (object) Parent
      }, this.CreateFolderOperationCompleted, userState);
    }

    private void OnCreateFolderOperationCompleted(object arg)
    {
      if (this.CreateFolderCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateFolderCompleted((object) this, new CreateFolderCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateReport", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("ItemInfo")]
    public CatalogItem CreateReport(string Report, string Parent, bool Overwrite, [XmlElement(DataType = "base64Binary")] byte[] Definition, Property[] Properties, out Warning[] Warnings)
    {
      object[] objArray = this.Invoke(nameof (CreateReport), new object[5]
      {
        (object) Report,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      });
      Warnings = (Warning[]) objArray[1];
      return (CatalogItem) objArray[0];
    }

    public void CreateReportAsync(string Report, string Parent, bool Overwrite, byte[] Definition, Property[] Properties)
    {
      this.CreateReportAsync(Report, Parent, Overwrite, Definition, Properties, (object) null);
    }

    public void CreateReportAsync(string Report, string Parent, bool Overwrite, byte[] Definition, Property[] Properties, object userState)
    {
      if (this.CreateReportOperationCompleted == null)
        this.CreateReportOperationCompleted = new SendOrPostCallback(this.OnCreateReportOperationCompleted);
      this.InvokeAsync("CreateReport", new object[5]
      {
        (object) Report,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      }, this.CreateReportOperationCompleted, userState);
    }

    private void OnCreateReportOperationCompleted(object arg)
    {
      if (this.CreateReportCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateReportCompleted((object) this, new CreateReportCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetReportDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Definition", DataType = "base64Binary")]
    public byte[] GetReportDefinition(string Report)
    {
      return (byte[]) this.Invoke(nameof (GetReportDefinition), new object[1]
      {
        (object) Report
      })[0];
    }

    public void GetReportDefinitionAsync(string Report)
    {
      this.GetReportDefinitionAsync(Report, (object) null);
    }

    public void GetReportDefinitionAsync(string Report, object userState)
    {
      if (this.GetReportDefinitionOperationCompleted == null)
        this.GetReportDefinitionOperationCompleted = new SendOrPostCallback(this.OnGetReportDefinitionOperationCompleted);
      this.InvokeAsync("GetReportDefinition", new object[1]
      {
        (object) Report
      }, this.GetReportDefinitionOperationCompleted, userState);
    }

    private void OnGetReportDefinitionOperationCompleted(object arg)
    {
      if (this.GetReportDefinitionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportDefinitionCompleted((object) this, new GetReportDefinitionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetReportDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Warnings")]
    public Warning[] SetReportDefinition(string Report, [XmlElement(DataType = "base64Binary")] byte[] Definition)
    {
      return (Warning[]) this.Invoke(nameof (SetReportDefinition), new object[2]
      {
        (object) Report,
        (object) Definition
      })[0];
    }

    public void SetReportDefinitionAsync(string Report, byte[] Definition)
    {
      this.SetReportDefinitionAsync(Report, Definition, (object) null);
    }

    public void SetReportDefinitionAsync(string Report, byte[] Definition, object userState)
    {
      if (this.SetReportDefinitionOperationCompleted == null)
        this.SetReportDefinitionOperationCompleted = new SendOrPostCallback(this.OnSetReportDefinitionOperationCompleted);
      this.InvokeAsync("SetReportDefinition", new object[2]
      {
        (object) Report,
        (object) Definition
      }, this.SetReportDefinitionOperationCompleted, userState);
    }

    private void OnSetReportDefinitionOperationCompleted(object arg)
    {
      if (this.SetReportDefinitionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportDefinitionCompleted((object) this, new SetReportDefinitionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateResource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("ItemInfo")]
    public CatalogItem CreateResource(string Resource, string Parent, bool Overwrite, [XmlElement(DataType = "base64Binary")] byte[] Contents, string MimeType, Property[] Properties)
    {
      return (CatalogItem) this.Invoke(nameof (CreateResource), new object[6]
      {
        (object) Resource,
        (object) Parent,
        (object) Overwrite,
        (object) Contents,
        (object) MimeType,
        (object) Properties
      })[0];
    }

    public void CreateResourceAsync(string Resource, string Parent, bool Overwrite, byte[] Contents, string MimeType, Property[] Properties)
    {
      this.CreateResourceAsync(Resource, Parent, Overwrite, Contents, MimeType, Properties, (object) null);
    }

    public void CreateResourceAsync(string Resource, string Parent, bool Overwrite, byte[] Contents, string MimeType, Property[] Properties, object userState)
    {
      if (this.CreateResourceOperationCompleted == null)
        this.CreateResourceOperationCompleted = new SendOrPostCallback(this.OnCreateResourceOperationCompleted);
      this.InvokeAsync("CreateResource", new object[6]
      {
        (object) Resource,
        (object) Parent,
        (object) Overwrite,
        (object) Contents,
        (object) MimeType,
        (object) Properties
      }, this.CreateResourceOperationCompleted, userState);
    }

    private void OnCreateResourceOperationCompleted(object arg)
    {
      if (this.CreateResourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateResourceCompleted((object) this, new CreateResourceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetResourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    public void SetResourceContents(string Resource, [XmlElement(DataType = "base64Binary")] byte[] Contents, string MimeType)
    {
      this.Invoke(nameof (SetResourceContents), new object[3]
      {
        (object) Resource,
        (object) Contents,
        (object) MimeType
      });
    }

    public void SetResourceContentsAsync(string Resource, byte[] Contents, string MimeType)
    {
      this.SetResourceContentsAsync(Resource, Contents, MimeType, (object) null);
    }

    public void SetResourceContentsAsync(string Resource, byte[] Contents, string MimeType, object userState)
    {
      if (this.SetResourceContentsOperationCompleted == null)
        this.SetResourceContentsOperationCompleted = new SendOrPostCallback(this.OnSetResourceContentsOperationCompleted);
      this.InvokeAsync("SetResourceContents", new object[3]
      {
        (object) Resource,
        (object) Contents,
        (object) MimeType
      }, this.SetResourceContentsOperationCompleted, userState);
    }

    private void OnSetResourceContentsOperationCompleted(object arg)
    {
      if (this.SetResourceContentsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetResourceContentsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetResourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Contents", DataType = "base64Binary")]
    public byte[] GetResourceContents(string Resource, out string MimeType)
    {
      object[] objArray = this.Invoke(nameof (GetResourceContents), new object[1]
      {
        (object) Resource
      });
      MimeType = (string) objArray[1];
      return (byte[]) objArray[0];
    }

    public void GetResourceContentsAsync(string Resource)
    {
      this.GetResourceContentsAsync(Resource, (object) null);
    }

    public void GetResourceContentsAsync(string Resource, object userState)
    {
      if (this.GetResourceContentsOperationCompleted == null)
        this.GetResourceContentsOperationCompleted = new SendOrPostCallback(this.OnGetResourceContentsOperationCompleted);
      this.InvokeAsync("GetResourceContents", new object[1]
      {
        (object) Resource
      }, this.GetResourceContentsOperationCompleted, userState);
    }

    private void OnGetResourceContentsOperationCompleted(object arg)
    {
      if (this.GetResourceContentsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetResourceContentsCompleted((object) this, new GetResourceContentsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetReportParameters", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Parameters")]
    public ReportParameter[] GetReportParameters(string Report, string HistoryID, ParameterValue[] Values, DataSourceCredentials[] Credentials)
    {
      return (ReportParameter[]) this.Invoke(nameof (GetReportParameters), new object[4]
      {
        (object) Report,
        (object) HistoryID,
        (object) Values,
        (object) Credentials
      })[0];
    }

    public void GetReportParametersAsync(string Report, string HistoryID, ParameterValue[] Values, DataSourceCredentials[] Credentials)
    {
      this.GetReportParametersAsync(Report, HistoryID, Values, Credentials, (object) null);
    }

    public void GetReportParametersAsync(string Report, string HistoryID, ParameterValue[] Values, DataSourceCredentials[] Credentials, object userState)
    {
      if (this.GetReportParametersOperationCompleted == null)
        this.GetReportParametersOperationCompleted = new SendOrPostCallback(this.OnGetReportParametersOperationCompleted);
      this.InvokeAsync("GetReportParameters", new object[4]
      {
        (object) Report,
        (object) HistoryID,
        (object) Values,
        (object) Credentials
      }, this.GetReportParametersOperationCompleted, userState);
    }

    private void OnGetReportParametersOperationCompleted(object arg)
    {
      if (this.GetReportParametersCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportParametersCompleted((object) this, new GetReportParametersCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetReportParameters", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetReportParameters(string Report, ReportParameter[] Parameters)
    {
      this.Invoke(nameof (SetReportParameters), new object[2]
      {
        (object) Report,
        (object) Parameters
      });
    }

    public void SetReportParametersAsync(string Report, ReportParameter[] Parameters)
    {
      this.SetReportParametersAsync(Report, Parameters, (object) null);
    }

    public void SetReportParametersAsync(string Report, ReportParameter[] Parameters, object userState)
    {
      if (this.SetReportParametersOperationCompleted == null)
        this.SetReportParametersOperationCompleted = new SendOrPostCallback(this.OnSetReportParametersOperationCompleted);
      this.InvokeAsync("SetReportParameters", new object[2]
      {
        (object) Report,
        (object) Parameters
      }, this.SetReportParametersOperationCompleted, userState);
    }

    private void OnSetReportParametersOperationCompleted(object arg)
    {
      if (this.SetReportParametersCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportParametersCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetExecutionOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetExecutionOptions(string Report, ExecutionSettingEnum ExecutionSetting, [XmlElement("ScheduleReference", typeof (ScheduleReference)), XmlElement("NoSchedule", typeof (NoSchedule)), XmlElement("ScheduleDefinition", typeof (ScheduleDefinition))] ScheduleDefinitionOrReference Item)
    {
      this.Invoke(nameof (SetExecutionOptions), new object[3]
      {
        (object) Report,
        (object) ExecutionSetting,
        (object) Item
      });
    }

    public void SetExecutionOptionsAsync(string Report, ExecutionSettingEnum ExecutionSetting, ScheduleDefinitionOrReference Item)
    {
      this.SetExecutionOptionsAsync(Report, ExecutionSetting, Item, (object) null);
    }

    public void SetExecutionOptionsAsync(string Report, ExecutionSettingEnum ExecutionSetting, ScheduleDefinitionOrReference Item, object userState)
    {
      if (this.SetExecutionOptionsOperationCompleted == null)
        this.SetExecutionOptionsOperationCompleted = new SendOrPostCallback(this.OnSetExecutionOptionsOperationCompleted);
      this.InvokeAsync("SetExecutionOptions", new object[3]
      {
        (object) Report,
        (object) ExecutionSetting,
        (object) Item
      }, this.SetExecutionOptionsOperationCompleted, userState);
    }

    private void OnSetExecutionOptionsOperationCompleted(object arg)
    {
      if (this.SetExecutionOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetExecutionOptionsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetExecutionOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("ExecutionSetting")]
    public ExecutionSettingEnum GetExecutionOptions(string Report, [XmlElement("ScheduleDefinition", typeof (ScheduleDefinition)), XmlElement("NoSchedule", typeof (NoSchedule)), XmlElement("ScheduleReference", typeof (ScheduleReference))] out ScheduleDefinitionOrReference Item)
    {
      object[] objArray = this.Invoke(nameof (GetExecutionOptions), new object[1]
      {
        (object) Report
      });
      Item = (ScheduleDefinitionOrReference) objArray[1];
      return (ExecutionSettingEnum) objArray[0];
    }

    public void GetExecutionOptionsAsync(string Report)
    {
      this.GetExecutionOptionsAsync(Report, (object) null);
    }

    public void GetExecutionOptionsAsync(string Report, object userState)
    {
      if (this.GetExecutionOptionsOperationCompleted == null)
        this.GetExecutionOptionsOperationCompleted = new SendOrPostCallback(this.OnGetExecutionOptionsOperationCompleted);
      this.InvokeAsync("GetExecutionOptions", new object[1]
      {
        (object) Report
      }, this.GetExecutionOptionsOperationCompleted, userState);
    }

    private void OnGetExecutionOptionsOperationCompleted(object arg)
    {
      if (this.GetExecutionOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetExecutionOptionsCompleted((object) this, new GetExecutionOptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetCacheOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetCacheOptions(string Report, bool CacheReport, [XmlElement("TimeExpiration", typeof (TimeExpiration)), XmlElement("ScheduleExpiration", typeof (ScheduleExpiration))] ExpirationDefinition Item)
    {
      this.Invoke(nameof (SetCacheOptions), new object[3]
      {
        (object) Report,
        (object) CacheReport,
        (object) Item
      });
    }

    public void SetCacheOptionsAsync(string Report, bool CacheReport, ExpirationDefinition Item)
    {
      this.SetCacheOptionsAsync(Report, CacheReport, Item, (object) null);
    }

    public void SetCacheOptionsAsync(string Report, bool CacheReport, ExpirationDefinition Item, object userState)
    {
      if (this.SetCacheOptionsOperationCompleted == null)
        this.SetCacheOptionsOperationCompleted = new SendOrPostCallback(this.OnSetCacheOptionsOperationCompleted);
      this.InvokeAsync("SetCacheOptions", new object[3]
      {
        (object) Report,
        (object) CacheReport,
        (object) Item
      }, this.SetCacheOptionsOperationCompleted, userState);
    }

    private void OnSetCacheOptionsOperationCompleted(object arg)
    {
      if (this.SetCacheOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetCacheOptionsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetCacheOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("CacheReport")]
    public bool GetCacheOptions(string Report, [XmlElement("TimeExpiration", typeof (TimeExpiration)), XmlElement("ScheduleExpiration", typeof (ScheduleExpiration))] out ExpirationDefinition Item)
    {
      object[] objArray = this.Invoke(nameof (GetCacheOptions), new object[1]
      {
        (object) Report
      });
      Item = (ExpirationDefinition) objArray[1];
      return (bool) objArray[0];
    }

    public void GetCacheOptionsAsync(string Report)
    {
      this.GetCacheOptionsAsync(Report, (object) null);
    }

    public void GetCacheOptionsAsync(string Report, object userState)
    {
      if (this.GetCacheOptionsOperationCompleted == null)
        this.GetCacheOptionsOperationCompleted = new SendOrPostCallback(this.OnGetCacheOptionsOperationCompleted);
      this.InvokeAsync("GetCacheOptions", new object[1]
      {
        (object) Report
      }, this.GetCacheOptionsOperationCompleted, userState);
    }

    private void OnGetCacheOptionsOperationCompleted(object arg)
    {
      if (this.GetCacheOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetCacheOptionsCompleted((object) this, new GetCacheOptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/UpdateReportExecutionSnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void UpdateReportExecutionSnapshot(string Report)
    {
      this.Invoke(nameof (UpdateReportExecutionSnapshot), new object[1]
      {
        (object) Report
      });
    }

    public void UpdateReportExecutionSnapshotAsync(string Report)
    {
      this.UpdateReportExecutionSnapshotAsync(Report, (object) null);
    }

    public void UpdateReportExecutionSnapshotAsync(string Report, object userState)
    {
      if (this.UpdateReportExecutionSnapshotOperationCompleted == null)
        this.UpdateReportExecutionSnapshotOperationCompleted = new SendOrPostCallback(this.OnUpdateReportExecutionSnapshotOperationCompleted);
      this.InvokeAsync("UpdateReportExecutionSnapshot", new object[1]
      {
        (object) Report
      }, this.UpdateReportExecutionSnapshotOperationCompleted, userState);
    }

    private void OnUpdateReportExecutionSnapshotOperationCompleted(object arg)
    {
      if (this.UpdateReportExecutionSnapshotCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.UpdateReportExecutionSnapshotCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/FlushCache", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void FlushCache(string Report)
    {
      this.Invoke(nameof (FlushCache), new object[1]
      {
        (object) Report
      });
    }

    public void FlushCacheAsync(string Report)
    {
      this.FlushCacheAsync(Report, (object) null);
    }

    public void FlushCacheAsync(string Report, object userState)
    {
      if (this.FlushCacheOperationCompleted == null)
        this.FlushCacheOperationCompleted = new SendOrPostCallback(this.OnFlushCacheOperationCompleted);
      this.InvokeAsync("FlushCache", new object[1]
      {
        (object) Report
      }, this.FlushCacheOperationCompleted, userState);
    }

    private void OnFlushCacheOperationCompleted(object arg)
    {
      if (this.FlushCacheCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.FlushCacheCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("ItemInfo")]
    public CatalogItem CreateDataSource(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
    {
      return (CatalogItem) this.Invoke(nameof (CreateDataSource), new object[5]
      {
        (object) DataSource,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      })[0];
    }

    public void CreateDataSourceAsync(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
    {
      this.CreateDataSourceAsync(DataSource, Parent, Overwrite, Definition, Properties, (object) null);
    }

    public void CreateDataSourceAsync(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties, object userState)
    {
      if (this.CreateDataSourceOperationCompleted == null)
        this.CreateDataSourceOperationCompleted = new SendOrPostCallback(this.OnCreateDataSourceOperationCompleted);
      this.InvokeAsync("CreateDataSource", new object[5]
      {
        (object) DataSource,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      }, this.CreateDataSourceOperationCompleted, userState);
    }

    private void OnCreateDataSourceOperationCompleted(object arg)
    {
      if (this.CreateDataSourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateDataSourceCompleted((object) this, new CreateDataSourceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetDataSourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Definition")]
    public DataSourceDefinition GetDataSourceContents(string DataSource)
    {
      return (DataSourceDefinition) this.Invoke(nameof (GetDataSourceContents), new object[1]
      {
        (object) DataSource
      })[0];
    }

    public void GetDataSourceContentsAsync(string DataSource)
    {
      this.GetDataSourceContentsAsync(DataSource, (object) null);
    }

    public void GetDataSourceContentsAsync(string DataSource, object userState)
    {
      if (this.GetDataSourceContentsOperationCompleted == null)
        this.GetDataSourceContentsOperationCompleted = new SendOrPostCallback(this.OnGetDataSourceContentsOperationCompleted);
      this.InvokeAsync("GetDataSourceContents", new object[1]
      {
        (object) DataSource
      }, this.GetDataSourceContentsOperationCompleted, userState);
    }

    private void OnGetDataSourceContentsOperationCompleted(object arg)
    {
      if (this.GetDataSourceContentsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetDataSourceContentsCompleted((object) this, new GetDataSourceContentsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetDataSourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetDataSourceContents(string DataSource, DataSourceDefinition Definition)
    {
      this.Invoke(nameof (SetDataSourceContents), new object[2]
      {
        (object) DataSource,
        (object) Definition
      });
    }

    public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition)
    {
      this.SetDataSourceContentsAsync(DataSource, Definition, (object) null);
    }

    public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition, object userState)
    {
      if (this.SetDataSourceContentsOperationCompleted == null)
        this.SetDataSourceContentsOperationCompleted = new SendOrPostCallback(this.OnSetDataSourceContentsOperationCompleted);
      this.InvokeAsync("SetDataSourceContents", new object[2]
      {
        (object) DataSource,
        (object) Definition
      }, this.SetDataSourceContentsOperationCompleted, userState);
    }

    private void OnSetDataSourceContentsOperationCompleted(object arg)
    {
      if (this.SetDataSourceContentsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetDataSourceContentsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/EnableDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void EnableDataSource(string DataSource)
    {
      this.Invoke(nameof (EnableDataSource), new object[1]
      {
        (object) DataSource
      });
    }

    public void EnableDataSourceAsync(string DataSource)
    {
      this.EnableDataSourceAsync(DataSource, (object) null);
    }

    public void EnableDataSourceAsync(string DataSource, object userState)
    {
      if (this.EnableDataSourceOperationCompleted == null)
        this.EnableDataSourceOperationCompleted = new SendOrPostCallback(this.OnEnableDataSourceOperationCompleted);
      this.InvokeAsync("EnableDataSource", new object[1]
      {
        (object) DataSource
      }, this.EnableDataSourceOperationCompleted, userState);
    }

    private void OnEnableDataSourceOperationCompleted(object arg)
    {
      if (this.EnableDataSourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.EnableDataSourceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/DisableDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void DisableDataSource(string DataSource)
    {
      this.Invoke(nameof (DisableDataSource), new object[1]
      {
        (object) DataSource
      });
    }

    public void DisableDataSourceAsync(string DataSource)
    {
      this.DisableDataSourceAsync(DataSource, (object) null);
    }

    public void DisableDataSourceAsync(string DataSource, object userState)
    {
      if (this.DisableDataSourceOperationCompleted == null)
        this.DisableDataSourceOperationCompleted = new SendOrPostCallback(this.OnDisableDataSourceOperationCompleted);
      this.InvokeAsync("DisableDataSource", new object[1]
      {
        (object) DataSource
      }, this.DisableDataSourceOperationCompleted, userState);
    }

    private void OnDisableDataSourceOperationCompleted(object arg)
    {
      if (this.DisableDataSourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DisableDataSourceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetItemDataSources", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetItemDataSources(string Item, DataSource[] DataSources)
    {
      this.Invoke(nameof (SetItemDataSources), new object[2]
      {
        (object) Item,
        (object) DataSources
      });
    }

    public void SetItemDataSourcesAsync(string Item, DataSource[] DataSources)
    {
      this.SetItemDataSourcesAsync(Item, DataSources, (object) null);
    }

    public void SetItemDataSourcesAsync(string Item, DataSource[] DataSources, object userState)
    {
      if (this.SetItemDataSourcesOperationCompleted == null)
        this.SetItemDataSourcesOperationCompleted = new SendOrPostCallback(this.OnSetItemDataSourcesOperationCompleted);
      this.InvokeAsync("SetItemDataSources", new object[2]
      {
        (object) Item,
        (object) DataSources
      }, this.SetItemDataSourcesOperationCompleted, userState);
    }

    private void OnSetItemDataSourcesOperationCompleted(object arg)
    {
      if (this.SetItemDataSourcesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetItemDataSourcesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetItemDataSources", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("DataSources")]
    public DataSource[] GetItemDataSources(string Item)
    {
      return (DataSource[]) this.Invoke(nameof (GetItemDataSources), new object[1]
      {
        (object) Item
      })[0];
    }

    public void GetItemDataSourcesAsync(string Item)
    {
      this.GetItemDataSourcesAsync(Item, (object) null);
    }

    public void GetItemDataSourcesAsync(string Item, object userState)
    {
      if (this.GetItemDataSourcesOperationCompleted == null)
        this.GetItemDataSourcesOperationCompleted = new SendOrPostCallback(this.OnGetItemDataSourcesOperationCompleted);
      this.InvokeAsync("GetItemDataSources", new object[1]
      {
        (object) Item
      }, this.GetItemDataSourcesOperationCompleted, userState);
    }

    private void OnGetItemDataSourcesOperationCompleted(object arg)
    {
      if (this.GetItemDataSourcesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetItemDataSourcesCompleted((object) this, new GetItemDataSourcesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetItemDataSourcePrompts", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("DataSourcePrompts")]
    public DataSourcePrompt[] GetItemDataSourcePrompts(string Item)
    {
      return (DataSourcePrompt[]) this.Invoke(nameof (GetItemDataSourcePrompts), new object[1]
      {
        (object) Item
      })[0];
    }

    public void GetItemDataSourcePromptsAsync(string Item)
    {
      this.GetItemDataSourcePromptsAsync(Item, (object) null);
    }

    public void GetItemDataSourcePromptsAsync(string Item, object userState)
    {
      if (this.GetItemDataSourcePromptsOperationCompleted == null)
        this.GetItemDataSourcePromptsOperationCompleted = new SendOrPostCallback(this.OnGetItemDataSourcePromptsOperationCompleted);
      this.InvokeAsync("GetItemDataSourcePrompts", new object[1]
      {
        (object) Item
      }, this.GetItemDataSourcePromptsOperationCompleted, userState);
    }

    private void OnGetItemDataSourcePromptsOperationCompleted(object arg)
    {
      if (this.GetItemDataSourcePromptsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetItemDataSourcePromptsCompleted((object) this, new GetItemDataSourcePromptsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateReportHistorySnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("HistoryID")]
    public string CreateReportHistorySnapshot(string Report, out Warning[] Warnings)
    {
      object[] objArray = this.Invoke(nameof (CreateReportHistorySnapshot), new object[1]
      {
        (object) Report
      });
      Warnings = (Warning[]) objArray[1];
      return (string) objArray[0];
    }

    public void CreateReportHistorySnapshotAsync(string Report)
    {
      this.CreateReportHistorySnapshotAsync(Report, (object) null);
    }

    public void CreateReportHistorySnapshotAsync(string Report, object userState)
    {
      if (this.CreateReportHistorySnapshotOperationCompleted == null)
        this.CreateReportHistorySnapshotOperationCompleted = new SendOrPostCallback(this.OnCreateReportHistorySnapshotOperationCompleted);
      this.InvokeAsync("CreateReportHistorySnapshot", new object[1]
      {
        (object) Report
      }, this.CreateReportHistorySnapshotOperationCompleted, userState);
    }

    private void OnCreateReportHistorySnapshotOperationCompleted(object arg)
    {
      if (this.CreateReportHistorySnapshotCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateReportHistorySnapshotCompleted((object) this, new CreateReportHistorySnapshotCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetReportHistoryOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("EnableManualSnapshotCreation")]
    public bool GetReportHistoryOptions(string Report, out bool KeepExecutionSnapshots, [XmlElement("ScheduleDefinition", typeof (ScheduleDefinition)), XmlElement("ScheduleReference", typeof (ScheduleReference)), XmlElement("NoSchedule", typeof (NoSchedule))] out ScheduleDefinitionOrReference Item)
    {
      object[] objArray = this.Invoke(nameof (GetReportHistoryOptions), new object[1]
      {
        (object) Report
      });
      KeepExecutionSnapshots = (bool) objArray[1];
      Item = (ScheduleDefinitionOrReference) objArray[2];
      return (bool) objArray[0];
    }

    public void GetReportHistoryOptionsAsync(string Report)
    {
      this.GetReportHistoryOptionsAsync(Report, (object) null);
    }

    public void GetReportHistoryOptionsAsync(string Report, object userState)
    {
      if (this.GetReportHistoryOptionsOperationCompleted == null)
        this.GetReportHistoryOptionsOperationCompleted = new SendOrPostCallback(this.OnGetReportHistoryOptionsOperationCompleted);
      this.InvokeAsync("GetReportHistoryOptions", new object[1]
      {
        (object) Report
      }, this.GetReportHistoryOptionsOperationCompleted, userState);
    }

    private void OnGetReportHistoryOptionsOperationCompleted(object arg)
    {
      if (this.GetReportHistoryOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportHistoryOptionsCompleted((object) this, new GetReportHistoryOptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetReportHistoryLimit", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetReportHistoryLimit(string Report, bool UseSystem, int HistoryLimit)
    {
      this.Invoke(nameof (SetReportHistoryLimit), new object[3]
      {
        (object) Report,
        (object) UseSystem,
        (object) HistoryLimit
      });
    }

    public void SetReportHistoryLimitAsync(string Report, bool UseSystem, int HistoryLimit)
    {
      this.SetReportHistoryLimitAsync(Report, UseSystem, HistoryLimit, (object) null);
    }

    public void SetReportHistoryLimitAsync(string Report, bool UseSystem, int HistoryLimit, object userState)
    {
      if (this.SetReportHistoryLimitOperationCompleted == null)
        this.SetReportHistoryLimitOperationCompleted = new SendOrPostCallback(this.OnSetReportHistoryLimitOperationCompleted);
      this.InvokeAsync("SetReportHistoryLimit", new object[3]
      {
        (object) Report,
        (object) UseSystem,
        (object) HistoryLimit
      }, this.SetReportHistoryLimitOperationCompleted, userState);
    }

    private void OnSetReportHistoryLimitOperationCompleted(object arg)
    {
      if (this.SetReportHistoryLimitCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportHistoryLimitCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetReportHistoryLimit", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("HistoryLimit")]
    public int GetReportHistoryLimit(string Report, out bool IsSystem, out int SystemLimit)
    {
      object[] objArray = this.Invoke(nameof (GetReportHistoryLimit), new object[1]
      {
        (object) Report
      });
      IsSystem = (bool) objArray[1];
      SystemLimit = (int) objArray[2];
      return (int) objArray[0];
    }

    public void GetReportHistoryLimitAsync(string Report)
    {
      this.GetReportHistoryLimitAsync(Report, (object) null);
    }

    public void GetReportHistoryLimitAsync(string Report, object userState)
    {
      if (this.GetReportHistoryLimitOperationCompleted == null)
        this.GetReportHistoryLimitOperationCompleted = new SendOrPostCallback(this.OnGetReportHistoryLimitOperationCompleted);
      this.InvokeAsync("GetReportHistoryLimit", new object[1]
      {
        (object) Report
      }, this.GetReportHistoryLimitOperationCompleted, userState);
    }

    private void OnGetReportHistoryLimitOperationCompleted(object arg)
    {
      if (this.GetReportHistoryLimitCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportHistoryLimitCompleted((object) this, new GetReportHistoryLimitCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListReportHistory", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("ReportHistory")]
    public ReportHistorySnapshot[] ListReportHistory(string Report)
    {
      return (ReportHistorySnapshot[]) this.Invoke(nameof (ListReportHistory), new object[1]
      {
        (object) Report
      })[0];
    }

    public void ListReportHistoryAsync(string Report)
    {
      this.ListReportHistoryAsync(Report, (object) null);
    }

    public void ListReportHistoryAsync(string Report, object userState)
    {
      if (this.ListReportHistoryOperationCompleted == null)
        this.ListReportHistoryOperationCompleted = new SendOrPostCallback(this.OnListReportHistoryOperationCompleted);
      this.InvokeAsync("ListReportHistory", new object[1]
      {
        (object) Report
      }, this.ListReportHistoryOperationCompleted, userState);
    }

    private void OnListReportHistoryOperationCompleted(object arg)
    {
      if (this.ListReportHistoryCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListReportHistoryCompleted((object) this, new ListReportHistoryCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/DeleteReportHistorySnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void DeleteReportHistorySnapshot(string Report, string HistoryID)
    {
      this.Invoke(nameof (DeleteReportHistorySnapshot), new object[2]
      {
        (object) Report,
        (object) HistoryID
      });
    }

    public void DeleteReportHistorySnapshotAsync(string Report, string HistoryID)
    {
      this.DeleteReportHistorySnapshotAsync(Report, HistoryID, (object) null);
    }

    public void DeleteReportHistorySnapshotAsync(string Report, string HistoryID, object userState)
    {
      if (this.DeleteReportHistorySnapshotOperationCompleted == null)
        this.DeleteReportHistorySnapshotOperationCompleted = new SendOrPostCallback(this.OnDeleteReportHistorySnapshotOperationCompleted);
      this.InvokeAsync("DeleteReportHistorySnapshot", new object[2]
      {
        (object) Report,
        (object) HistoryID
      }, this.DeleteReportHistorySnapshotOperationCompleted, userState);
    }

    private void OnDeleteReportHistorySnapshotOperationCompleted(object arg)
    {
      if (this.DeleteReportHistorySnapshotCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DeleteReportHistorySnapshotCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("ScheduleID")]
    public string CreateSchedule(string Name, ScheduleDefinition ScheduleDefinition, string Site)
    {
      return (string) this.Invoke(nameof (CreateSchedule), new object[3]
      {
        (object) Name,
        (object) ScheduleDefinition,
        (object) Site
      })[0];
    }

    public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, string Site)
    {
      this.CreateScheduleAsync(Name, ScheduleDefinition, Site, (object) null);
    }

    public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, string Site, object userState)
    {
      if (this.CreateScheduleOperationCompleted == null)
        this.CreateScheduleOperationCompleted = new SendOrPostCallback(this.OnCreateScheduleOperationCompleted);
      this.InvokeAsync("CreateSchedule", new object[3]
      {
        (object) Name,
        (object) ScheduleDefinition,
        (object) Site
      }, this.CreateScheduleOperationCompleted, userState);
    }

    private void OnCreateScheduleOperationCompleted(object arg)
    {
      if (this.CreateScheduleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateScheduleCompleted((object) this, new CreateScheduleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/DeleteSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void DeleteSchedule(string ScheduleID)
    {
      this.Invoke(nameof (DeleteSchedule), new object[1]
      {
        (object) ScheduleID
      });
    }

    public void DeleteScheduleAsync(string ScheduleID)
    {
      this.DeleteScheduleAsync(ScheduleID, (object) null);
    }

    public void DeleteScheduleAsync(string ScheduleID, object userState)
    {
      if (this.DeleteScheduleOperationCompleted == null)
        this.DeleteScheduleOperationCompleted = new SendOrPostCallback(this.OnDeleteScheduleOperationCompleted);
      this.InvokeAsync("DeleteSchedule", new object[1]
      {
        (object) ScheduleID
      }, this.DeleteScheduleOperationCompleted, userState);
    }

    private void OnDeleteScheduleOperationCompleted(object arg)
    {
      if (this.DeleteScheduleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DeleteScheduleCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetScheduleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetScheduleProperties(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
    {
      this.Invoke(nameof (SetScheduleProperties), new object[3]
      {
        (object) Name,
        (object) ScheduleID,
        (object) ScheduleDefinition
      });
    }

    public void SetSchedulePropertiesAsync(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
    {
      this.SetSchedulePropertiesAsync(Name, ScheduleID, ScheduleDefinition, (object) null);
    }

    public void SetSchedulePropertiesAsync(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition, object userState)
    {
      if (this.SetSchedulePropertiesOperationCompleted == null)
        this.SetSchedulePropertiesOperationCompleted = new SendOrPostCallback(this.OnSetSchedulePropertiesOperationCompleted);
      this.InvokeAsync("SetScheduleProperties", new object[3]
      {
        (object) Name,
        (object) ScheduleID,
        (object) ScheduleDefinition
      }, this.SetSchedulePropertiesOperationCompleted, userState);
    }

    private void OnSetSchedulePropertiesOperationCompleted(object arg)
    {
      if (this.SetSchedulePropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetSchedulePropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetScheduleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Schedule")]
    public Schedule GetScheduleProperties(string ScheduleID)
    {
      return (Schedule) this.Invoke(nameof (GetScheduleProperties), new object[1]
      {
        (object) ScheduleID
      })[0];
    }

    public void GetSchedulePropertiesAsync(string ScheduleID)
    {
      this.GetSchedulePropertiesAsync(ScheduleID, (object) null);
    }

    public void GetSchedulePropertiesAsync(string ScheduleID, object userState)
    {
      if (this.GetSchedulePropertiesOperationCompleted == null)
        this.GetSchedulePropertiesOperationCompleted = new SendOrPostCallback(this.OnGetSchedulePropertiesOperationCompleted);
      this.InvokeAsync("GetScheduleProperties", new object[1]
      {
        (object) ScheduleID
      }, this.GetSchedulePropertiesOperationCompleted, userState);
    }

    private void OnGetSchedulePropertiesOperationCompleted(object arg)
    {
      if (this.GetSchedulePropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetSchedulePropertiesCompleted((object) this, new GetSchedulePropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListScheduledReports", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("Reports")]
    public CatalogItem[] ListScheduledReports(string ScheduleID)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListScheduledReports), new object[1]
      {
        (object) ScheduleID
      })[0];
    }

    public void ListScheduledReportsAsync(string ScheduleID)
    {
      this.ListScheduledReportsAsync(ScheduleID, (object) null);
    }

    public void ListScheduledReportsAsync(string ScheduleID, object userState)
    {
      if (this.ListScheduledReportsOperationCompleted == null)
        this.ListScheduledReportsOperationCompleted = new SendOrPostCallback(this.OnListScheduledReportsOperationCompleted);
      this.InvokeAsync("ListScheduledReports", new object[1]
      {
        (object) ScheduleID
      }, this.ListScheduledReportsOperationCompleted, userState);
    }

    private void OnListScheduledReportsOperationCompleted(object arg)
    {
      if (this.ListScheduledReportsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListScheduledReportsCompleted((object) this, new ListScheduledReportsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListSchedules", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Schedules")]
    public Schedule[] ListSchedules(string Site)
    {
      return (Schedule[]) this.Invoke(nameof (ListSchedules), new object[1]
      {
        (object) Site
      })[0];
    }

    public void ListSchedulesAsync(string Site)
    {
      this.ListSchedulesAsync(Site, (object) null);
    }

    public void ListSchedulesAsync(string Site, object userState)
    {
      if (this.ListSchedulesOperationCompleted == null)
        this.ListSchedulesOperationCompleted = new SendOrPostCallback(this.OnListSchedulesOperationCompleted);
      this.InvokeAsync("ListSchedules", new object[1]
      {
        (object) Site
      }, this.ListSchedulesOperationCompleted, userState);
    }

    private void OnListSchedulesOperationCompleted(object arg)
    {
      if (this.ListSchedulesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSchedulesCompleted((object) this, new ListSchedulesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/PauseSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void PauseSchedule(string ScheduleID)
    {
      this.Invoke(nameof (PauseSchedule), new object[1]
      {
        (object) ScheduleID
      });
    }

    public void PauseScheduleAsync(string ScheduleID)
    {
      this.PauseScheduleAsync(ScheduleID, (object) null);
    }

    public void PauseScheduleAsync(string ScheduleID, object userState)
    {
      if (this.PauseScheduleOperationCompleted == null)
        this.PauseScheduleOperationCompleted = new SendOrPostCallback(this.OnPauseScheduleOperationCompleted);
      this.InvokeAsync("PauseSchedule", new object[1]
      {
        (object) ScheduleID
      }, this.PauseScheduleOperationCompleted, userState);
    }

    private void OnPauseScheduleOperationCompleted(object arg)
    {
      if (this.PauseScheduleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.PauseScheduleCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ResumeSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void ResumeSchedule(string ScheduleID)
    {
      this.Invoke(nameof (ResumeSchedule), new object[1]
      {
        (object) ScheduleID
      });
    }

    public void ResumeScheduleAsync(string ScheduleID)
    {
      this.ResumeScheduleAsync(ScheduleID, (object) null);
    }

    public void ResumeScheduleAsync(string ScheduleID, object userState)
    {
      if (this.ResumeScheduleOperationCompleted == null)
        this.ResumeScheduleOperationCompleted = new SendOrPostCallback(this.OnResumeScheduleOperationCompleted);
      this.InvokeAsync("ResumeSchedule", new object[1]
      {
        (object) ScheduleID
      }, this.ResumeScheduleOperationCompleted, userState);
    }

    private void OnResumeScheduleOperationCompleted(object arg)
    {
      if (this.ResumeScheduleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ResumeScheduleCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateSubscription", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("SubscriptionID")]
    public string CreateSubscription(string Report, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
    {
      return (string) this.Invoke(nameof (CreateSubscription), new object[6]
      {
        (object) Report,
        (object) ExtensionSettings,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      })[0];
    }

    public void CreateSubscriptionAsync(string Report, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
    {
      this.CreateSubscriptionAsync(Report, ExtensionSettings, Description, EventType, MatchData, Parameters, (object) null);
    }

    public void CreateSubscriptionAsync(string Report, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
    {
      if (this.CreateSubscriptionOperationCompleted == null)
        this.CreateSubscriptionOperationCompleted = new SendOrPostCallback(this.OnCreateSubscriptionOperationCompleted);
      this.InvokeAsync("CreateSubscription", new object[6]
      {
        (object) Report,
        (object) ExtensionSettings,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      }, this.CreateSubscriptionOperationCompleted, userState);
    }

    private void OnCreateSubscriptionOperationCompleted(object arg)
    {
      if (this.CreateSubscriptionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateSubscriptionCompleted((object) this, new CreateSubscriptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetSubscriptionProperties(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
    {
      this.Invoke(nameof (SetSubscriptionProperties), new object[6]
      {
        (object) SubscriptionID,
        (object) ExtensionSettings,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      });
    }

    public void SetSubscriptionPropertiesAsync(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters)
    {
      this.SetSubscriptionPropertiesAsync(SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters, (object) null);
    }

    public void SetSubscriptionPropertiesAsync(string SubscriptionID, ExtensionSettings ExtensionSettings, string Description, string EventType, string MatchData, ParameterValue[] Parameters, object userState)
    {
      if (this.SetSubscriptionPropertiesOperationCompleted == null)
        this.SetSubscriptionPropertiesOperationCompleted = new SendOrPostCallback(this.OnSetSubscriptionPropertiesOperationCompleted);
      this.InvokeAsync("SetSubscriptionProperties", new object[6]
      {
        (object) SubscriptionID,
        (object) ExtensionSettings,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      }, this.SetSubscriptionPropertiesOperationCompleted, userState);
    }

    private void OnSetSubscriptionPropertiesOperationCompleted(object arg)
    {
      if (this.SetSubscriptionPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetSubscriptionPropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Owner")]
    public string GetSubscriptionProperties(string SubscriptionID, out ExtensionSettings ExtensionSettings, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValue[] Parameters)
    {
      object[] objArray = this.Invoke(nameof (GetSubscriptionProperties), new object[1]
      {
        (object) SubscriptionID
      });
      ExtensionSettings = (ExtensionSettings) objArray[1];
      Description = (string) objArray[2];
      Active = (ActiveState) objArray[3];
      Status = (string) objArray[4];
      EventType = (string) objArray[5];
      MatchData = (string) objArray[6];
      Parameters = (ParameterValue[]) objArray[7];
      return (string) objArray[0];
    }

    public void GetSubscriptionPropertiesAsync(string SubscriptionID)
    {
      this.GetSubscriptionPropertiesAsync(SubscriptionID, (object) null);
    }

    public void GetSubscriptionPropertiesAsync(string SubscriptionID, object userState)
    {
      if (this.GetSubscriptionPropertiesOperationCompleted == null)
        this.GetSubscriptionPropertiesOperationCompleted = new SendOrPostCallback(this.OnGetSubscriptionPropertiesOperationCompleted);
      this.InvokeAsync("GetSubscriptionProperties", new object[1]
      {
        (object) SubscriptionID
      }, this.GetSubscriptionPropertiesOperationCompleted, userState);
    }

    private void OnGetSubscriptionPropertiesOperationCompleted(object arg)
    {
      if (this.GetSubscriptionPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetSubscriptionPropertiesCompleted((object) this, new GetSubscriptionPropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/DeleteSubscription", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void DeleteSubscription(string SubscriptionID)
    {
      this.Invoke(nameof (DeleteSubscription), new object[1]
      {
        (object) SubscriptionID
      });
    }

    public void DeleteSubscriptionAsync(string SubscriptionID)
    {
      this.DeleteSubscriptionAsync(SubscriptionID, (object) null);
    }

    public void DeleteSubscriptionAsync(string SubscriptionID, object userState)
    {
      if (this.DeleteSubscriptionOperationCompleted == null)
        this.DeleteSubscriptionOperationCompleted = new SendOrPostCallback(this.OnDeleteSubscriptionOperationCompleted);
      this.InvokeAsync("DeleteSubscription", new object[1]
      {
        (object) SubscriptionID
      }, this.DeleteSubscriptionOperationCompleted, userState);
    }

    private void OnDeleteSubscriptionOperationCompleted(object arg)
    {
      if (this.DeleteSubscriptionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DeleteSubscriptionCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/PrepareQuery", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("DataSettings")]
    public DataSetDefinition PrepareQuery(DataSource DataSource, DataSetDefinition DataSet, out bool Changed, out string[] ParameterNames)
    {
      object[] objArray = this.Invoke(nameof (PrepareQuery), new object[2]
      {
        (object) DataSource,
        (object) DataSet
      });
      Changed = (bool) objArray[1];
      ParameterNames = (string[]) objArray[2];
      return (DataSetDefinition) objArray[0];
    }

    public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet)
    {
      this.PrepareQueryAsync(DataSource, DataSet, (object) null);
    }

    public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet, object userState)
    {
      if (this.PrepareQueryOperationCompleted == null)
        this.PrepareQueryOperationCompleted = new SendOrPostCallback(this.OnPrepareQueryOperationCompleted);
      this.InvokeAsync("PrepareQuery", new object[2]
      {
        (object) DataSource,
        (object) DataSet
      }, this.PrepareQueryOperationCompleted, userState);
    }

    private void OnPrepareQueryOperationCompleted(object arg)
    {
      if (this.PrepareQueryCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.PrepareQueryCompleted((object) this, new PrepareQueryCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetExtensionSettings", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("ExtensionParameters")]
    public ExtensionParameter[] GetExtensionSettings(string Extension)
    {
      return (ExtensionParameter[]) this.Invoke(nameof (GetExtensionSettings), new object[1]
      {
        (object) Extension
      })[0];
    }

    public void GetExtensionSettingsAsync(string Extension)
    {
      this.GetExtensionSettingsAsync(Extension, (object) null);
    }

    public void GetExtensionSettingsAsync(string Extension, object userState)
    {
      if (this.GetExtensionSettingsOperationCompleted == null)
        this.GetExtensionSettingsOperationCompleted = new SendOrPostCallback(this.OnGetExtensionSettingsOperationCompleted);
      this.InvokeAsync("GetExtensionSettings", new object[1]
      {
        (object) Extension
      }, this.GetExtensionSettingsOperationCompleted, userState);
    }

    private void OnGetExtensionSettingsOperationCompleted(object arg)
    {
      if (this.GetExtensionSettingsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetExtensionSettingsCompleted((object) this, new GetExtensionSettingsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ValidateExtensionSettings", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("ParameterErrors")]
    public ExtensionParameter[] ValidateExtensionSettings(string Extension, ParameterValueOrFieldReference[] ParameterValues, string Site)
    {
      return (ExtensionParameter[]) this.Invoke(nameof (ValidateExtensionSettings), new object[3]
      {
        (object) Extension,
        (object) ParameterValues,
        (object) Site
      })[0];
    }

    public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues, string Site)
    {
      this.ValidateExtensionSettingsAsync(Extension, ParameterValues, Site, (object) null);
    }

    public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues, string Site, object userState)
    {
      if (this.ValidateExtensionSettingsOperationCompleted == null)
        this.ValidateExtensionSettingsOperationCompleted = new SendOrPostCallback(this.OnValidateExtensionSettingsOperationCompleted);
      this.InvokeAsync("ValidateExtensionSettings", new object[3]
      {
        (object) Extension,
        (object) ParameterValues,
        (object) Site
      }, this.ValidateExtensionSettingsOperationCompleted, userState);
    }

    private void OnValidateExtensionSettingsOperationCompleted(object arg)
    {
      if (this.ValidateExtensionSettingsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ValidateExtensionSettingsCompleted((object) this, new ValidateExtensionSettingsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListAllSubscriptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("SubscriptionItems")]
    public Subscription[] ListAllSubscriptions(string Site)
    {
      return (Subscription[]) this.Invoke(nameof (ListAllSubscriptions), new object[1]
      {
        (object) Site
      })[0];
    }

    public void ListAllSubscriptionsAsync(string Site)
    {
      this.ListAllSubscriptionsAsync(Site, (object) null);
    }

    public void ListAllSubscriptionsAsync(string Site, object userState)
    {
      if (this.ListAllSubscriptionsOperationCompleted == null)
        this.ListAllSubscriptionsOperationCompleted = new SendOrPostCallback(this.OnListAllSubscriptionsOperationCompleted);
      this.InvokeAsync("ListAllSubscriptions", new object[1]
      {
        (object) Site
      }, this.ListAllSubscriptionsOperationCompleted, userState);
    }

    private void OnListAllSubscriptionsOperationCompleted(object arg)
    {
      if (this.ListAllSubscriptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListAllSubscriptionsCompleted((object) this, new ListAllSubscriptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListMySubscriptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("SubscriptionItems")]
    public Subscription[] ListMySubscriptions(string Site)
    {
      return (Subscription[]) this.Invoke(nameof (ListMySubscriptions), new object[1]
      {
        (object) Site
      })[0];
    }

    public void ListMySubscriptionsAsync(string Site)
    {
      this.ListMySubscriptionsAsync(Site, (object) null);
    }

    public void ListMySubscriptionsAsync(string Site, object userState)
    {
      if (this.ListMySubscriptionsOperationCompleted == null)
        this.ListMySubscriptionsOperationCompleted = new SendOrPostCallback(this.OnListMySubscriptionsOperationCompleted);
      this.InvokeAsync("ListMySubscriptions", new object[1]
      {
        (object) Site
      }, this.ListMySubscriptionsOperationCompleted, userState);
    }

    private void OnListMySubscriptionsOperationCompleted(object arg)
    {
      if (this.ListMySubscriptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListMySubscriptionsCompleted((object) this, new ListMySubscriptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListReportSubscriptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("SubscriptionItems")]
    public Subscription[] ListReportSubscriptions(string Report)
    {
      return (Subscription[]) this.Invoke(nameof (ListReportSubscriptions), new object[1]
      {
        (object) Report
      })[0];
    }

    public void ListReportSubscriptionsAsync(string Report)
    {
      this.ListReportSubscriptionsAsync(Report, (object) null);
    }

    public void ListReportSubscriptionsAsync(string Report, object userState)
    {
      if (this.ListReportSubscriptionsOperationCompleted == null)
        this.ListReportSubscriptionsOperationCompleted = new SendOrPostCallback(this.OnListReportSubscriptionsOperationCompleted);
      this.InvokeAsync("ListReportSubscriptions", new object[1]
      {
        (object) Report
      }, this.ListReportSubscriptionsOperationCompleted, userState);
    }

    private void OnListReportSubscriptionsOperationCompleted(object arg)
    {
      if (this.ListReportSubscriptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListReportSubscriptionsCompleted((object) this, new ListReportSubscriptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListExtensions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("Extensions")]
    public Extension[] ListExtensions(ExtensionTypeEnum ExtensionType)
    {
      return (Extension[]) this.Invoke(nameof (ListExtensions), new object[1]
      {
        (object) ExtensionType
      })[0];
    }

    public void ListExtensionsAsync(ExtensionTypeEnum ExtensionType)
    {
      this.ListExtensionsAsync(ExtensionType, (object) null);
    }

    public void ListExtensionsAsync(ExtensionTypeEnum ExtensionType, object userState)
    {
      if (this.ListExtensionsOperationCompleted == null)
        this.ListExtensionsOperationCompleted = new SendOrPostCallback(this.OnListExtensionsOperationCompleted);
      this.InvokeAsync("ListExtensions", new object[1]
      {
        (object) ExtensionType
      }, this.ListExtensionsOperationCompleted, userState);
    }

    private void OnListExtensionsOperationCompleted(object arg)
    {
      if (this.ListExtensionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListExtensionsCompleted((object) this, new ListExtensionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListEvents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Events")]
    public Event[] ListEvents()
    {
      return (Event[]) this.Invoke(nameof (ListEvents), new object[0])[0];
    }

    public void ListEventsAsync()
    {
      this.ListEventsAsync((object) null);
    }

    public void ListEventsAsync(object userState)
    {
      if (this.ListEventsOperationCompleted == null)
        this.ListEventsOperationCompleted = new SendOrPostCallback(this.OnListEventsOperationCompleted);
      this.InvokeAsync("ListEvents", new object[0], this.ListEventsOperationCompleted, userState);
    }

    private void OnListEventsOperationCompleted(object arg)
    {
      if (this.ListEventsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListEventsCompleted((object) this, new ListEventsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/FireEvent", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void FireEvent(string EventType, string EventData, string Site)
    {
      this.Invoke(nameof (FireEvent), new object[3]
      {
        (object) EventType,
        (object) EventData,
        (object) Site
      });
    }

    public void FireEventAsync(string EventType, string EventData, string Site)
    {
      this.FireEventAsync(EventType, EventData, Site, (object) null);
    }

    public void FireEventAsync(string EventType, string EventData, string Site, object userState)
    {
      if (this.FireEventOperationCompleted == null)
        this.FireEventOperationCompleted = new SendOrPostCallback(this.OnFireEventOperationCompleted);
      this.InvokeAsync("FireEvent", new object[3]
      {
        (object) EventType,
        (object) EventData,
        (object) Site
      }, this.FireEventOperationCompleted, userState);
    }

    private void OnFireEventOperationCompleted(object arg)
    {
      if (this.FireEventCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.FireEventCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListTasks", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Tasks")]
    public Task[] ListTasks(SecurityScopeEnum SecurityScope)
    {
      return (Task[]) this.Invoke(nameof (ListTasks), new object[1]
      {
        (object) SecurityScope
      })[0];
    }

    public void ListTasksAsync(SecurityScopeEnum SecurityScope)
    {
      this.ListTasksAsync(SecurityScope, (object) null);
    }

    public void ListTasksAsync(SecurityScopeEnum SecurityScope, object userState)
    {
      if (this.ListTasksOperationCompleted == null)
        this.ListTasksOperationCompleted = new SendOrPostCallback(this.OnListTasksOperationCompleted);
      this.InvokeAsync("ListTasks", new object[1]
      {
        (object) SecurityScope
      }, this.ListTasksOperationCompleted, userState);
    }

    private void OnListTasksOperationCompleted(object arg)
    {
      if (this.ListTasksCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListTasksCompleted((object) this, new ListTasksCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListRoles", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Roles")]
    public Role[] ListRoles(SecurityScopeEnum SecurityScope, string Path)
    {
      return (Role[]) this.Invoke(nameof (ListRoles), new object[2]
      {
        (object) SecurityScope,
        (object) Path
      })[0];
    }

    public void ListRolesAsync(SecurityScopeEnum SecurityScope, string Path)
    {
      this.ListRolesAsync(SecurityScope, Path, (object) null);
    }

    public void ListRolesAsync(SecurityScopeEnum SecurityScope, string Path, object userState)
    {
      if (this.ListRolesOperationCompleted == null)
        this.ListRolesOperationCompleted = new SendOrPostCallback(this.OnListRolesOperationCompleted);
      this.InvokeAsync("ListRoles", new object[2]
      {
        (object) SecurityScope,
        (object) Path
      }, this.ListRolesOperationCompleted, userState);
    }

    private void OnListRolesOperationCompleted(object arg)
    {
      if (this.ListRolesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListRolesCompleted((object) this, new ListRolesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetRoleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Tasks")]
    public Task[] GetRoleProperties(string Name, string Site, out string Description)
    {
      object[] objArray = this.Invoke(nameof (GetRoleProperties), new object[2]
      {
        (object) Name,
        (object) Site
      });
      Description = (string) objArray[1];
      return (Task[]) objArray[0];
    }

    public void GetRolePropertiesAsync(string Name, string Site)
    {
      this.GetRolePropertiesAsync(Name, Site, (object) null);
    }

    public void GetRolePropertiesAsync(string Name, string Site, object userState)
    {
      if (this.GetRolePropertiesOperationCompleted == null)
        this.GetRolePropertiesOperationCompleted = new SendOrPostCallback(this.OnGetRolePropertiesOperationCompleted);
      this.InvokeAsync("GetRoleProperties", new object[2]
      {
        (object) Name,
        (object) Site
      }, this.GetRolePropertiesOperationCompleted, userState);
    }

    private void OnGetRolePropertiesOperationCompleted(object arg)
    {
      if (this.GetRolePropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetRolePropertiesCompleted((object) this, new GetRolePropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Policies")]
    public Policy[] GetPolicies(string Item, out bool InheritParent)
    {
      object[] objArray = this.Invoke(nameof (GetPolicies), new object[1]
      {
        (object) Item
      });
      InheritParent = (bool) objArray[1];
      return (Policy[]) objArray[0];
    }

    public void GetPoliciesAsync(string Item)
    {
      this.GetPoliciesAsync(Item, (object) null);
    }

    public void GetPoliciesAsync(string Item, object userState)
    {
      if (this.GetPoliciesOperationCompleted == null)
        this.GetPoliciesOperationCompleted = new SendOrPostCallback(this.OnGetPoliciesOperationCompleted);
      this.InvokeAsync("GetPolicies", new object[1]
      {
        (object) Item
      }, this.GetPoliciesOperationCompleted, userState);
    }

    private void OnGetPoliciesOperationCompleted(object arg)
    {
      if (this.GetPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetPoliciesCompleted((object) this, new GetPoliciesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    public void SetPolicies(string Item, Policy[] Policies)
    {
      this.Invoke(nameof (SetPolicies), new object[2]
      {
        (object) Item,
        (object) Policies
      });
    }

    public void SetPoliciesAsync(string Item, Policy[] Policies)
    {
      this.SetPoliciesAsync(Item, Policies, (object) null);
    }

    public void SetPoliciesAsync(string Item, Policy[] Policies, object userState)
    {
      if (this.SetPoliciesOperationCompleted == null)
        this.SetPoliciesOperationCompleted = new SendOrPostCallback(this.OnSetPoliciesOperationCompleted);
      this.InvokeAsync("SetPolicies", new object[2]
      {
        (object) Item,
        (object) Policies
      }, this.SetPoliciesOperationCompleted, userState);
    }

    private void OnSetPoliciesOperationCompleted(object arg)
    {
      if (this.SetPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetPoliciesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/InheritParentSecurity", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void InheritParentSecurity(string Item)
    {
      this.Invoke(nameof (InheritParentSecurity), new object[1]
      {
        (object) Item
      });
    }

    public void InheritParentSecurityAsync(string Item)
    {
      this.InheritParentSecurityAsync(Item, (object) null);
    }

    public void InheritParentSecurityAsync(string Item, object userState)
    {
      if (this.InheritParentSecurityOperationCompleted == null)
        this.InheritParentSecurityOperationCompleted = new SendOrPostCallback(this.OnInheritParentSecurityOperationCompleted);
      this.InvokeAsync("InheritParentSecurity", new object[1]
      {
        (object) Item
      }, this.InheritParentSecurityOperationCompleted, userState);
    }

    private void OnInheritParentSecurityOperationCompleted(object arg)
    {
      if (this.InheritParentSecurityCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.InheritParentSecurityCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetPermissions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Permissions")]
    [return: XmlArrayItem("Operation")]
    public string[] GetPermissions(string Item)
    {
      return (string[]) this.Invoke(nameof (GetPermissions), new object[1]
      {
        (object) Item
      })[0];
    }

    public void GetPermissionsAsync(string Item)
    {
      this.GetPermissionsAsync(Item, (object) null);
    }

    public void GetPermissionsAsync(string Item, object userState)
    {
      if (this.GetPermissionsOperationCompleted == null)
        this.GetPermissionsOperationCompleted = new SendOrPostCallback(this.OnGetPermissionsOperationCompleted);
      this.InvokeAsync("GetPermissions", new object[1]
      {
        (object) Item
      }, this.GetPermissionsOperationCompleted, userState);
    }

    private void OnGetPermissionsOperationCompleted(object arg)
    {
      if (this.GetPermissionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetPermissionsCompleted((object) this, new GetPermissionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/CreateModel", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("ItemInfo")]
    public CatalogItem CreateModel(string Model, string Parent, [XmlElement(DataType = "base64Binary")] byte[] Definition, Property[] Properties, out Warning[] Warnings)
    {
      object[] objArray = this.Invoke(nameof (CreateModel), new object[4]
      {
        (object) Model,
        (object) Parent,
        (object) Definition,
        (object) Properties
      });
      Warnings = (Warning[]) objArray[1];
      return (CatalogItem) objArray[0];
    }

    public void CreateModelAsync(string Model, string Parent, byte[] Definition, Property[] Properties)
    {
      this.CreateModelAsync(Model, Parent, Definition, Properties, (object) null);
    }

    public void CreateModelAsync(string Model, string Parent, byte[] Definition, Property[] Properties, object userState)
    {
      if (this.CreateModelOperationCompleted == null)
        this.CreateModelOperationCompleted = new SendOrPostCallback(this.OnCreateModelOperationCompleted);
      this.InvokeAsync("CreateModel", new object[4]
      {
        (object) Model,
        (object) Parent,
        (object) Definition,
        (object) Properties
      }, this.CreateModelOperationCompleted, userState);
    }

    private void OnCreateModelOperationCompleted(object arg)
    {
      if (this.CreateModelCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateModelCompleted((object) this, new CreateModelCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetModelDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("Definition", DataType = "base64Binary")]
    public byte[] GetModelDefinition(string Model)
    {
      return (byte[]) this.Invoke(nameof (GetModelDefinition), new object[1]
      {
        (object) Model
      })[0];
    }

    public void GetModelDefinitionAsync(string Model)
    {
      this.GetModelDefinitionAsync(Model, (object) null);
    }

    public void GetModelDefinitionAsync(string Model, object userState)
    {
      if (this.GetModelDefinitionOperationCompleted == null)
        this.GetModelDefinitionOperationCompleted = new SendOrPostCallback(this.OnGetModelDefinitionOperationCompleted);
      this.InvokeAsync("GetModelDefinition", new object[1]
      {
        (object) Model
      }, this.GetModelDefinitionOperationCompleted, userState);
    }

    private void OnGetModelDefinitionOperationCompleted(object arg)
    {
      if (this.GetModelDefinitionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetModelDefinitionCompleted((object) this, new GetModelDefinitionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetModelDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Warnings")]
    public Warning[] SetModelDefinition(string Model, [XmlElement(DataType = "base64Binary")] byte[] Definition)
    {
      return (Warning[]) this.Invoke(nameof (SetModelDefinition), new object[2]
      {
        (object) Model,
        (object) Definition
      })[0];
    }

    public void SetModelDefinitionAsync(string Model, byte[] Definition)
    {
      this.SetModelDefinitionAsync(Model, Definition, (object) null);
    }

    public void SetModelDefinitionAsync(string Model, byte[] Definition, object userState)
    {
      if (this.SetModelDefinitionOperationCompleted == null)
        this.SetModelDefinitionOperationCompleted = new SendOrPostCallback(this.OnSetModelDefinitionOperationCompleted);
      this.InvokeAsync("SetModelDefinition", new object[2]
      {
        (object) Model,
        (object) Definition
      }, this.SetModelDefinitionOperationCompleted, userState);
    }

    private void OnSetModelDefinitionOperationCompleted(object arg)
    {
      if (this.SetModelDefinitionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetModelDefinitionCompleted((object) this, new SetModelDefinitionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListModelPerspectives", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlArray("ModelCatalogItems")]
    public ModelCatalogItem[] ListModelPerspectives(string Path)
    {
      return (ModelCatalogItem[]) this.Invoke(nameof (ListModelPerspectives), new object[1]
      {
        (object) Path
      })[0];
    }

    public void ListModelPerspectivesAsync(string Path)
    {
      this.ListModelPerspectivesAsync(Path, (object) null);
    }

    public void ListModelPerspectivesAsync(string Path, object userState)
    {
      if (this.ListModelPerspectivesOperationCompleted == null)
        this.ListModelPerspectivesOperationCompleted = new SendOrPostCallback(this.OnListModelPerspectivesOperationCompleted);
      this.InvokeAsync("ListModelPerspectives", new object[1]
      {
        (object) Path
      }, this.ListModelPerspectivesOperationCompleted, userState);
    }

    private void OnListModelPerspectivesOperationCompleted(object arg)
    {
      if (this.ListModelPerspectivesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListModelPerspectivesCompleted((object) this, new ListModelPerspectivesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetUserModel", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [return: XmlElement("Definition", DataType = "base64Binary")]
    public byte[] GetUserModel(string Model, string Perspective)
    {
      return (byte[]) this.Invoke(nameof (GetUserModel), new object[2]
      {
        (object) Model,
        (object) Perspective
      })[0];
    }

    public void GetUserModelAsync(string Model, string Perspective)
    {
      this.GetUserModelAsync(Model, Perspective, (object) null);
    }

    public void GetUserModelAsync(string Model, string Perspective, object userState)
    {
      if (this.GetUserModelOperationCompleted == null)
        this.GetUserModelOperationCompleted = new SendOrPostCallback(this.OnGetUserModelOperationCompleted);
      this.InvokeAsync("GetUserModel", new object[2]
      {
        (object) Model,
        (object) Perspective
      }, this.GetUserModelOperationCompleted, userState);
    }

    private void OnGetUserModelOperationCompleted(object arg)
    {
      if (this.GetUserModelCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetUserModelCompleted((object) this, new GetUserModelCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListModelItemChildren", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("ModelItems")]
    public ModelItem[] ListModelItemChildren(string Model, string ModelItemID, bool Recursive)
    {
      return (ModelItem[]) this.Invoke(nameof (ListModelItemChildren), new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Recursive
      })[0];
    }

    public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive)
    {
      this.ListModelItemChildrenAsync(Model, ModelItemID, Recursive, (object) null);
    }

    public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive, object userState)
    {
      if (this.ListModelItemChildrenOperationCompleted == null)
        this.ListModelItemChildrenOperationCompleted = new SendOrPostCallback(this.OnListModelItemChildrenOperationCompleted);
      this.InvokeAsync("ListModelItemChildren", new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Recursive
      }, this.ListModelItemChildrenOperationCompleted, userState);
    }

    private void OnListModelItemChildrenOperationCompleted(object arg)
    {
      if (this.ListModelItemChildrenCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListModelItemChildrenCompleted((object) this, new ListModelItemChildrenCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetModelItemPermissions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Permissions")]
    public string[] GetModelItemPermissions(string Model, string ModelItemID)
    {
      return (string[]) this.Invoke(nameof (GetModelItemPermissions), new object[2]
      {
        (object) Model,
        (object) ModelItemID
      })[0];
    }

    public void GetModelItemPermissionsAsync(string Model, string ModelItemID)
    {
      this.GetModelItemPermissionsAsync(Model, ModelItemID, (object) null);
    }

    public void GetModelItemPermissionsAsync(string Model, string ModelItemID, object userState)
    {
      if (this.GetModelItemPermissionsOperationCompleted == null)
        this.GetModelItemPermissionsOperationCompleted = new SendOrPostCallback(this.OnGetModelItemPermissionsOperationCompleted);
      this.InvokeAsync("GetModelItemPermissions", new object[2]
      {
        (object) Model,
        (object) ModelItemID
      }, this.GetModelItemPermissionsOperationCompleted, userState);
    }

    private void OnGetModelItemPermissionsOperationCompleted(object arg)
    {
      if (this.GetModelItemPermissionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetModelItemPermissionsCompleted((object) this, new GetModelItemPermissionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GetModelItemPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Policies")]
    public Policy[] GetModelItemPolicies(string Model, string ModelItemID, out bool InheritParent)
    {
      object[] objArray = this.Invoke(nameof (GetModelItemPolicies), new object[2]
      {
        (object) Model,
        (object) ModelItemID
      });
      InheritParent = (bool) objArray[1];
      return (Policy[]) objArray[0];
    }

    public void GetModelItemPoliciesAsync(string Model, string ModelItemID)
    {
      this.GetModelItemPoliciesAsync(Model, ModelItemID, (object) null);
    }

    public void GetModelItemPoliciesAsync(string Model, string ModelItemID, object userState)
    {
      if (this.GetModelItemPoliciesOperationCompleted == null)
        this.GetModelItemPoliciesOperationCompleted = new SendOrPostCallback(this.OnGetModelItemPoliciesOperationCompleted);
      this.InvokeAsync("GetModelItemPolicies", new object[2]
      {
        (object) Model,
        (object) ModelItemID
      }, this.GetModelItemPoliciesOperationCompleted, userState);
    }

    private void OnGetModelItemPoliciesOperationCompleted(object arg)
    {
      if (this.GetModelItemPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetModelItemPoliciesCompleted((object) this, new GetModelItemPoliciesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetModelItemPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetModelItemPolicies(string Model, string ModelItemID, Policy[] Policies)
    {
      this.Invoke(nameof (SetModelItemPolicies), new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Policies
      });
    }

    public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies)
    {
      this.SetModelItemPoliciesAsync(Model, ModelItemID, Policies, (object) null);
    }

    public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies, object userState)
    {
      if (this.SetModelItemPoliciesOperationCompleted == null)
        this.SetModelItemPoliciesOperationCompleted = new SendOrPostCallback(this.OnSetModelItemPoliciesOperationCompleted);
      this.InvokeAsync("SetModelItemPolicies", new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Policies
      }, this.SetModelItemPoliciesOperationCompleted, userState);
    }

    private void OnSetModelItemPoliciesOperationCompleted(object arg)
    {
      if (this.SetModelItemPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetModelItemPoliciesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/InheritModelItemParentSecurity", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void InheritModelItemParentSecurity(string Model, string ModelItemID)
    {
      this.Invoke(nameof (InheritModelItemParentSecurity), new object[2]
      {
        (object) Model,
        (object) ModelItemID
      });
    }

    public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID)
    {
      this.InheritModelItemParentSecurityAsync(Model, ModelItemID, (object) null);
    }

    public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID, object userState)
    {
      if (this.InheritModelItemParentSecurityOperationCompleted == null)
        this.InheritModelItemParentSecurityOperationCompleted = new SendOrPostCallback(this.OnInheritModelItemParentSecurityOperationCompleted);
      this.InvokeAsync("InheritModelItemParentSecurity", new object[2]
      {
        (object) Model,
        (object) ModelItemID
      }, this.InheritModelItemParentSecurityOperationCompleted, userState);
    }

    private void OnInheritModelItemParentSecurityOperationCompleted(object arg)
    {
      if (this.InheritModelItemParentSecurityCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.InheritModelItemParentSecurityCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/RemoveAllModelItemPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void RemoveAllModelItemPolicies(string Model)
    {
      this.Invoke(nameof (RemoveAllModelItemPolicies), new object[1]
      {
        (object) Model
      });
    }

    public void RemoveAllModelItemPoliciesAsync(string Model)
    {
      this.RemoveAllModelItemPoliciesAsync(Model, (object) null);
    }

    public void RemoveAllModelItemPoliciesAsync(string Model, object userState)
    {
      if (this.RemoveAllModelItemPoliciesOperationCompleted == null)
        this.RemoveAllModelItemPoliciesOperationCompleted = new SendOrPostCallback(this.OnRemoveAllModelItemPoliciesOperationCompleted);
      this.InvokeAsync("RemoveAllModelItemPolicies", new object[1]
      {
        (object) Model
      }, this.RemoveAllModelItemPoliciesOperationCompleted, userState);
    }

    private void OnRemoveAllModelItemPoliciesOperationCompleted(object arg)
    {
      if (this.RemoveAllModelItemPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.RemoveAllModelItemPoliciesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/SetModelDrillthroughReports", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    public void SetModelDrillthroughReports(string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
    {
      this.Invoke(nameof (SetModelDrillthroughReports), new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Reports
      });
    }

    public void SetModelDrillthroughReportsAsync(string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
    {
      this.SetModelDrillthroughReportsAsync(Model, ModelItemID, Reports, (object) null);
    }

    public void SetModelDrillthroughReportsAsync(string Model, string ModelItemID, ModelDrillthroughReport[] Reports, object userState)
    {
      if (this.SetModelDrillthroughReportsOperationCompleted == null)
        this.SetModelDrillthroughReportsOperationCompleted = new SendOrPostCallback(this.OnSetModelDrillthroughReportsOperationCompleted);
      this.InvokeAsync("SetModelDrillthroughReports", new object[3]
      {
        (object) Model,
        (object) ModelItemID,
        (object) Reports
      }, this.SetModelDrillthroughReportsOperationCompleted, userState);
    }

    private void OnSetModelDrillthroughReportsOperationCompleted(object arg)
    {
      if (this.SetModelDrillthroughReportsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetModelDrillthroughReportsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/ListModelDrillthroughReports", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Reports")]
    public ModelDrillthroughReport[] ListModelDrillthroughReports(string Model, string ModelItemID)
    {
      return (ModelDrillthroughReport[]) this.Invoke(nameof (ListModelDrillthroughReports), new object[2]
      {
        (object) Model,
        (object) ModelItemID
      })[0];
    }

    public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID)
    {
      this.ListModelDrillthroughReportsAsync(Model, ModelItemID, (object) null);
    }

    public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID, object userState)
    {
      if (this.ListModelDrillthroughReportsOperationCompleted == null)
        this.ListModelDrillthroughReportsOperationCompleted = new SendOrPostCallback(this.OnListModelDrillthroughReportsOperationCompleted);
      this.InvokeAsync("ListModelDrillthroughReports", new object[2]
      {
        (object) Model,
        (object) ModelItemID
      }, this.ListModelDrillthroughReportsOperationCompleted, userState);
    }

    private void OnListModelDrillthroughReportsOperationCompleted(object arg)
    {
      if (this.ListModelDrillthroughReportsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListModelDrillthroughReportsCompleted((object) this, new ListModelDrillthroughReportsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/GenerateModel", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("ItemInfo")]
    public CatalogItem GenerateModel(string DataSource, string Model, string Parent, Property[] Properties, out Warning[] Warnings)
    {
      object[] objArray = this.Invoke(nameof (GenerateModel), new object[4]
      {
        (object) DataSource,
        (object) Model,
        (object) Parent,
        (object) Properties
      });
      Warnings = (Warning[]) objArray[1];
      return (CatalogItem) objArray[0];
    }

    public void GenerateModelAsync(string DataSource, string Model, string Parent, Property[] Properties)
    {
      this.GenerateModelAsync(DataSource, Model, Parent, Properties, (object) null);
    }

    public void GenerateModelAsync(string DataSource, string Model, string Parent, Property[] Properties, object userState)
    {
      if (this.GenerateModelOperationCompleted == null)
        this.GenerateModelOperationCompleted = new SendOrPostCallback(this.OnGenerateModelOperationCompleted);
      this.InvokeAsync("GenerateModel", new object[4]
      {
        (object) DataSource,
        (object) Model,
        (object) Parent,
        (object) Properties
      }, this.GenerateModelOperationCompleted, userState);
    }

    private void OnGenerateModelOperationCompleted(object arg)
    {
      if (this.GenerateModelCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GenerateModelCompleted((object) this, new GenerateModelCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("TrustedUserHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices/RegenerateModel", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Warnings")]
    public Warning[] RegenerateModel(string Model)
    {
      return (Warning[]) this.Invoke(nameof (RegenerateModel), new object[1]
      {
        (object) Model
      })[0];
    }

    public void RegenerateModelAsync(string Model)
    {
      this.RegenerateModelAsync(Model, (object) null);
    }

    public void RegenerateModelAsync(string Model, object userState)
    {
      if (this.RegenerateModelOperationCompleted == null)
        this.RegenerateModelOperationCompleted = new SendOrPostCallback(this.OnRegenerateModelOperationCompleted);
      this.InvokeAsync("RegenerateModel", new object[1]
      {
        (object) Model
      }, this.RegenerateModelOperationCompleted, userState);
    }

    private void OnRegenerateModelOperationCompleted(object arg)
    {
      if (this.RegenerateModelCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.RegenerateModelCompleted((object) this, new RegenerateModelCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState)
    {
      base.CancelAsync(userState);
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}

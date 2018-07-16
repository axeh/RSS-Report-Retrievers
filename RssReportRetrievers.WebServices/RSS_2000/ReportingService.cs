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

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [XmlInclude(typeof (ExpirationDefinition))]
  [XmlInclude(typeof (DataSourceDefinitionOrReference))]
  [XmlInclude(typeof (RecurrencePattern))]
  [XmlInclude(typeof (ScheduleDefinitionOrReference))]
  [DesignerCategory("code")]
  public class ReportingService : SoapHttpClientProtocol
  {
    private ServerInfoHeader serverInfoHeaderValueField;
    private SendOrPostCallback ListSecureMethodsOperationCompleted;
    private SendOrPostCallback CreateBatchOperationCompleted;
    private BatchHeader batchHeaderValueField;
    private SendOrPostCallback CancelBatchOperationCompleted;
    private SendOrPostCallback ExecuteBatchOperationCompleted;
    private SendOrPostCallback GetSystemPropertiesOperationCompleted;
    private SendOrPostCallback SetSystemPropertiesOperationCompleted;
    private SendOrPostCallback DeleteItemOperationCompleted;
    private SendOrPostCallback MoveItemOperationCompleted;
    private SendOrPostCallback ListChildrenOperationCompleted;
    private ItemNamespaceHeader itemNamespaceHeaderValueField;
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
    private SendOrPostCallback CreateLinkedReportOperationCompleted;
    private SendOrPostCallback GetReportLinkOperationCompleted;
    private SendOrPostCallback SetReportLinkOperationCompleted;
    private SendOrPostCallback ListLinkedReportsOperationCompleted;
    private SessionHeader sessionHeaderValueField;
    private SendOrPostCallback RenderOperationCompleted;
    private SendOrPostCallback RenderStreamOperationCompleted;
    private SendOrPostCallback GetRenderResourceOperationCompleted;
    private SendOrPostCallback SetExecutionOptionsOperationCompleted;
    private SendOrPostCallback GetExecutionOptionsOperationCompleted;
    private SendOrPostCallback SetCacheOptionsOperationCompleted;
    private SendOrPostCallback GetCacheOptionsOperationCompleted;
    private SendOrPostCallback UpdateReportExecutionSnapshotOperationCompleted;
    private SendOrPostCallback FlushCacheOperationCompleted;
    private SendOrPostCallback ListJobsOperationCompleted;
    private SendOrPostCallback CancelJobOperationCompleted;
    private SendOrPostCallback CreateDataSourceOperationCompleted;
    private SendOrPostCallback GetDataSourceContentsOperationCompleted;
    private SendOrPostCallback SetDataSourceContentsOperationCompleted;
    private SendOrPostCallback EnableDataSourceOperationCompleted;
    private SendOrPostCallback DisableDataSourceOperationCompleted;
    private SendOrPostCallback ListReportsUsingDataSourceOperationCompleted;
    private SendOrPostCallback SetReportDataSourcesOperationCompleted;
    private SendOrPostCallback GetReportDataSourcesOperationCompleted;
    private SendOrPostCallback GetReportDataSourcePromptsOperationCompleted;
    private SendOrPostCallback CreateReportHistorySnapshotOperationCompleted;
    private SendOrPostCallback SetReportHistoryOptionsOperationCompleted;
    private SendOrPostCallback GetReportHistoryOptionsOperationCompleted;
    private SendOrPostCallback SetReportHistoryLimitOperationCompleted;
    private SendOrPostCallback GetReportHistoryLimitOperationCompleted;
    private SendOrPostCallback ListReportHistoryOperationCompleted;
    private SendOrPostCallback DeleteReportHistorySnapshotOperationCompleted;
    private SendOrPostCallback FindItemsOperationCompleted;
    private SendOrPostCallback CreateScheduleOperationCompleted;
    private SendOrPostCallback DeleteScheduleOperationCompleted;
    private SendOrPostCallback SetSchedulePropertiesOperationCompleted;
    private SendOrPostCallback GetSchedulePropertiesOperationCompleted;
    private SendOrPostCallback ListScheduledReportsOperationCompleted;
    private SendOrPostCallback ListSchedulesOperationCompleted;
    private SendOrPostCallback PauseScheduleOperationCompleted;
    private SendOrPostCallback ResumeScheduleOperationCompleted;
    private SendOrPostCallback CreateSubscriptionOperationCompleted;
    private SendOrPostCallback CreateDataDrivenSubscriptionOperationCompleted;
    private SendOrPostCallback SetSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback SetDataDrivenSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback GetSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback GetDataDrivenSubscriptionPropertiesOperationCompleted;
    private SendOrPostCallback DeleteSubscriptionOperationCompleted;
    private SendOrPostCallback PrepareQueryOperationCompleted;
    private SendOrPostCallback GetExtensionSettingsOperationCompleted;
    private SendOrPostCallback ValidateExtensionSettingsOperationCompleted;
    private SendOrPostCallback ListSubscriptionsOperationCompleted;
    private SendOrPostCallback ListSubscriptionsUsingDataSourceOperationCompleted;
    private SendOrPostCallback ListExtensionsOperationCompleted;
    private SendOrPostCallback ListEventsOperationCompleted;
    private SendOrPostCallback FireEventOperationCompleted;
    private SendOrPostCallback ListSystemTasksOperationCompleted;
    private SendOrPostCallback ListTasksOperationCompleted;
    private SendOrPostCallback ListSystemRolesOperationCompleted;
    private SendOrPostCallback ListRolesOperationCompleted;
    private SendOrPostCallback CreateRoleOperationCompleted;
    private SendOrPostCallback DeleteRoleOperationCompleted;
    private SendOrPostCallback GetRolePropertiesOperationCompleted;
    private SendOrPostCallback SetRolePropertiesOperationCompleted;
    private SendOrPostCallback GetSystemPoliciesOperationCompleted;
    private SendOrPostCallback SetSystemPoliciesOperationCompleted;
    private SendOrPostCallback GetPoliciesOperationCompleted;
    private SendOrPostCallback SetPoliciesOperationCompleted;
    private SendOrPostCallback InheritParentSecurityOperationCompleted;
    private SendOrPostCallback GetSystemPermissionsOperationCompleted;
    private SendOrPostCallback GetPermissionsOperationCompleted;
    private SendOrPostCallback LogonUserOperationCompleted;
    private SendOrPostCallback LogoffOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public ReportingService()
    {
        this.Url = Settings.Default.RSS2000;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
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

    public BatchHeader BatchHeaderValue
    {
      get
      {
        return this.batchHeaderValueField;
      }
      set
      {
        this.batchHeaderValueField = value;
      }
    }

    public ItemNamespaceHeader ItemNamespaceHeaderValue
    {
      get
      {
        return this.itemNamespaceHeaderValueField;
      }
      set
      {
        this.itemNamespaceHeaderValueField = value;
      }
    }

    public SessionHeader SessionHeaderValue
    {
      get
      {
        return this.sessionHeaderValueField;
      }
      set
      {
        this.sessionHeaderValueField = value;
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

    public event CreateBatchCompletedEventHandler CreateBatchCompleted;

    public event CancelBatchCompletedEventHandler CancelBatchCompleted;

    public event ExecuteBatchCompletedEventHandler ExecuteBatchCompleted;

    public event GetSystemPropertiesCompletedEventHandler GetSystemPropertiesCompleted;

    public event SetSystemPropertiesCompletedEventHandler SetSystemPropertiesCompleted;

    public event DeleteItemCompletedEventHandler DeleteItemCompleted;

    public event MoveItemCompletedEventHandler MoveItemCompleted;

    public event ListChildrenCompletedEventHandler ListChildrenCompleted;

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

    public event CreateLinkedReportCompletedEventHandler CreateLinkedReportCompleted;

    public event GetReportLinkCompletedEventHandler GetReportLinkCompleted;

    public event SetReportLinkCompletedEventHandler SetReportLinkCompleted;

    public event ListLinkedReportsCompletedEventHandler ListLinkedReportsCompleted;

    public event RenderCompletedEventHandler RenderCompleted;

    public event RenderStreamCompletedEventHandler RenderStreamCompleted;

    public event GetRenderResourceCompletedEventHandler GetRenderResourceCompleted;

    public event SetExecutionOptionsCompletedEventHandler SetExecutionOptionsCompleted;

    public event GetExecutionOptionsCompletedEventHandler GetExecutionOptionsCompleted;

    public event SetCacheOptionsCompletedEventHandler SetCacheOptionsCompleted;

    public event GetCacheOptionsCompletedEventHandler GetCacheOptionsCompleted;

    public event UpdateReportExecutionSnapshotCompletedEventHandler UpdateReportExecutionSnapshotCompleted;

    public event FlushCacheCompletedEventHandler FlushCacheCompleted;

    public event ListJobsCompletedEventHandler ListJobsCompleted;

    public event CancelJobCompletedEventHandler CancelJobCompleted;

    public event CreateDataSourceCompletedEventHandler CreateDataSourceCompleted;

    public event GetDataSourceContentsCompletedEventHandler GetDataSourceContentsCompleted;

    public event SetDataSourceContentsCompletedEventHandler SetDataSourceContentsCompleted;

    public event EnableDataSourceCompletedEventHandler EnableDataSourceCompleted;

    public event DisableDataSourceCompletedEventHandler DisableDataSourceCompleted;

    public event ListReportsUsingDataSourceCompletedEventHandler ListReportsUsingDataSourceCompleted;

    public event SetReportDataSourcesCompletedEventHandler SetReportDataSourcesCompleted;

    public event GetReportDataSourcesCompletedEventHandler GetReportDataSourcesCompleted;

    public event GetReportDataSourcePromptsCompletedEventHandler GetReportDataSourcePromptsCompleted;

    public event CreateReportHistorySnapshotCompletedEventHandler CreateReportHistorySnapshotCompleted;

    public event SetReportHistoryOptionsCompletedEventHandler SetReportHistoryOptionsCompleted;

    public event GetReportHistoryOptionsCompletedEventHandler GetReportHistoryOptionsCompleted;

    public event SetReportHistoryLimitCompletedEventHandler SetReportHistoryLimitCompleted;

    public event GetReportHistoryLimitCompletedEventHandler GetReportHistoryLimitCompleted;

    public event ListReportHistoryCompletedEventHandler ListReportHistoryCompleted;

    public event DeleteReportHistorySnapshotCompletedEventHandler DeleteReportHistorySnapshotCompleted;

    public event FindItemsCompletedEventHandler FindItemsCompleted;

    public event CreateScheduleCompletedEventHandler CreateScheduleCompleted;

    public event DeleteScheduleCompletedEventHandler DeleteScheduleCompleted;

    public event SetSchedulePropertiesCompletedEventHandler SetSchedulePropertiesCompleted;

    public event GetSchedulePropertiesCompletedEventHandler GetSchedulePropertiesCompleted;

    public event ListScheduledReportsCompletedEventHandler ListScheduledReportsCompleted;

    public event ListSchedulesCompletedEventHandler ListSchedulesCompleted;

    public event PauseScheduleCompletedEventHandler PauseScheduleCompleted;

    public event ResumeScheduleCompletedEventHandler ResumeScheduleCompleted;

    public event CreateSubscriptionCompletedEventHandler CreateSubscriptionCompleted;

    public event CreateDataDrivenSubscriptionCompletedEventHandler CreateDataDrivenSubscriptionCompleted;

    public event SetSubscriptionPropertiesCompletedEventHandler SetSubscriptionPropertiesCompleted;

    public event SetDataDrivenSubscriptionPropertiesCompletedEventHandler SetDataDrivenSubscriptionPropertiesCompleted;

    public event GetSubscriptionPropertiesCompletedEventHandler GetSubscriptionPropertiesCompleted;

    public event GetDataDrivenSubscriptionPropertiesCompletedEventHandler GetDataDrivenSubscriptionPropertiesCompleted;

    public event DeleteSubscriptionCompletedEventHandler DeleteSubscriptionCompleted;

    public event PrepareQueryCompletedEventHandler PrepareQueryCompleted;

    public event GetExtensionSettingsCompletedEventHandler GetExtensionSettingsCompleted;

    public event ValidateExtensionSettingsCompletedEventHandler ValidateExtensionSettingsCompleted;

    public event ListSubscriptionsCompletedEventHandler ListSubscriptionsCompleted;

    public event ListSubscriptionsUsingDataSourceCompletedEventHandler ListSubscriptionsUsingDataSourceCompleted;

    public event ListExtensionsCompletedEventHandler ListExtensionsCompleted;

    public event ListEventsCompletedEventHandler ListEventsCompleted;

    public event FireEventCompletedEventHandler FireEventCompleted;

    public event ListSystemTasksCompletedEventHandler ListSystemTasksCompleted;

    public event ListTasksCompletedEventHandler ListTasksCompleted;

    public event ListSystemRolesCompletedEventHandler ListSystemRolesCompleted;

    public event ListRolesCompletedEventHandler ListRolesCompleted;

    public event CreateRoleCompletedEventHandler CreateRoleCompleted;

    public event DeleteRoleCompletedEventHandler DeleteRoleCompleted;

    public event GetRolePropertiesCompletedEventHandler GetRolePropertiesCompleted;

    public event SetRolePropertiesCompletedEventHandler SetRolePropertiesCompleted;

    public event GetSystemPoliciesCompletedEventHandler GetSystemPoliciesCompleted;

    public event SetSystemPoliciesCompletedEventHandler SetSystemPoliciesCompleted;

    public event GetPoliciesCompletedEventHandler GetPoliciesCompleted;

    public event SetPoliciesCompletedEventHandler SetPoliciesCompleted;

    public event InheritParentSecurityCompletedEventHandler InheritParentSecurityCompleted;

    public event GetSystemPermissionsCompletedEventHandler GetSystemPermissionsCompleted;

    public event GetPermissionsCompletedEventHandler GetPermissionsCompleted;

    public event LogonUserCompletedEventHandler LogonUserCompleted;

    public event LogoffCompletedEventHandler LogoffCompleted;

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSecureMethods", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateBatch", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("BatchID")]
    public string CreateBatch()
    {
      return (string) this.Invoke(nameof (CreateBatch), new object[0])[0];
    }

    public void CreateBatchAsync()
    {
      this.CreateBatchAsync((object) null);
    }

    public void CreateBatchAsync(object userState)
    {
      if (this.CreateBatchOperationCompleted == null)
        this.CreateBatchOperationCompleted = new SendOrPostCallback(this.OnCreateBatchOperationCompleted);
      this.InvokeAsync("CreateBatch", new object[0], this.CreateBatchOperationCompleted, userState);
    }

    private void OnCreateBatchOperationCompleted(object arg)
    {
      if (this.CreateBatchCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateBatchCompleted((object) this, new CreateBatchCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CancelBatch", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    public void CancelBatch()
    {
      this.Invoke(nameof (CancelBatch), new object[0]);
    }

    public void CancelBatchAsync()
    {
      this.CancelBatchAsync((object) null);
    }

    public void CancelBatchAsync(object userState)
    {
      if (this.CancelBatchOperationCompleted == null)
        this.CancelBatchOperationCompleted = new SendOrPostCallback(this.OnCancelBatchOperationCompleted);
      this.InvokeAsync("CancelBatch", new object[0], this.CancelBatchOperationCompleted, userState);
    }

    private void OnCancelBatchOperationCompleted(object arg)
    {
      if (this.CancelBatchCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CancelBatchCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ExecuteBatch", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void ExecuteBatch()
    {
      this.Invoke(nameof (ExecuteBatch), new object[0]);
    }

    public void ExecuteBatchAsync()
    {
      this.ExecuteBatchAsync((object) null);
    }

    public void ExecuteBatchAsync(object userState)
    {
      if (this.ExecuteBatchOperationCompleted == null)
        this.ExecuteBatchOperationCompleted = new SendOrPostCallback(this.OnExecuteBatchOperationCompleted);
      this.InvokeAsync("ExecuteBatch", new object[0], this.ExecuteBatchOperationCompleted, userState);
    }

    private void OnExecuteBatchOperationCompleted(object arg)
    {
      if (this.ExecuteBatchCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ExecuteBatchCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetSystemProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetSystemProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DeleteItem", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/MoveItem", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListChildren", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("CatalogItems")]
    public CatalogItem[] ListChildren(string Item, bool Recursive)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListChildren), new object[2]
      {
        (object) Item,
        (object) Recursive
      })[0];
    }

    public void ListChildrenAsync(string Item, bool Recursive)
    {
      this.ListChildrenAsync(Item, Recursive, (object) null);
    }

    public void ListChildrenAsync(string Item, bool Recursive, object userState)
    {
      if (this.ListChildrenOperationCompleted == null)
        this.ListChildrenOperationCompleted = new SendOrPostCallback(this.OnListChildrenOperationCompleted);
      this.InvokeAsync("ListChildren", new object[2]
      {
        (object) Item,
        (object) Recursive
      }, this.ListChildrenOperationCompleted, userState);
    }

    private void OnListChildrenOperationCompleted(object arg)
    {
      if (this.ListChildrenCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListChildrenCompleted((object) this, new ListChildrenCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("ItemNamespaceHeaderValue")]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetItemType", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateFolder", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void CreateFolder(string Folder, string Parent, Property[] Properties)
    {
      this.Invoke(nameof (CreateFolder), new object[3]
      {
        (object) Folder,
        (object) Parent,
        (object) Properties
      });
    }

    public void CreateFolderAsync(string Folder, string Parent, Property[] Properties)
    {
      this.CreateFolderAsync(Folder, Parent, Properties, (object) null);
    }

    public void CreateFolderAsync(string Folder, string Parent, Property[] Properties, object userState)
    {
      if (this.CreateFolderOperationCompleted == null)
        this.CreateFolderOperationCompleted = new SendOrPostCallback(this.OnCreateFolderOperationCompleted);
      this.InvokeAsync("CreateFolder", new object[3]
      {
        (object) Folder,
        (object) Parent,
        (object) Properties
      }, this.CreateFolderOperationCompleted, userState);
    }

    private void OnCreateFolderOperationCompleted(object arg)
    {
      if (this.CreateFolderCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateFolderCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateReport", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [return: XmlArray("Warnings")]
    public Warning[] CreateReport(string Report, string Parent, bool Overwrite, [XmlElement(DataType = "base64Binary")] byte[] Definition, Property[] Properties)
    {
      return (Warning[]) this.Invoke(nameof (CreateReport), new object[5]
      {
        (object) Report,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      })[0];
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportDefinition", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateResource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void CreateResource(string Resource, string Parent, bool Overwrite, [XmlElement(DataType = "base64Binary")] byte[] Contents, string MimeType, Property[] Properties)
    {
      this.Invoke(nameof (CreateResource), new object[6]
      {
        (object) Resource,
        (object) Parent,
        (object) Overwrite,
        (object) Contents,
        (object) MimeType,
        (object) Properties
      });
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
      this.CreateResourceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetResourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetResourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportParameters", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Parameters")]
    public ReportParameter[] GetReportParameters(string Report, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials)
    {
      return (ReportParameter[]) this.Invoke(nameof (GetReportParameters), new object[5]
      {
        (object) Report,
        (object) HistoryID,
        (object) ForRendering,
        (object) Values,
        (object) Credentials
      })[0];
    }

    public void GetReportParametersAsync(string Report, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials)
    {
      this.GetReportParametersAsync(Report, HistoryID, ForRendering, Values, Credentials, (object) null);
    }

    public void GetReportParametersAsync(string Report, string HistoryID, bool ForRendering, ParameterValue[] Values, DataSourceCredentials[] Credentials, object userState)
    {
      if (this.GetReportParametersOperationCompleted == null)
        this.GetReportParametersOperationCompleted = new SendOrPostCallback(this.OnGetReportParametersOperationCompleted);
      this.InvokeAsync("GetReportParameters", new object[5]
      {
        (object) Report,
        (object) HistoryID,
        (object) ForRendering,
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportParameters", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateLinkedReport", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void CreateLinkedReport(string Report, string Parent, string Link, Property[] Properties)
    {
      this.Invoke(nameof (CreateLinkedReport), new object[4]
      {
        (object) Report,
        (object) Parent,
        (object) Link,
        (object) Properties
      });
    }

    public void CreateLinkedReportAsync(string Report, string Parent, string Link, Property[] Properties)
    {
      this.CreateLinkedReportAsync(Report, Parent, Link, Properties, (object) null);
    }

    public void CreateLinkedReportAsync(string Report, string Parent, string Link, Property[] Properties, object userState)
    {
      if (this.CreateLinkedReportOperationCompleted == null)
        this.CreateLinkedReportOperationCompleted = new SendOrPostCallback(this.OnCreateLinkedReportOperationCompleted);
      this.InvokeAsync("CreateLinkedReport", new object[4]
      {
        (object) Report,
        (object) Parent,
        (object) Link,
        (object) Properties
      }, this.CreateLinkedReportOperationCompleted, userState);
    }

    private void OnCreateLinkedReportOperationCompleted(object arg)
    {
      if (this.CreateLinkedReportCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateLinkedReportCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportLink", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Link")]
    public string GetReportLink(string Report)
    {
      return (string) this.Invoke(nameof (GetReportLink), new object[1]
      {
        (object) Report
      })[0];
    }

    public void GetReportLinkAsync(string Report)
    {
      this.GetReportLinkAsync(Report, (object) null);
    }

    public void GetReportLinkAsync(string Report, object userState)
    {
      if (this.GetReportLinkOperationCompleted == null)
        this.GetReportLinkOperationCompleted = new SendOrPostCallback(this.OnGetReportLinkOperationCompleted);
      this.InvokeAsync("GetReportLink", new object[1]
      {
        (object) Report
      }, this.GetReportLinkOperationCompleted, userState);
    }

    private void OnGetReportLinkOperationCompleted(object arg)
    {
      if (this.GetReportLinkCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportLinkCompleted((object) this, new GetReportLinkCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportLink", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    public void SetReportLink(string Report, string Link)
    {
      this.Invoke(nameof (SetReportLink), new object[2]
      {
        (object) Report,
        (object) Link
      });
    }

    public void SetReportLinkAsync(string Report, string Link)
    {
      this.SetReportLinkAsync(Report, Link, (object) null);
    }

    public void SetReportLinkAsync(string Report, string Link, object userState)
    {
      if (this.SetReportLinkOperationCompleted == null)
        this.SetReportLinkOperationCompleted = new SendOrPostCallback(this.OnSetReportLinkOperationCompleted);
      this.InvokeAsync("SetReportLink", new object[2]
      {
        (object) Report,
        (object) Link
      }, this.SetReportLinkOperationCompleted, userState);
    }

    private void OnSetReportLinkOperationCompleted(object arg)
    {
      if (this.SetReportLinkCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportLinkCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListLinkedReports", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Reports")]
    public CatalogItem[] ListLinkedReports(string Report)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListLinkedReports), new object[1]
      {
        (object) Report
      })[0];
    }

    public void ListLinkedReportsAsync(string Report)
    {
      this.ListLinkedReportsAsync(Report, (object) null);
    }

    public void ListLinkedReportsAsync(string Report, object userState)
    {
      if (this.ListLinkedReportsOperationCompleted == null)
        this.ListLinkedReportsOperationCompleted = new SendOrPostCallback(this.OnListLinkedReportsOperationCompleted);
      this.InvokeAsync("ListLinkedReports", new object[1]
      {
        (object) Report
      }, this.ListLinkedReportsOperationCompleted, userState);
    }

    private void OnListLinkedReportsOperationCompleted(object arg)
    {
      if (this.ListLinkedReportsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListLinkedReportsCompleted((object) this, new ListLinkedReportsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/Render", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("SessionHeaderValue", Direction = SoapHeaderDirection.InOut)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Result", DataType = "base64Binary")]
    public byte[] Render(string Report, string Format, string HistoryID, string DeviceInfo, ParameterValue[] Parameters, DataSourceCredentials[] Credentials, string ShowHideToggle, out string Encoding, out string MimeType, out ParameterValue[] ParametersUsed, out Warning[] Warnings, out string[] StreamIds)
    {
      object[] objArray = this.Invoke(nameof (Render), new object[7]
      {
        (object) Report,
        (object) Format,
        (object) HistoryID,
        (object) DeviceInfo,
        (object) Parameters,
        (object) Credentials,
        (object) ShowHideToggle
      });
      Encoding = (string) objArray[1];
      MimeType = (string) objArray[2];
      ParametersUsed = (ParameterValue[]) objArray[3];
      Warnings = (Warning[]) objArray[4];
      StreamIds = (string[]) objArray[5];
      return (byte[]) objArray[0];
    }

    public void RenderAsync(string Report, string Format, string HistoryID, string DeviceInfo, ParameterValue[] Parameters, DataSourceCredentials[] Credentials, string ShowHideToggle)
    {
      this.RenderAsync(Report, Format, HistoryID, DeviceInfo, Parameters, Credentials, ShowHideToggle, (object) null);
    }

    public void RenderAsync(string Report, string Format, string HistoryID, string DeviceInfo, ParameterValue[] Parameters, DataSourceCredentials[] Credentials, string ShowHideToggle, object userState)
    {
      if (this.RenderOperationCompleted == null)
        this.RenderOperationCompleted = new SendOrPostCallback(this.OnRenderOperationCompleted);
      this.InvokeAsync("Render", new object[7]
      {
        (object) Report,
        (object) Format,
        (object) HistoryID,
        (object) DeviceInfo,
        (object) Parameters,
        (object) Credentials,
        (object) ShowHideToggle
      }, this.RenderOperationCompleted, userState);
    }

    private void OnRenderOperationCompleted(object arg)
    {
      if (this.RenderCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.RenderCompleted((object) this, new RenderCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("SessionHeaderValue", Direction = SoapHeaderDirection.InOut)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/RenderStream", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("Result", DataType = "base64Binary")]
    public byte[] RenderStream(string Report, string Format, string StreamID, string HistoryID, string DeviceInfo, ParameterValue[] Parameters, out string Encoding, out string MimeType)
    {
      object[] objArray = this.Invoke(nameof (RenderStream), new object[6]
      {
        (object) Report,
        (object) Format,
        (object) StreamID,
        (object) HistoryID,
        (object) DeviceInfo,
        (object) Parameters
      });
      Encoding = (string) objArray[1];
      MimeType = (string) objArray[2];
      return (byte[]) objArray[0];
    }

    public void RenderStreamAsync(string Report, string Format, string StreamID, string HistoryID, string DeviceInfo, ParameterValue[] Parameters)
    {
      this.RenderStreamAsync(Report, Format, StreamID, HistoryID, DeviceInfo, Parameters, (object) null);
    }

    public void RenderStreamAsync(string Report, string Format, string StreamID, string HistoryID, string DeviceInfo, ParameterValue[] Parameters, object userState)
    {
      if (this.RenderStreamOperationCompleted == null)
        this.RenderStreamOperationCompleted = new SendOrPostCallback(this.OnRenderStreamOperationCompleted);
      this.InvokeAsync("RenderStream", new object[6]
      {
        (object) Report,
        (object) Format,
        (object) StreamID,
        (object) HistoryID,
        (object) DeviceInfo,
        (object) Parameters
      }, this.RenderStreamOperationCompleted, userState);
    }

    private void OnRenderStreamOperationCompleted(object arg)
    {
      if (this.RenderStreamCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.RenderStreamCompleted((object) this, new RenderStreamCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetRenderResource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("Result", DataType = "base64Binary")]
    public byte[] GetRenderResource(string Format, string DeviceInfo, out string MimeType)
    {
      object[] objArray = this.Invoke(nameof (GetRenderResource), new object[2]
      {
        (object) Format,
        (object) DeviceInfo
      });
      MimeType = (string) objArray[1];
      return (byte[]) objArray[0];
    }

    public void GetRenderResourceAsync(string Format, string DeviceInfo)
    {
      this.GetRenderResourceAsync(Format, DeviceInfo, (object) null);
    }

    public void GetRenderResourceAsync(string Format, string DeviceInfo, object userState)
    {
      if (this.GetRenderResourceOperationCompleted == null)
        this.GetRenderResourceOperationCompleted = new SendOrPostCallback(this.OnGetRenderResourceOperationCompleted);
      this.InvokeAsync("GetRenderResource", new object[2]
      {
        (object) Format,
        (object) DeviceInfo
      }, this.GetRenderResourceOperationCompleted, userState);
    }

    private void OnGetRenderResourceOperationCompleted(object arg)
    {
      if (this.GetRenderResourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetRenderResourceCompleted((object) this, new GetRenderResourceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetExecutionOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetExecutionOptions(string Report, ExecutionSettingEnum ExecutionSetting, [XmlElement("ScheduleDefinition", typeof (ScheduleDefinition)), XmlElement("ScheduleReference", typeof (ScheduleReference)), XmlElement("NoSchedule", typeof (NoSchedule))] ScheduleDefinitionOrReference Item)
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetExecutionOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("ExecutionSetting")]
    public ExecutionSettingEnum GetExecutionOptions(string Report, [XmlElement("NoSchedule", typeof (NoSchedule)), XmlElement("ScheduleReference", typeof (ScheduleReference)), XmlElement("ScheduleDefinition", typeof (ScheduleDefinition))] out ScheduleDefinitionOrReference Item)
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetCacheOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetCacheOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("CacheReport")]
    public bool GetCacheOptions(string Report, [XmlElement("ScheduleExpiration", typeof (ScheduleExpiration)), XmlElement("TimeExpiration", typeof (TimeExpiration))] out ExpirationDefinition Item)
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/UpdateReportExecutionSnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/FlushCache", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListJobs", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Jobs")]
    public Job[] ListJobs()
    {
      return (Job[]) this.Invoke(nameof (ListJobs), new object[0])[0];
    }

    public void ListJobsAsync()
    {
      this.ListJobsAsync((object) null);
    }

    public void ListJobsAsync(object userState)
    {
      if (this.ListJobsOperationCompleted == null)
        this.ListJobsOperationCompleted = new SendOrPostCallback(this.OnListJobsOperationCompleted);
      this.InvokeAsync("ListJobs", new object[0], this.ListJobsOperationCompleted, userState);
    }

    private void OnListJobsOperationCompleted(object arg)
    {
      if (this.ListJobsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListJobsCompleted((object) this, new ListJobsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CancelJob", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public bool CancelJob(string JobID)
    {
      return (bool) this.Invoke(nameof (CancelJob), new object[1]
      {
        (object) JobID
      })[0];
    }

    public void CancelJobAsync(string JobID)
    {
      this.CancelJobAsync(JobID, (object) null);
    }

    public void CancelJobAsync(string JobID, object userState)
    {
      if (this.CancelJobOperationCompleted == null)
        this.CancelJobOperationCompleted = new SendOrPostCallback(this.OnCancelJobOperationCompleted);
      this.InvokeAsync("CancelJob", new object[1]
      {
        (object) JobID
      }, this.CancelJobOperationCompleted, userState);
    }

    private void OnCancelJobOperationCompleted(object arg)
    {
      if (this.CancelJobCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CancelJobCompleted((object) this, new CancelJobCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void CreateDataSource(string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
    {
      this.Invoke(nameof (CreateDataSource), new object[5]
      {
        (object) DataSource,
        (object) Parent,
        (object) Overwrite,
        (object) Definition,
        (object) Properties
      });
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
      this.CreateDataSourceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetDataSourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetDataSourceContents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/EnableDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DisableDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListReportsUsingDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Reports")]
    public CatalogItem[] ListReportsUsingDataSource(string DataSource)
    {
      return (CatalogItem[]) this.Invoke(nameof (ListReportsUsingDataSource), new object[1]
      {
        (object) DataSource
      })[0];
    }

    public void ListReportsUsingDataSourceAsync(string DataSource)
    {
      this.ListReportsUsingDataSourceAsync(DataSource, (object) null);
    }

    public void ListReportsUsingDataSourceAsync(string DataSource, object userState)
    {
      if (this.ListReportsUsingDataSourceOperationCompleted == null)
        this.ListReportsUsingDataSourceOperationCompleted = new SendOrPostCallback(this.OnListReportsUsingDataSourceOperationCompleted);
      this.InvokeAsync("ListReportsUsingDataSource", new object[1]
      {
        (object) DataSource
      }, this.ListReportsUsingDataSourceOperationCompleted, userState);
    }

    private void OnListReportsUsingDataSourceOperationCompleted(object arg)
    {
      if (this.ListReportsUsingDataSourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListReportsUsingDataSourceCompleted((object) this, new ListReportsUsingDataSourceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportDataSources", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetReportDataSources(string Report, DataSource[] DataSources)
    {
      this.Invoke(nameof (SetReportDataSources), new object[2]
      {
        (object) Report,
        (object) DataSources
      });
    }

    public void SetReportDataSourcesAsync(string Report, DataSource[] DataSources)
    {
      this.SetReportDataSourcesAsync(Report, DataSources, (object) null);
    }

    public void SetReportDataSourcesAsync(string Report, DataSource[] DataSources, object userState)
    {
      if (this.SetReportDataSourcesOperationCompleted == null)
        this.SetReportDataSourcesOperationCompleted = new SendOrPostCallback(this.OnSetReportDataSourcesOperationCompleted);
      this.InvokeAsync("SetReportDataSources", new object[2]
      {
        (object) Report,
        (object) DataSources
      }, this.SetReportDataSourcesOperationCompleted, userState);
    }

    private void OnSetReportDataSourcesOperationCompleted(object arg)
    {
      if (this.SetReportDataSourcesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportDataSourcesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportDataSources", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("DataSources")]
    public DataSource[] GetReportDataSources(string Report)
    {
      return (DataSource[]) this.Invoke(nameof (GetReportDataSources), new object[1]
      {
        (object) Report
      })[0];
    }

    public void GetReportDataSourcesAsync(string Report)
    {
      this.GetReportDataSourcesAsync(Report, (object) null);
    }

    public void GetReportDataSourcesAsync(string Report, object userState)
    {
      if (this.GetReportDataSourcesOperationCompleted == null)
        this.GetReportDataSourcesOperationCompleted = new SendOrPostCallback(this.OnGetReportDataSourcesOperationCompleted);
      this.InvokeAsync("GetReportDataSources", new object[1]
      {
        (object) Report
      }, this.GetReportDataSourcesOperationCompleted, userState);
    }

    private void OnGetReportDataSourcesOperationCompleted(object arg)
    {
      if (this.GetReportDataSourcesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportDataSourcesCompleted((object) this, new GetReportDataSourcesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportDataSourcePrompts", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("DataSourcePrompts")]
    public DataSourcePrompt[] GetReportDataSourcePrompts(string Report)
    {
      return (DataSourcePrompt[]) this.Invoke(nameof (GetReportDataSourcePrompts), new object[1]
      {
        (object) Report
      })[0];
    }

    public void GetReportDataSourcePromptsAsync(string Report)
    {
      this.GetReportDataSourcePromptsAsync(Report, (object) null);
    }

    public void GetReportDataSourcePromptsAsync(string Report, object userState)
    {
      if (this.GetReportDataSourcePromptsOperationCompleted == null)
        this.GetReportDataSourcePromptsOperationCompleted = new SendOrPostCallback(this.OnGetReportDataSourcePromptsOperationCompleted);
      this.InvokeAsync("GetReportDataSourcePrompts", new object[1]
      {
        (object) Report
      }, this.GetReportDataSourcePromptsOperationCompleted, userState);
    }

    private void OnGetReportDataSourcePromptsOperationCompleted(object arg)
    {
      if (this.GetReportDataSourcePromptsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetReportDataSourcePromptsCompleted((object) this, new GetReportDataSourcePromptsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateReportHistorySnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportHistoryOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetReportHistoryOptions(string Report, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, [XmlElement("NoSchedule", typeof (NoSchedule)), XmlElement("ScheduleDefinition", typeof (ScheduleDefinition)), XmlElement("ScheduleReference", typeof (ScheduleReference))] ScheduleDefinitionOrReference Item)
    {
      this.Invoke(nameof (SetReportHistoryOptions), new object[4]
      {
        (object) Report,
        (object) EnableManualSnapshotCreation,
        (object) KeepExecutionSnapshots,
        (object) Item
      });
    }

    public void SetReportHistoryOptionsAsync(string Report, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item)
    {
      this.SetReportHistoryOptionsAsync(Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item, (object) null);
    }

    public void SetReportHistoryOptionsAsync(string Report, bool EnableManualSnapshotCreation, bool KeepExecutionSnapshots, ScheduleDefinitionOrReference Item, object userState)
    {
      if (this.SetReportHistoryOptionsOperationCompleted == null)
        this.SetReportHistoryOptionsOperationCompleted = new SendOrPostCallback(this.OnSetReportHistoryOptionsOperationCompleted);
      this.InvokeAsync("SetReportHistoryOptions", new object[4]
      {
        (object) Report,
        (object) EnableManualSnapshotCreation,
        (object) KeepExecutionSnapshots,
        (object) Item
      }, this.SetReportHistoryOptionsOperationCompleted, userState);
    }

    private void OnSetReportHistoryOptionsOperationCompleted(object arg)
    {
      if (this.SetReportHistoryOptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetReportHistoryOptionsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportHistoryOptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("EnableManualSnapshotCreation")]
    public bool GetReportHistoryOptions(string Report, out bool KeepExecutionSnapshots, [XmlElement("NoSchedule", typeof (NoSchedule)), XmlElement("ScheduleDefinition", typeof (ScheduleDefinition)), XmlElement("ScheduleReference", typeof (ScheduleReference))] out ScheduleDefinitionOrReference Item)
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetReportHistoryLimit", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetReportHistoryLimit", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListReportHistory", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DeleteReportHistorySnapshot", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/FindItems", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Items")]
    public CatalogItem[] FindItems(string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions)
    {
      return (CatalogItem[]) this.Invoke(nameof (FindItems), new object[3]
      {
        (object) Folder,
        (object) BooleanOperator,
        (object) Conditions
      })[0];
    }

    public void FindItemsAsync(string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions)
    {
      this.FindItemsAsync(Folder, BooleanOperator, Conditions, (object) null);
    }

    public void FindItemsAsync(string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions, object userState)
    {
      if (this.FindItemsOperationCompleted == null)
        this.FindItemsOperationCompleted = new SendOrPostCallback(this.OnFindItemsOperationCompleted);
      this.InvokeAsync("FindItems", new object[3]
      {
        (object) Folder,
        (object) BooleanOperator,
        (object) Conditions
      }, this.FindItemsOperationCompleted, userState);
    }

    private void OnFindItemsOperationCompleted(object arg)
    {
      if (this.FindItemsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.FindItemsCompleted((object) this, new FindItemsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("ScheduleID")]
    public string CreateSchedule(string Name, ScheduleDefinition ScheduleDefinition)
    {
      return (string) this.Invoke(nameof (CreateSchedule), new object[2]
      {
        (object) Name,
        (object) ScheduleDefinition
      })[0];
    }

    public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition)
    {
      this.CreateScheduleAsync(Name, ScheduleDefinition, (object) null);
    }

    public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, object userState)
    {
      if (this.CreateScheduleOperationCompleted == null)
        this.CreateScheduleOperationCompleted = new SendOrPostCallback(this.OnCreateScheduleOperationCompleted);
      this.InvokeAsync("CreateSchedule", new object[2]
      {
        (object) Name,
        (object) ScheduleDefinition
      }, this.CreateScheduleOperationCompleted, userState);
    }

    private void OnCreateScheduleOperationCompleted(object arg)
    {
      if (this.CreateScheduleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateScheduleCompleted((object) this, new CreateScheduleCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DeleteSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetScheduleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetScheduleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListScheduledReports", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSchedules", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Schedules")]
    public Schedule[] ListSchedules()
    {
      return (Schedule[]) this.Invoke(nameof (ListSchedules), new object[0])[0];
    }

    public void ListSchedulesAsync()
    {
      this.ListSchedulesAsync((object) null);
    }

    public void ListSchedulesAsync(object userState)
    {
      if (this.ListSchedulesOperationCompleted == null)
        this.ListSchedulesOperationCompleted = new SendOrPostCallback(this.OnListSchedulesOperationCompleted);
      this.InvokeAsync("ListSchedules", new object[0], this.ListSchedulesOperationCompleted, userState);
    }

    private void OnListSchedulesOperationCompleted(object arg)
    {
      if (this.ListSchedulesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSchedulesCompleted((object) this, new ListSchedulesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/PauseSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ResumeSchedule", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateSubscription", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateDataDrivenSubscription", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlElement("SubscriptionID")]
    public string CreateDataDrivenSubscription(string Report, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
    {
      return (string) this.Invoke(nameof (CreateDataDrivenSubscription), new object[7]
      {
        (object) Report,
        (object) ExtensionSettings,
        (object) DataRetrievalPlan,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      })[0];
    }

    public void CreateDataDrivenSubscriptionAsync(string Report, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
    {
      this.CreateDataDrivenSubscriptionAsync(Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, (object) null);
    }

    public void CreateDataDrivenSubscriptionAsync(string Report, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, object userState)
    {
      if (this.CreateDataDrivenSubscriptionOperationCompleted == null)
        this.CreateDataDrivenSubscriptionOperationCompleted = new SendOrPostCallback(this.OnCreateDataDrivenSubscriptionOperationCompleted);
      this.InvokeAsync("CreateDataDrivenSubscription", new object[7]
      {
        (object) Report,
        (object) ExtensionSettings,
        (object) DataRetrievalPlan,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      }, this.CreateDataDrivenSubscriptionOperationCompleted, userState);
    }

    private void OnCreateDataDrivenSubscriptionOperationCompleted(object arg)
    {
      if (this.CreateDataDrivenSubscriptionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateDataDrivenSubscriptionCompleted((object) this, new CreateDataDrivenSubscriptionCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetDataDrivenSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void SetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
    {
      this.Invoke(nameof (SetDataDrivenSubscriptionProperties), new object[7]
      {
        (object) DataDrivenSubscriptionID,
        (object) ExtensionSettings,
        (object) DataRetrievalPlan,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      });
    }

    public void SetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters)
    {
      this.SetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, (object) null);
    }

    public void SetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, ExtensionSettings ExtensionSettings, DataRetrievalPlan DataRetrievalPlan, string Description, string EventType, string MatchData, ParameterValueOrFieldReference[] Parameters, object userState)
    {
      if (this.SetDataDrivenSubscriptionPropertiesOperationCompleted == null)
        this.SetDataDrivenSubscriptionPropertiesOperationCompleted = new SendOrPostCallback(this.OnSetDataDrivenSubscriptionPropertiesOperationCompleted);
      this.InvokeAsync("SetDataDrivenSubscriptionProperties", new object[7]
      {
        (object) DataDrivenSubscriptionID,
        (object) ExtensionSettings,
        (object) DataRetrievalPlan,
        (object) Description,
        (object) EventType,
        (object) MatchData,
        (object) Parameters
      }, this.SetDataDrivenSubscriptionPropertiesOperationCompleted, userState);
    }

    private void OnSetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
    {
      if (this.SetDataDrivenSubscriptionPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetDataDrivenSubscriptionPropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetDataDrivenSubscriptionProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlElement("Owner")]
    public string GetDataDrivenSubscriptionProperties(string DataDrivenSubscriptionID, out ExtensionSettings ExtensionSettings, out DataRetrievalPlan DataRetrievalPlan, out string Description, out ActiveState Active, out string Status, out string EventType, out string MatchData, out ParameterValueOrFieldReference[] Parameters)
    {
      object[] objArray = this.Invoke(nameof (GetDataDrivenSubscriptionProperties), new object[1]
      {
        (object) DataDrivenSubscriptionID
      });
      ExtensionSettings = (ExtensionSettings) objArray[1];
      DataRetrievalPlan = (DataRetrievalPlan) objArray[2];
      Description = (string) objArray[3];
      Active = (ActiveState) objArray[4];
      Status = (string) objArray[5];
      EventType = (string) objArray[6];
      MatchData = (string) objArray[7];
      Parameters = (ParameterValueOrFieldReference[]) objArray[8];
      return (string) objArray[0];
    }

    public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID)
    {
      this.GetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, (object) null);
    }

    public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, object userState)
    {
      if (this.GetDataDrivenSubscriptionPropertiesOperationCompleted == null)
        this.GetDataDrivenSubscriptionPropertiesOperationCompleted = new SendOrPostCallback(this.OnGetDataDrivenSubscriptionPropertiesOperationCompleted);
      this.InvokeAsync("GetDataDrivenSubscriptionProperties", new object[1]
      {
        (object) DataDrivenSubscriptionID
      }, this.GetDataDrivenSubscriptionPropertiesOperationCompleted, userState);
    }

    private void OnGetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
    {
      if (this.GetDataDrivenSubscriptionPropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetDataDrivenSubscriptionPropertiesCompleted((object) this, new GetDataDrivenSubscriptionPropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DeleteSubscription", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/PrepareQuery", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapHeader("BatchHeaderValue")]
    [return: XmlElement("DataSettings")]
    public DataSetDefinition PrepareQuery(DataSource DataSource, DataSetDefinition DataSet, out bool Changed)
    {
      object[] objArray = this.Invoke(nameof (PrepareQuery), new object[2]
      {
        (object) DataSource,
        (object) DataSet
      });
      Changed = (bool) objArray[1];
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetExtensionSettings", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ValidateExtensionSettings", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("ParameterErrors")]
    public ExtensionParameter[] ValidateExtensionSettings(string Extension, ParameterValueOrFieldReference[] ParameterValues)
    {
      return (ExtensionParameter[]) this.Invoke(nameof (ValidateExtensionSettings), new object[2]
      {
        (object) Extension,
        (object) ParameterValues
      })[0];
    }

    public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues)
    {
      this.ValidateExtensionSettingsAsync(Extension, ParameterValues, (object) null);
    }

    public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues, object userState)
    {
      if (this.ValidateExtensionSettingsOperationCompleted == null)
        this.ValidateExtensionSettingsOperationCompleted = new SendOrPostCallback(this.OnValidateExtensionSettingsOperationCompleted);
      this.InvokeAsync("ValidateExtensionSettings", new object[2]
      {
        (object) Extension,
        (object) ParameterValues
      }, this.ValidateExtensionSettingsOperationCompleted, userState);
    }

    private void OnValidateExtensionSettingsOperationCompleted(object arg)
    {
      if (this.ValidateExtensionSettingsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ValidateExtensionSettingsCompleted((object) this, new ValidateExtensionSettingsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSubscriptions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("SubscriptionItems")]
    public Subscription[] ListSubscriptions(string Report, string Owner)
    {
      return (Subscription[]) this.Invoke(nameof (ListSubscriptions), new object[2]
      {
        (object) Report,
        (object) Owner
      })[0];
    }

    public void ListSubscriptionsAsync(string Report, string Owner)
    {
      this.ListSubscriptionsAsync(Report, Owner, (object) null);
    }

    public void ListSubscriptionsAsync(string Report, string Owner, object userState)
    {
      if (this.ListSubscriptionsOperationCompleted == null)
        this.ListSubscriptionsOperationCompleted = new SendOrPostCallback(this.OnListSubscriptionsOperationCompleted);
      this.InvokeAsync("ListSubscriptions", new object[2]
      {
        (object) Report,
        (object) Owner
      }, this.ListSubscriptionsOperationCompleted, userState);
    }

    private void OnListSubscriptionsOperationCompleted(object arg)
    {
      if (this.ListSubscriptionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSubscriptionsCompleted((object) this, new ListSubscriptionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSubscriptionsUsingDataSource", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("SubscriptionItems")]
    public Subscription[] ListSubscriptionsUsingDataSource(string DataSource)
    {
      return (Subscription[]) this.Invoke(nameof (ListSubscriptionsUsingDataSource), new object[1]
      {
        (object) DataSource
      })[0];
    }

    public void ListSubscriptionsUsingDataSourceAsync(string DataSource)
    {
      this.ListSubscriptionsUsingDataSourceAsync(DataSource, (object) null);
    }

    public void ListSubscriptionsUsingDataSourceAsync(string DataSource, object userState)
    {
      if (this.ListSubscriptionsUsingDataSourceOperationCompleted == null)
        this.ListSubscriptionsUsingDataSourceOperationCompleted = new SendOrPostCallback(this.OnListSubscriptionsUsingDataSourceOperationCompleted);
      this.InvokeAsync("ListSubscriptionsUsingDataSource", new object[1]
      {
        (object) DataSource
      }, this.ListSubscriptionsUsingDataSourceOperationCompleted, userState);
    }

    private void OnListSubscriptionsUsingDataSourceOperationCompleted(object arg)
    {
      if (this.ListSubscriptionsUsingDataSourceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSubscriptionsUsingDataSourceCompleted((object) this, new ListSubscriptionsUsingDataSourceCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListExtensions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListEvents", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/FireEvent", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void FireEvent(string EventType, string EventData)
    {
      this.Invoke(nameof (FireEvent), new object[2]
      {
        (object) EventType,
        (object) EventData
      });
    }

    public void FireEventAsync(string EventType, string EventData)
    {
      this.FireEventAsync(EventType, EventData, (object) null);
    }

    public void FireEventAsync(string EventType, string EventData, object userState)
    {
      if (this.FireEventOperationCompleted == null)
        this.FireEventOperationCompleted = new SendOrPostCallback(this.OnFireEventOperationCompleted);
      this.InvokeAsync("FireEvent", new object[2]
      {
        (object) EventType,
        (object) EventData
      }, this.FireEventOperationCompleted, userState);
    }

    private void OnFireEventOperationCompleted(object arg)
    {
      if (this.FireEventCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.FireEventCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSystemTasks", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Tasks")]
    public Task[] ListSystemTasks()
    {
      return (Task[]) this.Invoke(nameof (ListSystemTasks), new object[0])[0];
    }

    public void ListSystemTasksAsync()
    {
      this.ListSystemTasksAsync((object) null);
    }

    public void ListSystemTasksAsync(object userState)
    {
      if (this.ListSystemTasksOperationCompleted == null)
        this.ListSystemTasksOperationCompleted = new SendOrPostCallback(this.OnListSystemTasksOperationCompleted);
      this.InvokeAsync("ListSystemTasks", new object[0], this.ListSystemTasksOperationCompleted, userState);
    }

    private void OnListSystemTasksOperationCompleted(object arg)
    {
      if (this.ListSystemTasksCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSystemTasksCompleted((object) this, new ListSystemTasksCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListTasks", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Tasks")]
    public Task[] ListTasks()
    {
      return (Task[]) this.Invoke(nameof (ListTasks), new object[0])[0];
    }

    public void ListTasksAsync()
    {
      this.ListTasksAsync((object) null);
    }

    public void ListTasksAsync(object userState)
    {
      if (this.ListTasksOperationCompleted == null)
        this.ListTasksOperationCompleted = new SendOrPostCallback(this.OnListTasksOperationCompleted);
      this.InvokeAsync("ListTasks", new object[0], this.ListTasksOperationCompleted, userState);
    }

    private void OnListTasksOperationCompleted(object arg)
    {
      if (this.ListTasksCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListTasksCompleted((object) this, new ListTasksCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListSystemRoles", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Roles")]
    public Role[] ListSystemRoles()
    {
      return (Role[]) this.Invoke(nameof (ListSystemRoles), new object[0])[0];
    }

    public void ListSystemRolesAsync()
    {
      this.ListSystemRolesAsync((object) null);
    }

    public void ListSystemRolesAsync(object userState)
    {
      if (this.ListSystemRolesOperationCompleted == null)
        this.ListSystemRolesOperationCompleted = new SendOrPostCallback(this.OnListSystemRolesOperationCompleted);
      this.InvokeAsync("ListSystemRoles", new object[0], this.ListSystemRolesOperationCompleted, userState);
    }

    private void OnListSystemRolesOperationCompleted(object arg)
    {
      if (this.ListSystemRolesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListSystemRolesCompleted((object) this, new ListSystemRolesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/ListRoles", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArray("Roles")]
    public Role[] ListRoles()
    {
      return (Role[]) this.Invoke(nameof (ListRoles), new object[0])[0];
    }

    public void ListRolesAsync()
    {
      this.ListRolesAsync((object) null);
    }

    public void ListRolesAsync(object userState)
    {
      if (this.ListRolesOperationCompleted == null)
        this.ListRolesOperationCompleted = new SendOrPostCallback(this.OnListRolesOperationCompleted);
      this.InvokeAsync("ListRoles", new object[0], this.ListRolesOperationCompleted, userState);
    }

    private void OnListRolesOperationCompleted(object arg)
    {
      if (this.ListRolesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.ListRolesCompleted((object) this, new ListRolesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/CreateRole", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void CreateRole(string Name, string Description, Task[] Tasks)
    {
      this.Invoke(nameof (CreateRole), new object[3]
      {
        (object) Name,
        (object) Description,
        (object) Tasks
      });
    }

    public void CreateRoleAsync(string Name, string Description, Task[] Tasks)
    {
      this.CreateRoleAsync(Name, Description, Tasks, (object) null);
    }

    public void CreateRoleAsync(string Name, string Description, Task[] Tasks, object userState)
    {
      if (this.CreateRoleOperationCompleted == null)
        this.CreateRoleOperationCompleted = new SendOrPostCallback(this.OnCreateRoleOperationCompleted);
      this.InvokeAsync("CreateRole", new object[3]
      {
        (object) Name,
        (object) Description,
        (object) Tasks
      }, this.CreateRoleOperationCompleted, userState);
    }

    private void OnCreateRoleOperationCompleted(object arg)
    {
      if (this.CreateRoleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.CreateRoleCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/DeleteRole", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    public void DeleteRole(string Name)
    {
      this.Invoke(nameof (DeleteRole), new object[1]
      {
        (object) Name
      });
    }

    public void DeleteRoleAsync(string Name)
    {
      this.DeleteRoleAsync(Name, (object) null);
    }

    public void DeleteRoleAsync(string Name, object userState)
    {
      if (this.DeleteRoleOperationCompleted == null)
        this.DeleteRoleOperationCompleted = new SendOrPostCallback(this.OnDeleteRoleOperationCompleted);
      this.InvokeAsync("DeleteRole", new object[1]
      {
        (object) Name
      }, this.DeleteRoleOperationCompleted, userState);
    }

    private void OnDeleteRoleOperationCompleted(object arg)
    {
      if (this.DeleteRoleCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.DeleteRoleCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetRoleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Tasks")]
    public Task[] GetRoleProperties(string Name, out string Description)
    {
      object[] objArray = this.Invoke(nameof (GetRoleProperties), new object[1]
      {
        (object) Name
      });
      Description = (string) objArray[1];
      return (Task[]) objArray[0];
    }

    public void GetRolePropertiesAsync(string Name)
    {
      this.GetRolePropertiesAsync(Name, (object) null);
    }

    public void GetRolePropertiesAsync(string Name, object userState)
    {
      if (this.GetRolePropertiesOperationCompleted == null)
        this.GetRolePropertiesOperationCompleted = new SendOrPostCallback(this.OnGetRolePropertiesOperationCompleted);
      this.InvokeAsync("GetRoleProperties", new object[1]
      {
        (object) Name
      }, this.GetRolePropertiesOperationCompleted, userState);
    }

    private void OnGetRolePropertiesOperationCompleted(object arg)
    {
      if (this.GetRolePropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetRolePropertiesCompleted((object) this, new GetRolePropertiesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetRoleProperties", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void SetRoleProperties(string Name, string Description, Task[] Tasks)
    {
      this.Invoke(nameof (SetRoleProperties), new object[3]
      {
        (object) Name,
        (object) Description,
        (object) Tasks
      });
    }

    public void SetRolePropertiesAsync(string Name, string Description, Task[] Tasks)
    {
      this.SetRolePropertiesAsync(Name, Description, Tasks, (object) null);
    }

    public void SetRolePropertiesAsync(string Name, string Description, Task[] Tasks, object userState)
    {
      if (this.SetRolePropertiesOperationCompleted == null)
        this.SetRolePropertiesOperationCompleted = new SendOrPostCallback(this.OnSetRolePropertiesOperationCompleted);
      this.InvokeAsync("SetRoleProperties", new object[3]
      {
        (object) Name,
        (object) Description,
        (object) Tasks
      }, this.SetRolePropertiesOperationCompleted, userState);
    }

    private void OnSetRolePropertiesOperationCompleted(object arg)
    {
      if (this.SetRolePropertiesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetRolePropertiesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetSystemPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Policies")]
    public Policy[] GetSystemPolicies()
    {
      return (Policy[]) this.Invoke(nameof (GetSystemPolicies), new object[0])[0];
    }

    public void GetSystemPoliciesAsync()
    {
      this.GetSystemPoliciesAsync((object) null);
    }

    public void GetSystemPoliciesAsync(object userState)
    {
      if (this.GetSystemPoliciesOperationCompleted == null)
        this.GetSystemPoliciesOperationCompleted = new SendOrPostCallback(this.OnGetSystemPoliciesOperationCompleted);
      this.InvokeAsync("GetSystemPolicies", new object[0], this.GetSystemPoliciesOperationCompleted, userState);
    }

    private void OnGetSystemPoliciesOperationCompleted(object arg)
    {
      if (this.GetSystemPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetSystemPoliciesCompleted((object) this, new GetSystemPoliciesCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetSystemPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("BatchHeaderValue")]
    public void SetSystemPolicies(Policy[] Policies)
    {
      this.Invoke(nameof (SetSystemPolicies), new object[1]
      {
        (object) Policies
      });
    }

    public void SetSystemPoliciesAsync(Policy[] Policies)
    {
      this.SetSystemPoliciesAsync(Policies, (object) null);
    }

    public void SetSystemPoliciesAsync(Policy[] Policies, object userState)
    {
      if (this.SetSystemPoliciesOperationCompleted == null)
        this.SetSystemPoliciesOperationCompleted = new SendOrPostCallback(this.OnSetSystemPoliciesOperationCompleted);
      this.InvokeAsync("SetSystemPolicies", new object[1]
      {
        (object) Policies
      }, this.SetSystemPoliciesOperationCompleted, userState);
    }

    private void OnSetSystemPoliciesOperationCompleted(object arg)
    {
      if (this.SetSystemPoliciesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.SetSystemPoliciesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/SetPolicies", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
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

    [SoapHeader("BatchHeaderValue")]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/InheritParentSecurity", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
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

    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetSystemPermissions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [return: XmlArray("Permissions")]
    [return: XmlArrayItem("Operation")]
    public string[] GetSystemPermissions()
    {
      return (string[]) this.Invoke(nameof (GetSystemPermissions), new object[0])[0];
    }

    public void GetSystemPermissionsAsync()
    {
      this.GetSystemPermissionsAsync((object) null);
    }

    public void GetSystemPermissionsAsync(object userState)
    {
      if (this.GetSystemPermissionsOperationCompleted == null)
        this.GetSystemPermissionsOperationCompleted = new SendOrPostCallback(this.OnGetSystemPermissionsOperationCompleted);
      this.InvokeAsync("GetSystemPermissions", new object[0], this.GetSystemPermissionsOperationCompleted, userState);
    }

    private void OnGetSystemPermissionsOperationCompleted(object arg)
    {
      if (this.GetSystemPermissionsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.GetSystemPermissionsCompleted((object) this, new GetSystemPermissionsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/GetPermissions", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    [return: XmlArrayItem("Operation")]
    [return: XmlArray("Permissions")]
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

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/LogonUser", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void LogonUser(string userName, string password, string authority)
    {
      this.Invoke(nameof (LogonUser), new object[3]
      {
        (object) userName,
        (object) password,
        (object) authority
      });
    }

    public void LogonUserAsync(string userName, string password, string authority)
    {
      this.LogonUserAsync(userName, password, authority, (object) null);
    }

    public void LogonUserAsync(string userName, string password, string authority, object userState)
    {
      if (this.LogonUserOperationCompleted == null)
        this.LogonUserOperationCompleted = new SendOrPostCallback(this.OnLogonUserOperationCompleted);
      this.InvokeAsync("LogonUser", new object[3]
      {
        (object) userName,
        (object) password,
        (object) authority
      }, this.LogonUserOperationCompleted, userState);
    }

    private void OnLogonUserOperationCompleted(object arg)
    {
      if (this.LogonUserCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.LogonUserCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices/Logoff", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices", Use = SoapBindingUse.Literal)]
    [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
    public void Logoff()
    {
      this.Invoke(nameof (Logoff), new object[0]);
    }

    public void LogoffAsync()
    {
      this.LogoffAsync((object) null);
    }

    public void LogoffAsync(object userState)
    {
      if (this.LogoffOperationCompleted == null)
        this.LogoffOperationCompleted = new SendOrPostCallback(this.OnLogoffOperationCompleted);
      this.InvokeAsync("Logoff", new object[0], this.LogoffOperationCompleted, userState);
    }

    private void OnLogoffOperationCompleted(object arg)
    {
      if (this.LogoffCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.LogoffCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
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

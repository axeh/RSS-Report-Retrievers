
// Type: RSS_Report_Retrievers.RSS_2000.GetDataDrivenSubscriptionPropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetDataDrivenSubscriptionPropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetDataDrivenSubscriptionPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public string Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[0];
      }
    }

    public ExtensionSettings ExtensionSettings
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ExtensionSettings) this.results[1];
      }
    }

    public DataRetrievalPlan DataRetrievalPlan
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataRetrievalPlan) this.results[2];
      }
    }

    public string Description
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[3];
      }
    }

    public ActiveState Active
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ActiveState) this.results[4];
      }
    }

    public string Status
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[5];
      }
    }

    public string EventType
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[6];
      }
    }

    public string MatchData
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[7];
      }
    }

    public ParameterValueOrFieldReference[] Parameters
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ParameterValueOrFieldReference[]) this.results[8];
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetSubscriptionPropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class GetSubscriptionPropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetSubscriptionPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

    public string Description
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[2];
      }
    }

    public ActiveState Active
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ActiveState) this.results[3];
      }
    }

    public string Status
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[4];
      }
    }

    public string EventType
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[5];
      }
    }

    public string MatchData
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[6];
      }
    }

    public ParameterValue[] Parameters
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ParameterValue[]) this.results[7];
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ListSubscriptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class ListSubscriptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListSubscriptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Subscription[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Subscription[]) this.results[0];
      }
    }
  }
}

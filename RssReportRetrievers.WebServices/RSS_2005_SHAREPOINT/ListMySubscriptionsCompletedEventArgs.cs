
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListMySubscriptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListMySubscriptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListMySubscriptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

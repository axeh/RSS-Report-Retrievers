
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListAllSubscriptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class ListAllSubscriptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListAllSubscriptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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


// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.CreateDataDrivenSubscriptionCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class CreateDataDrivenSubscriptionCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal CreateDataDrivenSubscriptionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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
  }
}

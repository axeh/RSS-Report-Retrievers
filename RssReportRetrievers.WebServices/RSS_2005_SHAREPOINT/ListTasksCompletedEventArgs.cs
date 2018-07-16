
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListTasksCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListTasksCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListTasksCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Task[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Task[]) this.results[0];
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2000.ListJobsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class ListJobsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListJobsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Job[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Job[]) this.results[0];
      }
    }
  }
}

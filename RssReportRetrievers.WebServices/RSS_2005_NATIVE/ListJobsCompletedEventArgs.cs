
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ListJobsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
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

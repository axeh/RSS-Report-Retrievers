
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetReportHistoryOptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class GetReportHistoryOptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportHistoryOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public bool Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[0];
      }
    }

    public bool KeepExecutionSnapshots
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[1];
      }
    }

    public ScheduleDefinitionOrReference Item
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ScheduleDefinitionOrReference) this.results[2];
      }
    }
  }
}

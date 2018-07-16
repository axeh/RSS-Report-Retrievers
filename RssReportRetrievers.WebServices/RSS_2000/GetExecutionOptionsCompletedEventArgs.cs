
// Type: RSS_Report_Retrievers.RSS_2000.GetExecutionOptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class GetExecutionOptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetExecutionOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ExecutionSettingEnum Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ExecutionSettingEnum) this.results[0];
      }
    }

    public ScheduleDefinitionOrReference Item
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ScheduleDefinitionOrReference) this.results[1];
      }
    }
  }
}

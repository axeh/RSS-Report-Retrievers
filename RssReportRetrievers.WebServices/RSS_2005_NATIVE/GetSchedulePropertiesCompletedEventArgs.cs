
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetSchedulePropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class GetSchedulePropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetSchedulePropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Schedule Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Schedule) this.results[0];
      }
    }
  }
}

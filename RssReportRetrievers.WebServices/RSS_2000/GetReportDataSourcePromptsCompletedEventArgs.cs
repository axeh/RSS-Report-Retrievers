
// Type: RSS_Report_Retrievers.RSS_2000.GetReportDataSourcePromptsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetReportDataSourcePromptsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportDataSourcePromptsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSourcePrompt[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSourcePrompt[]) this.results[0];
      }
    }
  }
}

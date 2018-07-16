
// Type: RSS_Report_Retrievers.RSS_2000.GetReportDataSourcesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetReportDataSourcesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportDataSourcesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSource[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSource[]) this.results[0];
      }
    }
  }
}

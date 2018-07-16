
// Type: RSS_Report_Retrievers.RSS_2000.SetReportDefinitionCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class SetReportDefinitionCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal SetReportDefinitionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Warning[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Warning[]) this.results[0];
      }
    }
  }
}

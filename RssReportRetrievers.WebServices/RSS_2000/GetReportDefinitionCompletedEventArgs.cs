
// Type: RSS_Report_Retrievers.RSS_2000.GetReportDefinitionCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetReportDefinitionCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportDefinitionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public byte[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (byte[]) this.results[0];
      }
    }
  }
}

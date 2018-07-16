
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.RegenerateModelCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class RegenerateModelCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal RegenerateModelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

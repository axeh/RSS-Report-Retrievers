
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GenerateModelCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GenerateModelCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GenerateModelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

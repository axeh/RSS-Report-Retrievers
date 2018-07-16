
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.CreateModelCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class CreateModelCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal CreateModelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

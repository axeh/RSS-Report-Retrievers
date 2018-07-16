
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ListExtensionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class ListExtensionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListExtensionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Extension[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Extension[]) this.results[0];
      }
    }
  }
}

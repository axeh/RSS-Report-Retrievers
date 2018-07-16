
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ListChildrenCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListChildrenCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListChildrenCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public CatalogItem[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (CatalogItem[]) this.results[0];
      }
    }
  }
}

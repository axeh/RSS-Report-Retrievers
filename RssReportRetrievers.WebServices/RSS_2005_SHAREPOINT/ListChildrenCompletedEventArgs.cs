
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListChildrenCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
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

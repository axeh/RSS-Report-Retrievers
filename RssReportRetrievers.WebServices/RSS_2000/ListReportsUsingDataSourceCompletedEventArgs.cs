
// Type: RSS_Report_Retrievers.RSS_2000.ListReportsUsingDataSourceCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class ListReportsUsingDataSourceCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListReportsUsingDataSourceCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

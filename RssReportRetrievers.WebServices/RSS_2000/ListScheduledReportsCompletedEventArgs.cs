
// Type: RSS_Report_Retrievers.RSS_2000.ListScheduledReportsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListScheduledReportsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListScheduledReportsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

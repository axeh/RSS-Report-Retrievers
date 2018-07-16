
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListModelPerspectivesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListModelPerspectivesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListModelPerspectivesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ModelCatalogItem[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ModelCatalogItem[]) this.results[0];
      }
    }
  }
}

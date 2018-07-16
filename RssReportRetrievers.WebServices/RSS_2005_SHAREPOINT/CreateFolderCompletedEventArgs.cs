
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.CreateFolderCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class CreateFolderCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal CreateFolderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public CatalogItem Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (CatalogItem) this.results[0];
      }
    }
  }
}

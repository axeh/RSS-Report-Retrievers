
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.GetItemDataSourcesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class GetItemDataSourcesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetItemDataSourcesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSource[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSource[]) this.results[0];
      }
    }
  }
}

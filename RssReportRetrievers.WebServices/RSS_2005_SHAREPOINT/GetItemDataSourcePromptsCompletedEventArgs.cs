
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.GetItemDataSourcePromptsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class GetItemDataSourcePromptsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetItemDataSourcePromptsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSourcePrompt[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSourcePrompt[]) this.results[0];
      }
    }
  }
}

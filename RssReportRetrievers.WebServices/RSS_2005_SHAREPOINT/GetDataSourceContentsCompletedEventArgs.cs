
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.GetDataSourceContentsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class GetDataSourceContentsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetDataSourceContentsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSourceDefinition Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSourceDefinition) this.results[0];
      }
    }
  }
}

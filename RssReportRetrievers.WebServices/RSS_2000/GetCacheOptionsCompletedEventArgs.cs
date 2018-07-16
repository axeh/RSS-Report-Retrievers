
// Type: RSS_Report_Retrievers.RSS_2000.GetCacheOptionsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class GetCacheOptionsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetCacheOptionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public bool Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[0];
      }
    }

    public ExpirationDefinition Item
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ExpirationDefinition) this.results[1];
      }
    }
  }
}

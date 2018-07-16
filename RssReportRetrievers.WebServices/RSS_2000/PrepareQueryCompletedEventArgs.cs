
// Type: RSS_Report_Retrievers.RSS_2000.PrepareQueryCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class PrepareQueryCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal PrepareQueryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public DataSetDefinition Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (DataSetDefinition) this.results[0];
      }
    }

    public bool Changed
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[1];
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.PrepareQueryCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
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

    public string[] ParameterNames
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string[]) this.results[2];
      }
    }
  }
}

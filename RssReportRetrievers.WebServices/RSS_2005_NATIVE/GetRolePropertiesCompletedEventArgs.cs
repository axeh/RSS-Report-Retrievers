
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetRolePropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class GetRolePropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetRolePropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Task[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Task[]) this.results[0];
      }
    }

    public string Description
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[1];
      }
    }
  }
}

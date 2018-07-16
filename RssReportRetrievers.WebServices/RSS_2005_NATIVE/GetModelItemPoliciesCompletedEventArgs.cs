
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetModelItemPoliciesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  public class GetModelItemPoliciesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetModelItemPoliciesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Policy[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Policy[]) this.results[0];
      }
    }

    public bool InheritParent
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (bool) this.results[1];
      }
    }
  }
}

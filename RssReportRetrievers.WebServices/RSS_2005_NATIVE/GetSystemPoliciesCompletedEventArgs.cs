
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetSystemPoliciesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetSystemPoliciesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetSystemPoliciesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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
  }
}

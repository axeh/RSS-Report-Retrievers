
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetPropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class GetPropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Property[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Property[]) this.results[0];
      }
    }
  }
}


// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.GetSystemPropertiesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class GetSystemPropertiesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetSystemPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
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

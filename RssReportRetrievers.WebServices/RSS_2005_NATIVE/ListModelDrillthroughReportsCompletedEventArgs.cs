
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ListModelDrillthroughReportsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class ListModelDrillthroughReportsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListModelDrillthroughReportsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ModelDrillthroughReport[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ModelDrillthroughReport[]) this.results[0];
      }
    }
  }
}

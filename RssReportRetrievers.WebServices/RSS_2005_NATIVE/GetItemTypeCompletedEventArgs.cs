
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetItemTypeCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class GetItemTypeCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetItemTypeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ItemTypeEnum Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ItemTypeEnum) this.results[0];
      }
    }
  }
}

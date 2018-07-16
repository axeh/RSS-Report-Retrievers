
// Type: RSS_Report_Retrievers.RSS_2000.ValidateExtensionSettingsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class ValidateExtensionSettingsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ValidateExtensionSettingsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ExtensionParameter[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ExtensionParameter[]) this.results[0];
      }
    }
  }
}

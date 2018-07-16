
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.ListEventsCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class ListEventsCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListEventsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Event[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Event[]) this.results[0];
      }
    }
  }
}

﻿
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.CreateResourceCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class CreateResourceCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal CreateResourceCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public CatalogItem Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (CatalogItem) this.results[0];
      }
    }
  }
}

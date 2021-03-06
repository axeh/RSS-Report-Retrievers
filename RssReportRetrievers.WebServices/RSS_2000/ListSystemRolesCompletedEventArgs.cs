﻿
// Type: RSS_Report_Retrievers.RSS_2000.ListSystemRolesCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class ListSystemRolesCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal ListSystemRolesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public Role[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Role[]) this.results[0];
      }
    }
  }
}

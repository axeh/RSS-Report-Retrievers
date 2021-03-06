﻿
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.GetReportParametersCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  public class GetReportParametersCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal GetReportParametersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ReportParameter[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ReportParameter[]) this.results[0];
      }
    }
  }
}

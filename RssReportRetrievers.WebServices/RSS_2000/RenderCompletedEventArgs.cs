
// Type: RSS_Report_Retrievers.RSS_2000.RenderCompletedEventArgs




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.4927")]
  [DebuggerStepThrough]
  public class RenderCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal RenderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public byte[] Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (byte[]) this.results[0];
      }
    }

    public string Encoding
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[1];
      }
    }

    public string MimeType
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[2];
      }
    }

    public ParameterValue[] ParametersUsed
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ParameterValue[]) this.results[3];
      }
    }

    public Warning[] Warnings
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (Warning[]) this.results[4];
      }
    }

    public string[] StreamIds
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string[]) this.results[5];
      }
    }
  }
}

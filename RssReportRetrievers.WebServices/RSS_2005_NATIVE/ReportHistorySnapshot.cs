
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.ReportHistorySnapshot




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class ReportHistorySnapshot
  {
    private string historyIDField;
    private DateTime creationDateField;
    private int sizeField;

    public string HistoryID
    {
      get
      {
        return this.historyIDField;
      }
      set
      {
        this.historyIDField = value;
      }
    }

    public DateTime CreationDate
    {
      get
      {
        return this.creationDateField;
      }
      set
      {
        this.creationDateField = value;
      }
    }

    public int Size
    {
      get
      {
        return this.sizeField;
      }
      set
      {
        this.sizeField = value;
      }
    }
  }
}

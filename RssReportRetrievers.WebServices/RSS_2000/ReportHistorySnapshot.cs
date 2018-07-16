
// Type: RSS_Report_Retrievers.RSS_2000.ReportHistorySnapshot




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
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

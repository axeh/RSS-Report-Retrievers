
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.SYSTEMTIME




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [Serializable]
  public class SYSTEMTIME
  {
    private short yearField;
    private short monthField;
    private short dayOfWeekField;
    private short dayField;
    private short hourField;
    private short minuteField;
    private short secondField;
    private short millisecondsField;

    public short year
    {
      get
      {
        return this.yearField;
      }
      set
      {
        this.yearField = value;
      }
    }

    public short month
    {
      get
      {
        return this.monthField;
      }
      set
      {
        this.monthField = value;
      }
    }

    public short dayOfWeek
    {
      get
      {
        return this.dayOfWeekField;
      }
      set
      {
        this.dayOfWeekField = value;
      }
    }

    public short day
    {
      get
      {
        return this.dayField;
      }
      set
      {
        this.dayField = value;
      }
    }

    public short hour
    {
      get
      {
        return this.hourField;
      }
      set
      {
        this.hourField = value;
      }
    }

    public short minute
    {
      get
      {
        return this.minuteField;
      }
      set
      {
        this.minuteField = value;
      }
    }

    public short second
    {
      get
      {
        return this.secondField;
      }
      set
      {
        this.secondField = value;
      }
    }

    public short milliseconds
    {
      get
      {
        return this.millisecondsField;
      }
      set
      {
        this.millisecondsField = value;
      }
    }
  }
}

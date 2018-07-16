
// Type: RSS_Report_Retrievers.RSS_2000.DaysOfWeekSelector




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2000
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2003/12/reporting/reportingservices")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class DaysOfWeekSelector
  {
    private bool sundayField;
    private bool mondayField;
    private bool tuesdayField;
    private bool wednesdayField;
    private bool thursdayField;
    private bool fridayField;
    private bool saturdayField;

    public bool Sunday
    {
      get
      {
        return this.sundayField;
      }
      set
      {
        this.sundayField = value;
      }
    }

    public bool Monday
    {
      get
      {
        return this.mondayField;
      }
      set
      {
        this.mondayField = value;
      }
    }

    public bool Tuesday
    {
      get
      {
        return this.tuesdayField;
      }
      set
      {
        this.tuesdayField = value;
      }
    }

    public bool Wednesday
    {
      get
      {
        return this.wednesdayField;
      }
      set
      {
        this.wednesdayField = value;
      }
    }

    public bool Thursday
    {
      get
      {
        return this.thursdayField;
      }
      set
      {
        this.thursdayField = value;
      }
    }

    public bool Friday
    {
      get
      {
        return this.fridayField;
      }
      set
      {
        this.fridayField = value;
      }
    }

    public bool Saturday
    {
      get
      {
        return this.saturdayField;
      }
      set
      {
        this.saturdayField = value;
      }
    }
  }
}

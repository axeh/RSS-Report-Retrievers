
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.MonthsOfYearSelector




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [Serializable]
  public class MonthsOfYearSelector
  {
    private bool januaryField;
    private bool februaryField;
    private bool marchField;
    private bool aprilField;
    private bool mayField;
    private bool juneField;
    private bool julyField;
    private bool augustField;
    private bool septemberField;
    private bool octoberField;
    private bool novemberField;
    private bool decemberField;

    public bool January
    {
      get
      {
        return this.januaryField;
      }
      set
      {
        this.januaryField = value;
      }
    }

    public bool February
    {
      get
      {
        return this.februaryField;
      }
      set
      {
        this.februaryField = value;
      }
    }

    public bool March
    {
      get
      {
        return this.marchField;
      }
      set
      {
        this.marchField = value;
      }
    }

    public bool April
    {
      get
      {
        return this.aprilField;
      }
      set
      {
        this.aprilField = value;
      }
    }

    public bool May
    {
      get
      {
        return this.mayField;
      }
      set
      {
        this.mayField = value;
      }
    }

    public bool June
    {
      get
      {
        return this.juneField;
      }
      set
      {
        this.juneField = value;
      }
    }

    public bool July
    {
      get
      {
        return this.julyField;
      }
      set
      {
        this.julyField = value;
      }
    }

    public bool August
    {
      get
      {
        return this.augustField;
      }
      set
      {
        this.augustField = value;
      }
    }

    public bool September
    {
      get
      {
        return this.septemberField;
      }
      set
      {
        this.septemberField = value;
      }
    }

    public bool October
    {
      get
      {
        return this.octoberField;
      }
      set
      {
        this.octoberField = value;
      }
    }

    public bool November
    {
      get
      {
        return this.novemberField;
      }
      set
      {
        this.novemberField = value;
      }
    }

    public bool December
    {
      get
      {
        return this.decemberField;
      }
      set
      {
        this.decemberField = value;
      }
    }
  }
}

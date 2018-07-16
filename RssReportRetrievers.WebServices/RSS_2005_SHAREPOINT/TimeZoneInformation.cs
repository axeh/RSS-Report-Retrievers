
// Type: RSS_Report_Retrievers.RSS_2005_SHAREPOINT.TimeZoneInformation




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_SHAREPOINT
{
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2006/03/15/reporting/reportingservices")]
  [DebuggerStepThrough]
  [Serializable]
  public class TimeZoneInformation
  {
    private int biasField;
    private int standardBiasField;
    private SYSTEMTIME standardDateField;
    private int daylightBiasField;
    private SYSTEMTIME daylightDateField;

    public int Bias
    {
      get
      {
        return this.biasField;
      }
      set
      {
        this.biasField = value;
      }
    }

    public int StandardBias
    {
      get
      {
        return this.standardBiasField;
      }
      set
      {
        this.standardBiasField = value;
      }
    }

    public SYSTEMTIME StandardDate
    {
      get
      {
        return this.standardDateField;
      }
      set
      {
        this.standardDateField = value;
      }
    }

    public int DaylightBias
    {
      get
      {
        return this.daylightBiasField;
      }
      set
      {
        this.daylightBiasField = value;
      }
    }

    public SYSTEMTIME DaylightDate
    {
      get
      {
        return this.daylightDateField;
      }
      set
      {
        this.daylightDateField = value;
      }
    }
  }
}

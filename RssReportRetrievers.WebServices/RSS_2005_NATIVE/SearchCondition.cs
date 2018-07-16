
// Type: RSS_Report_Retrievers.RSS_2005_NATIVE.SearchCondition




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RSS_Report_Retrievers.RSS_2005_NATIVE
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "2.0.50727.4927")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
  [Serializable]
  public class SearchCondition : Property
  {
    private ConditionEnum conditionField;
    private bool conditionFieldSpecified;

    public ConditionEnum Condition
    {
      get
      {
        return this.conditionField;
      }
      set
      {
        this.conditionField = value;
      }
    }

    [XmlIgnore]
    public bool ConditionSpecified
    {
      get
      {
        return this.conditionFieldSpecified;
      }
      set
      {
        this.conditionFieldSpecified = value;
      }
    }
  }
}

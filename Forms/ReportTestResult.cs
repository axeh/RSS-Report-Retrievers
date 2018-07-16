
// Type: RSS_Report_Retrievers.Forms.ReportTestResult




namespace RSS_Report_Retrievers.Forms
{
  public class ReportTestResult
  {
    private string reportName;
    private bool passedTest;

    public string ReportName
    {
      get
      {
        return this.reportName;
      }
      set
      {
        this.reportName = value;
      }
    }

    public bool PassedTest
    {
      get
      {
        return this.passedTest;
      }
      set
      {
        this.passedTest = value;
      }
    }
  }
}

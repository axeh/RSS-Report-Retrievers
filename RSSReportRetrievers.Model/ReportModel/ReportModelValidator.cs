namespace RSSReportRetrievers.Model.ReportModel
{
    public class ReportModelValidator
    {
        private readonly ModelParser modelParser = new ModelParser();

        public ReportModelValidator(string modelSMDL)
        {
            modelParser.LoadSMDL(modelSMDL);
        }

        public bool ValidateModelForReport(string reportRDL)
        {
            foreach (var queryReferenceGuiD in SematicQueryParser.ExtractQueryReferenceGUIDs(reportRDL))
                if (!modelParser.ContainsGUID(queryReferenceGuiD))
                    return false;
            return true;
        }
    }
}
namespace RSSReportRetrievers.Model
{
    public struct DatasourceExtension
    {
        public string Name;
        public string FriendlyName;

        public DatasourceExtension(string name, string friendlyName)
        {
            Name = name;
            FriendlyName = friendlyName;
        }
    }
}
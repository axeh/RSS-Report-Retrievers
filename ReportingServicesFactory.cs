
// Type: RSS_Report_Retrievers.ReportingServicesFactory


using System.Net;
using System.Windows.Forms;
using RSSReportRetrievers.Model;
using RSSReportRetrievers.Services;

namespace RSS_Report_Retrievers
{
  internal class ReportingServicesFactory
  {
    public static Controller CreateFromSettings(ServerSettingsConfigElement config, TreeView tvReportServer, ToolStripStatusLabel lbl, ListView lv)
    {
      return new Controller(tvReportServer, lbl, lv)
      {
        RsFacade = ReportingServicesFactory.CreateFacadeFromSettings(config)
      };
    }

    private static IRSFacade CreateFacadeFromSettings(ServerSettingsConfigElement config)
    {
      IRSFacade rsFacade;
      if (config.IsSharePointMode)
      {
        rsFacade = (IRSFacade) new Rs2005SharePointFacade();
        rsFacade.BaseUrl = config.ReportLibrary;
        rsFacade.PathIncludesExtension = true;
      }
      else
      {
        rsFacade = !config.IsSQL2000 ? (IRSFacade) new Rs2005Facade() : (IRSFacade) new RS2000Facade();
        rsFacade.BaseUrl = "/";
        rsFacade.PathIncludesExtension = false;
      }
      rsFacade.WebServiceUrl = config.Url;
      rsFacade.Credentials = !config.UseWindowsAuth ? (ICredentials) new NetworkCredential(config.WindowsUsername, config.WindowsPwd, config.WindowsDomain) : CredentialCache.DefaultCredentials;
      return rsFacade;
    }
  }
}

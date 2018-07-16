
// Type: RSS_Report_Retrievers.Program




using System;
using System.Windows.Forms;

namespace RSS_Report_Retrievers
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      try
      {
        Application.Run((Form) new FormSSRSExplorer());
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace, "Unhandled exception in Rss Explorer");
      }
    }
  }
}

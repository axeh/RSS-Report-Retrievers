
// Type: RSS_Report_Retrievers.Properties.Settings




using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RSS_Report_Retrievers.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("http://localhost/ReportServer/ReportService2005.asmx")]
    public string RSS_Report_Retrievers_RSS_2005_NATIVE_ReportingService
    {
      get
      {
        return (string) this[nameof (RSS_Report_Retrievers_RSS_2005_NATIVE_ReportingService)];
      }
    }

    [DefaultSettingValue("http://localhost/ReportServer/ReportService.asmx")]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [ApplicationScopedSetting]
    public string RSS_Report_Retrievers_RSS_2000_ReportingService
    {
      get
      {
        return (string) this[nameof (RSS_Report_Retrievers_RSS_2000_ReportingService)];
      }
    }

    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("http://localhost:8080/ReportServer/ReportService2006.asmx")]
    public string RSS_Report_Retrievers_RSS_2005_SHAREPOINT_ReportingService2006
    {
      get
      {
        return (string) this[nameof (RSS_Report_Retrievers_RSS_2005_SHAREPOINT_ReportingService2006)];
      }
    }
  }
}

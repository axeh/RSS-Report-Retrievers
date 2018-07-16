using System.Configuration;

namespace RSSReportRetrievers.Model
{
    public class ServerRegistry
    {
        private static ServerSettingsSection section;
        private static Configuration config;

        public static ServerSettingsConfigElementCollection GetServerSettings()
        {
            InitConfig();
            return section.Servers;
        }

        private static void InitConfig()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            section = (ServerSettingsSection) config.SectionGroups["applicationSettings"].Sections["ServerSettings"];
        }

        public static void AddElement(ServerSettingsConfigElement el)
        {
            section.Servers.Add(el);
        }

        public static void StoreSettings()
        {
            config.Save(ConfigurationSaveMode.Full);
        }

        public static void RemoveElement(ServerSettingsConfigElement el)
        {
            section.Servers.Remove(el);
        }
    }
}
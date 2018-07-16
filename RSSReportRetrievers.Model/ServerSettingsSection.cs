using System.Configuration;

namespace RSSReportRetrievers.Model
{
    public class ServerSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("Servers", IsDefaultCollection = false)]
        public ServerSettingsConfigElementCollection Servers =>
            (ServerSettingsConfigElementCollection) this[nameof(Servers)];
    }
}
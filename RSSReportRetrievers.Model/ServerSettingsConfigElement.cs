using System.Configuration;

namespace RSSReportRetrievers.Model
{
    public class ServerSettingsConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("alias")]
        public string Alias
        {
            get => (string) this["alias"];
            set => this["alias"] = value;
        }

        [ConfigurationProperty("isSQL2000")]
        public bool IsSQL2000
        {
            get => (bool) this["isSQL2000"];
            set => this["isSQL2000"] = value;
        }

        [ConfigurationProperty("url")]
        public string Url
        {
            get => (string) this["url"];
            set => this["url"] = value;
        }

        [ConfigurationProperty("isSharePointMode")]
        public bool IsSharePointMode
        {
            get => (bool) this["isSharePointMode"];
            set => this["isSharePointMode"] = value;
        }

        [ConfigurationProperty("reportLibrary")]
        public string ReportLibrary
        {
            get => (string) this["reportLibrary"];
            set => this["reportLibrary"] = value;
        }

        [ConfigurationProperty("useWindowsAuth")]
        public bool UseWindowsAuth
        {
            get => (bool) this["useWindowsAuth"];
            set => this["useWindowsAuth"] = value;
        }

        [ConfigurationProperty("windowsDomain")]
        public string WindowsDomain
        {
            get => (string) this["windowsDomain"];
            set => this["windowsDomain"] = value;
        }

        [ConfigurationProperty("windowsPwd")]
        public string WindowsPwd
        {
            get
            {
                try
                {
                    return CryptoHelper.ToInsecureString(CryptoHelper.DecryptString((string) this["windowsPwd"]));
                }
                catch
                {
                    return (string) this["windowsPwd"];
                }
            }
            set => this["windowsPwd"] = CryptoHelper.EncryptString(CryptoHelper.ToSecureString(value));
        }

        [ConfigurationProperty("windowsUsername")]
        public string WindowsUsername
        {
            get => (string) this["windowsUsername"];
            set => this["windowsUsername"] = value;
        }

        public ServerSettingsConfigElement Clone()
        {
            var settingsConfigElement = new ServerSettingsConfigElement();
            foreach (ConfigurationProperty property in Properties)
                settingsConfigElement[property.Name] = this[property.Name];
            return settingsConfigElement;
        }
    }
}
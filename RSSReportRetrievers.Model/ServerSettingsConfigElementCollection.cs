using System.Configuration;

namespace RSSReportRetrievers.Model
{
    public class ServerSettingsConfigElementCollection : ConfigurationElementCollection
    {
        public ServerSettingsConfigElement Get(string key)
        {
            return (ServerSettingsConfigElement) BaseGet(key);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ServerSettingsConfigElement();
        }

        protected override ConfigurationElement CreateNewElement(string elementName)
        {
            return base.CreateNewElement(elementName);
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ServerSettingsConfigElement) element).Alias;
        }

        public void Add(ServerSettingsConfigElement el)
        {
            if (BaseGet(GetElementKey(el)) != null)
                BaseRemove(GetElementKey(el));
            BaseAdd(el, true);
        }

        public void Remove(ServerSettingsConfigElement el)
        {
            BaseRemove(el.Alias);
        }
    }
}
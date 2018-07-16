using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using RSSReportRetrievers.Model;
using RSS_Report_Retrievers.RSS_2005_SHAREPOINT;

namespace RSSReportRetrievers.Services
{
    public class Rs2005SharePointFacade : IRSFacade
    {
        private readonly ReportingService2006 _rs = new ReportingService2006();

        public string BaseUrl { get; set; }

        public string WebServiceUrl
        {
            get => _rs.Url;
            set => _rs.Url = value;
        }

        public bool PathIncludesExtension { get; set; }

        public void CreateFolder(string folder, string text, string properties)
        {
            _rs.CreateFolder(folder, text);
        }

        public ReportWarning[] CreateReport(string filename, string destination, bool overwrite, byte[] definition, string properties)
        {
            Warning[] warnings;
            _rs.CreateReport(Path.GetFileName(filename), destination, overwrite, definition, null, out warnings);
            if (warnings != null)
                return Array.ConvertAll(warnings, ConvertSpWarningToReportWarning);
            return null;
        }

        public ReportWarning[] CreateModel(string filename, string destination, byte[] definition, string properties)
        {
            Warning[] warnings;
            _rs.CreateModel(Path.GetFileName(filename), destination, definition, null, out warnings);
            return Array.ConvertAll(warnings, ConvertSpWarningToReportWarning);
        }

        public ICredentials Credentials
        {
            get => _rs.Credentials;
            set => _rs.Credentials = value;
        }

        public void DeleteItem(string path)
        {
            _rs.DeleteItem(path);
        }

        public List<List<string>> GetItemProperties(string path)
        {
            var stringListList = new List<List<string>>();
            var propertyList = new List<Property>
            {
                new Property {Name = "Description"},
                new Property {Name = "Name"}
            };
            foreach (var property in _rs.GetProperties(path, null))
                stringListList.Add(new List<string>
                {
                    property.Name,
                    property.Value
                });
            return stringListList;
        }

        public Dictionary<string, string[]> GetItemSecurity(string path, out bool inheritsParentSecurity)
        {
            var dictionary = new Dictionary<string, string[]>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var policy in _rs.GetPolicies(path, out inheritsParentSecurity))
            {
                var strArray = Array.ConvertAll(policy.Roles, r => r.Name);
                dictionary.Add(policy.GroupUserName, strArray);
            }

            return dictionary;
        }

        public byte[] GetModelDefinition(string path)
        {
            return _rs.GetModelDefinition(path);
        }

        public List<string> GetReportDatasources(string path)
        {
            var stringList = new List<string>();
            foreach (var itemDataSource in _rs.GetItemDataSources(path))
                stringList.Add(itemDataSource.Name);
            return stringList;
        }

        public byte[] GetReportDefinition(string path)
        {
            return _rs.GetReportDefinition(path);
        }

        public List<List<string>> GetReportParameters(string path)
        {
            var stringListList = new List<List<string>>();
            foreach (var reportParameter in _rs.GetReportParameters(path, null, null, null))
                stringListList.Add(new List<string>
                {
                    reportParameter.Name,
                    reportParameter.Type.ToString(),
                    reportParameter.AllowBlank.ToString(),
                    reportParameter.Nullable.ToString(),
                    reportParameter.MultiValue.ToString(),
                    reportParameter.Prompt
                });
            return stringListList;
        }

        public ReportItemDTO[] ListChildren(string item, bool recursive)
        {
            return Array.ConvertAll(_rs.ListChildren(item), ConvertCatalogItemToReportItemDto);
        }

        public IEnumerable<string> ListRoles()
        {
            foreach (var listRole in _rs.ListRoles(SecurityScopeEnum.Catalog, BaseUrl))
                yield return listRole.Name;
        }

        public void MoveItem(string source, string destination, ReportItemTypes type)
        {
            if (!destination.EndsWith(".rsds") && type == ReportItemTypes.Datasource)
                destination += ".rsds";
            else if (!destination.EndsWith(".rdl") && type == ReportItemTypes.Report)
                destination += ".rdl";
            _rs.MoveItem(source, destination);
        }

        public void SetItemDataSources(string item, string dataSourceName)
        {
            var itemDataSources = _rs.GetItemDataSources(item);
            foreach (var dataSource in itemDataSources)
                dataSource.Item = new DataSourceReference
                {
                    Reference = dataSourceName
                };
            _rs.SetItemDataSources(item, itemDataSources);
        }

        public void SetItemSecurity(string itemPath, Dictionary<string, string[]> policies)
        {
            var policyList = new List<Policy>();
            foreach (var key in policies.Keys)
            {
                var policy = new Policy
                {
                    GroupUserName = key,
                    Roles = Array.ConvertAll(policies[key], roleName => new Role
                    {
                        Name = roleName
                    })
                };
            }

            _rs.SetPolicies(itemPath, policyList.ToArray());
        }

        public void CreateDataSource(Datasource datasource, string parent)
        {
            var definition = new DataSourceDefinition();
            definition.CredentialRetrieval = GetSsrsCredentialRetrievalTypeFromEnum(datasource.CredentialRetrievalType);
            definition.ConnectString = datasource.ConnectionString;
            definition.Enabled = datasource.Enabled;
            definition.Extension = datasource.Extension;
            definition.Prompt = datasource.Prompt;
            if (definition.CredentialRetrieval == CredentialRetrievalEnum.Store)
            {
                definition.UserName = datasource.Username;
                definition.Password = datasource.Password;
            }

            definition.ImpersonateUser = datasource.SetExecutionContext;
            definition.WindowsCredentials = datasource.UsePromptedCredentialsAsWindowsCredentials ||
                                            datasource.UseStoredCredentialsAsWindowsCredentials;
            if (!datasource.Name.EndsWith(".rsds")) datasource.Name += ".rsds";
            _rs.CreateDataSource(datasource.Name, parent, true, definition, null);
        }

        public List<DatasourceExtension> GetDataExtensions()
        {
            var datasourceExtensionList = new List<DatasourceExtension>();
            foreach (var listExtension in _rs.ListExtensions(ExtensionTypeEnum.Data))
                datasourceExtensionList.Add(new DatasourceExtension(listExtension.Name, listExtension.LocalizedName));
            return datasourceExtensionList;
        }

        public Datasource GetDatasource(string path)
        {
            var dataSourceContents = _rs.GetDataSourceContents(path);
            return new Datasource
            {
                ConnectionString = dataSourceContents.ConnectString,
                CredentialRetrievalType =
                    GetCredentialRetrievalTypeFromSsrsType(dataSourceContents.CredentialRetrieval),
                Enabled = dataSourceContents.Enabled,
                Extension = dataSourceContents.Extension,
                Username = dataSourceContents.UserName,
                Password = dataSourceContents.Password,
                Prompt = dataSourceContents.Prompt,
                SetExecutionContext = dataSourceContents.ImpersonateUser,
                UseStoredCredentialsAsWindowsCredentials = dataSourceContents.WindowsCredentials,
                UsePromptedCredentialsAsWindowsCredentials = dataSourceContents.WindowsCredentials
            };
        }

        public List<ReportItemDTO> ListDependantItems(string reportModel)
        {
            var reportItemDtoList = new List<ReportItemDTO>();
            foreach (var listDependentItem in _rs.ListDependentItems(reportModel))
                reportItemDtoList.Add(new ReportItemDTO
                {
                    Name = listDependentItem.Name,
                    Path = listDependentItem.Path
                });
            return reportItemDtoList;
        }

        private static CredentialRetrievalTypes GetCredentialRetrievalTypeFromSsrsType(CredentialRetrievalEnum type)
        {
            var credentialRetrievalTypes = CredentialRetrievalTypes.None;
            switch (type)
            {
                case CredentialRetrievalEnum.Prompt:
                    credentialRetrievalTypes = CredentialRetrievalTypes.Prompt;
                    break;
                case CredentialRetrievalEnum.Store:
                    credentialRetrievalTypes = CredentialRetrievalTypes.Store;
                    break;
                case CredentialRetrievalEnum.Integrated:
                    credentialRetrievalTypes = CredentialRetrievalTypes.Integrated;
                    break;
                case CredentialRetrievalEnum.None:
                    credentialRetrievalTypes = CredentialRetrievalTypes.None;
                    break;
            }

            return credentialRetrievalTypes;
        }

        private static ReportItemTypes GetReportItemTypeFromSsrsItemTyp(ItemTypeEnum ssrsType)
        {
            var reportItemTypes = ReportItemTypes.Unknown;
            switch (ssrsType)
            {
                case ItemTypeEnum.Folder:
                    reportItemTypes = ReportItemTypes.Folder;
                    break;
                case ItemTypeEnum.Report:
                    reportItemTypes = ReportItemTypes.Report;
                    break;
                case ItemTypeEnum.DataSource:
                    reportItemTypes = ReportItemTypes.Datasource;
                    break;
                case ItemTypeEnum.Model:
                    reportItemTypes = ReportItemTypes.Model;
                    break;
            }

            return reportItemTypes;
        }

        private static ReportItemDTO ConvertCatalogItemToReportItemDto(CatalogItem item)
        {
            ReportItemDTO reportItemDto;
            reportItemDto.Hidden = item.Hidden;
            reportItemDto.Name = item.Name;
            reportItemDto.Path = item.Path;
            reportItemDto.Type = GetReportItemTypeFromSsrsItemTyp(item.Type);
            return reportItemDto;
        }

        private static CredentialRetrievalEnum GetSsrsCredentialRetrievalTypeFromEnum(CredentialRetrievalTypes type)
        {
            var credentialRetrievalEnum = CredentialRetrievalEnum.None;
            switch (type)
            {
                case CredentialRetrievalTypes.None:
                    credentialRetrievalEnum = CredentialRetrievalEnum.None;
                    break;
                case CredentialRetrievalTypes.Prompt:
                    credentialRetrievalEnum = CredentialRetrievalEnum.Prompt;
                    break;
                case CredentialRetrievalTypes.Integrated:
                    credentialRetrievalEnum = CredentialRetrievalEnum.Integrated;
                    break;
                case CredentialRetrievalTypes.Store:
                    credentialRetrievalEnum = CredentialRetrievalEnum.Store;
                    break;
            }

            return credentialRetrievalEnum;
        }

        private static ReportWarning ConvertSpWarningToReportWarning(Warning w)
        {
            ReportWarning reportWarning;
            reportWarning.Code = w.Code;
            reportWarning.Message = w.Message;
            reportWarning.ObjectName = w.ObjectName;
            reportWarning.ObjectType = w.ObjectType;
            reportWarning.Severity = w.Severity;
            return reportWarning;
        }
    }
}
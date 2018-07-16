using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using RSSReportRetrievers.Model;
using RSS_Report_Retrievers.RSS_2005_NATIVE;

namespace RSSReportRetrievers.Services
{
    public class Rs2005Facade : IRSFacade
    {
        private readonly ReportingService2005 _rs = new ReportingService2005();

        public string BaseUrl { get; set; }

        public bool PathIncludesExtension { get; set; }

        public string WebServiceUrl
        {
            get => _rs.Url;
            set => _rs.Url = value;
        }

        public void CreateFolder(string folder, string parent, string properties)
        {
            _rs.CreateFolder(folder, parent, null);
        }

        public ReportWarning[] CreateReport(string filename, string destination, bool overwrite, byte[] definition, string properties)
        {
            var report = _rs.CreateReport(Path.GetFileNameWithoutExtension(filename), destination, overwrite, definition,
                null);
            if (report != null)
                return Array.ConvertAll(report, ConvertSpWarningToReportWarning);
            return null;
        }

        public ReportWarning[] CreateModel(string visibleName, string parentFolder, byte[] definition, string properties)
        {
            return Array.ConvertAll(_rs.CreateModel(visibleName, parentFolder, definition, null),
                ConvertSpWarningToReportWarning);
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
            {
                var dataSourceReference = itemDataSource.Item as DataSourceReference;
                if (dataSourceReference != null)
                    stringList.Add(dataSourceReference.Reference);
            }

            return stringList;
        }

        public byte[] GetReportDefinition(string path)
        {
            return _rs.GetReportDefinition(path);
        }

        public List<List<string>> GetReportParameters(string path)
        {
            var stringListList = new List<List<string>>();
            foreach (var reportParameter in _rs.GetReportParameters(path, null, false, null, null))
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
            return Array.ConvertAll(_rs.ListChildren(item, recursive), ConvertCatalogItemToReportItemDto);
        }

        public void MoveItem(string source, string destination, ReportItemTypes type)
        {
            _rs.MoveItem(source, destination.StartsWith("/") ? destination : "/" + destination);
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
                var policy = new Policy();
                policy.GroupUserName = key;
                policy.Roles = Array.ConvertAll(policies[key], roleName => new Role
                {
                    Name = roleName
                });
                if (!string.IsNullOrEmpty(policy.GroupUserName) && policy.Roles.Length > 0)
                    policyList.Add(policy);
            }

            _rs.SetPolicies(itemPath, policyList.ToArray());
        }

        public void CreateDataSource(Datasource datasource, string parent)
        {
            _rs.CreateDataSource(datasource.Name, parent, true, new DataSourceDefinition
            {
                ConnectString = datasource.ConnectionString,
                Enabled = datasource.Enabled,
                Extension = datasource.Extension,
                Password = datasource.Password,
                Prompt = datasource.Prompt,
                UserName = datasource.Username,
                ImpersonateUser = datasource.SetExecutionContext,
                WindowsCredentials = datasource.UsePromptedCredentialsAsWindowsCredentials ||
                                     datasource.UseStoredCredentialsAsWindowsCredentials,
                CredentialRetrieval = GetSsrsCredentialRetrievalTypeFromEnum(datasource.CredentialRetrievalType)
            }, null);
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

        public List<ReportItemDTO> ListDependantItems(string reportModelpath)
        {
            var reportItemDtoList = new List<ReportItemDTO>();
            foreach (var listDependentItem in _rs.ListDependentItems(reportModelpath))
                reportItemDtoList.Add(new ReportItemDTO
                {
                    Name = listDependentItem.Name,
                    Path = listDependentItem.Path
                });
            return reportItemDtoList;
        }

        public IEnumerable<string> ListRoles()
        {
            foreach (var listRole in _rs.ListRoles(SecurityScopeEnum.Catalog))
                yield return listRole.Name;
        }

        public List<ReportItemDTO> LoadDependantItems(string reportModelpath)
        {
            throw new Exception("The method or operation is not implemented.");
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

        private static ReportItemDTO ConvertCatalogItemToReportItemDto(CatalogItem item)
        {
            ReportItemDTO reportItemDto;
            reportItemDto.Hidden = item.Hidden;
            reportItemDto.Name = item.Name;
            reportItemDto.Path = item.Path;
            reportItemDto.Type = GetReportItemTypeFromSsrsItemTyp(item.Type);
            return reportItemDto;
        }

        private static ReportWarning ConvertSpWarningToReportWarning(Warning w)
        {
            var reportWarning = new ReportWarning();
            if (w != null)
            {
                reportWarning.Code = w.Code;
                reportWarning.Message = w.Message;
                reportWarning.ObjectName = w.ObjectName;
                reportWarning.ObjectType = w.ObjectType;
                reportWarning.Severity = w.Severity;
            }

            return reportWarning;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using RSSReportRetrievers.Model;
using RSS_Report_Retrievers.RSS_2000;

namespace RSSReportRetrievers.Services
{
    public class RS2000Facade : IRSFacade
    {
        private readonly ReportingService rs = new ReportingService();

        public string BaseUrl { get; set; }

        public bool PathIncludesExtension { get; set; }

        public string WebServiceUrl
        {
            get => rs.Url;
            set => rs.Url = value;
        }

        public void CreateFolder(string Folder, string text, string properties)
        {
            rs.CreateFolder(Folder, text, null);
        }

        public ReportWarning[] CreateReport(string filename, string destination, bool overwrite, byte[] definition,
            string Properties)
        {
            var report = rs.CreateReport(Path.GetFileNameWithoutExtension(filename), destination, overwrite, definition,
                null);
            if (report != null)
                return Array.ConvertAll(report, ConvertSPWarningToReportWarning);
            return null;
        }

        public ReportWarning[] CreateModel(string filename, string destination, byte[] definition, string Properties)
        {
            return null;
        }

        public ICredentials Credentials
        {
            get => rs.Credentials;
            set => rs.Credentials = value;
        }

        public void DeleteItem(string path)
        {
            rs.DeleteItem(path);
        }

        public List<List<string>> GetItemProperties(string path)
        {
            var stringListList = new List<List<string>>();
            foreach (var property in rs.GetProperties(path, null))
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
            foreach (var policy in rs.GetPolicies(path, out inheritsParentSecurity))
            {
                var strArray = Array.ConvertAll(policy.Roles, r => r.Name);
                dictionary.Add(policy.GroupUserName, strArray);
            }

            return dictionary;
        }

        public byte[] GetModelDefinition(string path)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public List<string> GetReportDatasources(string path)
        {
            var stringList = new List<string>();
            foreach (var reportDataSource in rs.GetReportDataSources(path))
                stringList.Add(reportDataSource.Name);
            return stringList;
        }

        public byte[] GetReportDefinition(string path)
        {
            return rs.GetReportDefinition(path);
        }

        public List<List<string>> GetReportParameters(string path)
        {
            var stringListList = new List<List<string>>();
            foreach (var reportParameter in rs.GetReportParameters(path, null, false, null, null))
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
            return Array.ConvertAll(rs.ListChildren(item, recursive), ConvertCatalogItemToReportItemDTO);
        }

        public void MoveItem(string source, string destination, ReportItemTypes type)
        {
            rs.MoveItem(source, destination.StartsWith("/") ? destination : "/" + destination);
        }

        public void SetItemDataSources(string item, string dataSourceName)
        {
            foreach (var reportDataSource in rs.GetReportDataSources(item))
                if (reportDataSource.Name == dataSourceName)
                    try
                    {
                        var dataSourceReference = new DataSourceReference();
                        dataSourceReference.Reference = dataSourceName;
                        var DataSources = new DataSource[1]
                        {
                            new DataSource
                            {
                                Item = dataSourceReference,
                                Name = ("/" + dataSourceName.Split('/')[dataSourceName.Split('/').GetUpperBound(0)])
                                    .Trim('/')
                            }
                        };
                        rs.SetReportDataSources(item, DataSources);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("An error has occured: {0}", ex.Message));
                    }
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

            rs.SetPolicies(itemPath, policyList.ToArray());
        }

        public void CreateDataSource(Datasource datasource, string parent)
        {
            rs.CreateDataSource(datasource.Name, parent, true, new DataSourceDefinition
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
                CredentialRetrieval = GetSSRSCredentialRetrievalTypeFromEnum(datasource.CredentialRetrievalType)
            }, null);
        }

        public List<DatasourceExtension> GetDataExtensions()
        {
            var datasourceExtensionList = new List<DatasourceExtension>();
            foreach (var listExtension in rs.ListExtensions(ExtensionTypeEnum.Data))
                datasourceExtensionList.Add(new DatasourceExtension(listExtension.Name, listExtension.LocalizedName));
            return datasourceExtensionList;
        }

        public Datasource GetDatasource(string path)
        {
            var dataSourceContents = rs.GetDataSourceContents(path);
            return new Datasource
            {
                ConnectionString = dataSourceContents.ConnectString,
                CredentialRetrievalType =
                    GetCredentialRetrievalTypeFromSSRSType(dataSourceContents.CredentialRetrieval),
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
            throw new Exception("The method or operation is not implemented.");
        }

        public IEnumerable<string> ListRoles()
        {
            foreach (var listRole in rs.ListRoles())
                yield return listRole.Name;
        }

        private static ReportWarning ConvertSPWarningToReportWarning(Warning w)
        {
            ReportWarning reportWarning;
            reportWarning.Code = w.Code;
            reportWarning.Message = w.Message;
            reportWarning.ObjectName = w.ObjectName;
            reportWarning.ObjectType = w.ObjectType;
            reportWarning.Severity = w.Severity;
            return reportWarning;
        }

        private static ReportItemTypes GetReportItemTypeFromSSRSItemTyp(ItemTypeEnum ssrsType)
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
            }

            return reportItemTypes;
        }

        private static ReportItemDTO ConvertCatalogItemToReportItemDTO(CatalogItem item)
        {
            ReportItemDTO reportItemDto;
            reportItemDto.Hidden = item.Hidden;
            reportItemDto.Name = item.Name;
            reportItemDto.Path = item.Path;
            reportItemDto.Type = GetReportItemTypeFromSSRSItemTyp(item.Type);
            return reportItemDto;
        }

        private static CredentialRetrievalEnum GetSSRSCredentialRetrievalTypeFromEnum(CredentialRetrievalTypes type)
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

        private static CredentialRetrievalTypes GetCredentialRetrievalTypeFromSSRSType(CredentialRetrievalEnum type)
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
    }
}
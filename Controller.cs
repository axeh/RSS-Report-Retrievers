
// Type: RSS_Report_Retrievers.Controller


using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using RSSReportRetrievers.Model;
using RSSReportRetrievers.Services;

namespace RSS_Report_Retrievers
{
  public class Controller
  {
    private TreeView tvReportServer = (TreeView) null;
    private ToolStripStatusLabel toolStripStatusLabel = (ToolStripStatusLabel) null;
    private ListView lvItems = (ListView) null;
    private ViewItems viewItem = ViewItems.Folders;
    public IRSFacade RsFacade;

    public Controller(TreeView treeView, ToolStripStatusLabel label, ListView listView)
    {
      this.tvReportServer = treeView;
      this.toolStripStatusLabel = label;
      this.lvItems = listView;
    }

    public ViewItems ViewItem
    {
      set
      {
        this.viewItem = value;
      }
      get
      {
        return this.viewItem;
      }
    }

    public void PopulateTreeView(string serverAlias)
    {
      this.tvReportServer.Nodes.Clear();
      TreeNode treeNode = new TreeNode(serverAlias);
      treeNode.Name = "/";
      treeNode.ToolTipText = this.RsFacade.BaseUrl;
      treeNode.Tag = (object) ReportItemTypes.Folder;
      this.tvReportServer.Nodes.Add(treeNode);
      if (this.toolStripStatusLabel != null)
      {
        this.toolStripStatusLabel.Text = "Retrieving server information....";
        Application.DoEvents();
      }
      try
      {
        this.ExpandNodeContent(treeNode, true);
        treeNode.Expand();
        this.tvReportServer.SelectedNode = treeNode;
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("An error occured: {0}. Please check the application settings using the menu.", (object) ex.Message));
      }
      finally
      {
        if (this.toolStripStatusLabel != null)
          this.toolStripStatusLabel.Text = "";
      }
    }

    public void ExpandNodeContent(TreeNode parent, bool recurseSubfolders)
    {
      foreach (ReportItemDTO listChild in this.RsFacade.ListChildren(parent.ToolTipText, false))
      {
        if (listChild.Type == ReportItemTypes.Folder && (this.viewItem == ViewItems.Folders || this.viewItem == ViewItems.All || this.viewItem == ViewItems.Datasources))
        {
          TreeNode treeNode = new TreeNode(listChild.Name);
          treeNode.Name = listChild.Name;
          treeNode.ImageIndex = listChild.Hidden ? 4 : 2;
          treeNode.Tag = (object) ReportItemTypes.Folder;
          treeNode.ToolTipText = listChild.Path;
          parent.Nodes.Add(treeNode);
          if (recurseSubfolders)
            this.ExpandNodeContent(treeNode, true);
        }
        else if (listChild.Type == ReportItemTypes.Datasource && (this.viewItem == ViewItems.Datasources || this.viewItem == ViewItems.All))
          parent.Nodes.Add(new TreeNode(listChild.Name)
          {
            Name = listChild.Name,
            ImageIndex = 0,
            Tag = (object) ReportItemTypes.Datasource,
            ToolTipText = listChild.Path
          });
        else if (listChild.Type == ReportItemTypes.Report && this.viewItem == ViewItems.All)
          parent.Nodes.Add(new TreeNode(listChild.Name)
          {
            Name = listChild.Name,
            ImageIndex = 1,
            Tag = (object) ReportItemTypes.Report,
            ToolTipText = listChild.Path
          });
        else if (listChild.Type == ReportItemTypes.Model && (this.viewItem == ViewItems.Datasources || this.viewItem == ViewItems.All))
          parent.Nodes.Add(new TreeNode(listChild.Name)
          {
            Name = listChild.Name,
            ImageIndex = 4,
            Tag = (object) ReportItemTypes.Model,
            ToolTipText = listChild.Path
          });
      }
    }

    public void PopulateItems(string path)
    {
      this.lvItems.Items.Clear();
      foreach (ReportItemDTO listChild in this.RsFacade.ListChildren(path, false))
      {
        ListViewItem listViewItem = new ListViewItem();
        listViewItem.Text = listChild.Name;
        listViewItem.ToolTipText = listChild.Path;
        switch (listChild.Type)
        {
          case ReportItemTypes.Folder:
            listViewItem.ImageIndex = listChild.Hidden ? 4 : 2;
            listViewItem.Tag = (object) ReportItemTypes.Folder;
            break;
          case ReportItemTypes.Datasource:
            listViewItem.Tag = (object) ReportItemTypes.Datasource;
            listViewItem.ImageIndex = 0;
            break;
          case ReportItemTypes.Report:
            listViewItem.ImageIndex = listChild.Hidden ? 5 : 1;
            listViewItem.Tag = (object) ReportItemTypes.Report;
            break;
          case ReportItemTypes.Model:
            listViewItem.Tag = (object) ReportItemTypes.Model;
            listViewItem.ImageIndex = 6;
            break;
        }
        this.lvItems.Items.Add(listViewItem);
      }
    }

    public void DeleteItem(string path)
    {
      try
      {
        this.RsFacade.DeleteItem(path);
        this.toolStripStatusLabel.Text = string.Format("'{0}' deleted", (object) path);
        Application.DoEvents();
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("An error occured: {0}", (object) ex.Message));
      }
    }

    public TreeNode CreateFolder(string name, TreeNode parent)
    {
      try
      {
        this.RsFacade.CreateFolder(name, parent.ToolTipText, (string) null);
      }
      catch (Exception ex)
      {
        if (!ex.Message.ToLower().Contains("already exists"))
          throw new Exception(ex.Message, ex);
      }
      TreeNode node = new TreeNode(name);
      node.Name = name;
      node.ImageIndex = 2;
      node.Tag = (object) ReportItemTypes.Folder;
      node.ToolTipText = !parent.ToolTipText.EndsWith("/") ? parent.ToolTipText + "/" + name : parent.ToolTipText + name;
      parent.Nodes.Add(node);
      return node;
    }

    public void CreateDataSource(Datasource datasource, string path)
    {
      try
      {
        this.RsFacade.CreateDataSource(datasource, path);
        this.toolStripStatusLabel.Text = string.Format("Updated / Created new datasource '{0}'", (object) datasource.Name);
        Application.DoEvents();
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("An error occured: {0}", (object) ex.Message));
      }
    }

    public void AddPolicyForMyReports(string userName, IEnumerable<string> roles)
    {
      ReportItemDTO reportItemDto;
      reportItemDto.Path = "";
      try
      {
        reportItemDto.Path = "/Users Folders";
        foreach (ReportItemDTO listChild in this.RsFacade.ListChildren("/Users Folders", false))
        {
          reportItemDto = listChild;
          if (listChild.Type == ReportItemTypes.Folder)
          {
            string str = listChild.Path + "/My reports";
            bool inheritsParentSecurity;
            Dictionary<string, string[]> itemSecurity = this.RsFacade.GetItemSecurity(str, out inheritsParentSecurity);
            this.RemoveExistingUser(itemSecurity, userName);
            List<string> stringList = new List<string>();
            foreach (string role in roles)
              stringList.Add(role);
            itemSecurity.Add(userName, stringList.ToArray());
            this.RsFacade.SetItemSecurity(str, itemSecurity);
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Current Item:" + reportItemDto.Path + "\r\n" + ex.ToString());
      }
    }

    private void RemoveExistingUser(Dictionary<string, string[]> existingPolicies, string userName)
    {
      if (!existingPolicies.ContainsKey(userName))
        return;
      existingPolicies.Remove(userName);
    }

    public void AddPolicyForMyReports(string itemPath, string visibleName, IFormSetPolicy policyDialog)
    {
      policyDialog.Init(this.RsFacade.ListRoles(), visibleName);
      if (policyDialog.ShowDialog() != DialogResult.OK)
        return;
      this.AddPolicyForMyReports(policyDialog.UserName, (IEnumerable<string>) policyDialog.SelectedRoles);
      int num = (int) MessageBox.Show("MyReports-folders updated!");
    }

    public void UploadFolder(string path, string destination, bool overwrite, TreeNode parent)
    {
      foreach (string file in Directory.GetFiles(path, "*.rdl", SearchOption.TopDirectoryOnly))
        this.UploadReport(file, destination, overwrite);
      foreach (string directory in Directory.GetDirectories(path))
        this.UploadFolder(directory, destination.TrimEnd('/') + "/" + Path.GetFileName(directory), (overwrite ? 1 : 0) != 0, this.CreateFolder(Path.GetFileName(directory), parent));
    }

    public void ReplaceModel(string filename, string itemToReplace)
    {
      byte[] bytesFromFile = Controller.GetBytesFromFile(filename);
      string fileName = Path.GetFileName(itemToReplace);
      List<string> reportDatasources = this.RsFacade.GetReportDatasources(itemToReplace);
      List<ReportItemDTO> dependantItems = this.RsFacade.ListDependantItems(itemToReplace);
      this.RsFacade.DeleteItem(itemToReplace);
      string folder = Path.GetDirectoryName(itemToReplace).Replace('\\', '/');
      this.RsFacade.CreateModel(fileName, folder, bytesFromFile, (string) null);
      if (reportDatasources != null && reportDatasources.Count > 0)
        this.RsFacade.SetItemDataSources(itemToReplace, reportDatasources[0]);
      this.UpdateDatasourceForDependantItems(dependantItems, itemToReplace);
      this.toolStripStatusLabel.Text = string.Format("Uploaded item {0}", (object) Path.GetFileName(filename));
      Application.DoEvents();
    }

    private void UpdateDatasourceForDependantItems(List<ReportItemDTO> dependantItems, string itemToReplace)
    {
      this.RsFacade.GetReportDatasources(itemToReplace);
      foreach (ReportItemDTO dependantItem in dependantItems)
        this.RsFacade.SetItemDataSources(dependantItem.Path, itemToReplace);
    }

    public void CreateModel(string filename, string destinationFolder, bool overwrite)
    {
      byte[] bytesFromFile = Controller.GetBytesFromFile(filename);
      this.RsFacade.CreateModel(Path.GetFileNameWithoutExtension(filename), destinationFolder, bytesFromFile, (string) null);
    }

    public void UploadReport(string filename, string destinationFolder, bool overwrite)
    {
      try
      {
        byte[] bytesFromFile = Controller.GetBytesFromFile(filename);
        this.RsFacade.CreateReport(Path.GetFileName(filename), destinationFolder, overwrite, bytesFromFile, (string) null);
        this.toolStripStatusLabel.Text = string.Format("Uploaded item {0}", (object) Path.GetFileName(filename));
        Application.DoEvents();
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format("An error has occured: {0}", (object) ex.Message));
      }
    }

    private static byte[] GetBytesFromFile(string filename)
    {
      FileStream fileStream = File.OpenRead(filename);
      byte[] buffer = new byte[fileStream.Length];
      fileStream.Read(buffer, 0, (int) fileStream.Length);
      fileStream.Close();
      return buffer;
    }

    public void SetDatasource(string item, string datasource, ReportItemTypes type)
    {
      switch (type)
      {
        case ReportItemTypes.Folder:
          foreach (ReportItemDTO listChild in this.RsFacade.ListChildren(item, true))
            this.SetDatasource(listChild.Path, datasource, listChild.Type);
          break;
        case ReportItemTypes.Report:
        case ReportItemTypes.Model:
          this.RsFacade.SetItemDataSources(item, datasource);
          this.toolStripStatusLabel.Text = string.Format("Updated datasource of {0}", (object) item);
          break;
        default:
          this.toolStripStatusLabel.Text = string.Format("Cannot set datasource of item {0}", (object) item);
          break;
      }
    }

    public void MoveItem(string source, string destination, ReportItemTypes type)
    {
      this.RsFacade.MoveItem(source, destination, type);
    }

    public List<List<string>> GetReportParameters(string path)
    {
      return this.RsFacade.GetReportParameters(path);
    }

    public List<string> GetReportDatasources(string path)
    {
      return this.RsFacade.GetReportDatasources(path);
    }

    public List<List<string>> GetItemProperties(string path)
    {
      return this.RsFacade.GetItemProperties(path);
    }

    public Dictionary<string, string[]> GetItemSecurity(string path, out bool inheritsParent)
    {
      return this.RsFacade.GetItemSecurity(path, out inheritsParent);
    }

    public IEnumerable<string> ListRoles()
    {
      return this.RsFacade.ListRoles();
    }

    public void DownloadItem(string path, string destinationFolder, ReportItemTypes type, bool preserveFolders)
    {
      switch (type)
      {
        case ReportItemTypes.Folder:
          foreach (ReportItemDTO listChild in this.RsFacade.ListChildren(path, true))
            this.DownloadItem(listChild.Path, destinationFolder, listChild.Type, preserveFolders);
          break;
        case ReportItemTypes.Report:
          XmlDocument definition1 = new XmlDocument();
          definition1.Load((Stream) new MemoryStream(this.RsFacade.GetReportDefinition(path)));
          this.SaveItem(path, type, destinationFolder, preserveFolders, definition1);
          break;
        case ReportItemTypes.Model:
          XmlDocument definition2 = new XmlDocument();
          definition2.Load((Stream) new MemoryStream(this.RsFacade.GetModelDefinition(path)));
          this.SaveItem(path, type, destinationFolder, preserveFolders, definition2);
          break;
      }
      this.toolStripStatusLabel.Text = string.Format("Downloaded '{0}'", (object) path);
      Application.DoEvents();
    }

    private string AppendFileSuffix(string path, ReportItemTypes type)
    {
      string str = path;
      switch (type)
      {
        case ReportItemTypes.Report:
          str += ".rdl";
          break;
        case ReportItemTypes.Model:
          str += ".smdl";
          break;
      }
      return str;
    }

    private void SaveItem(string filename, ReportItemTypes type, string destination, bool preserveFolders, XmlDocument definition)
    {
      if (!this.RsFacade.PathIncludesExtension)
        filename = this.AppendFileSuffix(filename, type);
      if (preserveFolders)
      {
        string toolTipText = this.tvReportServer.SelectedNode.ToolTipText;
        string directoryName = Path.GetDirectoryName(filename.Substring(toolTipText.Length));
        destination = Path.Combine(destination, directoryName);
        destination = destination.Replace('/', '\\');
      }
      filename = Path.GetFileName(filename);
      if (!Directory.Exists(destination))
        Directory.CreateDirectory(destination);
      definition.Save(string.Format("{0}\\{1}", (object) destination, (object) filename));
    }

    public List<ReportItemDTO> ListDependantItems(string modelPath)
    {
      return this.RsFacade.ListDependantItems(modelPath);
    }

    public byte[] GetReport(string path)
    {
      return this.RsFacade.GetReportDefinition(path);
    }

    public List<DatasourceExtension> GetDataExtensions()
    {
      return this.RsFacade.GetDataExtensions();
    }

    public Datasource GetDatasource(string path)
    {
      return this.RsFacade.GetDatasource(path);
    }
  }
}

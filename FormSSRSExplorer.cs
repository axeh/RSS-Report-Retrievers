
// Type: RSS_Report_Retrievers.FormSSRSExplorer


using RSS_Report_Retrievers.Forms;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RSSReportRetrievers.Model;
using RSSReportRetrievers.Services;

namespace RSS_Report_Retrievers
{
  public class FormSSRSExplorer : Form
  {
    public static ServerSettingsConfigElement SelectedServer = (ServerSettingsConfigElement) null;
    private IContainer components = (IContainer) null;
    private ServerSettingsConfigElementCollection serverCollection = (ServerSettingsConfigElementCollection) null;
    private const string REPORT_FILTER_STRING = "Reports|*.rdl";
    private const string MODEL_FILTER_STRING = "Models|*.smdl";
    private const string MODEL_FILEEXTENSION = ".smdl";
    private TreeView tvReportServer;
    private Button btnOK;
    private ImageList imageList;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem moveToolStripMenuItem;
    private ToolStripMenuItem newFolderToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItemSep1;
    private ToolStripMenuItem uploadToolStripMenuItem;
    private ToolStripMenuItem downloadToolStripMenuItem;
    private ToolStripMenuItem folderToolStripMenuItem;
    private ListView lvItems;
    private SplitContainer splitContainer;
    private ToolStripMenuItem filesToolStripMenuItem;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStripStatusLabel;
    private OpenFileDialog openFileDialog;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private ToolStripMenuItem setDatasourceToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItemSep2;
    private ToolStripMenuItem renameToolStripMenuItem;
    private ToolStripMenuItem propertiesToolStripMenuItem;
    private MenuStrip menuStripMain;
    private ToolStripContainer toolStripContainer;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem settingsToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem6;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem connectToolStripMenuItem;
    private ToolStripMenuItem createDatasourceToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem replaceModelToolStripMenuItem;
    private ToolStripMenuItem setItemSecurityToolStripMenuItem;
    private ToolStripMenuItem addPermissionsForUserToolStripMenuItem;
    private Controller rs;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSSRSExplorer));
      this.tvReportServer = new TreeView();
      this.imageList = new ImageList(this.components);
      this.contextMenuStrip = new ContextMenuStrip(this.components);
      this.deleteToolStripMenuItem = new ToolStripMenuItem();
      this.moveToolStripMenuItem = new ToolStripMenuItem();
      this.renameToolStripMenuItem = new ToolStripMenuItem();
      this.setDatasourceToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.createDatasourceToolStripMenuItem = new ToolStripMenuItem();
      this.setItemSecurityToolStripMenuItem = new ToolStripMenuItem();
      this.addPermissionsForUserToolStripMenuItem = new ToolStripMenuItem();
      this.newFolderToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemSep1 = new ToolStripSeparator();
      this.uploadToolStripMenuItem = new ToolStripMenuItem();
      this.filesToolStripMenuItem = new ToolStripMenuItem();
      this.folderToolStripMenuItem = new ToolStripMenuItem();
      this.downloadToolStripMenuItem = new ToolStripMenuItem();
      this.replaceModelToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemSep2 = new ToolStripSeparator();
      this.propertiesToolStripMenuItem = new ToolStripMenuItem();
      this.btnOK = new Button();
      this.lvItems = new ListView();
      this.splitContainer = new SplitContainer();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel = new ToolStripStatusLabel();
      this.openFileDialog = new OpenFileDialog();
      this.menuStripMain = new MenuStrip();
      this.toolStripMenuItem5 = new ToolStripMenuItem();
      this.connectToolStripMenuItem = new ToolStripMenuItem();
      this.settingsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem6 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripContainer = new ToolStripContainer();
      this.contextMenuStrip.SuspendLayout();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.menuStripMain.SuspendLayout();
      this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer.ContentPanel.SuspendLayout();
      this.toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer.SuspendLayout();
      this.SuspendLayout();
      this.tvReportServer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tvReportServer.ImageIndex = 2;
      this.tvReportServer.ImageList = this.imageList;
      this.tvReportServer.Location = new Point(3, 3);
      this.tvReportServer.Name = "tvReportServer";
      this.tvReportServer.SelectedImageIndex = 3;
      this.tvReportServer.Size = new Size(252, 405);
      this.tvReportServer.TabIndex = 0;
      this.tvReportServer.AfterSelect += new TreeViewEventHandler(this.tvReportServer_AfterSelect);
      this.imageList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList.ImageStream");
      this.imageList.TransparentColor = Color.Transparent;
      this.imageList.Images.SetKeyName(0, "");
      this.imageList.Images.SetKeyName(1, "");
      this.imageList.Images.SetKeyName(2, "");
      this.imageList.Images.SetKeyName(3, "");
      this.imageList.Images.SetKeyName(4, "");
      this.imageList.Images.SetKeyName(5, "");
      this.imageList.Images.SetKeyName(6, "model.gif");
      this.contextMenuStrip.Items.AddRange(new ToolStripItem[14]
      {
        (ToolStripItem) this.deleteToolStripMenuItem,
        (ToolStripItem) this.moveToolStripMenuItem,
        (ToolStripItem) this.renameToolStripMenuItem,
        (ToolStripItem) this.setDatasourceToolStripMenuItem,
        (ToolStripItem) this.editToolStripMenuItem,
        (ToolStripItem) this.createDatasourceToolStripMenuItem,
        (ToolStripItem) this.setItemSecurityToolStripMenuItem,
        (ToolStripItem) this.newFolderToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemSep1,
        (ToolStripItem) this.uploadToolStripMenuItem,
        (ToolStripItem) this.downloadToolStripMenuItem,
        (ToolStripItem) this.replaceModelToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemSep2,
        (ToolStripItem) this.propertiesToolStripMenuItem
      });
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.ShowImageMargin = false;
      this.contextMenuStrip.Size = new Size(167, 304);
      this.contextMenuStrip.Text = "With selected items:";
      this.contextMenuStrip.Opening += new CancelEventHandler(this.contextMenuStrip_Opening);
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new Size(166, 24);
      this.deleteToolStripMenuItem.Text = "&Delete";
      this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
      this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
      this.moveToolStripMenuItem.Size = new Size(166, 24);
      this.moveToolStripMenuItem.Text = "&Move";
      this.moveToolStripMenuItem.Click += new EventHandler(this.moveToolStripMenuItem_Click);
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new Size(166, 24);
      this.renameToolStripMenuItem.Text = "&Rename";
      this.renameToolStripMenuItem.Click += new EventHandler(this.renameToolStripMenuItem_Click);
      this.setDatasourceToolStripMenuItem.Name = "setDatasourceToolStripMenuItem";
      this.setDatasourceToolStripMenuItem.Size = new Size(166, 24);
      this.setDatasourceToolStripMenuItem.Text = "S&et Datasource";
      this.setDatasourceToolStripMenuItem.Click += new EventHandler(this.setDatasourceToolStripMenuItem_Click);
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(166, 24);
      this.editToolStripMenuItem.Text = "&Edit Datasource";
      this.editToolStripMenuItem.Click += new EventHandler(this.editToolStripMenuItem_Click);
      this.createDatasourceToolStripMenuItem.Name = "createDatasourceToolStripMenuItem";
      this.createDatasourceToolStripMenuItem.Size = new Size(166, 24);
      this.createDatasourceToolStripMenuItem.Text = "&Create Datasource";
      this.createDatasourceToolStripMenuItem.Click += new EventHandler(this.createDatasourceToolStripMenuItem_Click);
      this.setItemSecurityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.addPermissionsForUserToolStripMenuItem
      });
      this.setItemSecurityToolStripMenuItem.Name = "setItemSecurityToolStripMenuItem";
      this.setItemSecurityToolStripMenuItem.Size = new Size(166, 24);
      this.setItemSecurityToolStripMenuItem.Text = "Security";
      this.addPermissionsForUserToolStripMenuItem.Name = "addPermissionsForUserToolStripMenuItem";
      this.addPermissionsForUserToolStripMenuItem.Size = new Size(332, 24);
      this.addPermissionsForUserToolStripMenuItem.Text = "Add permissions for \"My Reports\"-folders";
      this.addPermissionsForUserToolStripMenuItem.Click += new EventHandler(this.addPermissionsForUserToolStripMenuItem_Click);
      this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
      this.newFolderToolStripMenuItem.Size = new Size(166, 24);
      this.newFolderToolStripMenuItem.Text = "&New Folder";
      this.newFolderToolStripMenuItem.Click += new EventHandler(this.newFolderToolStripMenuItem_Click);
      this.toolStripMenuItemSep1.Name = "toolStripMenuItemSep1";
      this.toolStripMenuItemSep1.Size = new Size(163, 6);
      this.uploadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.filesToolStripMenuItem,
        (ToolStripItem) this.folderToolStripMenuItem
      });
      this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
      this.uploadToolStripMenuItem.Size = new Size(166, 24);
      this.uploadToolStripMenuItem.Text = "&Upload";
      this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
      this.filesToolStripMenuItem.Size = new Size(116, 24);
      this.filesToolStripMenuItem.Text = "File(s)";
      this.filesToolStripMenuItem.Click += new EventHandler(this.filesToolStripMenuItem_Click);
      this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
      this.folderToolStripMenuItem.Size = new Size(116, 24);
      this.folderToolStripMenuItem.Text = "Folder";
      this.folderToolStripMenuItem.Click += new EventHandler(this.folderToolStripMenuItem_Click);
      this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
      this.downloadToolStripMenuItem.Size = new Size(166, 24);
      this.downloadToolStripMenuItem.Text = "Do&wnload";
      this.downloadToolStripMenuItem.Click += new EventHandler(this.downloadToolStripMenuItem_Click);
      this.replaceModelToolStripMenuItem.Name = "replaceModelToolStripMenuItem";
      this.replaceModelToolStripMenuItem.Size = new Size(166, 24);
      this.replaceModelToolStripMenuItem.Text = "Replace model";
      this.replaceModelToolStripMenuItem.Click += new EventHandler(this.replaceModelToolStripMenuItem_Click);
      this.toolStripMenuItemSep2.Name = "toolStripMenuItemSep2";
      this.toolStripMenuItemSep2.Size = new Size(163, 6);
      this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
      this.propertiesToolStripMenuItem.Size = new Size(166, 24);
      this.propertiesToolStripMenuItem.Text = "&Properties";
      this.propertiesToolStripMenuItem.Click += new EventHandler(this.propertiesToolStripMenuItem_Click);
      this.btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnOK.Location = new Point(694, 428);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.lvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lvItems.ContextMenuStrip = this.contextMenuStrip;
      this.lvItems.Location = new Point(3, 3);
      this.lvItems.Name = "lvItems";
      this.lvItems.ShowItemToolTips = true;
      this.lvItems.Size = new Size(514, 405);
      this.lvItems.SmallImageList = this.imageList;
      this.lvItems.TabIndex = 2;
      this.lvItems.UseCompatibleStateImageBehavior = false;
      this.lvItems.View = View.List;
      this.lvItems.MouseDoubleClick += new MouseEventHandler(this.lvItems_MouseDoubleClick);
      this.splitContainer.Dock = DockStyle.Fill;
      this.splitContainer.Location = new Point(0, 0);
      this.splitContainer.Name = "splitContainer";
      this.splitContainer.Panel1.Controls.Add((Control) this.tvReportServer);
      this.splitContainer.Panel2.Controls.Add((Control) this.lvItems);
      this.splitContainer.Size = new Size(781, 410);
      this.splitContainer.SplitterDistance = 257;
      this.splitContainer.TabIndex = 3;
      this.statusStrip.Dock = DockStyle.None;
      this.statusStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripStatusLabel
      });
      this.statusStrip.Location = new Point(0, 0);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(781, 24);
      this.statusStrip.TabIndex = 3;
      this.statusStrip.Text = "statusStrip1";
      this.toolStripStatusLabel.AutoToolTip = true;
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new Size(99, 19);
      this.toolStripStatusLabel.Text = "Not connected";
      this.openFileDialog.DefaultExt = "rdl";
      this.openFileDialog.Filter = "Reports|*.rdl";
      this.openFileDialog.InitialDirectory = "C:\\";
      this.openFileDialog.Multiselect = true;
      this.openFileDialog.ShowReadOnly = true;
      this.menuStripMain.Dock = DockStyle.None;
      this.menuStripMain.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.helpToolStripMenuItem
      });
      this.menuStripMain.Location = new Point(0, 0);
      this.menuStripMain.Name = "menuStripMain";
      this.menuStripMain.Size = new Size(781, 27);
      this.menuStripMain.TabIndex = 4;
      this.menuStripMain.Text = "menuStrip1";
      this.toolStripMenuItem5.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.connectToolStripMenuItem,
        (ToolStripItem) this.settingsToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new Size(89, 23);
      this.toolStripMenuItem5.Text = "&Application";
      this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
      this.connectToolStripMenuItem.Size = new Size(152, 24);
      this.connectToolStripMenuItem.Text = "&Connect";
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new Size(152, 24);
      this.settingsToolStripMenuItem.Text = "&Servers...";
      this.settingsToolStripMenuItem.Click += new EventHandler(this.settingsToolStripMenuItem_Click);
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new Size(149, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(152, 24);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.toolStripContainer.BottomToolStripPanel.Controls.Add((Control) this.statusStrip);
      this.toolStripContainer.ContentPanel.Controls.Add((Control) this.splitContainer);
      this.toolStripContainer.ContentPanel.Size = new Size(781, 410);
      this.toolStripContainer.Dock = DockStyle.Fill;
      this.toolStripContainer.Location = new Point(0, 0);
      this.toolStripContainer.Name = "toolStripContainer";
      this.toolStripContainer.Size = new Size(781, 461);
      this.toolStripContainer.TabIndex = 4;
      this.toolStripContainer.Text = "toolStripContainer1";
      this.toolStripContainer.TopToolStripPanel.Controls.Add((Control) this.menuStripMain);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(781, 461);
      this.Controls.Add((Control) this.toolStripContainer);
      this.Controls.Add((Control) this.btnOK);
      this.MainMenuStrip = this.menuStripMain;
      this.Name = nameof (FormSSRSExplorer);
      this.Text = "SSRS Explorer ";
      this.Shown += new EventHandler(this.frmReportSelector_Shown);
      this.contextMenuStrip.ResumeLayout(false);
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.menuStripMain.ResumeLayout(false);
      this.menuStripMain.PerformLayout();
      this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer.ContentPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.PerformLayout();
      this.toolStripContainer.ResumeLayout(false);
      this.toolStripContainer.PerformLayout();
      this.ResumeLayout(false);
    }

    public FormSSRSExplorer()
    {
      this.InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmReportSelector_Shown(object sender, EventArgs e)
    {
      this.BuildConnectSubMenu();
    }

    private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
    {
      if (this.rs == null)
      {
        e.Cancel = true;
      }
      else
      {
        this.moveToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0;
        this.deleteToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0;
        this.toolStripMenuItemSep2.Visible = this.lvItems.SelectedItems.Count > 0;
        this.downloadToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag != ReportItemTypes.Datasource;
        this.renameToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count == 1;
        this.propertiesToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count == 1;
        this.newFolderToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count == 0;
        this.createDatasourceToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count == 0;
        this.uploadToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count == 0;
        this.setDatasourceToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag != ReportItemTypes.Datasource;
        this.editToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag == ReportItemTypes.Datasource;
        this.toolStripMenuItemSep1.Visible = this.toolStripMenuItemSep1.Visible && this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag != ReportItemTypes.Datasource;
        this.replaceModelToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag == ReportItemTypes.Model;
        this.setItemSecurityToolStripMenuItem.Visible = this.lvItems.SelectedItems.Count > 0 && (ReportItemTypes) this.lvItems.SelectedItems[0].Tag == ReportItemTypes.Folder;
      }
    }

    private void tvReportServer_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.rs == null)
        return;
      try
      {
        this.rs.PopulateItems(e.Node.ToolTipText);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      ListViewItem itemAt = this.lvItems.GetItemAt(e.X, e.Y);
      if (itemAt != null && (ReportItemTypes) itemAt.Tag == ReportItemTypes.Folder)
      {
        foreach (TreeNode parent in this.tvReportServer.Nodes.Find(itemAt.Text, true))
        {
          if (parent.ToolTipText == itemAt.ToolTipText)
          {
            try
            {
              this.tvReportServer.SelectedNode = parent;
              parent.Nodes.Clear();
              this.rs.ExpandNodeContent(parent, true);
              parent.Expand();
            }
            catch (Exception ex)
            {
              LogHandler.WriteLogEntry(ex);
            }
          }
        }
      }
    }

    private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.tvReportServer.SelectedNode == null)
        return;
      FormGetName formGetName = new FormGetName("Create new folder");
      if (formGetName.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if (formGetName.Name.Trim() == "")
            throw new Exception("Name cannot be blank");
          this.rs.CreateFolder(formGetName.Name, this.tvReportServer.SelectedNode);
          this.toolStripStatusLabel.Text = string.Format("Created folder '{0}'", (object) formGetName.Name);
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(string.Format("An error occured: {0}", (object) ex.Message));
          LogHandler.WriteLogEntry(ex);
        }
      }
      try
      {
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void filesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.openFileDialog.Filter = "Reports|*.rdl|Models|*.smdl";
      if (this.openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      bool overwrite = MessageBox.Show("Overwrite existing items?", "Upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
      this.Cursor = Cursors.WaitCursor;
      foreach (string fileName in this.openFileDialog.FileNames)
      {
        string toolTipText = this.tvReportServer.SelectedNode.ToolTipText;
        try
        {
          if (Path.GetExtension(fileName) == ".smdl")
            this.rs.CreateModel(fileName, toolTipText, overwrite);
          else
            this.rs.UploadReport(fileName, toolTipText, overwrite);
        }
        catch (Exception ex)
        {
          LogHandler.WriteLogEntry(ex);
        }
      }
      try
      {
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
      this.Cursor = Cursors.Default;
    }

    private void folderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormSelectFilesystemFolder filesystemFolder = new FormSelectFilesystemFolder();
      filesystemFolder.EnableCreateNewFolder = false;
      if (filesystemFolder.ShowDialog() != DialogResult.OK)
        return;
      bool overwrite = MessageBox.Show("Overwrite existing items?", "Upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
      this.Cursor = Cursors.WaitCursor;
      try
      {
        this.rs.UploadFolder(filesystemFolder.Foldername, this.tvReportServer.SelectedNode.ToolTipText, overwrite, this.tvReportServer.SelectedNode);
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
      this.Cursor = Cursors.Default;
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.Cursor = Cursors.WaitCursor;
      foreach (ListViewItem selectedItem in this.lvItems.SelectedItems)
      {
        try
        {
          this.rs.DeleteItem(selectedItem.ToolTipText);
        }
        catch (Exception ex)
        {
          LogHandler.WriteLogEntry(ex);
        }
        if ((ReportItemTypes) selectedItem.Tag == ReportItemTypes.Folder)
        {
          foreach (TreeNode node in this.tvReportServer.SelectedNode.Nodes)
          {
            if (node.ToolTipText == selectedItem.ToolTipText)
              this.tvReportServer.Nodes.Remove(node);
          }
        }
      }
      this.Cursor = Cursors.Default;
      this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
    }

    public static string GetItemName(string path)
    {
      string[] strArray = path.Split('/');
      return path.Split('/')[strArray.Length - 1];
    }

    public static string GetItemPath(string path, bool forFileSystem)
    {
      path = path.Substring(0, path.LastIndexOf("/"));
      return forFileSystem ? path.Replace("/", "\\") : path;
    }

    private void ShowSelectServer()
    {
      FormServers formServers = new FormServers();
      int num = (int) formServers.ShowDialog();
      if (formServers.DialogResult != DialogResult.Cancel)
        FormSSRSExplorer.SelectedServer = formServers.SelectedServer;
      this.BuildConnectSubMenu();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void settingsToolStripMenuItem_Click(object s, EventArgs e)
    {
      this.ShowSelectServer();
    }

    private void renameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormGetName formGetName = new FormGetName("Rename item");
      formGetName.Name = this.lvItems.SelectedItems[0].Text;
      if (formGetName.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.rs.MoveItem(this.lvItems.SelectedItems[0].ToolTipText, FormSSRSExplorer.GetItemPath(this.lvItems.SelectedItems[0].ToolTipText, false) + "/" + formGetName.Name, (ReportItemTypes) this.lvItems.SelectedItems[0].Tag);
        this.toolStripStatusLabel.Text = string.Format("Renamed item '{0}' to '{1}'", (object) this.lvItems.SelectedItems[0].Text, (object) (FormSSRSExplorer.GetItemPath(this.lvItems.SelectedItems[0].ToolTipText, false) + "/" + formGetName.Name));
        if ((ReportItemTypes) this.lvItems.SelectedItems[0].Tag == ReportItemTypes.Folder)
          this.rs.PopulateTreeView(FormSSRSExplorer.SelectedServer.Alias);
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("An error has occured: {0}", (object) ex.Message));
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new FormProperties(this.lvItems.SelectedItems[0].ToolTipText, (ReportItemTypes) this.lvItems.SelectedItems[0].Tag).ShowDialog();
    }

    private void setDatasourceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormSSRSSItemSelector ssrssItemSelector = new FormSSRSSItemSelector(ViewItems.Datasources);
      if (ssrssItemSelector.ShowDialog() != DialogResult.OK || ssrssItemSelector.SelectedItemPath == null)
        return;
      foreach (ListViewItem selectedItem in this.lvItems.SelectedItems)
      {
        try
        {
          this.rs.SetDatasource(selectedItem.ToolTipText, ssrssItemSelector.SelectedItemPath, (ReportItemTypes) selectedItem.Tag);
        }
        catch (Exception ex)
        {
          LogHandler.WriteLogEntry(ex);
        }
      }
    }

    private void moveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormSSRSSItemSelector ssrssItemSelector = new FormSSRSSItemSelector(ViewItems.Folders);
      if (ssrssItemSelector.ShowDialog() != DialogResult.OK || ssrssItemSelector.SelectedItemPath == null)
        return;
      this.Cursor = Cursors.WaitCursor;
      foreach (ListViewItem selectedItem in this.lvItems.SelectedItems)
      {
        try
        {
          this.rs.MoveItem(selectedItem.ToolTipText, ssrssItemSelector.SelectedItemPath.Trim('/') + "/" + selectedItem.Text, (ReportItemTypes) selectedItem.Tag);
          this.toolStripStatusLabel.Text = string.Format("Moved item '{0}' to {1}", (object) selectedItem.Text, (object) ssrssItemSelector.SelectedItemPath);
          Application.DoEvents();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(string.Format("An error has occured: {0}", (object) ex.Message));
          LogHandler.WriteLogEntry(ex);
        }
      }
      try
      {
        this.rs.PopulateTreeView(FormSSRSExplorer.SelectedServer.Alias);
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
      this.Cursor = Cursors.Default;
    }

    private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormSelectFilesystemFolder filesystemFolder = new FormSelectFilesystemFolder();
      if (filesystemFolder.ShowDialog() != DialogResult.OK)
        return;
      bool flag = false;
      foreach (ListViewItem selectedItem in this.lvItems.SelectedItems)
      {
        if ((ReportItemTypes) selectedItem.Tag == ReportItemTypes.Folder)
        {
          flag = true;
          break;
        }
      }
      bool preserveFolders = flag && MessageBox.Show("Preserve folders?", "Download items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
      if (!Directory.Exists(filesystemFolder.Foldername))
        Directory.CreateDirectory(filesystemFolder.Foldername);
      this.Cursor = Cursors.WaitCursor;
      foreach (ListViewItem selectedItem in this.lvItems.SelectedItems)
      {
        try
        {
          this.rs.DownloadItem(selectedItem.ToolTipText, filesystemFolder.Foldername, (ReportItemTypes) selectedItem.Tag, preserveFolders);
        }
        catch (Exception ex)
        {
          LogHandler.WriteLogEntry(ex);
        }
      }
      this.Cursor = Cursors.Default;
    }

    private void BuildConnectSubMenu()
    {
      this.serverCollection = ServerRegistry.GetServerSettings();
      this.connectToolStripMenuItem.DropDownItems.Clear();
      foreach (ServerSettingsConfigElement server in (ConfigurationElementCollection) this.serverCollection)
        this.connectToolStripMenuItem.DropDownItems.Add((ToolStripItem) new ToolStripMenuItem(server.Alias, (Image) null, new EventHandler(this.connectToolStripMenuItem_Click)));
    }

    private void connectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormSSRSExplorer.SelectedServer = this.serverCollection.Get(((ToolStripItem) sender).Text);
      this.Connect();
      FormSetPolicy formSetPolicy = new FormSetPolicy();
    }

    private void Connect()
    {
      if (FormSSRSExplorer.SelectedServer != null)
      {
        if (string.IsNullOrEmpty(FormSSRSExplorer.SelectedServer.Url))
        {
          this.ShowSelectServer();
        }
        else
        {
          try
          {
            this.rs = ReportingServicesFactory.CreateFromSettings(FormSSRSExplorer.SelectedServer, this.tvReportServer, this.toolStripStatusLabel, this.lvItems);
          }
          catch (Exception ex)
          {
            LogHandler.WriteLogEntry(ex);
          }
        }
        try
        {
          this.rs.PopulateTreeView(FormSSRSExplorer.SelectedServer.Alias);
          this.toolStripStatusLabel.Text = string.Format("Connected to {0}", (object) FormSSRSExplorer.SelectedServer.Url);
          this.Text = "SSRS Explorer - connected to " + FormSSRSExplorer.SelectedServer.Alias;
        }
        catch (Exception ex)
        {
          this.Text = "SSRS Explorer - not connected";
          this.toolStripStatusLabel.Text = "Not connected";
          int num = (int) MessageBox.Show("Cannot connect. Check server settings.", "Initialisation failed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.rs = (Controller) null;
          LogHandler.WriteLogEntry(string.Format("Error connecting to {0}:", (object) FormSSRSExplorer.SelectedServer.Url));
          LogHandler.WriteLogEntry(ex);
        }
      }
      else
        this.ShowSelectServer();
    }

    private void createDatasourceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormDatasource formDatasource = new FormDatasource();
      formDatasource.Extensions = this.rs.GetDataExtensions();
      if (formDatasource.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.rs.CreateDataSource(formDatasource.Datasource, this.tvReportServer.SelectedNode.ToolTipText);
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("An error has occured: {0}", (object) ex.Message));
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormDatasource formDatasource = new FormDatasource();
      formDatasource.Extensions = this.rs.GetDataExtensions();
      Datasource datasource = this.rs.GetDatasource(this.lvItems.SelectedItems[0].ToolTipText);
      datasource.Name = this.lvItems.SelectedItems[0].Text;
      formDatasource.Datasource = datasource;
      if (formDatasource.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.rs.CreateDataSource(formDatasource.Datasource, this.tvReportServer.SelectedNode.ToolTipText);
        this.rs.PopulateItems(this.tvReportServer.SelectedNode.ToolTipText);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("An error has occured: {0}", (object) ex.Message));
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void replaceModelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.openFileDialog.FileName = "";
      this.openFileDialog.Filter = "Models|*.smdl";
      int num1 = (int) this.openFileDialog.ShowDialog();
      string fileName = this.openFileDialog.FileName;
      if (!(fileName != string.Empty))
        return;
      string toolTipText = this.lvItems.SelectedItems[0].ToolTipText;
      string newModelSMDL = File.ReadAllText(fileName);
      if (MessageBox.Show("Do you want to perform a compatibility check before replacing?", "Perform compatibility check?", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        int num2 = (int) new FormDependantItems(this.rs, toolTipText, newModelSMDL).ShowDialog();
      }
      if (MessageBox.Show("Do you want to replace the existing model?", "Replace model", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        try
        {
          this.rs.ReplaceModel(fileName, toolTipText);
        }
        catch (Exception ex)
        {
          LogHandler.WriteLogEntry(ex);
        }
      }
    }

    private void addPermissionsForUserToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.rs.AddPolicyForMyReports(this.lvItems.SelectedItems[0].ToolTipText, this.lvItems.SelectedItems[0].Text, (IFormSetPolicy) new FormSetPolicy());
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
    }
  }
}


// Type: RSS_Report_Retrievers.FormSSRSSItemSelector


using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RSSReportRetrievers.Model;
using RSSReportRetrievers.Services;

namespace RSS_Report_Retrievers
{
  public class FormSSRSSItemSelector : Form
  {
    private IContainer components = (IContainer) null;
    private ViewItems viewItem = ViewItems.Folders;
    private TreeView tvReportServer;
    private Button btnCancel;
    private Button btnOK;
    private ImageList imageList;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSSRSSItemSelector));
      this.tvReportServer = new TreeView();
      this.imageList = new ImageList(this.components);
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.SuspendLayout();
      this.tvReportServer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tvReportServer.ImageIndex = 2;
      this.tvReportServer.ImageList = this.imageList;
      this.tvReportServer.Location = new Point(4, 1);
      this.tvReportServer.Margin = new Padding(4, 4, 4, 4);
      this.tvReportServer.Name = "tvReportServer";
      this.tvReportServer.SelectedImageIndex = 3;
      this.tvReportServer.Size = new Size(365, 293);
      this.tvReportServer.TabIndex = 0;
      this.tvReportServer.MouseDoubleClick += new MouseEventHandler(this.tvReportServer_MouseDoubleClick);
      this.imageList.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList.ImageStream");
      this.imageList.TransparentColor = Color.Transparent;
      this.imageList.Images.SetKeyName(0, "16datasource.gif");
      this.imageList.Images.SetKeyName(1, "16doc.gif");
      this.imageList.Images.SetKeyName(2, "16fold.gif");
      this.imageList.Images.SetKeyName(3, "folderopen.gif");
      this.imageList.Images.SetKeyName(4, "model.png");
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(272, 303);
      this.btnCancel.Margin = new Padding(4, 4, 4, 4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(100, 28);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(164, 303);
      this.btnOK.Margin = new Padding(4, 4, 4, 4);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(100, 28);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(373, 352);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.tvReportServer);
      this.Margin = new Padding(4, 4, 4, 4);
      this.Name = nameof (FormSSRSSItemSelector);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "ReportServer Item Picker";
      this.Load += new EventHandler(this.frmSSRSSExplorer_Load);
      this.Shown += new EventHandler(this.frmSSRSSExplorer_Shown);
      this.FormClosing += new FormClosingEventHandler(this.frmSSRSSExplorer_FormClosing);
      this.ResumeLayout(false);
    }

    public string SelectedItemPath
    {
      get
      {
        return this.tvReportServer.SelectedNode == null ? (string) null : this.tvReportServer.SelectedNode.ToolTipText;
      }
    }

    public FormSSRSSItemSelector(ViewItems viewItems)
    {
      this.InitializeComponent();
      this.viewItem = viewItems;
      try
      {
        this.rs = ReportingServicesFactory.CreateFromSettings(FormSSRSExplorer.SelectedServer, this.tvReportServer, (ToolStripStatusLabel) null, (ListView) null);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
      this.rs.ViewItem = this.viewItem;
    }

    private void frmSSRSSExplorer_Shown(object sender, EventArgs e)
    {
      try
      {
        this.rs.PopulateTreeView(FormSSRSExplorer.SelectedServer.Alias);
      }
      catch (Exception ex)
      {
        LogHandler.WriteLogEntry(ex);
      }
    }

    private void tvReportServer_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left || this.tvReportServer.GetNodeAt(e.Location) == null)
        return;
      this.tvReportServer.SelectedNode = this.tvReportServer.GetNodeAt(e.Location);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void frmSSRSSExplorer_FormClosing(object sender, FormClosingEventArgs e)
    {
      if ((sender as FormSSRSSItemSelector).DialogResult != DialogResult.OK)
        return;
      if (this.tvReportServer.SelectedNode == null)
      {
        int num = (int) MessageBox.Show(string.Format("Please select a {0}.", this.viewItem == ViewItems.Folders ? (object) "folder" : (object) "datasource"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
      else if (this.viewItem == ViewItems.Datasources && (ReportItemTypes) this.tvReportServer.SelectedNode.Tag != ReportItemTypes.Datasource && (ReportItemTypes) this.tvReportServer.SelectedNode.Tag != ReportItemTypes.Model)
      {
        int num = (int) MessageBox.Show("Please select a datasource.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
      else if (this.viewItem == ViewItems.Folders && (ReportItemTypes) this.tvReportServer.SelectedNode.Tag != ReportItemTypes.Folder)
      {
        int num = (int) MessageBox.Show("Please select a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        e.Cancel = true;
      }
    }

    private void frmSSRSSExplorer_Load(object sender, EventArgs e)
    {
      this.Text = this.viewItem == ViewItems.Folders ? "Select a folder" : "Select a datasource";
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
    }
  }
}

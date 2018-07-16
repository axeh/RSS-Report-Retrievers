
// Type: RSS_Report_Retrievers.FormSelectFilesystemFolder




using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RSS_Report_Retrievers
{
  public class FormSelectFilesystemFolder : Form
  {
    private IContainer components = (IContainer) null;
    private Button btnCancel;
    private TextBox txtFoldername;
    private Button btnOK;
    private FolderBrowserDialog folderBrowserDialog;
    private Button btnSelectFolder;

    public FormSelectFilesystemFolder()
    {
      this.InitializeComponent();
    }

    public string Foldername
    {
      get
      {
        return this.txtFoldername.Text;
      }
    }

    public bool EnableCreateNewFolder
    {
      set
      {
        this.folderBrowserDialog.ShowNewFolderButton = value;
      }
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      this.folderBrowserDialog.SelectedPath = this.txtFoldername.Text == "" ? "C:\\" : this.txtFoldername.Text;
      if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtFoldername.Text = this.folderBrowserDialog.SelectedPath;
    }

    private void frmSelectFilesystemFolder_Load(object sender, EventArgs e)
    {
      this.txtFoldername.Text = "C:\\";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnCancel = new Button();
      this.txtFoldername = new TextBox();
      this.btnOK = new Button();
      this.folderBrowserDialog = new FolderBrowserDialog();
      this.btnSelectFolder = new Button();
      this.SuspendLayout();
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(134, 48);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.txtFoldername.Location = new Point(10, 10);
      this.txtFoldername.Name = "txtFoldername";
      this.txtFoldername.Size = new Size(251, 20);
      this.txtFoldername.TabIndex = 0;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(215, 48);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
      this.btnSelectFolder.Location = new Point(267, 8);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new Size(23, 23);
      this.btnSelectFolder.TabIndex = 1;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new EventHandler(this.btnSelectFolder_Click);
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(298, 84);
      this.Controls.Add((Control) this.btnSelectFolder);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.txtFoldername);
      this.Controls.Add((Control) this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = "frmSelectFilesystemFolder";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select folder";
      this.Load += new EventHandler(this.frmSelectFilesystemFolder_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

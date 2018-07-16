
// Type: RSS_Report_Retrievers.FormSettings


using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RSSReportRetrievers.Model;

namespace RSS_Report_Retrievers
{
  public class FormSettings : Form
  {
    private ServerSettingsConfigElement currentSetting = (ServerSettingsConfigElement) null;
    private IContainer components = (IContainer) null;
    private const string WS2000_SUFFIX = "ReportService.asmx";
    private const string WS2005or2008_SUFFIX = "ReportService2005.asmx";
    private const string WS2005_SHAREPOINT_SUFFIX = "ReportService2006.asmx";
    private const string WS2005_SHAREPOINT_DOCLIB_URL = "http://server/SiteDirectory/Rapportage/Rapporten";
    private GroupBox groupBox1;
    private Label lblDomain;
    private TextBox txtDomain;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblPassword;
    private TextBox txtPassword;
    private CheckBox chkWindowsAuthentication;
    private Label lblURL;
    private TextBox txtURL;
    private Button btnSave;
    private CheckBox chkSharePointMode;
    private Label lblReportLibrary;
    private TextBox txtReportLibrary;
    private Button btnCancel;
    private BindingSource bsServerSettings;
    private TextBox txtAlias;
    private Label label1;
    private RadioButton rbSQL2005or2008;
    private RadioButton rbSQL2000;

    public ServerSettingsConfigElement CurrentSetting
    {
      get
      {
        return this.currentSetting;
      }
      set
      {
        this.currentSetting = value;
      }
    }

    public FormSettings()
    {
      this.InitializeComponent();
    }

    public FormSettings(bool lockAliasTextfield)
      : this()
    {
      this.txtAlias.Enabled = !lockAliasTextfield;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void chkWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
    {
      this.SetControlState();
    }

    private void SetControlState()
    {
      this.bsServerSettings.DataSource = (object) this.CurrentSetting;
      this.txtDomain.Enabled = !this.chkWindowsAuthentication.Checked;
      this.txtUsername.Enabled = !this.chkWindowsAuthentication.Checked;
      this.txtPassword.Enabled = !this.chkWindowsAuthentication.Checked;
    }

    private void frmSettings_Load(object sender, EventArgs e)
    {
      this.SetControlState();
      this.txtReportLibrary.Enabled = this.chkSharePointMode.Checked;
    }

    private void chkSharePointMode_CheckedChanged(object sender, EventArgs e)
    {
      this.txtReportLibrary.Enabled = this.chkSharePointMode.Checked;
      if (this.chkSharePointMode.Checked)
        this.ChangeWSSuffix("ReportService2006.asmx");
      else
        this.ChangeWSSuffix("ReportService2005.asmx");
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void ChangeWSSuffix(string newURLEnding)
    {
      int length = this.txtURL.Text.LastIndexOf('/');
      if (length <= 0)
        return;
      this.txtURL.Text = this.txtURL.Text.Substring(0, length) + "/" + newURLEnding;
    }

    private void ShowSharePointDocLibDetails(bool isVisible)
    {
      this.chkSharePointMode.Enabled = isVisible;
      this.txtReportLibrary.Enabled = isVisible;
    }

    private void chkSharePointMode_Click(object sender, EventArgs e)
    {
      this.ChangeWSSuffix("http://server/SiteDirectory/Rapportage/Rapporten");
    }

    private void rbSQL2000_Click(object sender, EventArgs e)
    {
      this.ShowSharePointDocLibDetails(false);
      this.ChangeWSSuffix("ReportService.asmx");
    }

    private void rbSQL2005or2008_Click(object sender, EventArgs e)
    {
      this.ShowSharePointDocLibDetails(true);
      this.ChangeWSSuffix("ReportService2005.asmx");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.groupBox1 = new GroupBox();
      this.txtAlias = new TextBox();
      this.label1 = new Label();
      this.lblReportLibrary = new Label();
      this.txtReportLibrary = new TextBox();
      this.chkSharePointMode = new CheckBox();
      this.lblDomain = new Label();
      this.txtDomain = new TextBox();
      this.lblUsername = new Label();
      this.txtUsername = new TextBox();
      this.lblPassword = new Label();
      this.txtPassword = new TextBox();
      this.chkWindowsAuthentication = new CheckBox();
      this.lblURL = new Label();
      this.txtURL = new TextBox();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      this.rbSQL2000 = new RadioButton();
      this.rbSQL2005or2008 = new RadioButton();
      this.bsServerSettings = new BindingSource(this.components);
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.bsServerSettings).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.rbSQL2005or2008);
      this.groupBox1.Controls.Add((Control) this.rbSQL2000);
      this.groupBox1.Controls.Add((Control) this.txtAlias);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.lblReportLibrary);
      this.groupBox1.Controls.Add((Control) this.txtReportLibrary);
      this.groupBox1.Controls.Add((Control) this.chkSharePointMode);
      this.groupBox1.Controls.Add((Control) this.lblDomain);
      this.groupBox1.Controls.Add((Control) this.txtDomain);
      this.groupBox1.Controls.Add((Control) this.lblUsername);
      this.groupBox1.Controls.Add((Control) this.txtUsername);
      this.groupBox1.Controls.Add((Control) this.lblPassword);
      this.groupBox1.Controls.Add((Control) this.txtPassword);
      this.groupBox1.Controls.Add((Control) this.chkWindowsAuthentication);
      this.groupBox1.Controls.Add((Control) this.lblURL);
      this.groupBox1.Controls.Add((Control) this.txtURL);
      this.groupBox1.Location = new Point(12, 4);
      this.groupBox1.Margin = new Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(4);
      this.groupBox1.Size = new Size(727, 428);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtAlias.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "Alias", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtAlias.Location = new Point(23, 35);
      this.txtAlias.Name = "txtAlias";
      this.txtAlias.Size = new Size(100, 22);
      this.txtAlias.TabIndex = 33;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(20, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(43, 17);
      this.label1.TabIndex = 32;
      this.label1.Text = "Alias";
      this.lblReportLibrary.AutoSize = true;
      this.lblReportLibrary.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblReportLibrary.Location = new Point(53, 178);
      this.lblReportLibrary.Margin = new Padding(4, 0, 4, 0);
      this.lblReportLibrary.Name = "lblReportLibrary";
      this.lblReportLibrary.Size = new Size(113, 17);
      this.lblReportLibrary.TabIndex = 31;
      this.lblReportLibrary.Text = "Report Library";
      this.txtReportLibrary.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "ReportLibrary", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtReportLibrary.Enabled = false;
      this.txtReportLibrary.Location = new Point(174, 175);
      this.txtReportLibrary.Margin = new Padding(4);
      this.txtReportLibrary.Name = "txtReportLibrary";
      this.txtReportLibrary.Size = new Size(277, 22);
      this.txtReportLibrary.TabIndex = 30;
      this.chkSharePointMode.AutoSize = true;
      this.chkSharePointMode.DataBindings.Add(new Binding("Checked", (object) this.bsServerSettings, "IsSharePointMode", true, DataSourceUpdateMode.OnPropertyChanged));
      this.chkSharePointMode.Location = new Point(23, 142);
      this.chkSharePointMode.Margin = new Padding(4);
      this.chkSharePointMode.Name = "chkSharePointMode";
      this.chkSharePointMode.Size = new Size(404, 21);
      this.chkSharePointMode.TabIndex = 29;
      this.chkSharePointMode.Text = "This instance is configured for SharePoint Integration Mode";
      this.chkSharePointMode.UseVisualStyleBackColor = true;
      this.chkSharePointMode.Click += new EventHandler(this.chkSharePointMode_Click);
      this.chkSharePointMode.CheckedChanged += new EventHandler(this.chkSharePointMode_CheckedChanged);
      this.lblDomain.AutoSize = true;
      this.lblDomain.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDomain.Location = new Point(55, 280);
      this.lblDomain.Margin = new Padding(4, 0, 4, 0);
      this.lblDomain.Name = "lblDomain";
      this.lblDomain.Size = new Size(62, 17);
      this.lblDomain.TabIndex = 28;
      this.lblDomain.Text = "Domain";
      this.txtDomain.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "WindowsDomain", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtDomain.Enabled = false;
      this.txtDomain.Location = new Point(174, 275);
      this.txtDomain.Margin = new Padding(4);
      this.txtDomain.Name = "txtDomain";
      this.txtDomain.Size = new Size(160, 22);
      this.txtDomain.TabIndex = 5;
      this.lblUsername.AutoSize = true;
      this.lblUsername.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblUsername.Location = new Point(53, 314);
      this.lblUsername.Margin = new Padding(4, 0, 4, 0);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new Size(81, 17);
      this.lblUsername.TabIndex = 27;
      this.lblUsername.Text = "Username";
      this.txtUsername.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "WindowsUsername", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtUsername.Enabled = false;
      this.txtUsername.Location = new Point(174, 308);
      this.txtUsername.Margin = new Padding(4);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(160, 22);
      this.txtUsername.TabIndex = 6;
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblPassword.Location = new Point(53, 346);
      this.lblPassword.Margin = new Padding(4, 0, 4, 0);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new Size(77, 17);
      this.lblPassword.TabIndex = 26;
      this.lblPassword.Text = "Password";
      this.txtPassword.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "WindowsPwd", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtPassword.Enabled = false;
      this.txtPassword.Location = new Point(174, 340);
      this.txtPassword.Margin = new Padding(4);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new Size(160, 22);
      this.txtPassword.TabIndex = 7;
      this.chkWindowsAuthentication.AutoSize = true;
      this.chkWindowsAuthentication.DataBindings.Add(new Binding("Checked", (object) this.bsServerSettings, "UseWindowsAuth", true, DataSourceUpdateMode.OnPropertyChanged));
      this.chkWindowsAuthentication.Location = new Point(23, (int) byte.MaxValue);
      this.chkWindowsAuthentication.Margin = new Padding(4);
      this.chkWindowsAuthentication.Name = "chkWindowsAuthentication";
      this.chkWindowsAuthentication.Size = new Size(204, 21);
      this.chkWindowsAuthentication.TabIndex = 21;
      this.chkWindowsAuthentication.Text = "Use windows authentication";
      this.chkWindowsAuthentication.UseVisualStyleBackColor = true;
      this.chkWindowsAuthentication.CheckedChanged += new EventHandler(this.chkWindowsAuthentication_CheckedChanged);
      this.lblURL.AutoSize = true;
      this.lblURL.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblURL.Location = new Point(20, 80);
      this.lblURL.Margin = new Padding(4, 0, 4, 0);
      this.lblURL.Name = "lblURL";
      this.lblURL.Size = new Size(277, 17);
      this.lblURL.TabIndex = 25;
      this.lblURL.Text = "URL to  Reporting Server webservice";
      this.txtURL.DataBindings.Add(new Binding("Text", (object) this.bsServerSettings, "Url", true, DataSourceUpdateMode.OnPropertyChanged));
      this.txtURL.Location = new Point(23, 99);
      this.txtURL.Margin = new Padding(4);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new Size(428, 22);
      this.txtURL.TabIndex = 4;
      this.txtURL.Text = "http://localhost/ReportServer/ReportService2005.asmx";
      this.btnSave.DialogResult = DialogResult.OK;
      this.btnSave.Location = new Point(648, 440);
      this.btnSave.Margin = new Padding(4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(100, 28);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(540, 440);
      this.btnCancel.Margin = new Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(100, 28);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.rbSQL2000.DataBindings.Add(new Binding("Checked", (object) this.bsServerSettings, "IsSQL2000", true, DataSourceUpdateMode.OnPropertyChanged));
      this.rbSQL2000.AutoSize = true;
      this.rbSQL2000.Location = new Point(205, 40);
      this.rbSQL2000.Name = "rbSQL2000";
      this.rbSQL2000.Size = new Size(93, 21);
      this.rbSQL2000.TabIndex = 34;
      this.rbSQL2000.Text = "SQL 2000";
      this.rbSQL2000.UseVisualStyleBackColor = true;
      this.rbSQL2000.Click += new EventHandler(this.rbSQL2000_Click);
      this.rbSQL2005or2008.AutoSize = true;
      this.rbSQL2005or2008.Checked = true;
      this.rbSQL2005or2008.Location = new Point(205, 13);
      this.rbSQL2005or2008.Name = "rbSQL2005or2008";
      this.rbSQL2005or2008.Size = new Size(129, 21);
      this.rbSQL2005or2008.TabIndex = 35;
      this.rbSQL2005or2008.TabStop = true;
      this.rbSQL2005or2008.Text = "SQL 2005/2008";
      this.rbSQL2005or2008.UseVisualStyleBackColor = true;
      this.rbSQL2005or2008.Click += new EventHandler(this.rbSQL2005or2008_Click);
      this.bsServerSettings.AllowNew = false;
      this.bsServerSettings.DataSource = (object) typeof (ServerSettingsConfigElement);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(761, 515);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Margin = new Padding(4);
      this.Name = nameof (FormSettings);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Settings";
      this.Load += new EventHandler(this.frmSettings_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.bsServerSettings).EndInit();
      this.ResumeLayout(false);
    }
  }
}

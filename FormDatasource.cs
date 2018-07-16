
// Type: RSS_Report_Retrievers.FormDatasource


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RSSReportRetrievers.Model;

namespace RSS_Report_Retrievers
{
  public class FormDatasource : Form
  {
    private IContainer components = (IContainer) null;
    private Datasource datasource = new Datasource();
    private Label lblName;
    private TextBox txtName;
    private Label lblConnStr;
    private TextBox txtConnStr;
    private ComboBox cmbExtensions;
    private Label label1;
    private CheckBox chkEnabled;
    private Button btnOK;
    private Button btnCancel;
    private RadioButton radWindowsAuthentication;
    private RadioButton radPrompt;
    private RadioButton radStored;
    private RadioButton radNone;
    private CheckBox chkUsePromptedCredentialsAsWindowsCredentials;
    private TextBox txtCredentialsPrompt;
    private TextBox txtUsername;
    private Label label3;
    private TextBox txtPassword;
    private Label label2;
    private CheckBox chkExecutionContext;
    private CheckBox chkUseStoredCredentialsAsWindowsCredentials;
    private List<DatasourceExtension> extensions;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblName = new Label();
      this.txtName = new TextBox();
      this.lblConnStr = new Label();
      this.txtConnStr = new TextBox();
      this.cmbExtensions = new ComboBox();
      this.label1 = new Label();
      this.chkEnabled = new CheckBox();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.radWindowsAuthentication = new RadioButton();
      this.radPrompt = new RadioButton();
      this.radStored = new RadioButton();
      this.radNone = new RadioButton();
      this.chkUsePromptedCredentialsAsWindowsCredentials = new CheckBox();
      this.txtCredentialsPrompt = new TextBox();
      this.txtUsername = new TextBox();
      this.label3 = new Label();
      this.txtPassword = new TextBox();
      this.label2 = new Label();
      this.chkExecutionContext = new CheckBox();
      this.chkUseStoredCredentialsAsWindowsCredentials = new CheckBox();
      this.SuspendLayout();
      this.lblName.AutoSize = true;
      this.lblName.Location = new Point(12, 8);
      this.lblName.Name = "lblName";
      this.lblName.Size = new Size(35, 13);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Name";
      this.txtName.Location = new Point(15, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(341, 20);
      this.txtName.TabIndex = 1;
      this.lblConnStr.AutoSize = true;
      this.lblConnStr.Location = new Point(9, 99);
      this.lblConnStr.Name = "lblConnStr";
      this.lblConnStr.Size = new Size(89, 13);
      this.lblConnStr.TabIndex = 2;
      this.lblConnStr.Text = "Connection string";
      this.txtConnStr.Location = new Point(12, 115);
      this.txtConnStr.Multiline = true;
      this.txtConnStr.Name = "txtConnStr";
      this.txtConnStr.Size = new Size(344, 82);
      this.txtConnStr.TabIndex = 3;
      this.cmbExtensions.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbExtensions.FormattingEnabled = true;
      this.cmbExtensions.Location = new Point(15, 69);
      this.cmbExtensions.Name = "cmbExtensions";
      this.cmbExtensions.Size = new Size(341, 21);
      this.cmbExtensions.TabIndex = 4;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 53);
      this.label1.Name = "label1";
      this.label1.Size = new Size(67, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Data Source";
      this.chkEnabled.AutoSize = true;
      this.chkEnabled.Checked = true;
      this.chkEnabled.CheckState = CheckState.Checked;
      this.chkEnabled.Location = new Point(12, 480);
      this.chkEnabled.Name = "chkEnabled";
      this.chkEnabled.Size = new Size(65, 17);
      this.chkEnabled.TabIndex = 6;
      this.chkEnabled.Text = "Enabled";
      this.chkEnabled.UseVisualStyleBackColor = true;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(188, 508);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(281, 507);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.radWindowsAuthentication.AutoSize = true;
      this.radWindowsAuthentication.Checked = true;
      this.radWindowsAuthentication.Location = new Point(12, 203);
      this.radWindowsAuthentication.Name = "radWindowsAuthentication";
      this.radWindowsAuthentication.Size = new Size(139, 17);
      this.radWindowsAuthentication.TabIndex = 10;
      this.radWindowsAuthentication.TabStop = true;
      this.radWindowsAuthentication.Text = "Windows authentication";
      this.radWindowsAuthentication.UseVisualStyleBackColor = true;
      this.radWindowsAuthentication.CheckedChanged += new EventHandler(this.radAuthentication_CheckedChanged);
      this.radPrompt.AutoSize = true;
      this.radPrompt.Location = new Point(12, 226);
      this.radPrompt.Name = "radPrompt";
      this.radPrompt.Size = new Size((int) sbyte.MaxValue, 17);
      this.radPrompt.TabIndex = 11;
      this.radPrompt.Text = "Prompt for credentials";
      this.radPrompt.UseVisualStyleBackColor = true;
      this.radPrompt.CheckedChanged += new EventHandler(this.radAuthentication_CheckedChanged);
      this.radStored.AutoSize = true;
      this.radStored.Location = new Point(12, 299);
      this.radStored.Name = "radStored";
      this.radStored.Size = new Size(110, 17);
      this.radStored.TabIndex = 12;
      this.radStored.Text = "Stored credentials";
      this.radStored.UseVisualStyleBackColor = true;
      this.radStored.CheckedChanged += new EventHandler(this.radAuthentication_CheckedChanged);
      this.radNone.AutoSize = true;
      this.radNone.Location = new Point(12, 445);
      this.radNone.Name = "radNone";
      this.radNone.Size = new Size(93, 17);
      this.radNone.TabIndex = 13;
      this.radNone.Text = "No credentials";
      this.radNone.UseVisualStyleBackColor = true;
      this.radNone.CheckedChanged += new EventHandler(this.radAuthentication_CheckedChanged);
      this.chkUsePromptedCredentialsAsWindowsCredentials.AutoSize = true;
      this.chkUsePromptedCredentialsAsWindowsCredentials.Enabled = false;
      this.chkUsePromptedCredentialsAsWindowsCredentials.Location = new Point(33, 249);
      this.chkUsePromptedCredentialsAsWindowsCredentials.Name = "chkUsePromptedCredentialsAsWindowsCredentials";
      this.chkUsePromptedCredentialsAsWindowsCredentials.Size = new Size(157, 17);
      this.chkUsePromptedCredentialsAsWindowsCredentials.TabIndex = 14;
      this.chkUsePromptedCredentialsAsWindowsCredentials.Text = "Use as windows credentials";
      this.chkUsePromptedCredentialsAsWindowsCredentials.UseVisualStyleBackColor = true;
      this.txtCredentialsPrompt.Enabled = false;
      this.txtCredentialsPrompt.Location = new Point(33, 273);
      this.txtCredentialsPrompt.Name = "txtCredentialsPrompt";
      this.txtCredentialsPrompt.Size = new Size(323, 20);
      this.txtCredentialsPrompt.TabIndex = 15;
      this.txtUsername.Enabled = false;
      this.txtUsername.Location = new Point(33, 334);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(323, 20);
      this.txtUsername.TabIndex = 17;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(30, 318);
      this.label3.Name = "label3";
      this.label3.Size = new Size(55, 13);
      this.label3.TabIndex = 16;
      this.label3.Text = "Username";
      this.txtPassword.Enabled = false;
      this.txtPassword.Location = new Point(33, 376);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new Size(323, 20);
      this.txtPassword.TabIndex = 19;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(30, 360);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Password";
      this.chkExecutionContext.AutoSize = true;
      this.chkExecutionContext.Enabled = false;
      this.chkExecutionContext.Location = new Point(33, 422);
      this.chkExecutionContext.Name = "chkExecutionContext";
      this.chkExecutionContext.Size = new Size(202, 17);
      this.chkExecutionContext.TabIndex = 21;
      this.chkExecutionContext.Text = "Set execution context to this account";
      this.chkExecutionContext.UseVisualStyleBackColor = true;
      this.chkUseStoredCredentialsAsWindowsCredentials.AutoSize = true;
      this.chkUseStoredCredentialsAsWindowsCredentials.Enabled = false;
      this.chkUseStoredCredentialsAsWindowsCredentials.Location = new Point(33, 399);
      this.chkUseStoredCredentialsAsWindowsCredentials.Name = "chkUseStoredCredentialsAsWindowsCredentials";
      this.chkUseStoredCredentialsAsWindowsCredentials.Size = new Size(157, 17);
      this.chkUseStoredCredentialsAsWindowsCredentials.TabIndex = 20;
      this.chkUseStoredCredentialsAsWindowsCredentials.Text = "Use as windows credentials";
      this.chkUseStoredCredentialsAsWindowsCredentials.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(368, 542);
      this.Controls.Add((Control) this.chkExecutionContext);
      this.Controls.Add((Control) this.chkUseStoredCredentialsAsWindowsCredentials);
      this.Controls.Add((Control) this.txtPassword);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtUsername);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.txtCredentialsPrompt);
      this.Controls.Add((Control) this.chkUsePromptedCredentialsAsWindowsCredentials);
      this.Controls.Add((Control) this.radNone);
      this.Controls.Add((Control) this.radStored);
      this.Controls.Add((Control) this.radPrompt);
      this.Controls.Add((Control) this.radWindowsAuthentication);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.chkEnabled);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.cmbExtensions);
      this.Controls.Add((Control) this.txtConnStr);
      this.Controls.Add((Control) this.lblConnStr);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.lblName);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = nameof (FormDatasource);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Create / Edit Datasource";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public FormDatasource()
    {
      this.InitializeComponent();
    }

    public Datasource Datasource
    {
      get
      {
        this.datasource.ConnectionString = this.txtConnStr.Text;
        this.datasource.Prompt = this.txtCredentialsPrompt.Text;
        this.datasource.Name = this.txtName.Text;
        this.datasource.Username = this.txtUsername.Text;
        this.datasource.Password = this.txtPassword.Text;
        this.datasource.Enabled = this.chkEnabled.Checked;
        this.datasource.SetExecutionContext = this.chkExecutionContext.Checked;
        this.datasource.UsePromptedCredentialsAsWindowsCredentials = this.chkUsePromptedCredentialsAsWindowsCredentials.Checked;
        this.datasource.UseStoredCredentialsAsWindowsCredentials = this.chkUsePromptedCredentialsAsWindowsCredentials.Checked;
        this.datasource.Extension = "";
        if (this.cmbExtensions.SelectedIndex != -1)
        {
          foreach (DatasourceExtension extension in this.extensions)
          {
            if (extension.FriendlyName == this.cmbExtensions.SelectedItem.ToString())
            {
              this.datasource.Extension = extension.Name;
              break;
            }
          }
        }
        return this.datasource;
      }
      set
      {
        this.txtConnStr.Text = value.ConnectionString;
        this.txtCredentialsPrompt.Text = value.Prompt;
        this.txtName.Text = value.Name;
        this.txtUsername.Text = value.Username;
        this.txtPassword.Text = value.Password;
        this.chkEnabled.Checked = value.Enabled;
        this.chkExecutionContext.Checked = value.SetExecutionContext;
        this.chkUsePromptedCredentialsAsWindowsCredentials.Checked = value.UsePromptedCredentialsAsWindowsCredentials;
        this.chkUseStoredCredentialsAsWindowsCredentials.Checked = value.UseStoredCredentialsAsWindowsCredentials;
        foreach (DatasourceExtension extension in this.extensions)
        {
          if (value.Extension == extension.Name && this.cmbExtensions.Items.IndexOf((object) extension.FriendlyName) != -1)
            this.cmbExtensions.SelectedItem = (object) extension.FriendlyName;
        }
      }
    }

    public List<DatasourceExtension> Extensions
    {
      set
      {
        this.extensions = value;
        foreach (DatasourceExtension extension in this.extensions)
          this.cmbExtensions.Items.Add((object) extension.FriendlyName);
        this.cmbExtensions.SelectedIndex = 0;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (this.txtName.Text == "")
      {
        int num = (int) MessageBox.Show("Please fill in a name for the datasource");
      }
      else
        this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void radAuthentication_CheckedChanged(object sender, EventArgs e)
    {
      switch (((Control) sender).Name)
      {
        case "radPrompt":
          this.datasource.CredentialRetrievalType = CredentialRetrievalTypes.Prompt;
          this.txtUsername.Text = "";
          this.txtPassword.Text = "";
          this.chkUseStoredCredentialsAsWindowsCredentials.Checked = false;
          this.chkExecutionContext.Checked = false;
          break;
        case "radStored":
          this.datasource.CredentialRetrievalType = CredentialRetrievalTypes.Store;
          this.chkUsePromptedCredentialsAsWindowsCredentials.Checked = false;
          this.txtCredentialsPrompt.Text = "";
          break;
        case "radNone":
          this.datasource.CredentialRetrievalType = CredentialRetrievalTypes.None;
          this.txtUsername.Text = "";
          this.txtPassword.Text = "";
          this.chkUseStoredCredentialsAsWindowsCredentials.Checked = false;
          this.chkExecutionContext.Checked = false;
          this.txtUsername.Text = "";
          this.txtPassword.Text = "";
          this.chkUseStoredCredentialsAsWindowsCredentials.Checked = false;
          this.chkExecutionContext.Checked = false;
          this.chkUsePromptedCredentialsAsWindowsCredentials.Checked = false;
          this.txtCredentialsPrompt.Text = "";
          break;
        case "radWindowsAuthentication":
          this.datasource.CredentialRetrievalType = CredentialRetrievalTypes.Integrated;
          this.txtUsername.Text = "";
          this.txtPassword.Text = "";
          this.chkUseStoredCredentialsAsWindowsCredentials.Checked = false;
          this.chkExecutionContext.Checked = false;
          this.chkUsePromptedCredentialsAsWindowsCredentials.Checked = false;
          this.txtCredentialsPrompt.Text = "";
          break;
      }
      this.txtCredentialsPrompt.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Prompt;
      this.chkUsePromptedCredentialsAsWindowsCredentials.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Prompt;
      this.txtUsername.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Store;
      this.txtPassword.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Store;
      this.chkUseStoredCredentialsAsWindowsCredentials.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Store;
      this.chkExecutionContext.Enabled = this.datasource.CredentialRetrievalType == CredentialRetrievalTypes.Store;
    }
  }
}

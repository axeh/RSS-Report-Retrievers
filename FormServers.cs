
// Type: RSS_Report_Retrievers.FormServers


using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RSSReportRetrievers.Model;

namespace RSS_Report_Retrievers
{
  public class FormServers : Form
  {
    public ServerSettingsConfigElement SelectedServer = (ServerSettingsConfigElement) null;
    private IContainer components = (IContainer) null;
    private Label label1;
    private DataGridView dataGridView1;
    private Button btnRemove;
    private Button btnAdd;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Alias;
    private DataGridViewTextBoxColumn Url;
    private Button btnClose;
    private BindingSource bsRegistredServers;
    private Button btnEdit;

    public FormServers()
    {
      this.InitializeComponent();
    }

    private void FormServers_Load(object sender, EventArgs e)
    {
      this.ReloadServerlist();
    }

    private void ReloadServerlist()
    {
      this.bsRegistredServers.DataSource = (object) ServerRegistry.GetServerSettings();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      this.ShowSettingsForm(new ServerSettingsConfigElement());
    }

    private void ShowSettingsForm(ServerSettingsConfigElement setting)
    {
      FormSettings formSettings = new FormSettings(setting.Alias != string.Empty);
      formSettings.CurrentSetting = setting;
      int num = (int) formSettings.ShowDialog();
      if (formSettings.DialogResult == DialogResult.OK)
      {
        ServerRegistry.AddElement(setting);
        ServerRegistry.StoreSettings();
      }
      this.ReloadServerlist();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.dataGridView1.SelectedRows.Count <= 0)
        return;
      this.ShowSettingsForm(((ServerSettingsConfigElement) this.bsRegistredServers[this.dataGridView1.SelectedRows[0].Index]).Clone());
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      this.btnEdit.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.dataGridView1.SelectedRows.Count <= 0)
        return;
      this.ShowSettingsForm((ServerSettingsConfigElement) this.bsRegistredServers[this.dataGridView1.SelectedRows[0].Index]);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (this.dataGridView1.SelectedRows.Count > 0)
      {
        ServerRegistry.RemoveElement((ServerSettingsConfigElement) this.bsRegistredServers[this.dataGridView1.SelectedRows[0].Index]);
        ServerRegistry.StoreSettings();
      }
      this.ReloadServerlist();
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
      this.label1 = new Label();
      this.dataGridView1 = new DataGridView();
      this.ID = new DataGridViewTextBoxColumn();
      this.Alias = new DataGridViewTextBoxColumn();
      this.Url = new DataGridViewTextBoxColumn();
      this.bsRegistredServers = new BindingSource(this.components);
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.btnClose = new Button();
      this.btnEdit = new Button();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      ((ISupportInitialize) this.bsRegistredServers).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(144, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Registred Servers:";
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.ID, (DataGridViewColumn) this.Alias, (DataGridViewColumn) this.Url);
      this.dataGridView1.DataSource = (object) this.bsRegistredServers;
      this.dataGridView1.Location = new Point(12, 29);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(534, 363);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);
      this.ID.DataPropertyName = "Id";
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Visible = false;
      this.Alias.DataPropertyName = "Alias";
      this.Alias.HeaderText = "Alias";
      this.Alias.Name = "Alias";
      this.Alias.ReadOnly = true;
      this.Alias.Width = 150;
      this.Url.DataPropertyName = "Url";
      this.Url.HeaderText = "Url";
      this.Url.Name = "Url";
      this.Url.ReadOnly = true;
      this.Url.Width = 500;
      this.bsRegistredServers.DataSource = (object) typeof (ServerSettingsConfigElement);
      this.btnRemove.Location = new Point(572, 109);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new Size(75, 23);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
      this.btnAdd.Location = new Point(571, 29);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(75, 23);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.btnClose.Location = new Point(572, 369);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(75, 23);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnEdit.Location = new Point(571, 69);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(75, 23);
      this.btnEdit.TabIndex = 5;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(658, 429);
      this.Controls.Add((Control) this.btnEdit);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.btnRemove);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (FormServers);
      this.Text = nameof (FormServers);
      this.Load += new EventHandler(this.FormServers_Load);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      ((ISupportInitialize) this.bsRegistredServers).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

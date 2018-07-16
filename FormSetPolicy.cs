
// Type: RSS_Report_Retrievers.FormSetPolicy




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace RSS_Report_Retrievers
{
  public class FormSetPolicy : Form, IFormSetPolicy
  {
    private IContainer components = (IContainer) null;
    public Dictionary<string, string[]> policyList = (Dictionary<string, string[]>) null;
    public List<string> selectedRoles = new List<string>();
    private TextBox txtUsername;
    private Label label1;
    private Label label2;
    private ListBox listAvailableRoles;
    private ListBox listSelectedRoles;
    private Button btnAddToSelectedRoles;
    private Button btnRemoveFromSelectedRoles;
    private Label label3;
    private Button btnCancel;
    private Button btnApply;
    private GroupBox groupBox;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtUsername = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.listAvailableRoles = new ListBox();
      this.listSelectedRoles = new ListBox();
      this.btnAddToSelectedRoles = new Button();
      this.btnRemoveFromSelectedRoles = new Button();
      this.label3 = new Label();
      this.btnCancel = new Button();
      this.btnApply = new Button();
      this.groupBox = new GroupBox();
      this.groupBox.SuspendLayout();
      this.SuspendLayout();
      this.txtUsername.Location = new Point(15, 72);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(143, 22);
      this.txtUsername.TabIndex = 0;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 52);
      this.label1.Name = "label1";
      this.label1.Size = new Size(145, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Domain\\Username:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(285, 120);
      this.label2.Name = "label2";
      this.label2.Size = new Size(125, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Available Roles:";
      this.listAvailableRoles.FormattingEnabled = true;
      this.listAvailableRoles.ItemHeight = 16;
      this.listAvailableRoles.Location = new Point(288, 140);
      this.listAvailableRoles.Name = "listAvailableRoles";
      this.listAvailableRoles.SelectionMode = SelectionMode.MultiSimple;
      this.listAvailableRoles.Size = new Size(120, 132);
      this.listAvailableRoles.TabIndex = 4;
      this.listSelectedRoles.FormattingEnabled = true;
      this.listSelectedRoles.ItemHeight = 16;
      this.listSelectedRoles.Location = new Point(15, 140);
      this.listSelectedRoles.Name = "listSelectedRoles";
      this.listSelectedRoles.Size = new Size(120, 132);
      this.listSelectedRoles.TabIndex = 5;
      this.btnAddToSelectedRoles.Location = new Point(288, 291);
      this.btnAddToSelectedRoles.Name = "btnAddToSelectedRoles";
      this.btnAddToSelectedRoles.Size = new Size(75, 23);
      this.btnAddToSelectedRoles.TabIndex = 6;
      this.btnAddToSelectedRoles.Text = "Select";
      this.btnAddToSelectedRoles.UseVisualStyleBackColor = true;
      this.btnAddToSelectedRoles.Click += new EventHandler(this.btnAddToSelectedRoles_Click);
      this.btnRemoveFromSelectedRoles.Location = new Point(15, 291);
      this.btnRemoveFromSelectedRoles.Name = "btnRemoveFromSelectedRoles";
      this.btnRemoveFromSelectedRoles.Size = new Size(75, 23);
      this.btnRemoveFromSelectedRoles.TabIndex = 7;
      this.btnRemoveFromSelectedRoles.Text = "Remove";
      this.btnRemoveFromSelectedRoles.UseVisualStyleBackColor = true;
      this.btnRemoveFromSelectedRoles.Click += new EventHandler(this.btnRemoveFromSelectedRoles_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(12, 120);
      this.label3.Name = "label3";
      this.label3.Size = new Size(122, 17);
      this.label3.TabIndex = 8;
      this.label3.Text = "Selected Roles:";
      this.btnCancel.Location = new Point(364, 397);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 29);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnApply.Location = new Point(207, 397);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new Size(119, 29);
      this.btnApply.TabIndex = 11;
      this.btnApply.Text = "ApplyAndClose";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new EventHandler(this.btnApply_Click);
      this.groupBox.Controls.Add((Control) this.btnRemoveFromSelectedRoles);
      this.groupBox.Controls.Add((Control) this.txtUsername);
      this.groupBox.Controls.Add((Control) this.label1);
      this.groupBox.Controls.Add((Control) this.label3);
      this.groupBox.Controls.Add((Control) this.label2);
      this.groupBox.Controls.Add((Control) this.listAvailableRoles);
      this.groupBox.Controls.Add((Control) this.btnAddToSelectedRoles);
      this.groupBox.Controls.Add((Control) this.listSelectedRoles);
      this.groupBox.Location = new Point(12, 12);
      this.groupBox.Name = "groupBox";
      this.groupBox.Size = new Size(427, 332);
      this.groupBox.TabIndex = 12;
      this.groupBox.TabStop = false;
      this.groupBox.Text = "Setting security for ";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(458, 468);
      this.Controls.Add((Control) this.groupBox);
      this.Controls.Add((Control) this.btnApply);
      this.Controls.Add((Control) this.btnCancel);
      this.Name = nameof (FormSetPolicy);
      this.Text = nameof (FormSetPolicy);
      this.groupBox.ResumeLayout(false);
      this.groupBox.PerformLayout();
      this.ResumeLayout(false);
    }

    public string UserName
    {
      get
      {
        return this.txtUsername.Text;
      }
    }

    public List<string> SelectedRoles
    {
      get
      {
        return this.selectedRoles;
      }
    }

    public FormSetPolicy()
    {
      this.InitializeComponent();
    }

    public void Init(IEnumerable<string> availableRoles, string itemName)
    {
      this.groupBox.Text = "Adding user to " + itemName;
      this.txtUsername.Text = WindowsIdentity.GetCurrent().Name;
      this.listAvailableRoles.Items.Clear();
      foreach (object availableRole in availableRoles)
        this.listAvailableRoles.Items.Add(availableRole);
    }

    private void btnAddToSelectedRoles_Click(object sender, EventArgs e)
    {
      List<object> objectList = new List<object>();
      foreach (object selectedItem in this.listAvailableRoles.SelectedItems)
      {
        this.listSelectedRoles.Items.Add(selectedItem);
        objectList.Add(selectedItem);
      }
      foreach (object obj in objectList)
        this.listAvailableRoles.Items.Remove(obj);
    }

    private void btnRemoveFromSelectedRoles_Click(object sender, EventArgs e)
    {
      List<object> objectList = new List<object>();
      foreach (object selectedItem in this.listSelectedRoles.SelectedItems)
      {
        this.listAvailableRoles.Items.Add(selectedItem);
        objectList.Add(selectedItem);
      }
      foreach (object obj in objectList)
        this.listSelectedRoles.Items.Remove(obj);
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      foreach (object obj in this.listSelectedRoles.Items)
        this.SelectedRoles.Add(obj.ToString());
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    DialogResult IFormSetPolicy.ShowDialog()
    {
      return this.ShowDialog();
    }
  }
}

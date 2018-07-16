
// Type: RSS_Report_Retrievers.FormGetName




using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RSS_Report_Retrievers
{
  public class FormGetName : Form
  {
    private IContainer components = (IContainer) null;
    private Button btnOK;
    private TextBox txtName;
    private Button btnCancel;

    public FormGetName(string caption)
    {
      this.InitializeComponent();
      this.Text = caption;
    }

    public new string Name
    {
      get
      {
        return this.txtName.Text;
      }
      set
      {
        this.txtName.Text = value;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnOK = new Button();
      this.txtName = new TextBox();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(188, 38);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.txtName.Location = new Point(12, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(251, 20);
      this.txtName.TabIndex = 0;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(107, 38);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(280, 70);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.StartPosition = FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}


// Type: RSS_Report_Retrievers.FormProperties


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RSSReportRetrievers.Model;

namespace RSS_Report_Retrievers
{
  public class FormProperties : Form
  {
    private IContainer components = (IContainer) null;
    private string path;
    private ReportItemTypes itemType;
    private Controller rs;
    private Button btnOK;
    private ListView lvParameters;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ListView lvProperties;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ListView lvDataSources;
    private ColumnHeader columnHeader9;
    private ListView lvPermissions;
    private ColumnHeader columnHeader10;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private ColumnHeader columnHeader12;
    private Label lblInheritsPermissions;

    public FormProperties(string _path, ReportItemTypes _type)
    {
      this.InitializeComponent();
      this.rs = ReportingServicesFactory.CreateFromSettings(FormSSRSExplorer.SelectedServer, (TreeView) null, (ToolStripStatusLabel) null, (ListView) null);
      this.path = _path;
      this.itemType = _type;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormProperties_Shown(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        foreach (List<string> itemProperty in this.rs.GetItemProperties(this.path))
        {
          ListViewItem listViewItem = new ListViewItem();
          foreach (string text in itemProperty)
          {
            if (itemProperty.IndexOf(text) == 0)
              listViewItem.Text = text;
            else
              listViewItem.SubItems.Add(text);
          }
          this.lvProperties.Items.Add(listViewItem);
        }
        Application.DoEvents();
        bool inheritsParent;
        Dictionary<string, string[]> itemSecurity = this.rs.GetItemSecurity(this.path, out inheritsParent);
        foreach (string key in itemSecurity.Keys)
          this.lvPermissions.Items.Add(new ListViewItem()
          {
            Text = key,
            SubItems = {
              string.Join(",", itemSecurity[key])
            }
          });
        if (inheritsParent)
          this.lblInheritsPermissions.Text = "Inherited from parent object";
        else
          this.lblInheritsPermissions.Text = "";
        Application.DoEvents();
        if (this.itemType != ReportItemTypes.Report)
          return;
        foreach (string reportDatasource in this.rs.GetReportDatasources(this.path))
          this.lvDataSources.Items.Add(reportDatasource);
        Application.DoEvents();
        foreach (List<string> reportParameter in this.rs.GetReportParameters(this.path))
        {
          ListViewItem listViewItem = new ListViewItem();
          foreach (string text in reportParameter)
          {
            if (reportParameter.IndexOf(text) == 0)
              listViewItem.Text = text;
            else
              listViewItem.SubItems.Add(text);
          }
          this.lvParameters.Items.Add(listViewItem);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("An exception occured while retrieving item information: {0}", (object) ex.Message));
      }
      finally
      {
        this.Cursor = Cursors.Default;
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
      this.lvParameters = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.lvProperties = new ListView();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.lvDataSources = new ListView();
      this.columnHeader9 = new ColumnHeader();
      this.lvPermissions = new ListView();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.lblInheritsPermissions = new Label();
      this.SuspendLayout();
      this.btnOK.Location = new Point(724, 750);
      this.btnOK.Margin = new Padding(4, 4, 4, 4);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(100, 28);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.lvParameters.Columns.AddRange(new ColumnHeader[6]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6
      });
      this.lvParameters.Location = new Point(7, 34);
      this.lvParameters.Margin = new Padding(4, 4, 4, 4);
      this.lvParameters.MultiSelect = false;
      this.lvParameters.Name = "lvParameters";
      this.lvParameters.Size = new Size(815, 166);
      this.lvParameters.TabIndex = 9;
      this.lvParameters.UseCompatibleStateImageBehavior = false;
      this.lvParameters.View = View.Details;
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 250;
      this.columnHeader2.Text = "Type";
      this.columnHeader3.Text = "Allow Blank";
      this.columnHeader3.Width = 70;
      this.columnHeader4.Text = "Allow Null";
      this.columnHeader5.Text = "Multivalue";
      this.columnHeader6.Text = "Prompt";
      this.columnHeader6.Width = 80;
      this.lvProperties.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader7,
        this.columnHeader8
      });
      this.lvProperties.Location = new Point(7, 225);
      this.lvProperties.Margin = new Padding(4, 4, 4, 4);
      this.lvProperties.MultiSelect = false;
      this.lvProperties.Name = "lvProperties";
      this.lvProperties.Size = new Size(815, 171);
      this.lvProperties.TabIndex = 10;
      this.lvProperties.UseCompatibleStateImageBehavior = false;
      this.lvProperties.View = View.Details;
      this.columnHeader7.Text = "Name";
      this.columnHeader7.Width = 150;
      this.columnHeader8.Text = "Value";
      this.columnHeader8.Width = 400;
      this.lvDataSources.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader9
      });
      this.lvDataSources.Location = new Point(7, 421);
      this.lvDataSources.Margin = new Padding(4, 4, 4, 4);
      this.lvDataSources.MultiSelect = false;
      this.lvDataSources.Name = "lvDataSources";
      this.lvDataSources.Size = new Size(815, 117);
      this.lvDataSources.TabIndex = 11;
      this.lvDataSources.UseCompatibleStateImageBehavior = false;
      this.lvDataSources.View = View.Details;
      this.columnHeader9.Text = "Name";
      this.columnHeader9.Width = 400;
      this.lvPermissions.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader10,
        this.columnHeader12
      });
      this.lvPermissions.Location = new Point(7, 562);
      this.lvPermissions.Margin = new Padding(4, 4, 4, 4);
      this.lvPermissions.MultiSelect = false;
      this.lvPermissions.Name = "lvPermissions";
      this.lvPermissions.Size = new Size(815, 179);
      this.lvPermissions.TabIndex = 12;
      this.lvPermissions.UseCompatibleStateImageBehavior = false;
      this.lvPermissions.View = View.Details;
      this.columnHeader10.Text = "Item";
      this.columnHeader10.Width = 160;
      this.columnHeader12.Text = "Roles";
      this.columnHeader12.Width = 350;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 15);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(81, 17);
      this.label1.TabIndex = 13;
      this.label1.Text = "Parameters";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(3, 401);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(88, 17);
      this.label2.TabIndex = 14;
      this.label2.Text = "Datasources";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(3, 543);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(84, 17);
      this.label3.TabIndex = 15;
      this.label3.Text = "Permissions";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(3, 206);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(73, 17);
      this.label4.TabIndex = 16;
      this.label4.Text = "Properties";
      this.lblInheritsPermissions.AutoSize = true;
      this.lblInheritsPermissions.Location = new Point(94, 543);
      this.lblInheritsPermissions.Name = "lblInheritsPermissions";
      this.lblInheritsPermissions.Size = new Size(0, 17);
      this.lblInheritsPermissions.TabIndex = 17;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(840, 782);
      this.Controls.Add((Control) this.lblInheritsPermissions);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lvPermissions);
      this.Controls.Add((Control) this.lvDataSources);
      this.Controls.Add((Control) this.lvProperties);
      this.Controls.Add((Control) this.lvParameters);
      this.Controls.Add((Control) this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Margin = new Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.Name = nameof (FormProperties);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Properties";
      this.Shown += new EventHandler(this.FormProperties_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

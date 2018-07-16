
// Type: RSS_Report_Retrievers.Forms.FormDependantItems


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RSSReportRetrievers.Model;
using RSSReportRetrievers.Model.ReportModel;
using RSSReportRetrievers.Services;

namespace RSS_Report_Retrievers.Forms
{
  public class FormDependantItems : Form
  {
    private IContainer components = (IContainer) null;
    private Label lblDependantItems;
    private DataGridView dgvResults;
    private Button btnClose;
    private DataGridViewTextBoxColumn ReportName;
    private DataGridViewCheckBoxColumn isCompatible;
    private Controller controller;
    private string existingModelPath;
    private string newModelSMDL;
    private IList<ReportTestResult> testResults;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblDependantItems = new Label();
      this.dgvResults = new DataGridView();
      this.ReportName = new DataGridViewTextBoxColumn();
      this.isCompatible = new DataGridViewCheckBoxColumn();
      this.btnClose = new Button();
      ((ISupportInitialize) this.dgvResults).BeginInit();
      this.SuspendLayout();
      this.lblDependantItems.AutoSize = true;
      this.lblDependantItems.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDependantItems.Location = new Point(12, 19);
      this.lblDependantItems.Name = "lblDependantItems";
      this.lblDependantItems.Size = new Size(135, 17);
      this.lblDependantItems.TabIndex = 1;
      this.lblDependantItems.Text = "Dependant Items:";
      this.dgvResults.AllowUserToAddRows = false;
      this.dgvResults.AllowUserToDeleteRows = false;
      this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResults.Columns.AddRange((DataGridViewColumn) this.ReportName, (DataGridViewColumn) this.isCompatible);
      this.dgvResults.EditMode = DataGridViewEditMode.EditProgrammatically;
      this.dgvResults.Location = new Point(15, 40);
      this.dgvResults.MultiSelect = false;
      this.dgvResults.Name = "dgvResults";
      this.dgvResults.ReadOnly = true;
      this.dgvResults.RowTemplate.Height = 24;
      this.dgvResults.Size = new Size(715, 150);
      this.dgvResults.TabIndex = 2;
      this.ReportName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      this.ReportName.HeaderText = "Report name";
      this.ReportName.Name = "ReportName";
      this.ReportName.ReadOnly = true;
      this.ReportName.Width = 115;
      this.isCompatible.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      this.isCompatible.HeaderText = "Compatible";
      this.isCompatible.Name = "isCompatible";
      this.isCompatible.ReadOnly = true;
      this.isCompatible.Width = 84;
      this.btnClose.Location = new Point(655, 199);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(75, 23);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(742, 234);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.dgvResults);
      this.Controls.Add((Control) this.lblDependantItems);
      this.Name = nameof (FormDependantItems);
      this.Text = nameof (FormDependantItems);
      this.Load += new EventHandler(this.FormDependantItems_Load);
      this.Resize += new EventHandler(this.FormDependantItems_Resize);
      ((ISupportInitialize) this.dgvResults).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private IList<ReportTestResult> TestResults
    {
      get
      {
        return this.testResults;
      }
      set
      {
        this.testResults = value;
        this.dgvResults.Rows.Clear();
        foreach (ReportTestResult testResult in (IEnumerable<ReportTestResult>) this.testResults)
        {
          DataGridViewRow dataGridViewRow = new DataGridViewRow();
          dataGridViewRow.CreateCells(this.dgvResults);
          dataGridViewRow.Cells[0].Value = (object) testResult.ReportName;
          dataGridViewRow.Cells[1].Value = (object) testResult.PassedTest;
          this.dgvResults.Rows.Add(dataGridViewRow);
        }
      }
    }

    public FormDependantItems(Controller rs, string existingModelPath, string newModelSMDL)
    {
      this.controller = rs;
      this.existingModelPath = existingModelPath;
      this.newModelSMDL = newModelSMDL;
      this.InitializeComponent();
    }

    private void FormDependantItems_Load(object sender, EventArgs e)
    {
      this.CheckModelForCompatibility(this.controller, this.existingModelPath, this.newModelSMDL);
    }

    private void CheckModelForCompatibility(Controller rs, string existingModelPath, string newModelSMDL)
    {
      this.Show();
      this.DialogResult = DialogResult.Yes;
      bool flag = true;
      List<ReportItemDTO> reportItemDtoList = rs.ListDependantItems(existingModelPath);
      ReportModelValidator reportModelValidator = new ReportModelValidator(newModelSMDL);
      List<ReportTestResult> reportTestResultList = new List<ReportTestResult>();
      foreach (ReportItemDTO reportItemDto in reportItemDtoList)
      {
        string reportRDL = Encoding.UTF8.GetString(rs.GetReport(reportItemDto.Path));
        if (reportRDL[0] == '\xFEFF')
          reportRDL = reportRDL.Substring(1);
        ReportTestResult reportTestResult = new ReportTestResult();
        reportTestResult.ReportName = reportItemDto.Path + "/" + reportItemDto.Name;
        reportTestResult.PassedTest = reportModelValidator.ValidateModelForReport(reportRDL);
        if (!reportTestResult.PassedTest)
          flag = false;
        reportTestResultList.Add(reportTestResult);
        this.TestResults = (IList<ReportTestResult>) reportTestResultList;
        Application.DoEvents();
      }
      if (!flag)
      {
        int num1 = (int) MessageBox.Show("This model seem to have some compatibility issues with existing reports.", "Compatibility warning", MessageBoxButtons.OK);
      }
      else
      {
        int num2 = (int) MessageBox.Show("The new model seems to be compatible with existing reports. ", "", MessageBoxButtons.OK);
      }
    }

    private string GetModelDefinition(IRSFacade rsInstance, string path)
    {
      return new UTF8Encoding().GetString(rsInstance.GetModelDefinition(path));
    }

    private string GetReportDefinition(IRSFacade rsInstance, string path)
    {
      return new UTF8Encoding().GetString(rsInstance.GetReportDefinition(path));
    }

    private List<ReportItemDTO> LoadDependantItems(IRSFacade rsInstance, string modelPath)
    {
      return rsInstance.ListDependantItems(modelPath);
    }

    private void MockTestResults()
    {
      List<ReportTestResult> reportTestResultList = new List<ReportTestResult>();
      ReportTestResult reportTestResult1 = new ReportTestResult();
      reportTestResult1.PassedTest = true;
      reportTestResult1.ReportName = "David";
      ReportTestResult reportTestResult2 = new ReportTestResult();
      reportTestResult2.PassedTest = false;
      reportTestResult2.ReportName = "David2";
      reportTestResultList.Add(reportTestResult1);
      reportTestResultList.Add(reportTestResult2);
      this.TestResults = (IList<ReportTestResult>) reportTestResultList;
    }

    private void FormDependantItems_Resize(object sender, EventArgs e)
    {
      this.dgvResults.Width = this.Width - 50;
      this.dgvResults.Height = this.Height - 130;
      this.btnClose.Top = this.Height + 199 - 277;
      this.btnClose.Left = this.Width + 393 - 498;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}

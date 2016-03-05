namespace Wallnut.UI.Reports
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.wallnutProductionDataSet1 = new Wallnut.UI.WallnutProductionDataSet1();
            this.vEmployeeCurrentJubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEmployeeCurrentJubTableAdapter = new Wallnut.UI.WallnutProductionDataSet1TableAdapters.vEmployeeCurrentJubTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wallnutProductionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeCurrentJubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vEmployeeCurrentJubBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // wallnutProductionDataSet1
            // 
            this.wallnutProductionDataSet1.DataSetName = "WallnutProductionDataSet1";
            this.wallnutProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEmployeeCurrentJubBindingSource
            // 
            this.vEmployeeCurrentJubBindingSource.DataMember = "vEmployeeCurrentJub";
            this.vEmployeeCurrentJubBindingSource.DataSource = this.wallnutProductionDataSet1;
            // 
            // vEmployeeCurrentJubTableAdapter
            // 
            this.vEmployeeCurrentJubTableAdapter.ClearBeforeFill = true;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wallnutProductionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeCurrentJubBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private WallnutProductionDataSet1 wallnutProductionDataSet1;
        private System.Windows.Forms.BindingSource vEmployeeCurrentJubBindingSource;
        private WallnutProductionDataSet1TableAdapters.vEmployeeCurrentJubTableAdapter vEmployeeCurrentJubTableAdapter;
    }
}
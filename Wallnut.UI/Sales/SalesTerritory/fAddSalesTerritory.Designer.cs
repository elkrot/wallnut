namespace Wallnut.UI.Sales.SalesTerritory
{
    partial class fAddSalesTerritory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNamelbl = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCountryRegionCode = new System.Windows.Forms.ComboBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.tbSalesYTD = new System.Windows.Forms.TextBox();
            this.tbCostYTD = new System.Windows.Forms.TextBox();
            this.tbSalesLastYear = new System.Windows.Forms.TextBox();
            this.lbCountryRegionCode = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.lbSalesYTD = new System.Windows.Forms.Label();
            this.lbSalesLastYear = new System.Windows.Forms.Label();
            this.lbCostYTD = new System.Windows.Forms.Label();
            this.tbCostLastYear = new System.Windows.Forms.TextBox();
            this.lbCostLastYear = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamelbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCountryRegionCode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbGroup, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbSalesYTD, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbCostYTD, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbSalesLastYear, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbCountryRegionCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbGroup, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbSalesYTD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbSalesLastYear, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbCostYTD, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbCostLastYear, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbCostLastYear, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbNamelbl
            // 
            this.tbNamelbl.AutoSize = true;
            this.tbNamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNamelbl.Location = new System.Drawing.Point(23, 25);
            this.tbNamelbl.Name = "tbNamelbl";
            this.tbNamelbl.Size = new System.Drawing.Size(83, 25);
            this.tbNamelbl.TabIndex = 0;
            this.tbNamelbl.Text = "Наименование";
            this.tbNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(209, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // cbCountryRegionCode
            // 
            this.cbCountryRegionCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCountryRegionCode.FormattingEnabled = true;
            this.cbCountryRegionCode.Location = new System.Drawing.Point(209, 53);
            this.cbCountryRegionCode.Name = "cbCountryRegionCode";
            this.cbCountryRegionCode.Size = new System.Drawing.Size(298, 21);
            this.cbCountryRegionCode.TabIndex = 2;
            // 
            // tbGroup
            // 
            this.tbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGroup.Location = new System.Drawing.Point(209, 78);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(298, 20);
            this.tbGroup.TabIndex = 3;
            // 
            // tbSalesYTD
            // 
            this.tbSalesYTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSalesYTD.Location = new System.Drawing.Point(209, 103);
            this.tbSalesYTD.Name = "tbSalesYTD";
            this.tbSalesYTD.Size = new System.Drawing.Size(298, 20);
            this.tbSalesYTD.TabIndex = 3;
            // 
            // tbCostYTD
            // 
            this.tbCostYTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCostYTD.Location = new System.Drawing.Point(209, 153);
            this.tbCostYTD.Name = "tbCostYTD";
            this.tbCostYTD.Size = new System.Drawing.Size(298, 20);
            this.tbCostYTD.TabIndex = 3;
            // 
            // tbSalesLastYear
            // 
            this.tbSalesLastYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSalesLastYear.Location = new System.Drawing.Point(209, 128);
            this.tbSalesLastYear.Name = "tbSalesLastYear";
            this.tbSalesLastYear.Size = new System.Drawing.Size(298, 20);
            this.tbSalesLastYear.TabIndex = 3;
            // 
            // lbCountryRegionCode
            // 
            this.lbCountryRegionCode.AutoSize = true;
            this.lbCountryRegionCode.Location = new System.Drawing.Point(23, 50);
            this.lbCountryRegionCode.Name = "lbCountryRegionCode";
            this.lbCountryRegionCode.Size = new System.Drawing.Size(43, 13);
            this.lbCountryRegionCode.TabIndex = 4;
            this.lbCountryRegionCode.Text = "Страна";
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(23, 75);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(42, 13);
            this.lbGroup.TabIndex = 4;
            this.lbGroup.Text = "Группа";
            // 
            // lbSalesYTD
            // 
            this.lbSalesYTD.AutoSize = true;
            this.lbSalesYTD.Location = new System.Drawing.Point(23, 100);
            this.lbSalesYTD.Name = "lbSalesYTD";
            this.lbSalesYTD.Size = new System.Drawing.Size(126, 13);
            this.lbSalesYTD.TabIndex = 4;
            this.lbSalesYTD.Text = "Годовой объем продаж";
            // 
            // lbSalesLastYear
            // 
            this.lbSalesLastYear.AutoSize = true;
            this.lbSalesLastYear.Location = new System.Drawing.Point(23, 125);
            this.lbSalesLastYear.Name = "lbSalesLastYear";
            this.lbSalesLastYear.Size = new System.Drawing.Size(175, 13);
            this.lbSalesLastYear.TabIndex = 4;
            this.lbSalesLastYear.Text = "Объем продаж за последний год";
            // 
            // lbCostYTD
            // 
            this.lbCostYTD.AutoSize = true;
            this.lbCostYTD.Location = new System.Drawing.Point(23, 150);
            this.lbCostYTD.Name = "lbCostYTD";
            this.lbCostYTD.Size = new System.Drawing.Size(96, 13);
            this.lbCostYTD.TabIndex = 4;
            this.lbCostYTD.Text = "Годовые затраты";
            // 
            // tbCostLastYear
            // 
            this.tbCostLastYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCostLastYear.Location = new System.Drawing.Point(209, 178);
            this.tbCostLastYear.Name = "tbCostLastYear";
            this.tbCostLastYear.Size = new System.Drawing.Size(298, 20);
            this.tbCostLastYear.TabIndex = 5;
            // 
            // lbCostLastYear
            // 
            this.lbCostLastYear.AutoSize = true;
            this.lbCostLastYear.Location = new System.Drawing.Point(23, 175);
            this.lbCostLastYear.Name = "lbCostLastYear";
            this.lbCostLastYear.Size = new System.Drawing.Size(138, 13);
            this.lbCostLastYear.TabIndex = 6;
            this.lbCostLastYear.Text = "Затраты последнего года";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(530, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(452, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(371, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // fAddSalesTerritory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 257);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fAddSalesTerritory";
            this.Text = "Территория продаж";
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label tbNamelbl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox cbCountryRegionCode;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.TextBox tbSalesYTD;
        private System.Windows.Forms.TextBox tbCostYTD;
        private System.Windows.Forms.TextBox tbSalesLastYear;
        private System.Windows.Forms.Label lbCountryRegionCode;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.Label lbSalesYTD;
        private System.Windows.Forms.Label lbSalesLastYear;
        private System.Windows.Forms.Label lbCostYTD;
        private System.Windows.Forms.TextBox tbCostLastYear;
        private System.Windows.Forms.Label lbCostLastYear;
    }
}
namespace Wallnut.UI.Purchasing.PurchaseOrder
{
    partial class fAddPurchaseOrder
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNamelbl = new System.Windows.Forms.Label();
            this.tbRevisionNumber = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbVendorID = new System.Windows.Forms.ComboBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShipMethodID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtShipDate = new System.Windows.Forms.DateTimePicker();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTaxAmt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 389);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(518, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(398, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 389);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamelbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbRevisionNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbStatus, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbVendorID, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployeeID, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbShipMethodID, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtOrderDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtShipDate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbSubTotal, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbTaxAmt, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbFreight, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 389);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbNamelbl
            // 
            this.tbNamelbl.AutoSize = true;
            this.tbNamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNamelbl.Location = new System.Drawing.Point(36, 29);
            this.tbNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNamelbl.Name = "tbNamelbl";
            this.tbNamelbl.Size = new System.Drawing.Size(73, 36);
            this.tbNamelbl.TabIndex = 0;
            this.tbNamelbl.Text = "№Заказа";
            this.tbNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRevisionNumber
            // 
            this.tbRevisionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRevisionNumber.Location = new System.Drawing.Point(328, 33);
            this.tbRevisionNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbRevisionNumber.Name = "tbRevisionNumber";
            this.tbRevisionNumber.Size = new System.Drawing.Size(270, 24);
            this.tbRevisionNumber.TabIndex = 0;
            this.tbRevisionNumber.TextChanged += new System.EventHandler(this.tbRevisionNumber_TextChanged);
            this.tbRevisionNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbRevisionNumber_Validating);
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(328, 69);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(270, 26);
            this.cbStatus.TabIndex = 1;
            // 
            // cbVendorID
            // 
            this.cbVendorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbVendorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbVendorID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVendorID.FormattingEnabled = true;
            this.cbVendorID.Location = new System.Drawing.Point(328, 137);
            this.cbVendorID.Margin = new System.Windows.Forms.Padding(4);
            this.cbVendorID.Name = "cbVendorID";
            this.cbVendorID.Size = new System.Drawing.Size(270, 26);
            this.cbVendorID.TabIndex = 3;
            this.cbVendorID.Validating += new System.ComponentModel.CancelEventHandler(this.cbVendorID_Validating);
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(328, 105);
            this.cbEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(270, 26);
            this.cbEmployeeID.TabIndex = 2;
            this.cbEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.cbEmployeeID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ответственный";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поставщик";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbShipMethodID
            // 
            this.cbShipMethodID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShipMethodID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShipMethodID.FormattingEnabled = true;
            this.cbShipMethodID.Location = new System.Drawing.Point(328, 173);
            this.cbShipMethodID.Margin = new System.Windows.Forms.Padding(4);
            this.cbShipMethodID.Name = "cbShipMethodID";
            this.cbShipMethodID.Size = new System.Drawing.Size(270, 26);
            this.cbShipMethodID.TabIndex = 4;
            this.cbShipMethodID.Validating += new System.ComponentModel.CancelEventHandler(this.cbShipMethodID_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Метод доставки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(36, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата заказа";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate.Location = new System.Drawing.Point(328, 209);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(270, 24);
            this.dtOrderDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(36, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата предполагаемой отгрузки";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtShipDate
            // 
            this.dtShipDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShipDate.Location = new System.Drawing.Point(328, 241);
            this.dtShipDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtShipDate.Name = "dtShipDate";
            this.dtShipDate.Size = new System.Drawing.Size(270, 24);
            this.dtShipDate.TabIndex = 6;
            this.dtShipDate.Value = new System.DateTime(2016, 1, 28, 21, 45, 0, 0);
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubTotal.Location = new System.Drawing.Point(328, 273);
            this.tbSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(270, 24);
            this.tbSubTotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(36, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Сумма заказа";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTaxAmt
            // 
            this.tbTaxAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaxAmt.Location = new System.Drawing.Point(328, 309);
            this.tbTaxAmt.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaxAmt.Name = "tbTaxAmt";
            this.tbTaxAmt.Size = new System.Drawing.Size(270, 24);
            this.tbTaxAmt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(36, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Сумма Налогов";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFreight
            // 
            this.tbFreight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFreight.Location = new System.Drawing.Point(328, 341);
            this.tbFreight.Margin = new System.Windows.Forms.Padding(4);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(270, 24);
            this.tbFreight.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(36, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Сумма Доставки";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.PurchaseOrderDetail);
            // 
            // fAddPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(650, 467);
            this.Name = "fAddPurchaseOrder";
            this.Text = "Заказ на закупку.";
            this.Activated += new System.EventHandler(this.fAddPurchaseOrder_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddPurchaseOrder_FormClosing);
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fAddPurchaseOrder_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tbNamelbl;
        private System.Windows.Forms.TextBox tbRevisionNumber;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbVendorID;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbShipMethodID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtShipDate;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTaxAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.Label label9;
    }
}
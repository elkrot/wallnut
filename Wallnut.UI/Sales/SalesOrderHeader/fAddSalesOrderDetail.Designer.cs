namespace Wallnut.UI.Sales.SalesOrderDetail
{
    partial class fAddSalesOrderDetail
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
            this.lbOrderQty = new System.Windows.Forms.Label();
            this.tbOrderQty = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lbCarrierTrackingNumber = new System.Windows.Forms.Label();
            this.tbCarrierTrackingNumber = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbLineTotal = new System.Windows.Forms.Label();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.tbUnitPrice = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lbLineTotalLoc = new System.Windows.Forms.Label();
            this.cbSpecialOfferID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.lbOrderQty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderQty, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCarrierTrackingNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCarrierTrackingNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbProductID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbUnitPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbLineTotal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbProductID, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbUnitPrice, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbLineTotalLoc, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbSpecialOfferID, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbOrderQty
            // 
            this.lbOrderQty.AutoSize = true;
            this.lbOrderQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbOrderQty.Location = new System.Drawing.Point(34, 70);
            this.lbOrderQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderQty.Name = "lbOrderQty";
            this.lbOrderQty.Size = new System.Drawing.Size(92, 35);
            this.lbOrderQty.TabIndex = 0;
            this.lbOrderQty.Text = "Количество";
            this.lbOrderQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrderQty
            // 
            this.tbOrderQty.AllowNegative = true;
            this.tbOrderQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrderQty.Location = new System.Drawing.Point(288, 74);
            this.tbOrderQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.NumericPrecision = 1;
            this.tbOrderQty.NumericScaleOnFocus = 0;
            this.tbOrderQty.NumericScaleOnLostFocus = 0;
            this.tbOrderQty.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbOrderQty.Size = new System.Drawing.Size(353, 24);
            this.tbOrderQty.TabIndex = 1;
            this.tbOrderQty.Text = "0";
            this.tbOrderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbOrderQty.ZeroIsValid = false;
            this.tbOrderQty.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // lbCarrierTrackingNumber
            // 
            this.lbCarrierTrackingNumber.AutoSize = true;
            this.lbCarrierTrackingNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCarrierTrackingNumber.Location = new System.Drawing.Point(34, 38);
            this.lbCarrierTrackingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCarrierTrackingNumber.Name = "lbCarrierTrackingNumber";
            this.lbCarrierTrackingNumber.Size = new System.Drawing.Size(159, 32);
            this.lbCarrierTrackingNumber.TabIndex = 2;
            this.lbCarrierTrackingNumber.Text = "Номер отслеживания";
            this.lbCarrierTrackingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCarrierTrackingNumber
            // 
            this.tbCarrierTrackingNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCarrierTrackingNumber.Location = new System.Drawing.Point(288, 42);
            this.tbCarrierTrackingNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbCarrierTrackingNumber.Name = "tbCarrierTrackingNumber";
            this.tbCarrierTrackingNumber.Size = new System.Drawing.Size(353, 24);
            this.tbCarrierTrackingNumber.TabIndex = 0;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(34, 105);
            this.lbProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(67, 18);
            this.lbProductID.TabIndex = 2;
            this.lbProductID.Text = "Продукт";
            this.lbProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUnitPrice.Location = new System.Drawing.Point(34, 172);
            this.lbUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(43, 32);
            this.lbUnitPrice.TabIndex = 2;
            this.lbUnitPrice.Text = "Цена";
            this.lbUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLineTotal
            // 
            this.lbLineTotal.AutoSize = true;
            this.lbLineTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLineTotal.Location = new System.Drawing.Point(34, 204);
            this.lbLineTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLineTotal.Name = "lbLineTotal";
            this.lbLineTotal.Size = new System.Drawing.Size(41, 33);
            this.lbLineTotal.TabIndex = 2;
            this.lbLineTotal.Text = "Итог";
            this.lbLineTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProductID
            // 
            this.cbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(288, 109);
            this.cbProductID.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(353, 26);
            this.cbProductID.TabIndex = 2;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.AllowNegative = true;
            this.tbUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUnitPrice.Location = new System.Drawing.Point(288, 176);
            this.tbUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.NumericPrecision = 1;
            this.tbUnitPrice.NumericScaleOnFocus = 0;
            this.tbUnitPrice.NumericScaleOnLostFocus = 0;
            this.tbUnitPrice.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbUnitPrice.Size = new System.Drawing.Size(353, 24);
            this.tbUnitPrice.TabIndex = 3;
            this.tbUnitPrice.Text = "0";
            this.tbUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbUnitPrice.ZeroIsValid = false;
            // 
            // lbLineTotalLoc
            // 
            this.lbLineTotalLoc.AutoSize = true;
            this.lbLineTotalLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLineTotalLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLineTotalLoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLineTotalLoc.Location = new System.Drawing.Point(288, 204);
            this.lbLineTotalLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLineTotalLoc.Name = "lbLineTotalLoc";
            this.lbLineTotalLoc.Size = new System.Drawing.Size(353, 33);
            this.lbLineTotalLoc.TabIndex = 5;
            this.lbLineTotalLoc.Text = "0";
            this.lbLineTotalLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSpecialOfferID
            // 
            this.cbSpecialOfferID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpecialOfferID.FormattingEnabled = true;
            this.cbSpecialOfferID.Location = new System.Drawing.Point(287, 143);
            this.cbSpecialOfferID.Name = "cbSpecialOfferID";
            this.cbSpecialOfferID.Size = new System.Drawing.Size(355, 26);
            this.cbSpecialOfferID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Скидка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 251);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(559, 4);
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
            this.btnOK.Location = new System.Drawing.Point(439, 4);
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
            // fAddSalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 291);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAddSalesOrderDetail";
            this.Text = "Подробности заказа на продажу";
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
        private System.Windows.Forms.Label lbOrderQty;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lbCarrierTrackingNumber;
        private System.Windows.Forms.TextBox tbCarrierTrackingNumber;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbLineTotal;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label lbLineTotalLoc;
        private fTemplates.NumericTextBox tbOrderQty;
        private fTemplates.NumericTextBox tbUnitPrice;
        private System.Windows.Forms.ComboBox cbSpecialOfferID;
        private System.Windows.Forms.Label label1;
    }
}
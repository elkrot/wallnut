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
            this.tbOrderQty = new System.Windows.Forms.TextBox();
            this.lbCarrierTrackingNumber = new System.Windows.Forms.Label();
            this.tbCarrierTrackingNumber = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbLineTotal = new System.Windows.Forms.Label();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbOrderQty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderQty, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCarrierTrackingNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCarrierTrackingNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbProductID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbUnitPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbLineTotal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbProductID, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbUnitPrice, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 210);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbOrderQty
            // 
            this.lbOrderQty.AutoSize = true;
            this.lbOrderQty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbOrderQty.Location = new System.Drawing.Point(23, 50);
            this.lbOrderQty.Name = "lbOrderQty";
            this.lbOrderQty.Size = new System.Drawing.Size(66, 25);
            this.lbOrderQty.TabIndex = 0;
            this.lbOrderQty.Text = "Количество";
            this.lbOrderQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrderQty
            // 
            this.tbOrderQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrderQty.Location = new System.Drawing.Point(192, 53);
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.Size = new System.Drawing.Size(235, 20);
            this.tbOrderQty.TabIndex = 1;
            this.tbOrderQty.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // lbCarrierTrackingNumber
            // 
            this.lbCarrierTrackingNumber.AutoSize = true;
            this.lbCarrierTrackingNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCarrierTrackingNumber.Location = new System.Drawing.Point(23, 25);
            this.lbCarrierTrackingNumber.Name = "lbCarrierTrackingNumber";
            this.lbCarrierTrackingNumber.Size = new System.Drawing.Size(117, 25);
            this.lbCarrierTrackingNumber.TabIndex = 2;
            this.lbCarrierTrackingNumber.Text = "Номер отслеживания";
            this.lbCarrierTrackingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCarrierTrackingNumber
            // 
            this.tbCarrierTrackingNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCarrierTrackingNumber.Location = new System.Drawing.Point(192, 28);
            this.tbCarrierTrackingNumber.Name = "tbCarrierTrackingNumber";
            this.tbCarrierTrackingNumber.Size = new System.Drawing.Size(235, 20);
            this.tbCarrierTrackingNumber.TabIndex = 3;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProductID.Location = new System.Drawing.Point(23, 75);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(49, 25);
            this.lbProductID.TabIndex = 2;
            this.lbProductID.Text = "Продукт";
            this.lbProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUnitPrice.Location = new System.Drawing.Point(23, 100);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(33, 25);
            this.lbUnitPrice.TabIndex = 2;
            this.lbUnitPrice.Text = "Цена";
            this.lbUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLineTotal
            // 
            this.lbLineTotal.AutoSize = true;
            this.lbLineTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLineTotal.Location = new System.Drawing.Point(23, 125);
            this.lbLineTotal.Name = "lbLineTotal";
            this.lbLineTotal.Size = new System.Drawing.Size(31, 25);
            this.lbLineTotal.TabIndex = 2;
            this.lbLineTotal.Text = "Итог";
            this.lbLineTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProductID
            // 
            this.cbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(192, 78);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(235, 21);
            this.cbProductID.TabIndex = 4;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUnitPrice.Location = new System.Drawing.Point(192, 103);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(235, 20);
            this.tbUnitPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(372, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(291, 3);
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
            // fAddSalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.TextBox tbOrderQty;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lbCarrierTrackingNumber;
        private System.Windows.Forms.TextBox tbCarrierTrackingNumber;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbLineTotal;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label1;
    }
}
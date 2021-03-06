﻿using Wallnut.UI.fTemplates;
namespace Wallnut.UI.Purchasing.PurchaseOrder
{
    partial class fAddPurchaseOrderDetail
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNamelbl = new System.Windows.Forms.Label();
            this.tbOrderQty = new Wallnut.UI.fTemplates.NumericTextBox();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUnitPrice = new Wallnut.UI.fTemplates.NumericTextBox();
            this.tbReceivedQty = new Wallnut.UI.fTemplates.NumericTextBox();
            this.tbRejectedQty = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.lblSklad = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 297);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(672, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(556, 4);
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
            this.btnOK.Location = new System.Drawing.Point(436, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamelbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderQty, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDueDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbProduct, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbUnitPrice, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbReceivedQty, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbRejectedQty, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLineTotal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSklad, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 337);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbNamelbl
            // 
            this.tbNamelbl.AutoSize = true;
            this.tbNamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNamelbl.Location = new System.Drawing.Point(34, 68);
            this.tbNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNamelbl.Name = "tbNamelbl";
            this.tbNamelbl.Size = new System.Drawing.Size(177, 33);
            this.tbNamelbl.TabIndex = 0;
            this.tbNamelbl.Text = "Заказанное количество";
            this.tbNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrderQty
            // 
            this.tbOrderQty.AllowNegative = true;
            this.tbOrderQty.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbOrderQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrderQty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbOrderQty.Location = new System.Drawing.Point(443, 72);
            this.tbOrderQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.NumericPrecision = 16;
            this.tbOrderQty.NumericScaleOnFocus = 2;
            this.tbOrderQty.NumericScaleOnLostFocus = 2;
            this.tbOrderQty.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbOrderQty.Size = new System.Drawing.Size(196, 24);
            this.tbOrderQty.TabIndex = 1;
            this.tbOrderQty.Text = "0";
            this.tbOrderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbOrderQty.ZeroIsValid = false;
            this.tbOrderQty.TextChanged += new System.EventHandler(this.tbOrderQty_TextChanged);
            this.tbOrderQty.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(443, 38);
            this.dtDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(194, 24);
            this.dtDueDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ожидаемая дата получения продукта от поставщика";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Продукт";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProduct
            // 
            this.cbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(443, 105);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(196, 26);
            this.cbProduct.TabIndex = 2;
            this.cbProduct.Validating += new System.ComponentModel.CancelEventHandler(this.cbProduct_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена за единицу продукта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Промежуточная стоимость продукта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(34, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Фактически полученное количество от поставщика";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(34, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Количество товаров, отбракованное при осмотре";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(34, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Количество товаров, принятых на склад";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.AllowNegative = true;
            this.tbUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUnitPrice.Location = new System.Drawing.Point(443, 138);
            this.tbUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.NumericPrecision = 16;
            this.tbUnitPrice.NumericScaleOnFocus = 2;
            this.tbUnitPrice.NumericScaleOnLostFocus = 2;
            this.tbUnitPrice.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbUnitPrice.Size = new System.Drawing.Size(196, 24);
            this.tbUnitPrice.TabIndex = 3;
            this.tbUnitPrice.Text = "0";
            this.tbUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbUnitPrice.ZeroIsValid = false;
            this.tbUnitPrice.TextChanged += new System.EventHandler(this.tbOrderQty_TextChanged);
            this.tbUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbUnitPrice_Validating);
            // 
            // tbReceivedQty
            // 
            this.tbReceivedQty.AllowNegative = true;
            this.tbReceivedQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceivedQty.Location = new System.Drawing.Point(443, 199);
            this.tbReceivedQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbReceivedQty.Name = "tbReceivedQty";
            this.tbReceivedQty.NumericPrecision = 16;
            this.tbReceivedQty.NumericScaleOnFocus = 2;
            this.tbReceivedQty.NumericScaleOnLostFocus = 2;
            this.tbReceivedQty.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbReceivedQty.Size = new System.Drawing.Size(196, 24);
            this.tbReceivedQty.TabIndex = 4;
            this.tbReceivedQty.Text = "0";
            this.tbReceivedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbReceivedQty.ZeroIsValid = false;
            this.tbReceivedQty.TextChanged += new System.EventHandler(this.tbReceivedQty_TextChanged);
            this.tbReceivedQty.Validating += new System.ComponentModel.CancelEventHandler(this.tbReceivedQty_Validating);
            // 
            // tbRejectedQty
            // 
            this.tbRejectedQty.AllowNegative = true;
            this.tbRejectedQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRejectedQty.Location = new System.Drawing.Point(443, 230);
            this.tbRejectedQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbRejectedQty.Name = "tbRejectedQty";
            this.tbRejectedQty.NumericPrecision = 16;
            this.tbRejectedQty.NumericScaleOnFocus = 2;
            this.tbRejectedQty.NumericScaleOnLostFocus = 2;
            this.tbRejectedQty.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbRejectedQty.Size = new System.Drawing.Size(196, 24);
            this.tbRejectedQty.TabIndex = 5;
            this.tbRejectedQty.Text = "0";
            this.tbRejectedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRejectedQty.ZeroIsValid = false;
            this.tbRejectedQty.TextChanged += new System.EventHandler(this.tbReceivedQty_TextChanged);
            this.tbRejectedQty.Validating += new System.ComponentModel.CancelEventHandler(this.tbRejectedQty_Validating);
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLineTotal.Location = new System.Drawing.Point(442, 164);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(16, 31);
            this.lblLineTotal.TabIndex = 6;
            this.lblLineTotal.Text = "0";
            this.lblLineTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSklad
            // 
            this.lblSklad.AutoSize = true;
            this.lblSklad.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSklad.Location = new System.Drawing.Point(442, 258);
            this.lblSklad.Name = "lblSklad";
            this.lblSklad.Size = new System.Drawing.Size(16, 31);
            this.lblSklad.TabIndex = 6;
            this.lblSklad.Text = "0";
            this.lblSklad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // fAddPurchaseOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 337);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 375);
            this.Name = "fAddPurchaseOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав Заказа на закупку.";
            this.Activated += new System.EventHandler(this.fAddPurchaseOrderDetail_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAddPurchaseOrderDetail_FormClosing);
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fAddPurchaseOrderDetail_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private NumericTextBox tbOrderQty;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private NumericTextBox tbUnitPrice;
        private NumericTextBox tbReceivedQty;
        private NumericTextBox tbRejectedQty;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.Label lblSklad;
    }
}
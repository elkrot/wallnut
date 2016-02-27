﻿namespace Wallnut.UI
{
    partial class fAddProduct
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label productNumberLabel;
            System.Windows.Forms.Label weightUnitMeasureCodeLabel;
            System.Windows.Forms.Label standardCostLabel;
            System.Windows.Forms.Label listPriceLabel;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listPriceTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standardCostTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productNumberTextBox = new System.Windows.Forms.TextBox();
            this.finishedGoodsFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.makeFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbUnitMesure = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            nameLabel = new System.Windows.Forms.Label();
            productNumberLabel = new System.Windows.Forms.Label();
            weightUnitMeasureCodeLabel = new System.Windows.Forms.Label();
            standardCostLabel = new System.Windows.Forms.Label();
            listPriceLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            nameLabel.Location = new System.Drawing.Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(83, 26);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Наименование";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberLabel
            // 
            productNumberLabel.AutoSize = true;
            productNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            productNumberLabel.Location = new System.Drawing.Point(3, 26);
            productNumberLabel.Name = "productNumberLabel";
            productNumberLabel.Size = new System.Drawing.Size(26, 26);
            productNumberLabel.TabIndex = 5;
            productNumberLabel.Text = "Код";
            productNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightUnitMeasureCodeLabel
            // 
            weightUnitMeasureCodeLabel.AutoSize = true;
            weightUnitMeasureCodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            weightUnitMeasureCodeLabel.Location = new System.Drawing.Point(3, 112);
            weightUnitMeasureCodeLabel.Name = "weightUnitMeasureCodeLabel";
            weightUnitMeasureCodeLabel.Size = new System.Drawing.Size(109, 34);
            weightUnitMeasureCodeLabel.TabIndex = 8;
            weightUnitMeasureCodeLabel.Text = "Единица измерения";
            weightUnitMeasureCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // standardCostLabel
            // 
            standardCostLabel.AutoSize = true;
            standardCostLabel.Dock = System.Windows.Forms.DockStyle.Left;
            standardCostLabel.Location = new System.Drawing.Point(3, 146);
            standardCostLabel.Name = "standardCostLabel";
            standardCostLabel.Size = new System.Drawing.Size(62, 26);
            standardCostLabel.TabIndex = 9;
            standardCostLabel.Text = "Стоимость";
            standardCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceLabel
            // 
            listPriceLabel.AutoSize = true;
            listPriceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            listPriceLabel.Location = new System.Drawing.Point(3, 172);
            listPriceLabel.Name = "listPriceLabel";
            listPriceLabel.Size = new System.Drawing.Size(88, 26);
            listPriceLabel.TabIndex = 10;
            listPriceLabel.Text = "Отпускная цена";
            listPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 242);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(357, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(276, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(listPriceLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.listPriceTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(standardCostLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.standardCostTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productNumberTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(productNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.finishedGoodsFlagCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.makeFlagCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(weightUnitMeasureCodeLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 242);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listPriceTextBox
            // 
            this.listPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true));
            this.listPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPriceTextBox.Location = new System.Drawing.Point(118, 175);
            this.listPriceTextBox.Name = "listPriceTextBox";
            this.listPriceTextBox.Size = new System.Drawing.Size(314, 20);
            this.listPriceTextBox.TabIndex = 6;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Wallnut.Domain.Models.Product);
            // 
            // standardCostTextBox
            // 
            this.standardCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "StandardCost", true));
            this.standardCostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardCostTextBox.Location = new System.Drawing.Point(118, 149);
            this.standardCostTextBox.Name = "standardCostTextBox";
            this.standardCostTextBox.Size = new System.Drawing.Size(314, 20);
            this.standardCostTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(118, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(314, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // productNumberTextBox
            // 
            this.productNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNumber", true));
            this.productNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNumberTextBox.Location = new System.Drawing.Point(118, 29);
            this.productNumberTextBox.Name = "productNumberTextBox";
            this.productNumberTextBox.Size = new System.Drawing.Size(314, 20);
            this.productNumberTextBox.TabIndex = 1;
            // 
            // finishedGoodsFlagCheckBox
            // 
            this.finishedGoodsFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "FinishedGoodsFlag", true));
            this.finishedGoodsFlagCheckBox.Location = new System.Drawing.Point(118, 55);
            this.finishedGoodsFlagCheckBox.Name = "finishedGoodsFlagCheckBox";
            this.finishedGoodsFlagCheckBox.Size = new System.Drawing.Size(252, 24);
            this.finishedGoodsFlagCheckBox.TabIndex = 2;
            this.finishedGoodsFlagCheckBox.Text = " Продукт предназначен для продажи";
            this.finishedGoodsFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeFlagCheckBox
            // 
            this.makeFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "MakeFlag", true));
            this.makeFlagCheckBox.Location = new System.Drawing.Point(118, 85);
            this.makeFlagCheckBox.Name = "makeFlagCheckBox";
            this.makeFlagCheckBox.Size = new System.Drawing.Size(226, 24);
            this.makeFlagCheckBox.TabIndex = 3;
            this.makeFlagCheckBox.Text = "Продукт изготовлен в компании";
            this.makeFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbUnitMesure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(118, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 28);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUnitMesure
            // 
            this.cbUnitMesure.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUnitMesure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnitMesure.FormattingEnabled = true;
            this.cbUnitMesure.Location = new System.Drawing.Point(0, 0);
            this.cbUnitMesure.Name = "cbUnitMesure";
            this.cbUnitMesure.Size = new System.Drawing.Size(266, 21);
            this.cbUnitMesure.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.productBindingSource;
            this.errorProvider1.RightToLeft = true;
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(551, 409);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 309);
            this.Name = "fAddProduct";
            this.Text = "Продукт";
            this.Activated += new System.EventHandler(this.fAddProduct_Activated);
            this.Load += new System.EventHandler(this.fAddProduct_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.CheckBox finishedGoodsFlagCheckBox;
        private System.Windows.Forms.CheckBox makeFlagCheckBox;
        private System.Windows.Forms.TextBox listPriceTextBox;
        private System.Windows.Forms.TextBox standardCostTextBox;
        private System.Windows.Forms.ComboBox cbUnitMesure;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
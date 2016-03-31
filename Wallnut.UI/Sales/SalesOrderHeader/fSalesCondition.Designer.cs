namespace Wallnut.UI.Sales.SalesOrderHeader
{
    partial class fSalesCondition
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chIsCustomer = new System.Windows.Forms.CheckBox();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.chIsSalesTerritory = new System.Windows.Forms.CheckBox();
            this.cbTerritoryID = new System.Windows.Forms.ComboBox();
            this.chIsSalesOrderNumber = new System.Windows.Forms.CheckBox();
            this.tbSalesOrderNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(353, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 40);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Установить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(467, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(96, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(132, 24);
            this.dtFrom.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(278, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(132, 24);
            this.dtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Период с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "по";
            // 
            // chIsCustomer
            // 
            this.chIsCustomer.AutoSize = true;
            this.chIsCustomer.Location = new System.Drawing.Point(16, 42);
            this.chIsCustomer.Name = "chIsCustomer";
            this.chIsCustomer.Size = new System.Drawing.Size(93, 22);
            this.chIsCustomer.TabIndex = 4;
            this.chIsCustomer.Text = "Заказчик";
            this.chIsCustomer.UseVisualStyleBackColor = true;
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(194, 42);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(360, 26);
            this.cbCustomerID.TabIndex = 5;
            // 
            // chIsSalesTerritory
            // 
            this.chIsSalesTerritory.AutoSize = true;
            this.chIsSalesTerritory.Location = new System.Drawing.Point(16, 76);
            this.chIsSalesTerritory.Name = "chIsSalesTerritory";
            this.chIsSalesTerritory.Size = new System.Drawing.Size(165, 22);
            this.chIsSalesTerritory.TabIndex = 4;
            this.chIsSalesTerritory.Text = "Территория продаж";
            this.chIsSalesTerritory.UseVisualStyleBackColor = true;
            // 
            // cbTerritoryID
            // 
            this.cbTerritoryID.FormattingEnabled = true;
            this.cbTerritoryID.Location = new System.Drawing.Point(194, 74);
            this.cbTerritoryID.Name = "cbTerritoryID";
            this.cbTerritoryID.Size = new System.Drawing.Size(360, 26);
            this.cbTerritoryID.TabIndex = 5;
            // 
            // chIsSalesOrderNumber
            // 
            this.chIsSalesOrderNumber.AutoSize = true;
            this.chIsSalesOrderNumber.Location = new System.Drawing.Point(16, 106);
            this.chIsSalesOrderNumber.Name = "chIsSalesOrderNumber";
            this.chIsSalesOrderNumber.Size = new System.Drawing.Size(126, 22);
            this.chIsSalesOrderNumber.TabIndex = 6;
            this.chIsSalesOrderNumber.Text = "Номер заказа";
            this.chIsSalesOrderNumber.UseVisualStyleBackColor = true;
            // 
            // tbSalesOrderNumber
            // 
            this.tbSalesOrderNumber.Location = new System.Drawing.Point(194, 106);
            this.tbSalesOrderNumber.Name = "tbSalesOrderNumber";
            this.tbSalesOrderNumber.Size = new System.Drawing.Size(360, 24);
            this.tbSalesOrderNumber.TabIndex = 7;
            // 
            // fSalesCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 261);
            this.Controls.Add(this.tbSalesOrderNumber);
            this.Controls.Add(this.chIsSalesOrderNumber);
            this.Controls.Add(this.cbTerritoryID);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.chIsSalesTerritory);
            this.Controls.Add(this.chIsCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(594, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(594, 299);
            this.Name = "fSalesCondition";
            this.Text = "Условие отбора заказов на продажу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chIsCustomer;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.CheckBox chIsSalesTerritory;
        private System.Windows.Forms.ComboBox cbTerritoryID;
        private System.Windows.Forms.CheckBox chIsSalesOrderNumber;
        private System.Windows.Forms.TextBox tbSalesOrderNumber;
    }
}
namespace Wallnut.UI.Purchasing.PurchaseOrder
{
    partial class fCondition
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
            this.dtFirst = new System.Windows.Forms.DateTimePicker();
            this.purchaseConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtLast = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseConditionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFirst
            // 
            this.dtFirst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseConditionBindingSource, "DateFirst", true));
            this.dtFirst.Location = new System.Drawing.Point(107, 24);
            this.dtFirst.Name = "dtFirst";
            this.dtFirst.ShowCheckBox = true;
            this.dtFirst.Size = new System.Drawing.Size(169, 24);
            this.dtFirst.TabIndex = 0;
            // 
            // purchaseConditionBindingSource
            // 
            this.purchaseConditionBindingSource.DataSource = typeof(Wallnut.Domain.Entities.PurchaseCondition);
            // 
            // dtLast
            // 
            this.dtLast.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseConditionBindingSource, "DateLast", true));
            this.dtLast.Location = new System.Drawing.Point(333, 24);
            this.dtLast.Name = "dtLast";
            this.dtLast.ShowCheckBox = true;
            this.dtLast.Size = new System.Drawing.Size(169, 24);
            this.dtLast.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "по";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(285, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 45);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Установить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.purchaseConditionBindingSource, "IsBigShipment", true));
            this.checkBox1.Location = new System.Drawing.Point(107, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 22);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Крупные партии";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.purchaseConditionBindingSource, "IsSmallWholesale", true));
            this.checkBox2.Location = new System.Drawing.Point(107, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 22);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Мелкий опт";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // fCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 176);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtLast);
            this.Controls.Add(this.dtFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 178);
            this.Name = "fCondition";
            this.Text = "Условие отбора";
            this.Load += new System.EventHandler(this.fCondition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseConditionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFirst;
        private System.Windows.Forms.DateTimePicker dtLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.BindingSource purchaseConditionBindingSource;
    }
}
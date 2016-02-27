namespace Wallnut.UI.Sales.CurrencyRate
{
    partial class fAddCurrencyRate
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
            this.lbRate = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.dtCurrencyRateDate = new System.Windows.Forms.DateTimePicker();
            this.сbFromCurrencyCode = new System.Windows.Forms.ComboBox();
            this.сbToCurrencyCode = new System.Windows.Forms.ComboBox();
            this.lbCurrencyRateDate = new System.Windows.Forms.Label();
            this.lbFromCurrencyCode = new System.Windows.Forms.Label();
            this.lbToCurrencyCode = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(273, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbRate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbRate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtCurrencyRateDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.сbFromCurrencyCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.сbToCurrencyCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCurrencyRateDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbFromCurrencyCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbToCurrencyCode, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRate.Location = new System.Drawing.Point(3, 81);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(31, 27);
            this.lbRate.TabIndex = 0;
            this.lbRate.Text = "Курс";
            this.lbRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRate
            // 
            this.tbRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRate.Location = new System.Drawing.Point(103, 84);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(326, 20);
            this.tbRate.TabIndex = 1;
            this.tbRate.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // dtCurrencyRateDate
            // 
            this.dtCurrencyRateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCurrencyRateDate.Location = new System.Drawing.Point(103, 3);
            this.dtCurrencyRateDate.Name = "dtCurrencyRateDate";
            this.dtCurrencyRateDate.Size = new System.Drawing.Size(326, 20);
            this.dtCurrencyRateDate.TabIndex = 2;
            // 
            // сbFromCurrencyCode
            // 
            this.сbFromCurrencyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сbFromCurrencyCode.FormattingEnabled = true;
            this.сbFromCurrencyCode.Location = new System.Drawing.Point(103, 28);
            this.сbFromCurrencyCode.Name = "сbFromCurrencyCode";
            this.сbFromCurrencyCode.Size = new System.Drawing.Size(326, 21);
            this.сbFromCurrencyCode.TabIndex = 3;
            // 
            // сbToCurrencyCode
            // 
            this.сbToCurrencyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сbToCurrencyCode.FormattingEnabled = true;
            this.сbToCurrencyCode.Location = new System.Drawing.Point(103, 56);
            this.сbToCurrencyCode.Name = "сbToCurrencyCode";
            this.сbToCurrencyCode.Size = new System.Drawing.Size(326, 21);
            this.сbToCurrencyCode.TabIndex = 4;
            // 
            // lbCurrencyRateDate
            // 
            this.lbCurrencyRateDate.AutoSize = true;
            this.lbCurrencyRateDate.Location = new System.Drawing.Point(3, 0);
            this.lbCurrencyRateDate.Name = "lbCurrencyRateDate";
            this.lbCurrencyRateDate.Size = new System.Drawing.Size(65, 13);
            this.lbCurrencyRateDate.TabIndex = 5;
            this.lbCurrencyRateDate.Text = "Дата курса";
            // 
            // lbFromCurrencyCode
            // 
            this.lbFromCurrencyCode.AutoSize = true;
            this.lbFromCurrencyCode.Location = new System.Drawing.Point(3, 25);
            this.lbFromCurrencyCode.Name = "lbFromCurrencyCode";
            this.lbFromCurrencyCode.Size = new System.Drawing.Size(63, 13);
            this.lbFromCurrencyCode.TabIndex = 6;
            this.lbFromCurrencyCode.Text = "Валюта ИЗ";
            // 
            // lbToCurrencyCode
            // 
            this.lbToCurrencyCode.AutoSize = true;
            this.lbToCurrencyCode.Location = new System.Drawing.Point(3, 53);
            this.lbToCurrencyCode.Name = "lbToCurrencyCode";
            this.lbToCurrencyCode.Size = new System.Drawing.Size(55, 13);
            this.lbToCurrencyCode.TabIndex = 7;
            this.lbToCurrencyCode.Text = "Валюта В";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // fAddCurrencyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fAddCurrencyRate";
            this.Text = "fAddCurrencyRate";
            this.Load += new System.EventHandler(this.fEdit_Load);
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
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DateTimePicker dtCurrencyRateDate;
        private System.Windows.Forms.ComboBox сbFromCurrencyCode;
        private System.Windows.Forms.ComboBox сbToCurrencyCode;
        private System.Windows.Forms.Label lbCurrencyRateDate;
        private System.Windows.Forms.Label lbFromCurrencyCode;
        private System.Windows.Forms.Label lbToCurrencyCode;
    }
}
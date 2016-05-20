namespace Wallnut.UI.Production.frmWorkOrderHistory
{
    partial class fAddWorkOrderHistory
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
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBusinessEntityID = new System.Windows.Forms.ComboBox();
            this.cbLocationID = new System.Windows.Forms.ComboBox();
            this.dtActualStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtActualEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbActualCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxActualResourceHrs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tbNamelbl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbProductID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbBusinessEntityID, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbLocationID, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtActualStartDate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtActualEndDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbActualCost, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbxActualResourceHrs, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbQty, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbNamelbl
            // 
            this.tbNamelbl.AutoSize = true;
            this.tbNamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNamelbl.Location = new System.Drawing.Point(34, 245);
            this.tbNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNamelbl.Name = "tbNamelbl";
            this.tbNamelbl.Size = new System.Drawing.Size(109, 35);
            this.tbNamelbl.TabIndex = 0;
            this.tbNamelbl.Text = "Время работы";
            this.tbNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProductID
            // 
            this.cbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(334, 39);
            this.cbProductID.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(384, 26);
            this.cbProductID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование продукции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Раотник";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Расположение";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Начальная дата";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(34, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Конечная дата";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBusinessEntityID
            // 
            this.cbBusinessEntityID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBusinessEntityID.FormattingEnabled = true;
            this.cbBusinessEntityID.Location = new System.Drawing.Point(334, 74);
            this.cbBusinessEntityID.Margin = new System.Windows.Forms.Padding(4);
            this.cbBusinessEntityID.Name = "cbBusinessEntityID";
            this.cbBusinessEntityID.Size = new System.Drawing.Size(384, 26);
            this.cbBusinessEntityID.TabIndex = 2;
            // 
            // cbLocationID
            // 
            this.cbLocationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLocationID.FormattingEnabled = true;
            this.cbLocationID.Location = new System.Drawing.Point(334, 109);
            this.cbLocationID.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocationID.Name = "cbLocationID";
            this.cbLocationID.Size = new System.Drawing.Size(384, 26);
            this.cbLocationID.TabIndex = 2;
            // 
            // dtActualStartDate
            // 
            this.dtActualStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtActualStartDate.Location = new System.Drawing.Point(334, 144);
            this.dtActualStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtActualStartDate.Name = "dtActualStartDate";
            this.dtActualStartDate.Size = new System.Drawing.Size(384, 24);
            this.dtActualStartDate.TabIndex = 4;
            // 
            // dtActualEndDate
            // 
            this.dtActualEndDate.Checked = false;
            this.dtActualEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtActualEndDate.Location = new System.Drawing.Point(334, 179);
            this.dtActualEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtActualEndDate.Name = "dtActualEndDate";
            this.dtActualEndDate.ShowCheckBox = true;
            this.dtActualEndDate.Size = new System.Drawing.Size(384, 24);
            this.dtActualEndDate.TabIndex = 5;
            this.dtActualEndDate.ValueChanged += new System.EventHandler(this.dtActualEndDate_ValueChanged);
            // 
            // tbActualCost
            // 
            this.tbActualCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActualCost.Location = new System.Drawing.Point(334, 284);
            this.tbActualCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbActualCost.Name = "tbActualCost";
            this.tbActualCost.Size = new System.Drawing.Size(384, 24);
            this.tbActualCost.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(34, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Стоимость работы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxActualResourceHrs
            // 
            this.tbxActualResourceHrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxActualResourceHrs.Location = new System.Drawing.Point(334, 249);
            this.tbxActualResourceHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbxActualResourceHrs.Name = "tbxActualResourceHrs";
            this.tbxActualResourceHrs.Size = new System.Drawing.Size(384, 24);
            this.tbxActualResourceHrs.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(34, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbQty
            // 
            this.tbQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQty.Location = new System.Drawing.Point(334, 214);
            this.tbQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(384, 24);
            this.tbQty.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(636, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(516, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // fAddWorkOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 385);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAddWorkOrderHistory";
            this.Text = "Заказ на производство.";
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
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBusinessEntityID;
        private System.Windows.Forms.ComboBox cbLocationID;
        private System.Windows.Forms.DateTimePicker dtActualStartDate;
        private System.Windows.Forms.DateTimePicker dtActualEndDate;
        private System.Windows.Forms.TextBox tbActualCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxActualResourceHrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQty;
    }
}
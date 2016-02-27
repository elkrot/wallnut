﻿namespace Wallnut.UI.HumanResources.frmEmployeeAttendanceHistory
{
    partial class fAddEmployeeAttendanceHistory
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
            this.tbRate = new System.Windows.Forms.TextBox();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWorkedOutHrs = new System.Windows.Forms.TextBox();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
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
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.tbRate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployeeID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtStartDate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtEndDate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbWorkedOutHrs, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtStartTime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtEndTime, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbRate
            // 
            this.tbRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRate.Location = new System.Drawing.Point(144, 98);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(200, 20);
            this.tbRate.TabIndex = 1;
            this.tbRate.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(144, 23);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(200, 21);
            this.cbEmployeeID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работник";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(144, 48);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Checked = false;
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(144, 73);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.ShowCheckBox = true;
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 5;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начало работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Окончание работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тариф";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Отработано часов";
            // 
            // tbWorkedOutHrs
            // 
            this.tbWorkedOutHrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWorkedOutHrs.Location = new System.Drawing.Point(144, 123);
            this.tbWorkedOutHrs.Name = "tbWorkedOutHrs";
            this.tbWorkedOutHrs.Size = new System.Drawing.Size(200, 20);
            this.tbWorkedOutHrs.TabIndex = 8;
            // 
            // dtStartTime
            // 
            this.dtStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtStartTime.CustomFormat = "HH:mm";
            this.dtStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(350, 48);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtStartTime.TabIndex = 9;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "HH:mm";
            this.dtEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(350, 73);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.ShowUpDown = true;
            this.dtEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtEndTime.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(496, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(415, 3);
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
            // fAddEmployeeAttendanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 242);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fAddEmployeeAttendanceHistory";
            this.Text = "История выходов";
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
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWorkedOutHrs;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
    }
}
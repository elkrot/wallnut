﻿namespace Wallnut.UI
{
    partial class fAddShift
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
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStartTime = new System.Windows.Forms.MaskedTextBox();
            this.mtbEndTime = new System.Windows.Forms.MaskedTextBox();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            nameLabel.Location = new System.Drawing.Point(24, 20);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(115, 33);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Наименование:";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            startTimeLabel.Location = new System.Drawing.Point(24, 53);
            startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(115, 32);
            startTimeLabel.TabIndex = 2;
            startTimeLabel.Text = "Начало смены:";
            startTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            endTimeLabel.Location = new System.Drawing.Point(24, 85);
            endTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(105, 33);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "Конец смены:";
            endTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 218);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(374, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(254, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.52128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.47872F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(endTimeLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(startTimeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbStartTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtbEndTime, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 218);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftBindingSource, "Name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(156, 24);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(308, 24);
            this.nameTextBox.TabIndex = 1;
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(Wallnut.Domain.Models.Shift);
            this.shiftBindingSource.CurrentChanged += new System.EventHandler(this.shiftBindingSource_CurrentChanged);
            // 
            // tbStartTime
            // 
            this.tbStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftBindingSource, "StartTime", true));
            this.tbStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStartTime.Location = new System.Drawing.Point(156, 57);
            this.tbStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbStartTime.Mask = "00:00";
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(308, 24);
            this.tbStartTime.TabIndex = 6;
            this.tbStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtbEndTime
            // 
            this.mtbEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftBindingSource, "EndTime", true));
            this.mtbEndTime.Location = new System.Drawing.Point(156, 89);
            this.mtbEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtbEndTime.Mask = "00:00";
            this.mtbEndTime.Name = "mtbEndTime";
            this.mtbEndTime.Size = new System.Drawing.Size(148, 24);
            this.mtbEndTime.TabIndex = 7;
            this.mtbEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // fAddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(506, 189);
            this.Name = "fAddShift";
            this.Text = "Добавить смену";
            this.Load += new System.EventHandler(this.fAddShift_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private System.Windows.Forms.MaskedTextBox tbStartTime;
        private System.Windows.Forms.MaskedTextBox mtbEndTime;
    }
}
namespace Wallnut.UI
{
    partial class fShifts
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
            this.bsShift = new System.Windows.Forms.BindingSource(this.components);
            this.shiftBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.tbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingNavigator)).BeginInit();
            this.shiftBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // bsShift
            // 
            this.bsShift.DataSource = typeof(Wallnut.Domain.Models.Shift);
            // 
            // shiftBindingNavigator
            // 
            this.shiftBindingNavigator.AddNewItem = null;
            this.shiftBindingNavigator.CountItem = null;
            this.shiftBindingNavigator.DeleteItem = null;
            this.shiftBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.shiftBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbnAdd,
            this.tsbEdit,
            this.tsbRemove,
            this.toolStripButton3});
            this.shiftBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shiftBindingNavigator.MoveFirstItem = null;
            this.shiftBindingNavigator.MoveLastItem = null;
            this.shiftBindingNavigator.MoveNextItem = null;
            this.shiftBindingNavigator.MovePreviousItem = null;
            this.shiftBindingNavigator.Name = "shiftBindingNavigator";
            this.shiftBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.shiftBindingNavigator.PositionItem = null;
            this.shiftBindingNavigator.Size = new System.Drawing.Size(849, 39);
            this.shiftBindingNavigator.TabIndex = 0;
            this.shiftBindingNavigator.Text = "bindingNavigator1";
            // 
            // tbnAdd
            // 
            this.tbnAdd.Image = global::Wallnut.UI.Properties.Resources.edit_add;
            this.tbnAdd.Name = "tbnAdd";
            this.tbnAdd.Size = new System.Drawing.Size(95, 36);
            this.tbnAdd.Text = "Добавить";
            this.tbnAdd.Click += new System.EventHandler(this.shiftBindingNavigatorSaveItem_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Wallnut.UI.Properties.Resources.pencil;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(97, 36);
            this.tsbEdit.Text = "Изменить";
            this.tsbEdit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.Image = global::Wallnut.UI.Properties.Resources.edit_delete;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(87, 36);
            this.tsbRemove.Text = "Удалить";
            this.tsbRemove.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AutoGenerateColumns = false;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcName,
            this.tbcStartTime,
            this.tbcEndTime});
            this.dgvShift.DataSource = this.bsShift;
            this.dgvShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShift.Location = new System.Drawing.Point(0, 39);
            this.dgvShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShift.Size = new System.Drawing.Size(849, 432);
            this.dgvShift.TabIndex = 1;
            // 
            // tbcName
            // 
            this.tbcName.DataPropertyName = "Name";
            this.tbcName.HeaderText = "Наименование";
            this.tbcName.Name = "tbcName";
            this.tbcName.Width = 200;
            // 
            // tbcStartTime
            // 
            this.tbcStartTime.DataPropertyName = "StartTime";
            this.tbcStartTime.HeaderText = "Начало смены";
            this.tbcStartTime.Name = "tbcStartTime";
            this.tbcStartTime.Width = 150;
            // 
            // tbcEndTime
            // 
            this.tbcEndTime.DataPropertyName = "EndTime";
            this.tbcEndTime.HeaderText = "Конец смены";
            this.tbcEndTime.Name = "tbcEndTime";
            this.tbcEndTime.Width = 150;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvShift);
            this.Controls.Add(this.shiftBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fShifts";
            this.Text = "Смены";
            this.Load += new System.EventHandler(this.fShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingNavigator)).EndInit();
            this.shiftBindingNavigator.ResumeLayout(false);
            this.shiftBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsShift;
        private System.Windows.Forms.BindingNavigator shiftBindingNavigator;
        private System.Windows.Forms.ToolStripButton tbnAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcEndTime;
    }
}
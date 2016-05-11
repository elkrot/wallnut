namespace Wallnut.UI
{
    partial class fDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDepartment));
            this.ssDepartment = new System.Windows.Forms.StatusStrip();
            this.bnDepartment = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnDepartment)).BeginInit();
            this.bnDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // ssDepartment
            // 
            this.ssDepartment.Location = new System.Drawing.Point(0, 434);
            this.ssDepartment.Name = "ssDepartment";
            this.ssDepartment.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssDepartment.Size = new System.Drawing.Size(686, 22);
            this.ssDepartment.TabIndex = 0;
            this.ssDepartment.Text = "statusStrip1";
            // 
            // bnDepartment
            // 
            this.bnDepartment.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnDepartment.BindingSource = this.bsDepartment;
            this.bnDepartment.CountItem = null;
            this.bnDepartment.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnDepartment.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bnDepartment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bnDepartment.Location = new System.Drawing.Point(0, 0);
            this.bnDepartment.MoveFirstItem = null;
            this.bnDepartment.MoveLastItem = null;
            this.bnDepartment.MoveNextItem = null;
            this.bnDepartment.MovePreviousItem = null;
            this.bnDepartment.Name = "bnDepartment";
            this.bnDepartment.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnDepartment.PositionItem = null;
            this.bnDepartment.Size = new System.Drawing.Size(686, 39);
            this.bnDepartment.TabIndex = 1;
            this.bnDepartment.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDepartment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 395);
            this.panel1.TabIndex = 2;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AutoGenerateColumns = false;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentName,
            this.GroupName});
            this.dgvDepartment.DataSource = this.bsDepartment;
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(686, 395);
            this.dgvDepartment.TabIndex = 0;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "Name";
            this.DepartmentName.FillWeight = 200F;
            this.DepartmentName.HeaderText = "Наименование подразделения";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 200;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Наименование группы";
            this.GroupName.Name = "GroupName";
            this.GroupName.Width = 200;
            // 
            // fDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnDepartment);
            this.Controls.Add(this.ssDepartment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fDepartment";
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.fDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnDepartment)).EndInit();
            this.bnDepartment.ResumeLayout(false);
            this.bnDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartment)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssDepartment;
        private System.Windows.Forms.BindingNavigator bnDepartment;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsDepartment;
        public System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}
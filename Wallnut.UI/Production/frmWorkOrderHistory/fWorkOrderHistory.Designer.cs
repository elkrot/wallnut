namespace Wallnut.UI.Production.frmWorkOrderHistory
{
    partial class fWorkOrderHistory
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
            aForm = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWorkOrderHistory));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualResourceHrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.WorkOrderHistory);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.colQty,
            this.colEmployeeName,
            this.colLocationID,
            this.actualStartDateDataGridViewTextBoxColumn,
            this.actualEndDateDataGridViewTextBoxColumn,
            this.actualResourceHrsDataGridViewTextBoxColumn,
            this.actualCostDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1018, 302);
            this.dgv.TabIndex = 2;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Количество";
            this.colQty.Name = "colQty";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.DataPropertyName = "EmployeeName";
            this.colEmployeeName.HeaderText = "Работник";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.ReadOnly = true;
            // 
            // colLocationID
            // 
            this.colLocationID.DataPropertyName = "LocationName";
            this.colLocationID.HeaderText = "Расположение";
            this.colLocationID.Name = "colLocationID";
            this.colLocationID.ReadOnly = true;
            // 
            // actualStartDateDataGridViewTextBoxColumn
            // 
            this.actualStartDateDataGridViewTextBoxColumn.DataPropertyName = "ActualStartDate";
            this.actualStartDateDataGridViewTextBoxColumn.HeaderText = "Начальная дата";
            this.actualStartDateDataGridViewTextBoxColumn.Name = "actualStartDateDataGridViewTextBoxColumn";
            // 
            // actualEndDateDataGridViewTextBoxColumn
            // 
            this.actualEndDateDataGridViewTextBoxColumn.DataPropertyName = "ActualEndDate";
            this.actualEndDateDataGridViewTextBoxColumn.HeaderText = "Конечная дата";
            this.actualEndDateDataGridViewTextBoxColumn.Name = "actualEndDateDataGridViewTextBoxColumn";
            this.actualEndDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // actualResourceHrsDataGridViewTextBoxColumn
            // 
            this.actualResourceHrsDataGridViewTextBoxColumn.DataPropertyName = "ActualResourceHrs";
            this.actualResourceHrsDataGridViewTextBoxColumn.HeaderText = "Временные затраты";
            this.actualResourceHrsDataGridViewTextBoxColumn.Name = "actualResourceHrsDataGridViewTextBoxColumn";
            this.actualResourceHrsDataGridViewTextBoxColumn.Visible = false;
            // 
            // actualCostDataGridViewTextBoxColumn
            // 
            this.actualCostDataGridViewTextBoxColumn.DataPropertyName = "ActualCost";
            this.actualCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.actualCostDataGridViewTextBoxColumn.Name = "actualCostDataGridViewTextBoxColumn";
            this.actualCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // bn
            // 
            this.bn.AddNewItem = null;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = null;
            this.bn.DeleteItem = null;
            this.bn.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton3,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = null;
            this.bn.MoveLastItem = null;
            this.bn.MoveNextItem = null;
            this.bn.MovePreviousItem = null;
            this.bn.Name = "bn";
            this.bn.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bn.PositionItem = null;
            this.bn.Size = new System.Drawing.Size(1018, 39);
            this.bn.TabIndex = 1;
            this.bn.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::Wallnut.UI.Properties.Resources.purchase;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 36);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(140, 36);
            this.toolStripButton3.Text = "Выдача в производство";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Wallnut.UI.Properties.Resources.edit_add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(95, 36);
            this.tsbAdd.Text = "Добавить";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Wallnut.UI.Properties.Resources.pencil;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(97, 36);
            this.tsbEdit.Text = "Изменить";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Wallnut.UI.Properties.Resources.edit_delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(87, 36);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Wallnut.UI.Properties.Resources.role;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(91, 36);
            this.toolStripButton2.Text = "В работу";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 341);
            this.ss.Name = "ss";
            this.ss.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss.Size = new System.Drawing.Size(1018, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // fWorkOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 363);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fWorkOrderHistory";
            this.Text = "История. Производство";
            this.Load += new System.EventHandler(this.fList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualResourceHrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualCostDataGridViewTextBoxColumn;
    }
}
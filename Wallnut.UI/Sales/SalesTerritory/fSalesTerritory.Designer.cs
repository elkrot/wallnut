namespace Wallnut.UI.Sales.SalesTerritory
{
    partial class fSalesTerritory
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
            this.ss = new System.Windows.Forms.StatusStrip();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesYTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesLastYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costYTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costLastYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.SalesTerritory);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 561);
            this.ss.Name = "ss";
            this.ss.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss.Size = new System.Drawing.Size(1732, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // bn
            // 
            this.bn.AddNewItem = null;
            this.bn.BindingSource = this.bs;
            this.bn.CountItem = null;
            this.bn.DeleteItem = null;
            this.bn.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = null;
            this.bn.MoveLastItem = null;
            this.bn.MoveNextItem = null;
            this.bn.MovePreviousItem = null;
            this.bn.Name = "bn";
            this.bn.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bn.PositionItem = null;
            this.bn.Size = new System.Drawing.Size(1732, 39);
            this.bn.TabIndex = 1;
            this.bn.Text = "bindingNavigator1";
            this.bn.RefreshItems += new System.EventHandler(this.bn_RefreshItems);
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
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countryRegionCodeDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.salesYTDDataGridViewTextBoxColumn,
            this.salesLastYearDataGridViewTextBoxColumn,
            this.costYTDDataGridViewTextBoxColumn,
            this.costLastYearDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1732, 522);
            this.dgv.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Территория";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Описание территории продаж";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // countryRegionCodeDataGridViewTextBoxColumn
            // 
            this.countryRegionCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryRegionCode";
            this.countryRegionCodeDataGridViewTextBoxColumn.HeaderText = "Код страны";
            this.countryRegionCodeDataGridViewTextBoxColumn.Name = "countryRegionCodeDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.FillWeight = 300F;
            this.groupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ToolTipText = "Географическая область, к которой принадлежит территория продаж";
            this.groupDataGridViewTextBoxColumn.Width = 300;
            // 
            // salesYTDDataGridViewTextBoxColumn
            // 
            this.salesYTDDataGridViewTextBoxColumn.DataPropertyName = "SalesYTD";
            this.salesYTDDataGridViewTextBoxColumn.HeaderText = "Годовой объем";
            this.salesYTDDataGridViewTextBoxColumn.Name = "salesYTDDataGridViewTextBoxColumn";
            this.salesYTDDataGridViewTextBoxColumn.ToolTipText = "Продажи на территории с начала года до настоящего времени";
            // 
            // salesLastYearDataGridViewTextBoxColumn
            // 
            this.salesLastYearDataGridViewTextBoxColumn.DataPropertyName = "SalesLastYear";
            this.salesLastYearDataGridViewTextBoxColumn.HeaderText = "Продажи за пред Год";
            this.salesLastYearDataGridViewTextBoxColumn.Name = "salesLastYearDataGridViewTextBoxColumn";
            this.salesLastYearDataGridViewTextBoxColumn.ToolTipText = "Продажи на территории в предыдущем году";
            // 
            // costYTDDataGridViewTextBoxColumn
            // 
            this.costYTDDataGridViewTextBoxColumn.DataPropertyName = "CostYTD";
            this.costYTDDataGridViewTextBoxColumn.HeaderText = "Расходы за год";
            this.costYTDDataGridViewTextBoxColumn.Name = "costYTDDataGridViewTextBoxColumn";
            this.costYTDDataGridViewTextBoxColumn.ToolTipText = "Расходы по территории продаж с начала года до настоящего времени";
            // 
            // costLastYearDataGridViewTextBoxColumn
            // 
            this.costLastYearDataGridViewTextBoxColumn.DataPropertyName = "CostLastYear";
            this.costLastYearDataGridViewTextBoxColumn.HeaderText = "Расходы пред Год";
            this.costLastYearDataGridViewTextBoxColumn.Name = "costLastYearDataGridViewTextBoxColumn";
            this.costLastYearDataGridViewTextBoxColumn.ToolTipText = "Расходы по территории продаж в предыдущем году";
            // 
            // fSalesTerritory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 583);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fSalesTerritory";
            this.Text = "Территория продаж";
            this.Load += new System.EventHandler(this.fList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryRegionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesYTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLastYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costYTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costLastYearDataGridViewTextBoxColumn;
    }
}
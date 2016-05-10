namespace Wallnut.UI
{
    partial class fProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProducts));
            this.ssProducts = new System.Windows.Forms.StatusStrip();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnProducts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbProductListPriceHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbProductCostHistory = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightUnitMeasureCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnProducts)).BeginInit();
            this.bnProducts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // ssProducts
            // 
            this.ssProducts.Location = new System.Drawing.Point(0, 386);
            this.ssProducts.Name = "ssProducts";
            this.ssProducts.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssProducts.Size = new System.Drawing.Size(820, 22);
            this.ssProducts.TabIndex = 0;
            this.ssProducts.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 37);
            this.panel1.TabIndex = 2;
            // 
            // bnProducts
            // 
            this.bnProducts.AddNewItem = null;
            this.bnProducts.BindingSource = this.bsProducts;
            this.bnProducts.CountItem = null;
            this.bnProducts.DeleteItem = null;
            this.bnProducts.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bnProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbProductListPriceHistory,
            this.tsbProductCostHistory});
            this.bnProducts.Location = new System.Drawing.Point(0, 0);
            this.bnProducts.MoveFirstItem = null;
            this.bnProducts.MoveLastItem = null;
            this.bnProducts.MoveNextItem = null;
            this.bnProducts.MovePreviousItem = null;
            this.bnProducts.Name = "bnProducts";
            this.bnProducts.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnProducts.PositionItem = null;
            this.bnProducts.Size = new System.Drawing.Size(820, 39);
            this.bnProducts.TabIndex = 5;
            this.bnProducts.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(81, 36);
            this.tsbAdd.Text = "tsbAdd";
            this.tsbAdd.ToolTipText = "Добавить";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click_1);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(79, 36);
            this.tsbEdit.Text = "tsbEdit";
            this.tsbEdit.ToolTipText = "Изменить";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(87, 36);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbProductListPriceHistory
            // 
            this.tsbProductListPriceHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbProductListPriceHistory.Image")));
            this.tsbProductListPriceHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductListPriceHistory.Name = "tsbProductListPriceHistory";
            this.tsbProductListPriceHistory.Size = new System.Drawing.Size(188, 36);
            this.tsbProductListPriceHistory.Text = "История продажной цены";
            this.tsbProductListPriceHistory.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tsbProductCostHistory
            // 
            this.tsbProductCostHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbProductCostHistory.Image")));
            this.tsbProductCostHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductCostHistory.Name = "tsbProductCostHistory";
            this.tsbProductCostHistory.Size = new System.Drawing.Size(168, 36);
            this.tsbProductCostHistory.Text = "История цены закупки";
            this.tsbProductCostHistory.Click += new System.EventHandler(this.tsbProductCostHistory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(820, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeyDisplayString = "F7";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 324);
            this.panel2.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.WeightUnitMeasureCode});
            this.dgvProducts.DataSource = this.bsProducts;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(820, 324);
            this.dgvProducts.TabIndex = 1;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.FillWeight = 300F;
            this.NameProduct.HeaderText = "Наименование";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 300;
            // 
            // WeightUnitMeasureCode
            // 
            this.WeightUnitMeasureCode.DataPropertyName = "WeightUnitMeasureCode";
            this.WeightUnitMeasureCode.HeaderText = "ЕдИзм";
            this.WeightUnitMeasureCode.Name = "WeightUnitMeasureCode";
            this.WeightUnitMeasureCode.ReadOnly = true;
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssProducts);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fProducts";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.fProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fProducts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnProducts)).EndInit();
            this.bnProducts.ResumeLayout(false);
            this.bnProducts.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bnProducts;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ToolStripButton tsbProductListPriceHistory;
        private System.Windows.Forms.ToolStripButton tsbProductCostHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightUnitMeasureCode;
    }
}
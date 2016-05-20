namespace Wallnut.UI.Persons.frmBusinessEntityAddress
{
    partial class fBusinessEntityAddress
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
            this.cbAddressTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAddressTytleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 240);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(564, 22);
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
            this.bn.PositionItem = null;
            this.bn.Size = new System.Drawing.Size(564, 39);
            this.bn.TabIndex = 1;
            this.bn.Text = "bindingNavigator1";
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
            this.cbAddressTitle,
            this.cbAddressTytleTitle});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(564, 201);
            this.dgv.TabIndex = 2;
            // 
            // cbAddressTitle
            // 
            this.cbAddressTitle.DataPropertyName = "AddressTitle";
            this.cbAddressTitle.FillWeight = 300F;
            this.cbAddressTitle.HeaderText = "Адрес";
            this.cbAddressTitle.Name = "cbAddressTitle";
            this.cbAddressTitle.Width = 300;
            // 
            // cbAddressTytleTitle
            // 
            this.cbAddressTytleTitle.DataPropertyName = "AddressTytleTitle";
            this.cbAddressTytleTitle.FillWeight = 200F;
            this.cbAddressTytleTitle.HeaderText = "Тип Адреса";
            this.cbAddressTytleTitle.Name = "cbAddressTytleTitle";
            this.cbAddressTytleTitle.Width = 200;
            // 
            // fBusinessEntityAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ss);
            this.Name = "fBusinessEntityAddress";
            this.Text = "Адреса";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cbAddressTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbAddressTytleTitle;
    }
}
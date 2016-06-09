namespace Wallnut.UI.HumanResources.frmSalaryPaymentOrder
{
    partial class fSalaryPaymentOrder
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.bsdetail = new System.Windows.Forms.BindingSource(this.components);
            this.bnDetail = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbAddDetail = new System.Windows.Forms.ToolStripButton();
            this.tsbEditDetail = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetail)).BeginInit();
            this.bnDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.SalaryPaymentOrder);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 341);
            this.ss.Name = "ss";
            this.ss.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss.Size = new System.Drawing.Size(778, 22);
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
            this.toolStripButton1,
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
            this.bn.Size = new System.Drawing.Size(778, 39);
            this.bn.TabIndex = 1;
            this.bn.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Wallnut.UI.Properties.Resources.filter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 36);
            this.toolStripButton1.Text = "Усовие";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.orderNoDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalSalaryPaymentDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(778, 133);
            this.dgv.TabIndex = 2;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "Ведомость №";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата ведомости";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // totalSalaryPaymentDataGridViewTextBoxColumn
            // 
            this.totalSalaryPaymentDataGridViewTextBoxColumn.DataPropertyName = "TotalSalaryPayment";
            this.totalSalaryPaymentDataGridViewTextBoxColumn.HeaderText = "Итого по ведомости";
            this.totalSalaryPaymentDataGridViewTextBoxColumn.Name = "totalSalaryPaymentDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Controls.Add(this.bnDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 169);
            this.panel1.TabIndex = 3;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AutoGenerateColumns = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.salaryPaymentDataGridViewTextBoxColumn});
            this.dgvDetail.DataSource = this.bsdetail;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 39);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(778, 130);
            this.dgvDetail.TabIndex = 3;
            // 
            // bsdetail
            // 
            this.bsdetail.DataSource = typeof(Wallnut.Domain.Models.SalaryPaymentHistory);
            // 
            // bnDetail
            // 
            this.bnDetail.AddNewItem = null;
            this.bnDetail.BindingSource = this.bs;
            this.bnDetail.CountItem = null;
            this.bnDetail.DeleteItem = null;
            this.bnDetail.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bnDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddDetail,
            this.tsbEditDetail,
            this.tsbDeleteDetail});
            this.bnDetail.Location = new System.Drawing.Point(0, 0);
            this.bnDetail.MoveFirstItem = null;
            this.bnDetail.MoveLastItem = null;
            this.bnDetail.MoveNextItem = null;
            this.bnDetail.MovePreviousItem = null;
            this.bnDetail.Name = "bnDetail";
            this.bnDetail.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnDetail.PositionItem = null;
            this.bnDetail.Size = new System.Drawing.Size(778, 39);
            this.bnDetail.TabIndex = 2;
            this.bnDetail.Text = "bindingNavigator1";
            // 
            // tsbAddDetail
            // 
            this.tsbAddDetail.Image = global::Wallnut.UI.Properties.Resources.edit_add;
            this.tsbAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddDetail.Name = "tsbAddDetail";
            this.tsbAddDetail.Size = new System.Drawing.Size(95, 36);
            this.tsbAddDetail.Text = "Добавить";
            this.tsbAddDetail.Click += new System.EventHandler(this.tsbAddDetail_Click);
            // 
            // tsbEditDetail
            // 
            this.tsbEditDetail.Image = global::Wallnut.UI.Properties.Resources.pencil;
            this.tsbEditDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditDetail.Name = "tsbEditDetail";
            this.tsbEditDetail.Size = new System.Drawing.Size(97, 36);
            this.tsbEditDetail.Text = "Изменить";
            this.tsbEditDetail.Click += new System.EventHandler(this.tsbEditDetail_Click);
            // 
            // tsbDeleteDetail
            // 
            this.tsbDeleteDetail.Image = global::Wallnut.UI.Properties.Resources.edit_delete;
            this.tsbDeleteDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteDetail.Name = "tsbDeleteDetail";
            this.tsbDeleteDetail.Size = new System.Drawing.Size(87, 36);
            this.tsbDeleteDetail.Text = "Удалить";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.employeeIDDataGridViewTextBoxColumn.FillWeight = 300F;
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ФИО Сотрудника";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryPaymentDataGridViewTextBoxColumn
            // 
            this.salaryPaymentDataGridViewTextBoxColumn.DataPropertyName = "SalaryPayment";
            this.salaryPaymentDataGridViewTextBoxColumn.FillWeight = 200F;
            this.salaryPaymentDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.salaryPaymentDataGridViewTextBoxColumn.Name = "salaryPaymentDataGridViewTextBoxColumn";
            this.salaryPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryPaymentDataGridViewTextBoxColumn.Width = 200;
            // 
            // fSalaryPaymentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fSalaryPaymentOrder";
            this.Text = "Ведомость выдачи заработной платы";
            this.Load += new System.EventHandler(this.fList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetail)).EndInit();
            this.bnDetail.ResumeLayout(false);
            this.bnDetail.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.BindingSource bsdetail;
        private System.Windows.Forms.BindingNavigator bnDetail;
        private System.Windows.Forms.ToolStripButton tsbAddDetail;
        private System.Windows.Forms.ToolStripButton tsbEditDetail;
        private System.Windows.Forms.ToolStripButton tsbDeleteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPaymentDataGridViewTextBoxColumn;
    }
}
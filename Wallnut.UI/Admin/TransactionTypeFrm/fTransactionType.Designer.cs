﻿namespace Wallnut.UI.Admin.TransactionTypeFrm
{
    partial class fTransactionType
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
            this.transactionTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationSequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSysRowDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.TransactionType);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 341);
            this.ss.Name = "ss";
            this.ss.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss.Size = new System.Drawing.Size(748, 22);
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
            this.bn.Size = new System.Drawing.Size(748, 39);
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
            this.transactionTypeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.operationSequenceDataGridViewTextBoxColumn,
            this.locationIDFromDataGridViewTextBoxColumn,
            this.locationIDToDataGridViewTextBoxColumn,
            this.isSysRowDataGridViewCheckBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 39);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(748, 302);
            this.dgv.TabIndex = 2;
            // 
            // transactionTypeIDDataGridViewTextBoxColumn
            // 
            this.transactionTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionTypeID";
            this.transactionTypeIDDataGridViewTextBoxColumn.HeaderText = "Код";
            this.transactionTypeIDDataGridViewTextBoxColumn.Name = "transactionTypeIDDataGridViewTextBoxColumn";
            this.transactionTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // operationSequenceDataGridViewTextBoxColumn
            // 
            this.operationSequenceDataGridViewTextBoxColumn.DataPropertyName = "OperationSequence";
            this.operationSequenceDataGridViewTextBoxColumn.HeaderText = "Порядок";
            this.operationSequenceDataGridViewTextBoxColumn.Name = "operationSequenceDataGridViewTextBoxColumn";
            this.operationSequenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationIDFromDataGridViewTextBoxColumn
            // 
            this.locationIDFromDataGridViewTextBoxColumn.DataPropertyName = "LocationIDFrom";
            this.locationIDFromDataGridViewTextBoxColumn.HeaderText = "Откуда";
            this.locationIDFromDataGridViewTextBoxColumn.Name = "locationIDFromDataGridViewTextBoxColumn";
            this.locationIDFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationIDToDataGridViewTextBoxColumn
            // 
            this.locationIDToDataGridViewTextBoxColumn.DataPropertyName = "LocationIDTo";
            this.locationIDToDataGridViewTextBoxColumn.HeaderText = "Куда";
            this.locationIDToDataGridViewTextBoxColumn.Name = "locationIDToDataGridViewTextBoxColumn";
            this.locationIDToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isSysRowDataGridViewCheckBoxColumn
            // 
            this.isSysRowDataGridViewCheckBoxColumn.DataPropertyName = "IsSysRow";
            this.isSysRowDataGridViewCheckBoxColumn.HeaderText = "Системная строка";
            this.isSysRowDataGridViewCheckBoxColumn.Name = "isSysRowDataGridViewCheckBoxColumn";
            this.isSysRowDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 363);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.ss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTransactionType";
            this.Text = "Тип транзакции";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationSequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSysRowDataGridViewCheckBoxColumn;
    }
}
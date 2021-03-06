﻿namespace Wallnut.UI.Sales.SalesOrderHeader
{
    partial class fSalesOrderHeader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.revisionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.territoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipMethodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyRateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.carrierTrackingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialOfferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnDetail = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbAddDetail = new System.Windows.Forms.ToolStripButton();
            this.tsbEditDetail = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetail)).BeginInit();
            this.bnDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Wallnut.Domain.Models.SalesOrderHeader);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged);
            // 
            // bsDetail
            // 
            this.bsDetail.DataSource = typeof(Wallnut.Domain.Models.SalesOrderDetail);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.bn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.bnDetail);
            this.splitContainer1.Size = new System.Drawing.Size(970, 497);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 208);
            this.panel1.TabIndex = 5;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.revisionNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.shipDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.salesOrderNumberDataGridViewTextBoxColumn,
            this.purchaseOrderNumberDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.salesPersonIDDataGridViewTextBoxColumn,
            this.territoryIDDataGridViewTextBoxColumn,
            this.billToAddressIDDataGridViewTextBoxColumn,
            this.shipToAddressIDDataGridViewTextBoxColumn,
            this.shipMethodIDDataGridViewTextBoxColumn,
            this.currencyRateIDDataGridViewTextBoxColumn,
            this.colCurrencyName,
            this.subTotalDataGridViewTextBoxColumn,
            this.taxAmtDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.totalDueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(970, 208);
            this.dgv.TabIndex = 4;
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            // 
            // revisionNumberDataGridViewTextBoxColumn
            // 
            this.revisionNumberDataGridViewTextBoxColumn.DataPropertyName = "RevisionNumber";
            this.revisionNumberDataGridViewTextBoxColumn.FillWeight = 40F;
            this.revisionNumberDataGridViewTextBoxColumn.HeaderText = "№ Рев";
            this.revisionNumberDataGridViewTextBoxColumn.Name = "revisionNumberDataGridViewTextBoxColumn";
            this.revisionNumberDataGridViewTextBoxColumn.ToolTipText = "Порядковый номер для отслеживания изменений заказа на продажу с течением времени." +
    "";
            this.revisionNumberDataGridViewTextBoxColumn.Width = 40;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ToolTipText = "Дата создания заказа на продажу";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dueDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Дата выполнения";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ToolTipText = "Дата выполнения заказа.";
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.shipDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            this.shipDateDataGridViewTextBoxColumn.ToolTipText = "Дата отправки заказа клиенту.";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // salesOrderNumberDataGridViewTextBoxColumn
            // 
            this.salesOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNumber";
            this.salesOrderNumberDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.salesOrderNumberDataGridViewTextBoxColumn.Name = "salesOrderNumberDataGridViewTextBoxColumn";
            this.salesOrderNumberDataGridViewTextBoxColumn.ToolTipText = "Уникальный идентификационный номер заказа на продажу";
            // 
            // purchaseOrderNumberDataGridViewTextBoxColumn
            // 
            this.purchaseOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrderNumber";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.HeaderText = "Номер счета ";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.Name = "purchaseOrderNumberDataGridViewTextBoxColumn";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.ToolTipText = "Ссылка на номер заказа на покупку";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Номер счета";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ToolTipText = "Ссылка на номер финансового счета";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerIDDataGridViewTextBoxColumn.FillWeight = 300F;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.ToolTipText = " заказчик";
            this.customerIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // salesPersonIDDataGridViewTextBoxColumn
            // 
            this.salesPersonIDDataGridViewTextBoxColumn.DataPropertyName = "SalesPersonID";
            this.salesPersonIDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.salesPersonIDDataGridViewTextBoxColumn.HeaderText = "Контакт заказчика";
            this.salesPersonIDDataGridViewTextBoxColumn.Name = "salesPersonIDDataGridViewTextBoxColumn";
            this.salesPersonIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // territoryIDDataGridViewTextBoxColumn
            // 
            this.territoryIDDataGridViewTextBoxColumn.DataPropertyName = "TerritoryName";
            this.territoryIDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.territoryIDDataGridViewTextBoxColumn.HeaderText = "Территория продаж";
            this.territoryIDDataGridViewTextBoxColumn.Name = "territoryIDDataGridViewTextBoxColumn";
            this.territoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.territoryIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // billToAddressIDDataGridViewTextBoxColumn
            // 
            this.billToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "BillToAddressTitle";
            this.billToAddressIDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.billToAddressIDDataGridViewTextBoxColumn.HeaderText = "Адрес для выст. счета";
            this.billToAddressIDDataGridViewTextBoxColumn.Name = "billToAddressIDDataGridViewTextBoxColumn";
            this.billToAddressIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.billToAddressIDDataGridViewTextBoxColumn.ToolTipText = "Адрес заказчика для выставления счета";
            this.billToAddressIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // shipToAddressIDDataGridViewTextBoxColumn
            // 
            this.shipToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "ShipToAddressTitle";
            this.shipToAddressIDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.shipToAddressIDDataGridViewTextBoxColumn.HeaderText = "Адрес для отгрузки";
            this.shipToAddressIDDataGridViewTextBoxColumn.Name = "shipToAddressIDDataGridViewTextBoxColumn";
            this.shipToAddressIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipToAddressIDDataGridViewTextBoxColumn.ToolTipText = "Адрес заказчика для отгрузки";
            this.shipToAddressIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // shipMethodIDDataGridViewTextBoxColumn
            // 
            this.shipMethodIDDataGridViewTextBoxColumn.DataPropertyName = "ShipMethodName";
            this.shipMethodIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.shipMethodIDDataGridViewTextBoxColumn.HeaderText = "Метод доставки";
            this.shipMethodIDDataGridViewTextBoxColumn.Name = "shipMethodIDDataGridViewTextBoxColumn";
            this.shipMethodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipMethodIDDataGridViewTextBoxColumn.ToolTipText = "Метод доставки";
            this.shipMethodIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // currencyRateIDDataGridViewTextBoxColumn
            // 
            this.currencyRateIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyRateID";
            this.currencyRateIDDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.currencyRateIDDataGridViewTextBoxColumn.Name = "currencyRateIDDataGridViewTextBoxColumn";
            this.currencyRateIDDataGridViewTextBoxColumn.ToolTipText = "Используемый курс обмена валюты";
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.HeaderText = "Валюта";
            this.colCurrencyName.Name = "colCurrencyName";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Подытог продаж";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxAmtDataGridViewTextBoxColumn
            // 
            this.taxAmtDataGridViewTextBoxColumn.DataPropertyName = "TaxAmt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.taxAmtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.taxAmtDataGridViewTextBoxColumn.HeaderText = "Сумма налогов";
            this.taxAmtDataGridViewTextBoxColumn.Name = "taxAmtDataGridViewTextBoxColumn";
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.freightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.freightDataGridViewTextBoxColumn.HeaderText = "Стоимость доставки";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            // 
            // totalDueDataGridViewTextBoxColumn
            // 
            this.totalDueDataGridViewTextBoxColumn.DataPropertyName = "TotalDue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.totalDueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalDueDataGridViewTextBoxColumn.HeaderText = "Общая задолж.";
            this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
            this.totalDueDataGridViewTextBoxColumn.ToolTipText = "Общая задолженность заказчика";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарии";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ToolTipText = "Комментарии, сделанные коммерческим представителем";
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
            this.bn.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bn.Size = new System.Drawing.Size(970, 39);
            this.bn.Stretch = true;
            this.bn.TabIndex = 4;
            this.bn.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Wallnut.UI.Properties.Resources.filter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "Условие";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 205);
            this.panel2.TabIndex = 1;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.AutoGenerateColumns = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carrierTrackingNumberDataGridViewTextBoxColumn,
            this.orderQtyDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.specialOfferIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitPriceDiscountDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn});
            this.dgvDetail.DataSource = this.bsDetail;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(970, 205);
            this.dgvDetail.TabIndex = 0;
            // 
            // carrierTrackingNumberDataGridViewTextBoxColumn
            // 
            this.carrierTrackingNumberDataGridViewTextBoxColumn.DataPropertyName = "CarrierTrackingNumber";
            this.carrierTrackingNumberDataGridViewTextBoxColumn.HeaderText = "Трак. ном.";
            this.carrierTrackingNumberDataGridViewTextBoxColumn.Name = "carrierTrackingNumberDataGridViewTextBoxColumn";
            this.carrierTrackingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carrierTrackingNumberDataGridViewTextBoxColumn.ToolTipText = "номер, предоставляемый компанией-поставщиком для отслеживания грузов";
            // 
            // orderQtyDataGridViewTextBoxColumn
            // 
            this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
            this.orderQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderQtyDataGridViewTextBoxColumn.ToolTipText = "Заказанное количество по видам продукта";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.ToolTipText = "Проданный заказчику продукт";
            // 
            // specialOfferIDDataGridViewTextBoxColumn
            // 
            this.specialOfferIDDataGridViewTextBoxColumn.DataPropertyName = "SpecialOfferID";
            this.specialOfferIDDataGridViewTextBoxColumn.HeaderText = "SpecialOfferID";
            this.specialOfferIDDataGridViewTextBoxColumn.Name = "specialOfferIDDataGridViewTextBoxColumn";
            this.specialOfferIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialOfferIDDataGridViewTextBoxColumn.ToolTipText = "Код рекламной акции";
            this.specialOfferIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.ToolTipText = "Отпускная цена за единицу продукта";
            // 
            // unitPriceDiscountDataGridViewTextBoxColumn
            // 
            this.unitPriceDiscountDataGridViewTextBoxColumn.DataPropertyName = "UnitPriceDiscount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.unitPriceDiscountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.unitPriceDiscountDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.unitPriceDiscountDataGridViewTextBoxColumn.Name = "unitPriceDiscountDataGridViewTextBoxColumn";
            this.unitPriceDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDiscountDataGridViewTextBoxColumn.ToolTipText = "Сумма скидки";
            this.unitPriceDiscountDataGridViewTextBoxColumn.Visible = false;
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.lineTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineTotalDataGridViewTextBoxColumn.ToolTipText = "Промежуточный итог за продукт";
            // 
            // bnDetail
            // 
            this.bnDetail.AddNewItem = null;
            this.bnDetail.BindingSource = this.bsDetail;
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
            this.bnDetail.Size = new System.Drawing.Size(970, 39);
            this.bnDetail.TabIndex = 0;
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
            this.tsbDeleteDetail.Click += new System.EventHandler(this.tsbDeleteDetail_Click);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(0, 497);
            this.ss.Name = "ss";
            this.ss.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ss.Size = new System.Drawing.Size(970, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // fSalesOrderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fSalesOrderHeader";
            this.Text = "Заказ на продажу";
            this.Load += new System.EventHandler(this.fList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetail)).EndInit();
            this.bnDetail.ResumeLayout(false);
            this.bnDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.BindingNavigator bnDetail;
        private System.Windows.Forms.ToolStripButton tsbAddDetail;
        private System.Windows.Forms.ToolStripButton tsbEditDetail;
        private System.Windows.Forms.ToolStripButton tsbDeleteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierTrackingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialOfferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
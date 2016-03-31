namespace Wallnut.UI.Sales.SalesOrderHeader
{
    partial class fAddSalesOrderHeader
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTerritoryID = new System.Windows.Forms.Label();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtShipDate = new System.Windows.Forms.DateTimePicker();
            this.lbShipDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.lbPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSalesPersonID = new System.Windows.Forms.Label();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.cbSalesPersonID = new System.Windows.Forms.ComboBox();
            this.cbTerritoryID = new System.Windows.Forms.ComboBox();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnTerritoryEdit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBillToAddressID = new System.Windows.Forms.ComboBox();
            this.lbBillToAddressID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShipToAddressID = new System.Windows.Forms.ComboBox();
            this.cbShipMethodID = new System.Windows.Forms.ComboBox();
            this.lbShipMethodID = new System.Windows.Forms.Label();
            this.btnBillToAddressEdit = new System.Windows.Forms.Button();
            this.btnShipToAddressEdit = new System.Windows.Forms.Button();
            this.btnShipMethod = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbTaxAmt = new System.Windows.Forms.Label();
            this.lbTotalDue = new System.Windows.Forms.Label();
            this.tbTaxAmt = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.tbFreight = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lbCurrencyRate = new System.Windows.Forms.Label();
            this.btnCurrencyRateEdit = new System.Windows.Forms.Button();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.tbSubTotal = new Wallnut.UI.fTemplates.NumericTextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.CurrencyTitle = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 490);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(757, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbTerritoryID, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.dtOrderDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbOrderDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDueDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDueDate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtShipDate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbShipDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbStatus, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbStatus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPurchaseOrderNumber, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbPurchaseOrderNumber, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbAccountNumber, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbAccountNumber, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbSalesPersonID, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbCustomerID, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbSalesPersonID, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbTerritoryID, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnCustomerEdit, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnTerritoryEdit, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbComment, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbComment, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 451);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbTerritoryID
            // 
            this.lbTerritoryID.AutoSize = true;
            this.lbTerritoryID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTerritoryID.Location = new System.Drawing.Point(34, 315);
            this.lbTerritoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTerritoryID.Name = "lbTerritoryID";
            this.lbTerritoryID.Size = new System.Drawing.Size(220, 35);
            this.lbTerritoryID.TabIndex = 0;
            this.lbTerritoryID.Text = "Территория, на которой была осуществлена продажа";
            this.lbTerritoryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtOrderDate.Location = new System.Drawing.Point(331, 39);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(364, 24);
            this.dtOrderDate.TabIndex = 0;
            this.dtOrderDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtOrderDate_Validating);
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(34, 35);
            this.lbOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(249, 18);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Дата создания заказа на продажу";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(34, 70);
            this.lbDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(184, 18);
            this.lbDueDate.TabIndex = 3;
            this.lbDueDate.Text = "Дата выполнения заказа";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDueDate.Location = new System.Drawing.Point(331, 74);
            this.dtDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(364, 24);
            this.dtDueDate.TabIndex = 1;
            // 
            // dtShipDate
            // 
            this.dtShipDate.Checked = false;
            this.dtShipDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtShipDate.Location = new System.Drawing.Point(331, 109);
            this.dtShipDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtShipDate.Name = "dtShipDate";
            this.dtShipDate.ShowCheckBox = true;
            this.dtShipDate.Size = new System.Drawing.Size(364, 24);
            this.dtShipDate.TabIndex = 2;
            // 
            // lbShipDate
            // 
            this.lbShipDate.AutoSize = true;
            this.lbShipDate.Location = new System.Drawing.Point(34, 105);
            this.lbShipDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShipDate.Name = "lbShipDate";
            this.lbShipDate.Size = new System.Drawing.Size(222, 18);
            this.lbShipDate.TabIndex = 3;
            this.lbShipDate.Text = "Дата отправки заказа клиенту";
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(331, 144);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(364, 26);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cbStatus_Validating);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(34, 140);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(56, 18);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Статус";
            // 
            // tbPurchaseOrderNumber
            // 
            this.tbPurchaseOrderNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPurchaseOrderNumber.Location = new System.Drawing.Point(331, 179);
            this.tbPurchaseOrderNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPurchaseOrderNumber.Name = "tbPurchaseOrderNumber";
            this.tbPurchaseOrderNumber.Size = new System.Drawing.Size(364, 24);
            this.tbPurchaseOrderNumber.TabIndex = 4;
            // 
            // lbPurchaseOrderNumber
            // 
            this.lbPurchaseOrderNumber.AutoSize = true;
            this.lbPurchaseOrderNumber.Location = new System.Drawing.Point(34, 175);
            this.lbPurchaseOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPurchaseOrderNumber.Name = "lbPurchaseOrderNumber";
            this.lbPurchaseOrderNumber.Size = new System.Drawing.Size(186, 18);
            this.lbPurchaseOrderNumber.TabIndex = 3;
            this.lbPurchaseOrderNumber.Text = "Номер заказа на покупку";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAccountNumber.Location = new System.Drawing.Point(331, 214);
            this.tbAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(364, 24);
            this.tbAccountNumber.TabIndex = 5;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(34, 210);
            this.lbAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(119, 18);
            this.lbAccountNumber.TabIndex = 3;
            this.lbAccountNumber.Text = "Расчетный счет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заказчик";
            // 
            // lbSalesPersonID
            // 
            this.lbSalesPersonID.AutoSize = true;
            this.lbSalesPersonID.Location = new System.Drawing.Point(34, 280);
            this.lbSalesPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalesPersonID.Name = "lbSalesPersonID";
            this.lbSalesPersonID.Size = new System.Drawing.Size(141, 18);
            this.lbSalesPersonID.TabIndex = 3;
            this.lbSalesPersonID.Text = "Контакт заказчика";
            this.lbSalesPersonID.Visible = false;
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(331, 249);
            this.cbCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(364, 26);
            this.cbCustomerID.TabIndex = 6;
            this.cbCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomerID_Validating);
            // 
            // cbSalesPersonID
            // 
            this.cbSalesPersonID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSalesPersonID.FormattingEnabled = true;
            this.cbSalesPersonID.Location = new System.Drawing.Point(331, 284);
            this.cbSalesPersonID.Margin = new System.Windows.Forms.Padding(4);
            this.cbSalesPersonID.Name = "cbSalesPersonID";
            this.cbSalesPersonID.Size = new System.Drawing.Size(364, 26);
            this.cbSalesPersonID.TabIndex = 7;
            this.cbSalesPersonID.Visible = false;
            // 
            // cbTerritoryID
            // 
            this.cbTerritoryID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTerritoryID.FormattingEnabled = true;
            this.cbTerritoryID.Location = new System.Drawing.Point(331, 319);
            this.cbTerritoryID.Margin = new System.Windows.Forms.Padding(4);
            this.cbTerritoryID.Name = "cbTerritoryID";
            this.cbTerritoryID.Size = new System.Drawing.Size(364, 26);
            this.cbTerritoryID.TabIndex = 8;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Location = new System.Drawing.Point(703, 249);
            this.btnCustomerEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(42, 26);
            this.btnCustomerEdit.TabIndex = 7;
            this.btnCustomerEdit.Text = "...";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnTerritoryEdit
            // 
            this.btnTerritoryEdit.Location = new System.Drawing.Point(703, 319);
            this.btnTerritoryEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnTerritoryEdit.Name = "btnTerritoryEdit";
            this.btnTerritoryEdit.Size = new System.Drawing.Size(42, 26);
            this.btnTerritoryEdit.TabIndex = 7;
            this.btnTerritoryEdit.Text = "...";
            this.btnTerritoryEdit.UseVisualStyleBackColor = true;
            this.btnTerritoryEdit.Click += new System.EventHandler(this.btnTerritoryEdit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(703, 284);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(331, 354);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(364, 65);
            this.tbComment.TabIndex = 9;
            this.tbComment.Text = "";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(34, 350);
            this.lbComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(76, 18);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Описание";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(757, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доставка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.37318F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.62682F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.Controls.Add(this.cbBillToAddressID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbBillToAddressID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbShipToAddressID, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbShipMethodID, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbShipMethodID, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnBillToAddressEdit, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnShipToAddressEdit, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnShipMethod, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 451);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbBillToAddressID
            // 
            this.cbBillToAddressID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBillToAddressID.FormattingEnabled = true;
            this.cbBillToAddressID.Location = new System.Drawing.Point(331, 39);
            this.cbBillToAddressID.Margin = new System.Windows.Forms.Padding(4);
            this.cbBillToAddressID.Name = "cbBillToAddressID";
            this.cbBillToAddressID.Size = new System.Drawing.Size(274, 26);
            this.cbBillToAddressID.TabIndex = 0;
            this.cbBillToAddressID.Validating += new System.ComponentModel.CancelEventHandler(this.cbBillToAddressID_Validating);
            // 
            // lbBillToAddressID
            // 
            this.lbBillToAddressID.AutoSize = true;
            this.lbBillToAddressID.Location = new System.Drawing.Point(34, 35);
            this.lbBillToAddressID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillToAddressID.Name = "lbBillToAddressID";
            this.lbBillToAddressID.Size = new System.Drawing.Size(255, 35);
            this.lbBillToAddressID.TabIndex = 1;
            this.lbBillToAddressID.Text = "Адрес заказчика для выставления счета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес заказчика для отгрузки";
            // 
            // cbShipToAddressID
            // 
            this.cbShipToAddressID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShipToAddressID.FormattingEnabled = true;
            this.cbShipToAddressID.Location = new System.Drawing.Point(331, 74);
            this.cbShipToAddressID.Margin = new System.Windows.Forms.Padding(4);
            this.cbShipToAddressID.Name = "cbShipToAddressID";
            this.cbShipToAddressID.Size = new System.Drawing.Size(274, 26);
            this.cbShipToAddressID.TabIndex = 1;
            this.cbShipToAddressID.Validating += new System.ComponentModel.CancelEventHandler(this.cbShipToAddressID_Validating);
            // 
            // cbShipMethodID
            // 
            this.cbShipMethodID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShipMethodID.FormattingEnabled = true;
            this.cbShipMethodID.Location = new System.Drawing.Point(331, 109);
            this.cbShipMethodID.Margin = new System.Windows.Forms.Padding(4);
            this.cbShipMethodID.Name = "cbShipMethodID";
            this.cbShipMethodID.Size = new System.Drawing.Size(274, 26);
            this.cbShipMethodID.TabIndex = 2;
            this.cbShipMethodID.Validating += new System.ComponentModel.CancelEventHandler(this.cbShipMethodID_Validating);
            // 
            // lbShipMethodID
            // 
            this.lbShipMethodID.AutoSize = true;
            this.lbShipMethodID.Location = new System.Drawing.Point(34, 105);
            this.lbShipMethodID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShipMethodID.Name = "lbShipMethodID";
            this.lbShipMethodID.Size = new System.Drawing.Size(123, 18);
            this.lbShipMethodID.TabIndex = 1;
            this.lbShipMethodID.Text = "Метод доставки";
            // 
            // btnBillToAddressEdit
            // 
            this.btnBillToAddressEdit.Location = new System.Drawing.Point(613, 39);
            this.btnBillToAddressEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnBillToAddressEdit.Name = "btnBillToAddressEdit";
            this.btnBillToAddressEdit.Size = new System.Drawing.Size(52, 26);
            this.btnBillToAddressEdit.TabIndex = 2;
            this.btnBillToAddressEdit.Text = "...";
            this.btnBillToAddressEdit.UseVisualStyleBackColor = true;
            this.btnBillToAddressEdit.Click += new System.EventHandler(this.btnBillToAddressEdit_Click);
            // 
            // btnShipToAddressEdit
            // 
            this.btnShipToAddressEdit.Location = new System.Drawing.Point(613, 74);
            this.btnShipToAddressEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnShipToAddressEdit.Name = "btnShipToAddressEdit";
            this.btnShipToAddressEdit.Size = new System.Drawing.Size(52, 26);
            this.btnShipToAddressEdit.TabIndex = 2;
            this.btnShipToAddressEdit.Text = "...";
            this.btnShipToAddressEdit.UseVisualStyleBackColor = true;
            this.btnShipToAddressEdit.Click += new System.EventHandler(this.btnShipToAddressEdit_Click);
            // 
            // btnShipMethod
            // 
            this.btnShipMethod.Location = new System.Drawing.Point(613, 109);
            this.btnShipMethod.Margin = new System.Windows.Forms.Padding(4);
            this.btnShipMethod.Name = "btnShipMethod";
            this.btnShipMethod.Size = new System.Drawing.Size(52, 26);
            this.btnShipMethod.TabIndex = 2;
            this.btnShipMethod.Text = "...";
            this.btnShipMethod.UseVisualStyleBackColor = true;
            this.btnShipMethod.Click += new System.EventHandler(this.btnShipMethod_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(757, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Суммы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88272F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.11728F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel3.Controls.Add(this.lbSubTotal, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTaxAmt, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTotalDue, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbTaxAmt, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbFreight, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbFreight, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbCurrencyRate, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnCurrencyRateEdit, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalDue, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbSubTotal, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbRate, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.CurrencyTitle, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbCurrency, 2, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 451);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSubTotal.Location = new System.Drawing.Point(34, 35);
            this.lbSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(127, 35);
            this.lbSubTotal.TabIndex = 0;
            this.lbSubTotal.Text = "Подытог продаж";
            // 
            // lbTaxAmt
            // 
            this.lbTaxAmt.AutoSize = true;
            this.lbTaxAmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTaxAmt.Location = new System.Drawing.Point(34, 70);
            this.lbTaxAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaxAmt.Name = "lbTaxAmt";
            this.lbTaxAmt.Size = new System.Drawing.Size(117, 35);
            this.lbTaxAmt.TabIndex = 0;
            this.lbTaxAmt.Text = "Сумма налогов";
            // 
            // lbTotalDue
            // 
            this.lbTotalDue.AutoSize = true;
            this.lbTotalDue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTotalDue.Location = new System.Drawing.Point(34, 140);
            this.lbTotalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalDue.Name = "lbTotalDue";
            this.lbTotalDue.Size = new System.Drawing.Size(122, 35);
            this.lbTotalDue.TabIndex = 0;
            this.lbTotalDue.Text = "Общая задолженность заказчика";
            // 
            // tbTaxAmt
            // 
            this.tbTaxAmt.AllowNegative = true;
            this.tbTaxAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaxAmt.Location = new System.Drawing.Point(199, 74);
            this.tbTaxAmt.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaxAmt.Name = "tbTaxAmt";
            this.tbTaxAmt.NumericPrecision = 1;
            this.tbTaxAmt.NumericScaleOnFocus = 0;
            this.tbTaxAmt.NumericScaleOnLostFocus = 0;
            this.tbTaxAmt.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTaxAmt.Size = new System.Drawing.Size(275, 24);
            this.tbTaxAmt.TabIndex = 1;
            this.tbTaxAmt.Text = "0";
            this.tbTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTaxAmt.ZeroIsValid = false;
            this.tbTaxAmt.Validating += new System.ComponentModel.CancelEventHandler(this.tbTaxAmt_Validating);
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(34, 105);
            this.lbFreight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(155, 18);
            this.lbFreight.TabIndex = 2;
            this.lbFreight.Text = "Стоимость доставки";
            // 
            // tbFreight
            // 
            this.tbFreight.AllowNegative = true;
            this.tbFreight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFreight.Location = new System.Drawing.Point(199, 109);
            this.tbFreight.Margin = new System.Windows.Forms.Padding(4);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.NumericPrecision = 1;
            this.tbFreight.NumericScaleOnFocus = 0;
            this.tbFreight.NumericScaleOnLostFocus = 0;
            this.tbFreight.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbFreight.Size = new System.Drawing.Size(275, 24);
            this.tbFreight.TabIndex = 2;
            this.tbFreight.Text = "0";
            this.tbFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFreight.ZeroIsValid = false;
            this.tbFreight.Validating += new System.ComponentModel.CancelEventHandler(this.tbFreight_Validating);
            // 
            // lbCurrencyRate
            // 
            this.lbCurrencyRate.AutoSize = true;
            this.lbCurrencyRate.Location = new System.Drawing.Point(34, 175);
            this.lbCurrencyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrencyRate.Name = "lbCurrencyRate";
            this.lbCurrencyRate.Size = new System.Drawing.Size(41, 18);
            this.lbCurrencyRate.TabIndex = 5;
            this.lbCurrencyRate.Text = "Курс";
            // 
            // btnCurrencyRateEdit
            // 
            this.btnCurrencyRateEdit.Location = new System.Drawing.Point(482, 179);
            this.btnCurrencyRateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurrencyRateEdit.Name = "btnCurrencyRateEdit";
            this.btnCurrencyRateEdit.Size = new System.Drawing.Size(51, 26);
            this.btnCurrencyRateEdit.TabIndex = 6;
            this.btnCurrencyRateEdit.Text = "...";
            this.btnCurrencyRateEdit.UseVisualStyleBackColor = true;
            this.btnCurrencyRateEdit.Click += new System.EventHandler(this.CurrencyRate_Click);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDue.Location = new System.Drawing.Point(198, 140);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(277, 35);
            this.lblTotalDue.TabIndex = 3;
            this.lblTotalDue.Text = "0";
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.AllowNegative = true;
            this.tbSubTotal.Location = new System.Drawing.Point(198, 38);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.NumericPrecision = 1;
            this.tbSubTotal.NumericScaleOnFocus = 0;
            this.tbSubTotal.NumericScaleOnLostFocus = 0;
            this.tbSubTotal.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSubTotal.Size = new System.Drawing.Size(277, 24);
            this.tbSubTotal.TabIndex = 0;
            this.tbSubTotal.Text = "0";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSubTotal.ZeroIsValid = false;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRate.Location = new System.Drawing.Point(198, 175);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(277, 35);
            this.lbRate.TabIndex = 7;
            this.lbRate.Text = "0";
            this.lbRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrencyTitle
            // 
            this.CurrencyTitle.AutoSize = true;
            this.CurrencyTitle.Location = new System.Drawing.Point(34, 210);
            this.CurrencyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrencyTitle.Name = "CurrencyTitle";
            this.CurrencyTitle.Size = new System.Drawing.Size(61, 18);
            this.CurrencyTitle.TabIndex = 5;
            this.CurrencyTitle.Text = "Валюта";
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrency.Location = new System.Drawing.Point(198, 210);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(277, 35);
            this.lbCurrency.TabIndex = 7;
            this.lbCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 490);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(649, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(529, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // fAddSalesOrderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAddSalesOrderHeader";
            this.Text = "Заказ на закупку";
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTerritoryID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.DateTimePicker dtShipDate;
        private System.Windows.Forms.Label lbShipDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbPurchaseOrderNumber;
        private System.Windows.Forms.Label lbPurchaseOrderNumber;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSalesPersonID;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.ComboBox cbSalesPersonID;
        private System.Windows.Forms.ComboBox cbTerritoryID;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTerritoryEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbBillToAddressID;
        private System.Windows.Forms.Label lbBillToAddressID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShipToAddressID;
        private System.Windows.Forms.ComboBox cbShipMethodID;
        private System.Windows.Forms.Label lbShipMethodID;
        private System.Windows.Forms.Button btnBillToAddressEdit;
        private System.Windows.Forms.Button btnShipToAddressEdit;
        private System.Windows.Forms.Button btnShipMethod;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbTaxAmt;
        private System.Windows.Forms.Label lbTotalDue;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbCurrencyRate;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Button btnCurrencyRateEdit;
        private System.Windows.Forms.Label lblTotalDue;
        private fTemplates.NumericTextBox tbSubTotal;
        private fTemplates.NumericTextBox tbTaxAmt;
        private fTemplates.NumericTextBox tbFreight;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label CurrencyTitle;
        private System.Windows.Forms.Label lbCurrency;
    }
}
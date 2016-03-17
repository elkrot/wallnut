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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.lbTaxAmt = new System.Windows.Forms.Label();
            this.lbTotalDue = new System.Windows.Forms.Label();
            this.tbTaxAmt = new System.Windows.Forms.TextBox();
            this.tbTotalDue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.lbCurrencyRate = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tbCurrencyRateID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 354);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(703, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(625, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(544, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 354);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.button6, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbComment, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbComment, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 322);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbTerritoryID
            // 
            this.lbTerritoryID.AutoSize = true;
            this.lbTerritoryID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTerritoryID.Location = new System.Drawing.Point(23, 225);
            this.lbTerritoryID.Name = "lbTerritoryID";
            this.lbTerritoryID.Size = new System.Drawing.Size(281, 25);
            this.lbTerritoryID.TabIndex = 0;
            this.lbTerritoryID.Text = "Территория, на которой была осуществлена продажа";
            this.lbTerritoryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtOrderDate.Location = new System.Drawing.Point(346, 28);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(242, 20);
            this.dtOrderDate.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(23, 25);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(184, 13);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Дата создания заказа на продажу";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(23, 50);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(137, 13);
            this.lbDueDate.TabIndex = 3;
            this.lbDueDate.Text = "Дата выполнения заказа";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDueDate.Location = new System.Drawing.Point(346, 53);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(242, 20);
            this.dtDueDate.TabIndex = 2;
            // 
            // dtShipDate
            // 
            this.dtShipDate.Checked = false;
            this.dtShipDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtShipDate.Location = new System.Drawing.Point(346, 78);
            this.dtShipDate.Name = "dtShipDate";
            this.dtShipDate.ShowCheckBox = true;
            this.dtShipDate.Size = new System.Drawing.Size(242, 20);
            this.dtShipDate.TabIndex = 2;
            // 
            // lbShipDate
            // 
            this.lbShipDate.AutoSize = true;
            this.lbShipDate.Location = new System.Drawing.Point(23, 75);
            this.lbShipDate.Name = "lbShipDate";
            this.lbShipDate.Size = new System.Drawing.Size(165, 13);
            this.lbShipDate.TabIndex = 3;
            this.lbShipDate.Text = "Дата отправки заказа клиенту";
            // 
            // cbStatus
            // 
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(346, 103);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(242, 21);
            this.cbStatus.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(23, 100);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Статус";
            // 
            // tbPurchaseOrderNumber
            // 
            this.tbPurchaseOrderNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPurchaseOrderNumber.Location = new System.Drawing.Point(346, 128);
            this.tbPurchaseOrderNumber.Name = "tbPurchaseOrderNumber";
            this.tbPurchaseOrderNumber.Size = new System.Drawing.Size(242, 20);
            this.tbPurchaseOrderNumber.TabIndex = 5;
            // 
            // lbPurchaseOrderNumber
            // 
            this.lbPurchaseOrderNumber.AutoSize = true;
            this.lbPurchaseOrderNumber.Location = new System.Drawing.Point(23, 125);
            this.lbPurchaseOrderNumber.Name = "lbPurchaseOrderNumber";
            this.lbPurchaseOrderNumber.Size = new System.Drawing.Size(138, 13);
            this.lbPurchaseOrderNumber.TabIndex = 3;
            this.lbPurchaseOrderNumber.Text = "Номер заказа на покупку";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAccountNumber.Location = new System.Drawing.Point(346, 153);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(242, 20);
            this.tbAccountNumber.TabIndex = 5;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(23, 150);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lbAccountNumber.TabIndex = 3;
            this.lbAccountNumber.Text = "Расчетный счет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заказчик";
            // 
            // lbSalesPersonID
            // 
            this.lbSalesPersonID.AutoSize = true;
            this.lbSalesPersonID.Location = new System.Drawing.Point(23, 200);
            this.lbSalesPersonID.Name = "lbSalesPersonID";
            this.lbSalesPersonID.Size = new System.Drawing.Size(104, 13);
            this.lbSalesPersonID.TabIndex = 3;
            this.lbSalesPersonID.Text = "Контакт заказчика";
            this.lbSalesPersonID.Visible = false;
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(346, 178);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(242, 21);
            this.cbCustomerID.TabIndex = 6;
            // 
            // cbSalesPersonID
            // 
            this.cbSalesPersonID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSalesPersonID.FormattingEnabled = true;
            this.cbSalesPersonID.Location = new System.Drawing.Point(346, 203);
            this.cbSalesPersonID.Name = "cbSalesPersonID";
            this.cbSalesPersonID.Size = new System.Drawing.Size(242, 21);
            this.cbSalesPersonID.TabIndex = 6;
            this.cbSalesPersonID.Visible = false;
            // 
            // cbTerritoryID
            // 
            this.cbTerritoryID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTerritoryID.FormattingEnabled = true;
            this.cbTerritoryID.Location = new System.Drawing.Point(346, 228);
            this.cbTerritoryID.Name = "cbTerritoryID";
            this.cbTerritoryID.Size = new System.Drawing.Size(242, 21);
            this.cbTerritoryID.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 19);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(594, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 19);
            this.button6.TabIndex = 7;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(594, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 19);
            this.button5.TabIndex = 7;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(346, 253);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(242, 46);
            this.tbComment.TabIndex = 8;
            this.tbComment.Text = "";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(23, 250);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(57, 13);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Описание";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доставка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89817F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.Controls.Add(this.cbBillToAddressID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbBillToAddressID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbShipToAddressID, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbShipMethodID, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbShipMethodID, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(689, 322);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbBillToAddressID
            // 
            this.cbBillToAddressID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBillToAddressID.FormattingEnabled = true;
            this.cbBillToAddressID.Location = new System.Drawing.Point(269, 28);
            this.cbBillToAddressID.Name = "cbBillToAddressID";
            this.cbBillToAddressID.Size = new System.Drawing.Size(239, 21);
            this.cbBillToAddressID.TabIndex = 0;
            // 
            // lbBillToAddressID
            // 
            this.lbBillToAddressID.AutoSize = true;
            this.lbBillToAddressID.Location = new System.Drawing.Point(23, 25);
            this.lbBillToAddressID.Name = "lbBillToAddressID";
            this.lbBillToAddressID.Size = new System.Drawing.Size(216, 13);
            this.lbBillToAddressID.TabIndex = 1;
            this.lbBillToAddressID.Text = "Адрес заказчика для выставления счета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес заказчика для отгрузки";
            // 
            // cbShipToAddressID
            // 
            this.cbShipToAddressID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShipToAddressID.FormattingEnabled = true;
            this.cbShipToAddressID.Location = new System.Drawing.Point(269, 53);
            this.cbShipToAddressID.Name = "cbShipToAddressID";
            this.cbShipToAddressID.Size = new System.Drawing.Size(239, 21);
            this.cbShipToAddressID.TabIndex = 0;
            // 
            // cbShipMethodID
            // 
            this.cbShipMethodID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShipMethodID.FormattingEnabled = true;
            this.cbShipMethodID.Location = new System.Drawing.Point(269, 78);
            this.cbShipMethodID.Name = "cbShipMethodID";
            this.cbShipMethodID.Size = new System.Drawing.Size(239, 21);
            this.cbShipMethodID.TabIndex = 0;
            // 
            // lbShipMethodID
            // 
            this.lbShipMethodID.AutoSize = true;
            this.lbShipMethodID.Location = new System.Drawing.Point(23, 75);
            this.lbShipMethodID.Name = "lbShipMethodID";
            this.lbShipMethodID.Size = new System.Drawing.Size(89, 13);
            this.lbShipMethodID.TabIndex = 1;
            this.lbShipMethodID.Text = "Метод доставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(695, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Суммы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88272F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.11728F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Controls.Add(this.lbSubTotal, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbSubTotal, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbTaxAmt, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTotalDue, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbTaxAmt, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbTotalDue, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbFreight, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbCurrencyRate, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.button7, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbCurrencyRateID, 2, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(689, 322);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSubTotal.Location = new System.Drawing.Point(23, 25);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(92, 25);
            this.lbSubTotal.TabIndex = 0;
            this.lbSubTotal.Text = "Подытог продаж";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubTotal.Location = new System.Drawing.Point(218, 28);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(327, 20);
            this.tbSubTotal.TabIndex = 1;
            // 
            // lbTaxAmt
            // 
            this.lbTaxAmt.AutoSize = true;
            this.lbTaxAmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTaxAmt.Location = new System.Drawing.Point(23, 50);
            this.lbTaxAmt.Name = "lbTaxAmt";
            this.lbTaxAmt.Size = new System.Drawing.Size(85, 25);
            this.lbTaxAmt.TabIndex = 0;
            this.lbTaxAmt.Text = "Сумма налогов";
            // 
            // lbTotalDue
            // 
            this.lbTotalDue.AutoSize = true;
            this.lbTotalDue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTotalDue.Location = new System.Drawing.Point(23, 100);
            this.lbTotalDue.Name = "lbTotalDue";
            this.lbTotalDue.Size = new System.Drawing.Size(180, 25);
            this.lbTotalDue.TabIndex = 0;
            this.lbTotalDue.Text = "Общая задолженность заказчика";
            // 
            // tbTaxAmt
            // 
            this.tbTaxAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaxAmt.Location = new System.Drawing.Point(218, 53);
            this.tbTaxAmt.Name = "tbTaxAmt";
            this.tbTaxAmt.Size = new System.Drawing.Size(327, 20);
            this.tbTaxAmt.TabIndex = 1;
            // 
            // tbTotalDue
            // 
            this.tbTotalDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTotalDue.Location = new System.Drawing.Point(218, 103);
            this.tbTotalDue.Name = "tbTotalDue";
            this.tbTotalDue.Size = new System.Drawing.Size(327, 20);
            this.tbTotalDue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Стоимость доставки";
            // 
            // tbFreight
            // 
            this.tbFreight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFreight.Location = new System.Drawing.Point(218, 78);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(327, 20);
            this.tbFreight.TabIndex = 3;
            // 
            // lbCurrencyRate
            // 
            this.lbCurrencyRate.AutoSize = true;
            this.lbCurrencyRate.Location = new System.Drawing.Point(23, 125);
            this.lbCurrencyRate.Name = "lbCurrencyRate";
            this.lbCurrencyRate.Size = new System.Drawing.Size(31, 13);
            this.lbCurrencyRate.TabIndex = 5;
            this.lbCurrencyRate.Text = "Курс";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(551, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 19);
            this.button7.TabIndex = 6;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tbCurrencyRateID
            // 
            this.tbCurrencyRateID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrencyRateID.Location = new System.Drawing.Point(218, 128);
            this.tbCurrencyRateID.Name = "tbCurrencyRateID";
            this.tbCurrencyRateID.Size = new System.Drawing.Size(327, 20);
            this.tbCurrencyRateID.TabIndex = 7;
            // 
            // fAddSalesOrderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "fAddSalesOrderHeader";
            this.Text = "Заказ на закупку";
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbBillToAddressID;
        private System.Windows.Forms.Label lbBillToAddressID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShipToAddressID;
        private System.Windows.Forms.ComboBox cbShipMethodID;
        private System.Windows.Forms.Label lbShipMethodID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label lbTaxAmt;
        private System.Windows.Forms.Label lbTotalDue;
        private System.Windows.Forms.TextBox tbTaxAmt;
        private System.Windows.Forms.TextBox tbTotalDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.Label lbCurrencyRate;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbCurrencyRateID;
    }
}
namespace Wallnut.UI.Production.frmProductInventory
{
    partial class fAddProductInventory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbShelf = new System.Windows.Forms.Label();
            this.tbShelf = new System.Windows.Forms.TextBox();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.cbLocationID = new System.Windows.Forms.ComboBox();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbBin = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbShelf, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbShelf, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbProductID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbLocationID, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbBin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbProduct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbLocation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbQuantity, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbQuantity, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbShelf
            // 
            this.lbShelf.AutoSize = true;
            this.lbShelf.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbShelf.Location = new System.Drawing.Point(23, 75);
            this.lbShelf.Name = "lbShelf";
            this.lbShelf.Size = new System.Drawing.Size(39, 25);
            this.lbShelf.TabIndex = 0;
            this.lbShelf.Text = "Полка";
            this.lbShelf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbShelf
            // 
            this.tbShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbShelf.Location = new System.Drawing.Point(123, 78);
            this.tbShelf.Name = "tbShelf";
            this.tbShelf.Size = new System.Drawing.Size(313, 20);
            this.tbShelf.TabIndex = 1;
            this.tbShelf.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // cbProductID
            // 
            this.cbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(123, 28);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(313, 21);
            this.cbProductID.TabIndex = 2;
            // 
            // cbLocationID
            // 
            this.cbLocationID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLocationID.FormattingEnabled = true;
            this.cbLocationID.Location = new System.Drawing.Point(123, 53);
            this.cbLocationID.Name = "cbLocationID";
            this.cbLocationID.Size = new System.Drawing.Size(313, 21);
            this.cbLocationID.TabIndex = 3;
            // 
            // tbBin
            // 
            this.tbBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBin.Location = new System.Drawing.Point(123, 103);
            this.tbBin.Name = "tbBin";
            this.tbBin.Size = new System.Drawing.Size(313, 20);
            this.tbBin.TabIndex = 4;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProduct.Location = new System.Drawing.Point(23, 25);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(49, 25);
            this.lbProduct.TabIndex = 5;
            this.lbProduct.Text = "Продукт";
            this.lbProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLocation.Location = new System.Drawing.Point(23, 50);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(82, 25);
            this.lbLocation.TabIndex = 5;
            this.lbLocation.Text = "Расположение";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBin
            // 
            this.lbBin.AutoSize = true;
            this.lbBin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbBin.Location = new System.Drawing.Point(23, 100);
            this.lbBin.Name = "lbBin";
            this.lbBin.Size = new System.Drawing.Size(44, 25);
            this.lbBin.TabIndex = 5;
            this.lbBin.Text = "Ячейка";
            this.lbBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuantity.Location = new System.Drawing.Point(123, 128);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(313, 20);
            this.tbQuantity.TabIndex = 4;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbQuantity.Location = new System.Drawing.Point(23, 125);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(66, 25);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Количество";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(381, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(300, 3);
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
            // fAddProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 204);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fAddProductInventory";
            this.Text = "Склад. ";
            this.Load += new System.EventHandler(this.fEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbShelf;
        private System.Windows.Forms.TextBox tbShelf;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.ComboBox cbLocationID;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbBin;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
    }
}
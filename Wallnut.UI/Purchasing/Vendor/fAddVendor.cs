using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Implementations;

namespace Wallnut.UI.Purchasing.Vendor
{
    public partial class fAddVendor : Wallnut.UI.Implementations.AddForm
    {
        public bool UpdateInForm = false;
        public fAddVendor()
        {

            InitializeComponent();
        }

        #region BindingData
      private void BindingData()
        {

            this.tbAccountNumber.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "AccountNumber",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.cbCreditRating.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Vendor,
            "CreditRating",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            cbCreditRating.DataSource = new BindingSource(
    new Dictionary<byte, string>() { { 1, "Превосходный" }, { 2, "Отличный" }
    , { 3, "Выше среднего" }
    , { 4, "Средний" }
    , { 5, "Ниже среднего" }}, null);

            cbCreditRating.ValueMember = "Key";
            cbCreditRating.DisplayMember = "Value";

            cbCreditRating.SelectedValue = (this.entity as Wallnut.Domain.Models.Vendor).CreditRating;

            cbCreditRating.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.Vendor).CreditRating
                  = (byte)cbCreditRating.SelectedValue;
            };

            this.chPreferredVendorStatus.DataBindings.Add("Checked",
            this.entity as Wallnut.Domain.Models.Vendor,
            "PreferredVendorStatus",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.chActiveFlag.DataBindings.Add("Checked",
            this.entity as Wallnut.Domain.Models.Vendor,
            "ActiveFlag",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
        }
		 
	#endregion
  
        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
            InitUpdateInFormEvent();
        }
        #region InitUpdateInFormEvent
        private void InitUpdateInFormEvent()
        {
            

            foreach (var pc in this.tabControl.Controls)
            {
                if (pc is TabPage)
                {
                    (pc as TabPage).Select();
                    foreach (var item in (pc as TabPage).Controls[0].Controls)
                    {
                       
                        if (item is TextBox)
                        {
                            (item as TextBox).TextChanged += (o, e) =>
                            {
                                UpdateInForm = true;
                            };
                        }
                        else if (item is ComboBox)
                        {
                            (item as ComboBox).SelectedIndexChanged += (o, e) => { UpdateInForm = true; };
                        }
                        else if (item is CheckBox)
                        {
                            (item as CheckBox).CheckedChanged += (o, e) => { UpdateInForm = true; };
                        }
                    }
                }
            }
  
        }
        #endregion

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetDataToEntity();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void SetDataToEntity()
        {
            (this.entity as Wallnut.Domain.Models.Vendor).ModifiedDate = DateTime.Now;
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                if ((this.entity as Wallnut.Domain.Models.Vendor).BusinessEntityID == 0)
                {
                    (this.entity as Wallnut.Domain.Models.Vendor).BusinessEntityID =
                        (unitOfWork.GetRepository<BusinessEntity>() as BusinessEntityRepository).GetNewBusinessEntityID();
                }
            }
        }

        private bool ValidateForm()
        {
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return false;
            }
            return true;
        }

        private void fAddVendor_Activated(object sender, EventArgs e)
        {
            tbAccountNumber.Focus();
        }

        private void fAddVendor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdateInForm && ((sender as Form).DialogResult) != System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ValidateForm()) SetDataToEntity();     
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    //Не сохраняем
                }
                else e.Cancel = true;//Отменяем действие
            }

            if(((sender as Form).DialogResult) == System.Windows.Forms.DialogResult.OK){
               if (ValidateForm()) SetDataToEntity();
            }
        }

        private void tbName_Validating_1(object sender, CancelEventArgs e)
        {
            Wallnut.Utils.Validation.FieldIsRequired<TextBox>(ref  sender, ref  e, "Наименование", ref ep);
        }
        #region OnHotKeyDown
        private void OnHotKeyDown(KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnOK_Click(this, EventArgs.Empty);
            }else if ( e.KeyCode == Keys.Escape)  this.Close();
           
        }
        #endregion

        private void fAddVendor_KeyDown(object sender, KeyEventArgs e)
        {
            OnHotKeyDown(e);
            
           
        }




          }
}

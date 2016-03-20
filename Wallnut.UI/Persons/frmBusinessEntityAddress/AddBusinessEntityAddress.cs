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
using Wallnut.UI.Persons.Address;
using Wallnut.UI.Persons.AddressTypes;

namespace Wallnut.UI.Persons.frmBusinessEntityAddress
{
    public partial class AddBusinessEntityAddress : Wallnut.UI.Implementations.AddForm
    {
        private List<Wallnut.Domain.Models.Address> address;
        private List<Wallnut.Domain.Models.AddressType> addressType;

        public AddBusinessEntityAddress()
        {

            InitializeComponent();
        }

        #region BindingData
           private void BindingData()
        {

            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.address = unitOfWork.AddressRepository.GetAll().ToList<Wallnut.Domain.Models.Address>();
                cbAddressID.DataSource = address;
                this.addressType = unitOfWork.AddressTypeRepository.GetAll().ToList<Wallnut.Domain.Models.AddressType>();
                cbAddressTypeID.DataSource = addressType;
            }

            #region AddressType
            cbAddressTypeID.ValueMember = "AddressTypeID";
            cbAddressTypeID.DisplayMember = "Name";
            cbAddressTypeID.SelectedValue =
                (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).AddressTypeID;
            cbAddressTypeID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).AddressTypeID = 
                    (int)cbAddressTypeID.SelectedValue;
            };
            #endregion

            #region Address
            cbAddressID.ValueMember = "AddressID";
            cbAddressID.DisplayMember = "AddressLine1";
            cbAddressID.SelectedValue =
                (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).AddressID;
            cbAddressID.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).AddressID =
                    (int)cbAddressID.SelectedValue;
            };
            #endregion

            int id = 0;
            Int32.TryParse(AddParams[0].ToString(), out id);
            (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).BusinessEntityID= id;
        }

        #endregion
     
        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true; tbName.Focus(); ep.SetError(tbName, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbName, "");
            }*/
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            (this.entity as Wallnut.Domain.Models.BusinessEntityAddress).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddress f = new fAddress();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAddressType f = new fAddressType();
            f.ShowDialog();
        }
    }
}

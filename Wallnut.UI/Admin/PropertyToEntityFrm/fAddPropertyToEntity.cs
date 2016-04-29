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

namespace Wallnut.UI.Admin.PropertyToEntityFrm
{
    public partial class fAddPropertyToEntity : Wallnut.UI.Implementations.AddForm
    {
        private int BusinesEntityId;
        private List<Property> PropertyCodeList;
        

        public fAddPropertyToEntity()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.PropertyCodeList = unitOfWork.PropertyRepository.GetAll().ToList<Property>();
            }

            cbPropertyCode.DataSource = this.PropertyCodeList;
            cbPropertyCode.ValueMember = "PropertyCode";
            cbPropertyCode.DisplayMember = "Name";
            cbPropertyCode.SelectedValue =
                (this.entity as Wallnut.Domain.Models.PropertyToEntity).PropertyCode??"";
            cbPropertyCode.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.PropertyToEntity).PropertyCode = (string)cbPropertyCode.SelectedValue;
            };



            this.tbPropertyValue.DataBindings.Add("Text",
             this.entity as Wallnut.Domain.Models.PropertyToEntity,
             "PropertyValue",
             false,
             DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {

            if (this.AddParams != null && this.AddParams.Length == 1)
            {
                BusinesEntityId = (int)this.AddParams[0];
            }
            if ((this.entity as Wallnut.Domain.Models.PropertyToEntity).BusinesEntityID == 0)
                (this.entity as Wallnut.Domain.Models.PropertyToEntity).BusinesEntityID = BusinesEntityId;

            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
           /* if (string.IsNullOrEmpty(tbName.Text))
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
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}

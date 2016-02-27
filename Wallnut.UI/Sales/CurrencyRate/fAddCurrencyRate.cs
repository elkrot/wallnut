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

namespace Wallnut.UI.Sales.CurrencyRate
{
    public partial class fAddCurrencyRate : Wallnut.UI.Implementations.AddForm
    {
        private List<Wallnut.Domain.Models.Currency> fromCurrencyList;
        private List<Wallnut.Domain.Models.Currency> toCurrencyList;
        public fAddCurrencyRate()
        {

            InitializeComponent();
        }

        private void BindingData()
        {
            if((this.entity as Wallnut.Domain.Models.CurrencyRate).CurrencyRateDate<=DateTime.MinValue)
            {
                (this.entity as Wallnut.Domain.Models.CurrencyRate).CurrencyRateDate = DateTime.Now;
            }
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.fromCurrencyList = unitOfWork.CurrencyRepository.GetAll().ToList<Wallnut.Domain.Models.Currency>();
                toCurrencyList = new List<Wallnut.Domain.Models.Currency>(fromCurrencyList); 
                сbFromCurrencyCode.DataSource = fromCurrencyList;
                сbToCurrencyCode.DataSource = toCurrencyList;
            }

            сbFromCurrencyCode.ValueMember = "CurrencyCode";
            сbFromCurrencyCode.DisplayMember = "Name";
            сbFromCurrencyCode.SelectedValue =
                (this.entity as Wallnut.Domain.Models.CurrencyRate).FromCurrencyCode??"";
            сbFromCurrencyCode.SelectedIndexChanged += (x, y) =>
            {
(this.entity as Wallnut.Domain.Models.CurrencyRate).FromCurrencyCode = сbFromCurrencyCode.SelectedValue.ToString();
                        };



            сbToCurrencyCode.ValueMember = "CurrencyCode";
            сbToCurrencyCode.DisplayMember = "Name";
            сbToCurrencyCode.SelectedValue =
                (this.entity as Wallnut.Domain.Models.CurrencyRate).ToCurrencyCode ?? "";
            сbToCurrencyCode.SelectedIndexChanged += (x, y) =>
            {
                (this.entity as Wallnut.Domain.Models.CurrencyRate).ToCurrencyCode = сbToCurrencyCode.SelectedValue.ToString();
            };     


            this.tbRate.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.CurrencyRate,
            "Rate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.dtCurrencyRateDate.DataBindings.Add("Value",
            this.entity as Wallnut.Domain.Models.CurrencyRate,
            "CurrencyRateDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
      



  






        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRate.Text))
            {
                e.Cancel = true; tbRate.Focus(); ep.SetError(tbRate, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbRate, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            (this.entity as Wallnut.Domain.Models.CurrencyRate).ModifiedDate = DateTime.Now;
            (this.entity as Wallnut.Domain.Models.CurrencyRate).CurrencyRateDate = dtCurrencyRateDate.Value;
            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}



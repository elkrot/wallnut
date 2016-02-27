using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Implementations;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Implementations;

namespace Wallnut.UI.Sales.Currency
{
    public partial class fCurrency : Wallnut.UI.Implementations.ListForm
    {
        public fCurrency()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.Currency>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddCurrency, Wallnut.Domain.Models.Currency>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Currency;
            string CurrencyCode = entity.CurrencyCode;
            UpdateEntity<fAddCurrency, Wallnut.Domain.Models.Currency>(CurrencyCode);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.Currency;
            string CurrencyCode = entity.CurrencyCode;
            RemoveEntity<Wallnut.Domain.Models.Currency>(CurrencyCode);
        }








    }
}

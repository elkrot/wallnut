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

namespace Wallnut.UI.Sales.CurrencyRate
{
    public partial class fCurrencyRate : Wallnut.UI.Implementations.ListForm
    {
        public fCurrencyRate()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.CurrencyRate>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddCurrencyRate, Wallnut.Domain.Models.CurrencyRate>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.CurrencyRate;
            int CurrencyRateID = entity.CurrencyRateID;
            UpdateEntity<fAddCurrencyRate, Wallnut.Domain.Models.CurrencyRate>(CurrencyRateID);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.CurrencyRate;
            int CurrencyRateID = entity.CurrencyRateID;
            RemoveEntity<Wallnut.Domain.Models.CurrencyRate>(CurrencyRateID);
        }








    }
}

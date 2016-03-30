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
        public int RetId { get; set; }
        public fCurrencyRate()
        {
            RetId = 0;
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            bn.Items["tsbHelpOk"].Visible = (FormMode == ListFormMode.Help);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (FormMode == ListFormMode.Help)
            {
                if (dgv.SelectedRows[0] != null)
                    RetId = (dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.CurrencyRate).CurrencyRateID;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }








    }
}

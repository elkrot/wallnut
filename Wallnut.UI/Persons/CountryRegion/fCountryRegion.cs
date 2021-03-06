﻿using System;
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

namespace Wallnut.UI.Persons.CountryRegion
{
    public partial class fCountryRegion : Wallnut.UI.Implementations.ListForm
    {
        public fCountryRegion()
        {
            InitializeComponent();
        }

        private void fList_Load(object sender, EventArgs e)
        {
            RefreshData<Wallnut.Domain.Models.CountryRegion>();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddEntity<fAddCountryRegion, Wallnut.Domain.Models.CountryRegion>();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.CountryRegion;
            string code = entity.CountryRegionCode;
            UpdateEntity<fAddCountryRegion, Wallnut.Domain.Models.CountryRegion>(code);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as Wallnut.Domain.Models.CountryRegion;
            string code = entity.CountryRegionCode;
            RemoveEntity<Wallnut.Domain.Models.CountryRegion>(code);
        }








    }
}

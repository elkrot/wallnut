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

namespace Wallnut.UI.Admin.TransactionTypeFrm
{
    public partial class fTransactionType : Wallnut.UI.Implementations.ListForm
    {
        public ListFormBehavior<TransactionType, fAddTransactionType> behavior;
        public fTransactionType()
        {
            behavior = new ListFormBehavior<TransactionType, fAddTransactionType>(x=>true, Reread);
            InitializeComponent();
        }
        public void Reread()
        {
            bs.DataSource = behavior.EntityList.ToList();
        }
        private void fList_Load(object sender, EventArgs e)
        {
            behavior.RefreshData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            behavior.AddEntity();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as TransactionType;
            string id = entity.TransactionTypeID;
            behavior.UpdateEntity(id);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var entity = dgv.SelectedRows[0].DataBoundItem as TransactionType;
            string id = entity.TransactionTypeID;
            behavior.RemoveEntity(id);
        }








    }
}

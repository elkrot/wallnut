﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;

namespace Wallnut.UI.fTemplates
{
    public partial class fEdit : Wallnut.UI.Implementations.AddForm
    {
        public fEdit()
        {
            
            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbName.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.UnitMeasure,
            "Name",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true; tbName.Focus(); ep.SetError(tbName, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbName, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //(this.entity as Wallnut.Domain.Models.___).ModifiedDate = DateTime.Now;
            if (!this.ValidateChildren())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}

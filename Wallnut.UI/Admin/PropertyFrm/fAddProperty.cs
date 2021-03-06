﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.Domain.Models;
using System.ComponentModel.DataAnnotations;


namespace Wallnut.UI.Admin.PropertyFrm
{
    public partial class fAddProperty : Wallnut.UI.Implementations.AddForm
    {
        public fAddProperty()
        {

            InitializeComponent();
        }

        private void BindingData()
        {

            this.tbPropertyCode.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Property,
            "PropertyCode",
            false,
            DataSourceUpdateMode.OnPropertyChanged);

            this.tbPropertyTitle.DataBindings.Add("Text",
            this.entity as Wallnut.Domain.Models.Property,
            "PropertyTitle",
            false,
            DataSourceUpdateMode.OnPropertyChanged);


        }

        private void fEdit_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPropertyCode.Text))
            {
                e.Cancel = true; tbPropertyCode.Focus(); ep.SetError(tbPropertyCode, "Поле наименование не может быть пустым");
            }
            else
            {
                e.Cancel = false; ep.SetError(tbPropertyCode, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            

            if (!this.ValidateChildren())
            {

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            ValidateByModel();

        }

        private void ValidateByModel()
        {
            var prop = this.entity as Wallnut.Domain.Models.Property;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(prop, null, null);
            var errors = "";
            if (!Validator.TryValidateObject(prop, context, results, true))
            {
                foreach (var error in results)
                {
                    errors += error.ErrorMessage;
                }
                MessageBox.Show(errors);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
    }
}

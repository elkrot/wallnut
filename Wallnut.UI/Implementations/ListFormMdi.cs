using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Interfaces;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;
using System.Linq.Expressions;

namespace Wallnut.UI.Implementations
{
    public class ListFormMdi:Form,IListForm 
    {
        private static ListFormMdi aForm = null;

        protected ListFormMdi() : base() { 
        
        }
        /*public ListForm(Expression<Func<T, bool>> predicate)  :base() {
            Predicate = predicate;
        }*/
        public System.Windows.Forms.BindingSource bs =new System.Windows.Forms.BindingSource();
        //public Expression<Func<T, bool>> Predicate;
        #region Add
        public void AddEntity<TAddForm, T>(params object[] addParams)
            where TAddForm : AddForm, new()
            where T : class,new()
        {
            TAddForm frm = new TAddForm();
            frm.Text = "Добавление ";
            if (addParams!=null)
            {
                frm.AddParams = addParams;
            }
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.entity = new T();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    unitOfWork.GetRepository<T>().Add(frm.entity as T);
                    unitOfWork.Complete();
                    /*if (this.Predicate != null)
                    {
                        Expression<Func<T, bool>> ex=e=>e.ToString()=="";
                        bs.DataSource = unitOfWork.GetRepository<T>().Find(ex).ToList();
                    }
                    else
                    {*/
                        bs.DataSource = unitOfWork.GetRepository<T>().GetAll().ToList();
                   // }
                }
            }
        }
        #endregion

        //var entity = dgv.SelectedRows[0].DataBoundItem as Entity;
        //int id=entity.%%%Id
        #region Update
        public void UpdateEntity<TAddForm, T>(params object[] KeyValues)
            where TAddForm:AddForm ,new()
            where T : class,new()
        {
            TAddForm frm = new TAddForm();
            frm.Text = "Изменение ";
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.entity = unitOfWork.GetRepository<T>().Get(KeyValues);
                DialogResult result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    unitOfWork.GetRepository<T>().Update(frm.entity as T);
                    unitOfWork.Complete();
                    bs.DataSource = unitOfWork.GetRepository<T>().GetAll().ToList();
                }
            }
        }
        #endregion

        #region Remove
        public void RemoveEntity<T>(params object[] KeyValues)
            where T : class,new()
        {
            System.Windows.Forms.DialogResult res = MessageBox.Show("Удалить запись?", "Удалить запись?", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var obj = unitOfWork.GetRepository<T>().Get(KeyValues);
                    
                    unitOfWork.GetRepository<T>().Remove(obj);
                    unitOfWork.Complete();
                    bs.DataSource = unitOfWork.GetRepository<T>().GetAll().ToList();
                }
            }
        }
        #endregion

        #region Refresh
        public void RefreshData<T>()where T:class{
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var rep = unitOfWork.GetRepository<T>().GetAll();
                    bs.DataSource = rep.ToList();
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ListForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "ListForm";
            this.Load += new System.EventHandler(this.ListFormMdi_Load);
            this.ResumeLayout(false);

        }

        private void ListFormMdi_Load(object sender, EventArgs e)
        {
            
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }


/*        public static ListFormMdi Instance()
        {
            if (aForm == null)
            {
                aForm = new ListFormMdi();
            }
            return aForm;
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            aForm = null;
        }
        /*
         private static Form3 aForm = null;
        private Form3()
        {
            InitializeComponent();
        }
 public static Form3 Instance()
        {
            if (aForm == null)
            {
                aForm = new Form3();
            }
            return aForm;
        }

         
         * 
         *         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            aForm = null;
        }
         * 
         */
    }
}

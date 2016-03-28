using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.UI.Interfaces;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;
using System.Linq.Expressions;
using System.Diagnostics;

namespace Wallnut.UI.Implementations
{
    public class ListFormBehavior<T, TAddForm> : INewListForm<T, TAddForm> 
        where T : class,new()
        where TAddForm : AddForm, new()
    { public Action RereadDataSource;
        public event EventHandler BeforeAddEntity;
        public event EventHandler BeforeUpdateEntity;
        public event EventHandler AfterAddEntity;
        public event EventHandler AfterUpdateEntity;
        public event EventHandler AfterRemoveEntity;
        public ConditionForm ConditionForm;

        #region Constructors
       public ListFormBehavior() : base() { 
       }

        public ListFormBehavior(Expression<Func<T, bool>> predicate, Action rereadDataSource)
            : base()
        {
            SetCondition(predicate);
            RereadDataSource += rereadDataSource;
        }

        /// <summary>
        /// Конструктор для формы с условием отбора
        /// </summary>
        /// <param name="predicate">Условие отбора</param>
        /// <param name="rereadDataSource">Процедура перечитки</param>
        /// <param name="conditionForm">Форма Условия отбора</param>
        public ListFormBehavior(Expression<Func<T, bool>> predicate, Action rereadDataSource, ConditionForm conditionForm)
            : base()
        {
            ConditionForm = conditionForm;
            if (ConditionForm.SetScreenConditionFieldsValues())
            {
                SetCondition(predicate);
            }
            RereadDataSource += rereadDataSource;
        }
        #endregion

        #region IsConditionChange
        private bool IsConditionChange()
        {
            DialogResult result = ConditionForm.ShowDialog();
            return (result == System.Windows.Forms.DialogResult.OK);
        }
        #endregion



        #region SetCondition
        public void SetCondition(Expression<Func<T, bool>> predicate)
        {
            Predicate = predicate;
        }        
        #endregion

        
        public Expression<Func<T, bool>> Predicate = null;
        public List<T> EntityList { get; set; }



        #region Add
        public void AddEntity(params object[] addParams)
        {
            TAddForm frm = new TAddForm();
            frm.Text += "Добавление ";
            if (addParams.Count()>0)
            {
                frm.AddParams = addParams;
            }
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                frm.entity = new T();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BusinessLogic.Interfaces.IRepository<T> repo =unitOfWork.GetRepository<T>();
                    if (repo == null)
                        throw new ArgumentNullException("Отсутствует репозиторий", "репо");
                    if (BeforeAddEntity!=null)
                        BeforeAddEntity(this, EventArgs.Empty);

                    repo.Add(frm.entity as T);
                    unitOfWork.Complete();
                    var rep = unitOfWork.GetRepository<T>().Find(Predicate);
                    EntityList = rep.ToList();
                }
            }
            if (AfterAddEntity!=null)
                AfterAddEntity (this, EventArgs.Empty);
            RereadDataSource();
        }
        #endregion

        #region Update
        public void UpdateEntity(params object[] KeyValues)  
        {
            TAddForm frm = new TAddForm();
            frm.Text += "Изменение ";
            if (KeyValues != null)
            {
                frm.AddParams = KeyValues;
            }
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var repo=unitOfWork.GetRepository<T>();
                if (repo == null)
                    throw new ArgumentNullException("Отсутствует репозиторий "+typeof(T).ToString(), "репо");
                frm.entity = repo.Get(KeyValues);

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (BeforeUpdateEntity != null)
                    BeforeUpdateEntity(this, EventArgs.Empty);
                    repo.Update(frm.entity as T);
                    unitOfWork.Complete();

                    if (AfterRemoveEntity != null)
                        AfterRemoveEntity(this, EventArgs.Empty);

                    var rep = repo.Find(Predicate);
                    EntityList = rep.ToList();
                }
                if (AfterUpdateEntity != null)
                    AfterUpdateEntity(this, EventArgs.Empty);
                RereadDataSource();
            }
        }
        #endregion

        #region Remove
        public void RemoveEntity(params object[] KeyValues)
            
        {
            System.Windows.Forms.DialogResult res = MessageBox.Show("Удалить запись?", "Удалить запись?", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
                {
                    var obj = unitOfWork.GetRepository<T>().Get(KeyValues);
                    
                    unitOfWork.GetRepository<T>().Remove(obj);
                    unitOfWork.Complete();
                    var rep = unitOfWork.GetRepository<T>().Find(Predicate);
                    EntityList = rep.ToList();
                }
                RereadDataSource();
            }
        }
        #endregion

        #region Refresh
        public void RefreshData(){
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var repo=unitOfWork.GetRepository<T>();
                Debug.Assert(repo != null);
                var rep = repo.Find(Predicate);
                EntityList = rep.ToList();
            }
            RereadDataSource();
        }
        public void Refresh()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var rep = unitOfWork.GetRepository<T>().Find(Predicate);
                EntityList = rep.ToList();
            }

        }
        #endregion
       
        
    }
}

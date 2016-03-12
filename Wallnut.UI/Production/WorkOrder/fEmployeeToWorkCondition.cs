using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;

namespace Wallnut.UI.Production.WorkOrder
{
    public partial class fEmployeeToWorkCondition : Form
    {
        private List<Department> departmentList;
        private List<Shift> shiftList;
        private List<Product> productList;
        private EmployeeToWorkCondition curCondition;
        public List<EmployeeToWorkResult> FormResult;
        public fEmployeeToWorkCondition()
        {
            curCondition = new EmployeeToWorkCondition() { WorkDate = DateTime.Now, DepartmentId = 2, ShiftId = 1, ProductId = 1 };
            InitializeComponent();
        }

        private void fEmployeeToWorkCondition_Load(object sender, EventArgs e)
        {

            BindingData();

            ReReadGrid();
        }

        private void ReReadGrid()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {

                List<System.Data.SqlClient.SqlParameter> prms =
                    new List<System.Data.SqlClient.SqlParameter>();

                var DepartmentId = new System.Data.SqlClient.SqlParameter("@DepartmentID", SqlDbType.Int);
                DepartmentId.Value = curCondition.DepartmentId;

                var ShiftId = new System.Data.SqlClient.SqlParameter("@ShiftID", SqlDbType.Int);
                ShiftId.Value = curCondition.ShiftId;
                prms.Add(DepartmentId);

                prms.Add(ShiftId);

                //r("@ShiftID",curCondition.ShiftId) };

                var strWhere = @" and v.DepartmentID=@DepartmentID and v.ShiftID=@ShiftID";
                var obj = unitOfWork.EmployeeRepository.GetEmployeeWithJobTitle(prms, strWhere)
                    .Select(p => new ListEmployeeToWork
                    {
                        Fio = p.FirstName + " " + p.MiddleName + " " + p.LastName
                        ,
                        Qty = 0.0
                        ,
                        Id = p.BusinessEntityID
                        ,
                        JobTitle = p.JobTitle
                    ,
                        Selected = true
                    });


                bs.DataSource = obj.ToList();

            }
        }


        #region BindingData
        private void BindingData()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                this.departmentList = unitOfWork.DepartmentRepository.GetAll().ToList<Wallnut.Domain.Models.Department>();
                cbDepartment.DataSource = departmentList;
                this.shiftList = unitOfWork.ShiftRepository.GetAll().ToList<Wallnut.Domain.Models.Shift>();
                cbShift.DataSource = shiftList;
                this.productList = unitOfWork.ProductsRepository.GetAll().ToList<Wallnut.Domain.Models.Product>();
                cbProduct.DataSource = productList;
            }
            #region Department
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedValue = curCondition.DepartmentId;
            cbDepartment.SelectedIndexChanged += (x, y) =>
            {
                curCondition.DepartmentId = (short)cbDepartment.SelectedValue;
                ReReadGrid();
            };
            #endregion

            #region Shift
            cbShift.ValueMember = "ShiftID";
            cbShift.DisplayMember = "Name";
            cbShift.SelectedValue =
                curCondition.ShiftId;
            cbShift.SelectedIndexChanged += (x, y) =>
            {
                curCondition.ShiftId = (int)cbShift.SelectedValue;
                ReReadGrid();
            };
            #endregion

            #region Product
            cbProduct.ValueMember = "ProductID";
            cbProduct.DisplayMember = "Name";
            cbProduct.SelectedValue =
                curCondition.ProductId;
            cbProduct.SelectedIndexChanged += (x, y) =>
            {
                curCondition.ProductId = (int)cbProduct.SelectedValue;
            };
            #endregion

            #region WorkDate
            this.dtpWorkDate.DataBindings.Add("Value",
            curCondition,
            "WorkDate",
            false,
            DataSourceUpdateMode.OnPropertyChanged);
            #endregion

        }
        #endregion

        #region dgv_CellValidating
        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (dgv.CurrentCell.ColumnIndex == 1)
            {
                dgv.Rows[e.RowIndex].ErrorText = "";
                double newInteger;

                // Don't try to validate the 'new row' until finished 
                // editing since there
                // is not any point in validating its initial value.
                if (dgv.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgv.Rows[e.RowIndex].ErrorText = "Значение должно быть положительным числом";
                }
            }
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetResult();
        }

        #region SetResult
        private void SetResult()
        {
            var workDate = curCondition.WorkDate;
            var productId = curCondition.ProductId;

            var employeeToWorkList = (bs.DataSource as List<ListEmployeeToWork>).Where(m => m.Selected == true);

            foreach (var item in employeeToWorkList)
            {
                FormResult.Add(new EmployeeToWorkResult()
                {
                    EmployeeId = item.Id,
                    Qty = item.Qty,
                    WorkDate = workDate,
                    ProductId = productId
                });
            }
        }        
        #endregion

    }



 


}

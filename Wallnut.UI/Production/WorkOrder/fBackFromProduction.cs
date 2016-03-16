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
    public partial class fBackFromProduction : Form
    {
        private List<Department> departmentList;
        private List<Shift> shiftList;
        private List<Product> productList;
        private EmployeeToWorkCondition curCondition;
        public List<BackFromProductionResult> FormResult;
        public fBackFromProduction()
        {
            FormResult = new List<BackFromProductionResult>();
            curCondition = new EmployeeToWorkCondition()
            {
                WorkDate = DateTime.Now
                ,
                DepartmentId = Wallnut.Utils.Settings.DepartmentWorkshopId
                ,
                ShiftId = Wallnut.Utils.Settings.DefaultShiftId
                ,
                ProductId = Wallnut.Utils.Settings.WalnutKernelId
            };
            InitializeComponent();
        }

        private void fEmployeeToWorkCondition_Load(object sender, EventArgs e)
        {

            BindingData();

            ReReadGrid();
        }

        #region ReReadGrid
        private void ReReadGrid()
        {
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var obj = unitOfWork.EmployeeRepository.GetEmployeeListBackFromProdaction
            (curCondition.DepartmentId, curCondition.ShiftId, curCondition.WorkDate)
                    .Select(p => new ListBackFromProduction
                    {
                        Fio = p.Fio
                        ,
                        QtyIssued = p.Qty
                        ,
                        QtyKernel = 0
                        ,
                        QtyNuts = 0
                        ,
                        QtyShucks = 0
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
        #endregion

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

            if (dgv.CurrentCell.ColumnIndex == 2 || dgv.CurrentCell.ColumnIndex == 3 || dgv.CurrentCell.ColumnIndex == 4)
            {
                dgv.Rows[e.RowIndex].ErrorText = "";
                decimal newInteger;

                // Don't try to validate the 'new row' until finished 
                // editing since there
                // is not any point in validating its initial value.
                if (dgv.Rows[e.RowIndex].IsNewRow) { return; }
                if (!decimal.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                    dgv.Rows[e.RowIndex].ErrorText = "Значение должно быть положительным числом";
                }
            }/**/
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

            var employeeToWorkList = (bs.DataSource as List<ListBackFromProduction>).Where(m => m.Selected == true);

            foreach (var item in employeeToWorkList)
            {
                FormResult.Add(new BackFromProductionResult()
                {
                    EmployeeId = item.Id,
                    QtyKernel = item.QtyKernel,
                    QtyShucks = item.QtyShucks,
                    QtyNuts = item.QtyNuts,
                    WorkDate = workDate,
                    ProductId = productId
                });
            }
        }
        #endregion

        private void dtpWorkDate_ValueChanged(object sender, EventArgs e)
        {
            curCondition.WorkDate = (DateTime)dtpWorkDate.Value;
            ReReadGrid();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            decimal qtyIssued=0;
            decimal qtyKernel =0; 
            decimal qtyShucks =0;
            decimal qtyNuts=0;

                decimal.TryParse(dgv.Rows[e.RowIndex].Cells["colQtyIssued"].Value.ToString(), out qtyIssued);
                decimal.TryParse(dgv.Rows[e.RowIndex].Cells["colQtyKernel"].Value.ToString(), out qtyKernel);
                decimal.TryParse(dgv.Rows[e.RowIndex].Cells["colQtyShucks"].Value.ToString(), out qtyShucks);
                decimal.TryParse(dgv.Rows[e.RowIndex].Cells["colQtyNuts"].Value.ToString(), out qtyNuts);

            switch (e.ColumnIndex)
	{
                case 2:
            dgv.Rows[e.RowIndex].Cells[4].Value =
                (qtyIssued - qtyKernel - qtyShucks).ToString();
                    break;
                case 3:
                    dgv.Rows[e.RowIndex].Cells[4].Value =
                (qtyIssued - qtyKernel - qtyShucks).ToString();
                    break;
                case 4:
                    break;
		default:
 break;
	}
            
        }

    }






}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain;
using System.Data.Entity;
using Wallnut.Domain.Interfaces;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace Wallnut.BusinessLogic.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _context;

        #region Constructor
               /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст</param>
        public UnitOfWork(IDbContext context)
        {
            _context = context;

            AddressRepository = new AddressRepository(_context);
            EmployeeRepository = new EFEmployeesRepository(_context);
            DepartmentRepository = new DepartmentRepository(_context);
            ProductsRepository = new ProductsRepository(_context);
            UnitMeasureRepository = new UnitMeasureRepository(_context);
            PasswordRepository = new PasswordRepository(_context);
            ShiftRepository = new ShiftRepository(_context);
            CurrencyRepository = new CurrencyRepository(_context);
            AddressTypesRepository = new AddressTypeRepository(_context);
            CountryRegionRepository = new CountryRegionRepository(_context);
            CurrencyRateRepository = new CurrencyRateRepository(_context);
            CustomerRepository = new CustomerRepository(_context);
            EmailAddressRepository = new EmailAddressRepository(_context);
            EmployeeDepartmentHistoryRepository = new EmployeeDepartmentHistoryRepository(_context);
            PersonPhoneRepository = new PersonPhoneRepository(_context);
            LocationRepository = new LocationRepository(_context);
            PhoneNumberTypeRepository = new PhoneNumberTypeRepository(_context);
            ProductListPriceHistoryRepository = new ProductListPriceHistoryRepository(_context);
            ProductVendorRepository = new ProductVendorRepository(_context);
            PurchaseOrderDetailRepository = new PurchaseOrderDetailRepository(_context);
            PurchaseOrderHeaderRepository = new PurchaseOrderHeaderRepository(_context);
            SalesOrderDetailRepository = new SalesOrderDetailRepository(_context);
            StateProvinceRepository = new StateProvinceRepository(_context);
            VendorRepository = new VendorRepository(_context);
            ContactTypeRepository = new ContactTypeRepository(_context);
            BusinessEntityRepository = new BusinessEntityRepository(_context);
            ShipMethodRepository = new ShipMethodRepository(_context);
            ProductCostHistoryRepository = new ProductCostHistoryRepository(_context);

            ExpenditureRepository = new ExpenditureRepository(_context);
            ExpenditureCostHistoryRepository = new ExpenditureCostHistoryRepository(_context);

            WorkOrderRepository = new WorkOrderRepository(_context);
            WorkOrderHistoryRepository = new WorkOrderHistoryRepository(_context);

            EmployeeAttendanceHistoryRepository = new EmployeeAttendanceHistoryRepository(_context);
            ProductInventoryRepository = new ProductInventoryRepository(_context);
            SalesOrderHeaderRepository = new SalesOrderHeaderRepository(_context);

            StoreRepository = new StoreRepository(_context);
            SalesTerritoryRepository = new SalesTerritoryRepository(_context);
            //  _ = new _(_context);
        }
        #endregion

        #region Repositories
         public IAddressRepository AddressRepository { get; private set; }
        public IAddressTypesRepository  AddressTypesRepository{ get; private set; }
        public ICountryRegionRepository  CountryRegionRepository{ get; private set; }
        public ICurrencyRateRepository CurrencyRateRepository { get; private set; }
        public ICustomerRepository CustomerRepository { get; private set; }
        public IEmailAddressRepository EmailAddressRepository { get; private set; }
        public IEmployeeDepartmentHistoryRepository EmployeeDepartmentHistoryRepository  { get; private set; }
        public IPersonPhoneRepository  PersonPhoneRepository{ get; private set; }
        public ILocationRepository  LocationRepository{ get; private set; }
        public IPhoneNumberTypeRepository PhoneNumberTypeRepository { get; private set; }
        public IProductListPriceHistoryRepository ProductListPriceHistoryRepository { get; private set; }
        public IProductVendorRepository  ProductVendorRepository{ get; private set; }
        public IPurchaseOrderDetailRepository  PurchaseOrderDetailRepository{ get; private set; }
        public IPurchaseOrderHeaderRepository  PurchaseOrderHeaderRepository{ get; private set; }
        public ISalesOrderDetailRepository SalesOrderDetailRepository{ get; private set; }
        public IStateProvinceRepository StateProvinceRepository{ get; private set; }
        public IVendorRepository VendorRepository{ get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IProductsRepository ProductsRepository { get; private set; }
        public IUnitMeasureRepository UnitMeasureRepository { get; private set; }
        public IPasswordRepository PasswordRepository { get; private set; }
        public IShiftRepository ShiftRepository { get; private set; }
        public ICurrencyRepository CurrencyRepository { get; private set; }
        public IContactTypeRepository ContactTypeRepository { get; private set; }
        public IBusinessEntityRepository BusinessEntityRepository { get; private set; }
        public IShipMethodRepository ShipMethodRepository { get; private set; }
        public IProductCostHistoryRepository ProductCostHistoryRepository { get; private set; }
        public IExpenditureRepository ExpenditureRepository { get; private set; }
        public IExpenditureCostHistoryRepository ExpenditureCostHistoryRepository { get; private set; }
        public IWorkOrderRepository WorkOrderRepository { get; private set; }
        public IWorkOrderHistoryRepository WorkOrderHistoryRepository { get; private set; }
        public IEmployeeAttendanceHistoryRepository EmployeeAttendanceHistoryRepository { get; private set; }
        public IProductInventoryRepository ProductInventoryRepository { get; private set; }
        public ISalesOrderHeaderRepository SalesOrderHeaderRepository { get; private set; }

        public ISalesTerritoryRepository SalesTerritoryRepository { get; private set; }

        public IStoreRepository StoreRepository { get; private set; }
        //public I  { get; private set; }
        #endregion

        #region Complete
        /// <summary>
        /// Сохранение данных в БД
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {

            try
            {
                return (_context as DbContext).SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " Ошибки валидации: ", fullErrorMessage);
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                //return 0;
                // Throw a new DbEntityValidationException with the improved exception message.
                
            }
            catch (DbUpdateException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.InnerException.InnerException.Message;
                var exceptionMessage = string.Concat(ex.Message, " Ошибки Сохранения в БД: ", errorMessages);
                System.Windows.Forms.MessageBox.Show(exceptionMessage, "Ошибка приложения"
                    , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                // Throw a new DbEntityValidationException with the improved exception message.
                 throw new DbUpdateException(exceptionMessage);
               // return 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Удаление
        /// </summary>
         public void Dispose()
        {
            (_context as DbContext).Dispose();
        }       
        #endregion

         public IRepository<T> GetRepository<T>() where T : class
         {
             IRepository<T> ret;
             Type typeoft = typeof(T);
             switch (typeoft.Name)
             {
        case "Address": ret = (IRepository<T>)AddressRepository;
                     break;

        case "AddressTypes" :ret = (IRepository<T>)AddressTypesRepository ;
                     break;

        case "CountryRegion" :ret = (IRepository<T>)CountryRegionRepository;
                     break;
        case "CurrencyRate" :ret = (IRepository<T>)CurrencyRateRepository ;
                     break;
        case "Customer" :ret = (IRepository<T>)CustomerRepository ;
                     break;
        case "EmailAddress" :ret = (IRepository<T>)EmailAddressRepository ;
                     break;
        case "EmployeeDepartmentHistory" :ret = (IRepository<T>)EmployeeDepartmentHistoryRepository ;
                     break; 
        case "PersonPhone" :ret = (IRepository<T>)PersonPhoneRepository;
                     break;
        case "Location" :ret = (IRepository<T>) LocationRepository;
                     break;
        case "PhoneNumberType" :ret = (IRepository<T>)PhoneNumberTypeRepository ;
                     break;
        case "ProductListPriceHistory" :ret = (IRepository<T>)ProductListPriceHistoryRepository;
                     break; 
        case "ProductVendor" :ret = (IRepository<T>) ProductVendorRepository;
                     break;
        case "PurchaseOrderDetail" :ret = (IRepository<T>) PurchaseOrderDetailRepository;
                     break;
        case "PurchaseOrderHeader" :ret = (IRepository<T>)  PurchaseOrderHeaderRepository;
                     break;
        case "SalesOrderDetail" :ret = (IRepository<T>) SalesOrderDetailRepository;
                     break;
        case "StateProvince" :ret = (IRepository<T>) StateProvinceRepository;
                     break;
        case "Vendor" :ret = (IRepository<T>) VendorRepository;
                     break;
        case "Employee" :ret = (IRepository<T>) EmployeeRepository ;
                     break;
        case "Department" :ret = (IRepository<T>) DepartmentRepository ;
                     break;
        case "Products" :ret = (IRepository<T>) ProductsRepository ;
                     break;
        case "UnitMeasure" :ret = (IRepository<T>) UnitMeasureRepository ;
                     break;
        case "Password" :ret = (IRepository<T>) PasswordRepository;
                     break; 
        case "Shift" :ret = (IRepository<T>) ShiftRepository ;
                     break;
        case "Currency": ret = (IRepository<T>)CurrencyRepository;
                     break;
        case "ContactType": ret = (IRepository<T>)ContactTypeRepository;
                     break;
        case "BusinessEntity": ret = (IRepository<T>)BusinessEntityRepository;
                     break;
        case "ShipMethod": ret = (IRepository<T>)ShipMethodRepository;
                     break;
        case "ProductCostHistory": ret = (IRepository<T>)ProductCostHistoryRepository;
                     break;
        case "Expenditure": ret = (IRepository<T>)ExpenditureRepository;
                     break;
        case "ExpenditureCostHistory": ret = (IRepository<T>)ExpenditureCostHistoryRepository;
                     break;

        case "WorkOrder": ret = (IRepository<T>)WorkOrderRepository;
                     break;
        case "WorkOrderHistory": ret = (IRepository<T>)WorkOrderHistoryRepository;
                     break;
        case "EmployeeAttendanceHistory": ret = (IRepository<T>)EmployeeAttendanceHistoryRepository;
                     break;
        case "ProductInventory": ret = (IRepository<T>)ProductInventoryRepository;
                     break;
        case "SalesOrderHeader": ret = (IRepository<T>)SalesOrderHeaderRepository;
                     break;
        case "SalesTerritory": ret = (IRepository<T>)SalesTerritoryRepository;
                     break;
        case "Store": ret = (IRepository<T>)StoreRepository;
                     break;
                 default:
                     ret = null;
                     break;
             }
             return ret;
         
         }
    }
}

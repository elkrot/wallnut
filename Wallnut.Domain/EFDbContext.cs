// -----------------------------------------------------------------------
// <copyright file="EFDbContext.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Entity;
    using Wallnut.Domain.Entities;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.Entity.Infrastructure;
    /// <summary>
    /// Super class
    /// </summary>
    public class EFDbContext : System.Data.Entity.DbContext
    {


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EFDbContext" /> class.
        /// </summary>
        public EFDbContext()
            : base("WallnutDb")
        {
            // var serv=@".\SQLEXPRESS";
            //HP-NOUT\SQLEXPRESS
            //  Database.Connection.ConnectionString = string.Format(@"Data Source={0};Initial Catalog=WallnutDb;Integrated Security=True",serv);
        }

        #endregion

        #region Properties

        public DbSet<Employee> Employees { get; set; }
        #endregion

        #region Functions

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            //Database.SetInitializer(new DropCreateDatabaseAlways());
            modelBuilder.Entity<BusinessEntity>().HasKey(b => b.BusinessEntityID);


            // Human Resources  (Сотрудники компании)
            #region Employee
            modelBuilder.Entity<Employee>().Property(p => p.BusinessEntityID).HasDatabaseGeneratedOption
               (DatabaseGeneratedOption.None);
            modelBuilder.Entity<Employee>().Property(p => p.NationalIDNumber).HasColumnType("nvarchar")
                .HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.LoginID).HasColumnType("nvarchar")
                .HasMaxLength(256).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.JobTitle).HasColumnType("nvarchar")
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.MaritalStatus).HasColumnType("nchar")
                .HasMaxLength(1).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.Gender).HasColumnType("nchar")
                .HasMaxLength(1).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.SalariedFlag).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Employee>().Property(p => p.CurrentFlag).HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Employee>().ToTable("Employee", "HumanResources");
            #endregion

            #region Department
            modelBuilder.Entity<Department>().HasKey(b => b.DepartmentID);
            modelBuilder.Entity<Department>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Department>().Property(p => p.GroupName)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Department>().ToTable("Department", "HumanResources");
            #endregion

            #region Shift
            modelBuilder.Entity<Shift>().HasKey(b => b.ShiftID);
            modelBuilder.Entity<Shift>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Shift>().Property(p => p.StartTime)
                .HasColumnType("time").IsRequired();
            modelBuilder.Entity<Shift>().Property(p => p.EndTime)
                .HasColumnType("time").IsRequired();

            modelBuilder.Entity<Shift>().ToTable("Shift", "HumanResources");
            #endregion

            #region EmployeeDepartmentHistory
            modelBuilder.Entity<EmployeeDepartmentHistory>().HasKey(b => b.BusinessEntityID);
            modelBuilder.Entity<EmployeeDepartmentHistory>().Property(p => p.DepartmentID)
                 .HasColumnType("smallint").IsRequired();
            modelBuilder.Entity<EmployeeDepartmentHistory>().Property(p => p.ShiftID)
                .HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<EmployeeDepartmentHistory>().Property(p => p.StartDate)
                .HasColumnType("date").IsRequired();
            modelBuilder.Entity<EmployeeDepartmentHistory>().Property(p => p.EndDate)
                .HasColumnType("date");

            modelBuilder.Entity<EmployeeDepartmentHistory>().ToTable("EmployeeDepartmentHistory", "HumanResources");
            #endregion

            #region EmployeePayHistory
            modelBuilder.Entity<EmployeePayHistory>().HasKey(b => b.BusinessEntityID);
            modelBuilder.Entity<EmployeePayHistory>().Property(p => p.BusinessEntityID)
                .HasColumnType("int").IsRequired().HasDatabaseGeneratedOption
               (DatabaseGeneratedOption.None);
            modelBuilder.Entity<EmployeePayHistory>().Property(p => p.RateChangeDate)
                 .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<EmployeePayHistory>().Property(p => p.Rate)
                 .HasColumnType("money").IsRequired();
            modelBuilder.Entity<EmployeePayHistory>().Property(p => p.PayFrequency)
                 .HasColumnType("tinyint").IsRequired();

            modelBuilder.Entity<Employee>().ToTable("EmployeePayHistory", "HumanResources");

            #endregion
            // Person (ФИО и адреса частных лиц: заказчиков, поставщиков и сотрудников.)
            #region Person
            modelBuilder.Entity<Person>().Property(p => p.BusinessEntityID).HasDatabaseGeneratedOption
               (DatabaseGeneratedOption.None);
            modelBuilder.Entity<Person>().Property(p => p.PersonType).HasColumnType("nchar")
               .HasMaxLength(2).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.FirstName).HasColumnType("nvarchar")
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.MiddleName).HasColumnType("nvarchar")
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.LastName).HasColumnType("nvarchar")
                .HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Person>().ToTable("Person", "Person");
            #endregion

            #region Address
            modelBuilder.Entity<Address>().HasKey(b => b.AddressID);
            modelBuilder.Entity<Address>().Property(p => p.AddressLine1)
                .HasColumnType("nvarchar").IsRequired().HasMaxLength(60);
            modelBuilder.Entity<Address>().Property(p => p.AddressLine2)
                .HasColumnType("nvarchar").HasMaxLength(60);
            modelBuilder.Entity<Address>().Property(p => p.City)
                .HasColumnType("nvarchar").HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(p => p.StateProvinceID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<Address>().Property(p => p.PostalCode)
                .HasColumnType("nvarchar").HasMaxLength(15).IsRequired();


            modelBuilder.Entity<Address>().ToTable("Address", "Person");
            #endregion

            #region AddressType
            modelBuilder.Entity<AddressType>().HasKey(b => b.AddressTypeID);
            modelBuilder.Entity<AddressType>().Property(p => p.Name)
                .HasColumnType("nvarchar").IsRequired().HasMaxLength(50);

            modelBuilder.Entity<AddressType>().ToTable("Address", "Person");
            #endregion

            #region BusinessEntityAddress
            modelBuilder.Entity<BusinessEntityAddress>().HasKey(p => new { p.BusinessEntityID, p.AddressID, p.AddressTypeID });

            modelBuilder.Entity<BusinessEntityAddress>().ToTable("BusinessEntityAddress", "Person");
            #endregion

            #region BusinessEntityContact
            modelBuilder.Entity<BusinessEntityContact>().HasKey(p => new { p.BusinessEntityID, p.PersonID, p.ContactTypeID });

            modelBuilder.Entity<BusinessEntityContact>().ToTable("BusinessEntityContact", "Person");
            #endregion


            #region CountryRegion
            modelBuilder.Entity<CountryRegion>().HasKey(b => b.CountryRegionCode);

            modelBuilder.Entity<CountryRegion>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<CountryRegion>().ToTable("CountryRegion", "Person");
            #endregion

            #region EmailAddress
            modelBuilder.Entity<EmailAddress>().HasKey(b => new { b.BusinessEntityID, b.EmailAddressID });

            modelBuilder.Entity<EmailAddress>().Property(p => p.EmailAddress1)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<EmailAddress>().ToTable("EmailAddress", "Person");

            #endregion

            #region Password
            modelBuilder.Entity<Password>().HasKey(b => b.BusinessEntityID);

            modelBuilder.Entity<Password>().Property(p => p.PasswordHash)
                .HasColumnType("varchar").HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Password>().Property(p => p.PasswordSalt)
                .HasColumnType("varchar").HasMaxLength(10).IsRequired();

            modelBuilder.Entity<Password>().ToTable("Password", "Person");
            #endregion

            #region PersonPhone
            modelBuilder.Entity<PersonPhone>().HasKey(b => b.BusinessEntityID);

            modelBuilder.Entity<PersonPhone>().Property(p => p.PhoneNumber)
                .HasColumnType("nvarchar").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<PersonPhone>().Property(p => p.PhoneNumberTypeID)
                .HasColumnType("int").IsRequired();

            modelBuilder.Entity<PersonPhone>().ToTable("PersonPhone", "Person");
            #endregion

            #region PhoneNumberType
            modelBuilder.Entity<PhoneNumberType>().HasKey(b => b.PhoneNumberTypeID);

            modelBuilder.Entity<PhoneNumberType>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<PhoneNumberType>().ToTable("PhoneNumberType", "Person");
            #endregion

            #region StateProvince
            modelBuilder.Entity<StateProvince>().HasKey(b => b.StateProvinceID);
            modelBuilder.Entity<StateProvince>().Property(p => p.StateProvinceCode)
                .HasColumnType("nchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<StateProvince>().Property(p => p.CountryRegionCode)
                .HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<StateProvince>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<StateProvince>().Property(p => p.TerritoryID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<StateProvince>().ToTable("PhoneNumberType", "Person");
            #endregion

            // Production (Продукция, производимая и реализуемая компанией)
            #region Product
            modelBuilder.Entity<Product>().HasKey(b => b.ProductID);

            modelBuilder.Entity<Product>().Property(p => p.Name)
                .HasColumnType("nchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.ProductNumber)
                .HasColumnType("nvarchar").HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.MakeFlag)
                .HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.FinishedGoodsFlag)
                .HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.StandardCost)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.ListPrice)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.UnitMeasureCode)
                .HasColumnType("nchar").HasMaxLength(3);
            modelBuilder.Entity<Product>().Property(p => p.FinishedGoodsFlag);
            modelBuilder.Entity<Product>().ToTable("Product", "Production");

            #endregion

            #region Location
            modelBuilder.Entity<Location>().HasKey(b => b.LocationID);

            modelBuilder.Entity<Location>().Property(p => p.Name)
                .HasColumnType("nchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Location>().Property(p => p.CostRate)
                .HasColumnType("smallmoney").IsRequired();
            modelBuilder.Entity<Location>().Property(p => p.Availability)
                .HasColumnType("decimal").HasPrecision(8, 2).IsRequired();

            modelBuilder.Entity<Location>().ToTable("Location", "Production");
            #endregion

            #region WorkOrderRouting
            modelBuilder.Entity<WorkOrderRouting>().HasKey(b => new { b.WorkOrderID, b.ProductID, b.OperationSequence });

            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ProductID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.OperationSequence)
                .HasColumnType("smallint").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.LocationID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ScheduledStartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ScheduledStartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ActualStartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ActualEndDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ActualResourcesHrs)
                .HasColumnType("decimal").HasPrecision(9, 4).IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.PlannedCost)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<WorkOrderRouting>().Property(p => p.ActualCost)
                .HasColumnType("money").IsRequired();

            modelBuilder.Entity<WorkOrderRouting>().ToTable("WorkOrderRouting", "Production");
            #endregion

            #region WorkOrder
            modelBuilder.Entity<WorkOrder>().HasKey(b => b.WorkOrderID);

            modelBuilder.Entity<WorkOrder>().Property(p => p.ProductID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<WorkOrder>().Property(p => p.OrderQty)
                .HasColumnType("decimal").HasPrecision(9, 4).IsRequired();
            modelBuilder.Entity<WorkOrder>().Property(p => p.OrderQty)
                .HasColumnType("decimal").HasPrecision(9, 4).IsRequired();
            modelBuilder.Entity<WorkOrder>().Property(p => p.ScrappedQty)
                .HasColumnType("decimal").HasPrecision(9, 4).IsRequired();
            modelBuilder.Entity<WorkOrder>().Property(p => p.StartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<WorkOrder>().ToTable("WorkOrder", "Production");            
            #endregion

            #region UnitMeasure
            modelBuilder.Entity<UnitMeasure>().HasKey(b => b.UnitMeasureCode);

            modelBuilder.Entity<UnitMeasure>().Property(p => p.UnitMeasureCode)
                .HasColumnType("nchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<UnitMeasure>().Property(p => p.Name)
                .HasColumnType("decimal").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<UnitMeasure>().ToTable("UnitMeasure", "Production"); 
            #endregion

            #region ProductListPriceHistory
            modelBuilder.Entity<ProductListPriceHistory>().HasKey(b => new { b.ProductID,b.StartDate });

            modelBuilder.Entity<ProductListPriceHistory>().Property(p => p.StartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<ProductListPriceHistory>().Property(p => p.EndDate)
                .HasColumnType("datetime");
            modelBuilder.Entity<ProductListPriceHistory>().Property(p => p.ListPrice)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<ProductListPriceHistory>().ToTable("ProductListPriceHistory", "Production"); 
            #endregion

            #region ProductCostHistory
            modelBuilder.Entity<ProductCostHistory>().HasKey(b => new { b.ProductID, b.StartDate });

            modelBuilder.Entity<ProductCostHistory>().Property(p => p.StartDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<ProductCostHistory>().Property(p => p.EndDate)
                .HasColumnType("datetime");
            modelBuilder.Entity<ProductCostHistory>().Property(p => p.StandardCost)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<ProductCostHistory>().ToTable("ProductCostHistory", "Production");
            #endregion

            //Purchasing (Поставщики готовой продукции и комплектующих.)
            #region ProductVendor
            modelBuilder.Entity<ProductVendor>().HasKey(b => new { b.ProductID, b.BusinessEntityID });

            modelBuilder.Entity<ProductVendor>().Property(p => p.AverageLeadTime)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<ProductVendor>().Property(p => p.StandardPrice)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<ProductVendor>().Property(p => p.LastReceiptCost)
                .HasColumnType("money");
            modelBuilder.Entity<ProductVendor>().Property(p => p.MinOrderQty)
                .HasColumnType("decimal").HasPrecision(9, 4);
            modelBuilder.Entity<ProductVendor>().Property(p => p.MaxOrderQty)
                .HasColumnType("decimal").HasPrecision(9, 4);
            modelBuilder.Entity<ProductVendor>().Property(p => p.UnitMeasureCode)
                .HasColumnType("nchar").HasMaxLength(3).IsRequired();

            modelBuilder.Entity<ProductVendor>().ToTable("ProductVendor", "Purchasing");
            #endregion

            #region PurchaseOrderDetail
            modelBuilder.Entity<PurchaseOrderDetail>().HasKey(b => new { b.PurchaseOrderID, b.PurchaseOrderDetailID });
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.DueDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.OrderQty)
                .HasColumnType("decimal").HasPrecision(9, 4).IsRequired();
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.ProductID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.UnitPrice)
                .HasColumnType("money");
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.ReceivedQty)
                .HasColumnType("decimal").HasPrecision(8, 2);
            modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.ReceivedQty)
                .HasColumnType("decimal").HasPrecision(8, 2);

            modelBuilder.Entity<ProductVendor>().ToTable("PurchaseOrderDetail", "Purchasing");
            #endregion

            #region PurchaseOrderHeader
            modelBuilder.Entity<PurchaseOrderHeader>()
                .HasKey(b =>  b.PurchaseOrderID);

            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.RevisionNumber)
                .HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.Status)
                .HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.EmployeeID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.VendorID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.ShipMethodID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.OrderDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.ShipDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.SubTotal)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.TaxAmt)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<PurchaseOrderHeader>().Property(p => p.Freight)
                .HasColumnType("money").IsRequired();

            modelBuilder.Entity<PurchaseOrderHeader>().ToTable("PurchaseOrderHeader", "Purchasing");
            #endregion

            #region Vendor
            modelBuilder.Entity<Vendor>()
                .HasKey(b => b.BusinessEntityID);

            modelBuilder.Entity<Vendor>().Property(p => p.AccountNumber)
                .HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Vendor>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Vendor>().Property(p => p.CreditRating)
                .HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<Vendor>().Property(p => p.PreferredVendorStatus)
                .HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Vendor>().Property(p => p.ActiveFlag)
                .HasColumnType("bit").IsRequired();
           

            modelBuilder.Entity<Vendor>().ToTable("Vendor", "Purchasing");            
            #endregion

            // Sales(Данные о заказчиках и продажах.)

            #region Currency
            modelBuilder.Entity<Currency>()
                .HasKey(b => b.CurrencyCode);

            modelBuilder.Entity<Currency>().Property(p => p.CurrencyCode)
                .HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<Currency>().Property(p => p.Name)
                .HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Currency>().ToTable("Currency", "Sales");     
            #endregion

            #region CurrencyRate
            modelBuilder.Entity<CurrencyRate>()
                .HasKey(b => b.CurrencyRateID);

            modelBuilder.Entity<CurrencyRate>().Property(p => p.CurrencyRateDate)
                .HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CurrencyRate>().Property(p => p.FromCurrencyCode)
                .HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<CurrencyRate>().Property(p => p.ToCurrencyCode)
                .HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<CurrencyRate>().Property(p => p.Rate)
                .HasColumnType("money").IsRequired();


            modelBuilder.Entity<CurrencyRate>().ToTable("CurrencyRate", "Sales");   
            #endregion

            #region Customer
                        modelBuilder.Entity<Customer>()
                .HasKey(b => b.CustomerID);

            modelBuilder.Entity<Customer>().Property(p => p.PersonID)
                .HasColumnType("int");
            modelBuilder.Entity<Customer>().Property(p => p.StoreID)
                .HasColumnType("int");
            modelBuilder.Entity<Customer>().Property(p => p.TerritoryID)
                .HasColumnType("int");
            modelBuilder.Entity<Customer>().Property(p => p.AccountNumber)
                .HasColumnType("int");

            modelBuilder.Entity<CurrencyRate>().ToTable("Customer", "Sales"); 
            #endregion

            #region SalesOrderDetail
            modelBuilder.Entity<SalesOrderDetail>()
                .HasKey(b => new { b.SalesOrderDetailID, b.SalesOrderID });

            modelBuilder.Entity<SalesOrderDetail>().Property(p => p.CarrierTrackingNumber)
                .HasColumnType("nvarchar").HasMaxLength(25);
            modelBuilder.Entity<SalesOrderDetail>().Property(p => p.OrderQty)
                .HasColumnType("smallint").IsRequired();
            modelBuilder.Entity<SalesOrderDetail>().Property(p => p.ProductID)
                .HasColumnType("int").IsRequired();
            modelBuilder.Entity<SalesOrderDetail>().Property(p => p.UnitPrice)
                .HasColumnType("money").IsRequired();
            modelBuilder.Entity<SalesOrderDetail>().Property(p => p.UnitPriceDiscount)
    .HasColumnType("money").IsRequired();

            modelBuilder.Entity<CurrencyRate>().ToTable("SalesOrderDetail ", "Sales");   
            #endregion





            /*modelBuilder.Entity<BookDetails>().Ignore(t => t.TotalTagsLenght)
             modelBuilder.Entity<BookDetails>().Property(t => t.PublishedAt)
    .HasColumnName("PublishDate")
             * modelBuilder.Entity<BookDetails>().Property(t => t.Author)
    .HasColumnType("varchar")
             * modelBuilder.Entity<BookDetails>().Property(t => t.Title)
    .IsRequired()
    .HasMaxLength(128)
    .HasColumnName("BookTitle")
    .HasColumnOrder(2);
             * 
             * modelBuilder.Entity<BookDetails>().ToTable("Catalog");
             * 
             * modelBuilder.Ignore<Tag>();
             
        modelBuilder.Entity<BookDetails>()
    .Map(m => {
        m.Properties(b => new { b.Id, b.Title, b.Author, b.Url });
        m.ToTable("Catalog");
    })
    .Map(m => {
        m.Properties(b => new {
            b.Description,
            b.IsFree,
            b.IsVisible,
            b.LanguageId,
            b.PublishedAt,
            b.PublisherId,
            b.Rating });
        m.ToTable("BookDetails");
    });
             * 
             modelBuilder.Entity<Arbitter>()
    .HasRequired(a => a.Game)
    .WithRequiredPrincipal(g => g.Arbitter); один к одному
             */

        }
        #endregion


    }




    public class CatalogInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            base.Seed(context);
            var emp1 = new Employee()
            {
                BusinessEntityID = 1,
                JobTitle = "JT",
                LoginID = "Login",
                NationalIDNumber = ""
            };
            context.Employees.Add(emp1);
        }
    }
}

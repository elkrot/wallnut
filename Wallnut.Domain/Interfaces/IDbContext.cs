using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Wallnut.Domain.Models;

namespace Wallnut.Domain.Interfaces
{
   public interface IDbContext 
    {
         DbSet<Department> Departments { get; set; }
         DbSet<Employee> Employees { get; set; }
         DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
         DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
         DbSet<JobCandidate> JobCandidates { get; set; }
         DbSet<Shift> Shifts { get; set; }
         DbSet<Address> Addresses { get; set; }
         DbSet<AddressType> AddressTypes { get; set; }
         DbSet<BusinessEntity> BusinessEntities { get; set; }
         DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
         DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }
         DbSet<ContactType> ContactTypes { get; set; }
         DbSet<CountryRegion> CountryRegions { get; set; }
         DbSet<EmailAddress> EmailAddresses { get; set; }
         DbSet<Password> Passwords { get; set; }
         DbSet<Person> People { get; set; }
         DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
         DbSet<StateProvince> StateProvinces { get; set; }
         DbSet<Location> Locations { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<ProductCostHistory> ProductCostHistories { get; set; }
         DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
         DbSet<UnitMeasure> UnitMeasures { get; set; }
         DbSet<WorkOrder> WorkOrders { get; set; }
         DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
         DbSet<ProductVendor> ProductVendors { get; set; }
         DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
         DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
         DbSet<ShipMethod> ShipMethods { get; set; }
         DbSet<Vendor> Vendors { get; set; }
         DbSet<Currency> Currencies { get; set; }
         DbSet<CurrencyRate> CurrencyRates { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
         DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
         DbSet<SalesPerson> SalesPersons { get; set; }
         DbSet<SalesTerritory> SalesTerritories { get; set; }
         DbSet<SpecialOffer> SpecialOffers { get; set; }
         DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
         DbSet<Store> Stores { get; set; }
    }
}

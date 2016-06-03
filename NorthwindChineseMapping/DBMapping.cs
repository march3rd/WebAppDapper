using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindChineseMapping
{

    // mapping table name: Categorie
    public class Categorie
    {
        // [ColumnMappingAttribute("CategoryID")]                        
        public Int32 CategoryID { get; set; }

        // [ColumnMappingAttribute("CategoryName")]                        
        public String CategoryName { get; set; }

        // [ColumnMappingAttribute("Description")]                        
        public String Description { get; set; }

        // [ColumnMappingAttribute("Picture")]                        
        public Byte[] Picture { get; set; }

    }

    // mapping table name: Customer
    public class Customer
    {
        // [ColumnMappingAttribute("CustomerID")]                        
        public String CustomerID { get; set; }

        // [ColumnMappingAttribute("CompanyName")]                        
        public String CompanyName { get; set; }

        // [ColumnMappingAttribute("ContactName")]                        
        public String ContactName { get; set; }

        // [ColumnMappingAttribute("ContactTitle")]                        
        public String ContactTitle { get; set; }

        // [ColumnMappingAttribute("Address")]                        
        public String Address { get; set; }

        // [ColumnMappingAttribute("City")]                        
        public String City { get; set; }

        // [ColumnMappingAttribute("Region")]                        
        public String Region { get; set; }

        // [ColumnMappingAttribute("PostalCode")]                        
        public String PostalCode { get; set; }

        // [ColumnMappingAttribute("Country")]                        
        public String Country { get; set; }

        // [ColumnMappingAttribute("Phone")]                        
        public String Phone { get; set; }

        // [ColumnMappingAttribute("Fax")]                        
        public String Fax { get; set; }

    }

    // mapping table name: Employee
    public class Employee
    {
        // [ColumnMappingAttribute("EmployeeID")]                        
        public Int32 EmployeeID { get; set; }

        // [ColumnMappingAttribute("EmployeeName")]                        
        public String EmployeeName { get; set; }

        // [ColumnMappingAttribute("Title")]                        
        public String Title { get; set; }

        // [ColumnMappingAttribute("TitleOfCourtesy")]                        
        public String TitleOfCourtesy { get; set; }

        // [ColumnMappingAttribute("BirthDate")]                        
        public DateTime BirthDate { get; set; }

        // [ColumnMappingAttribute("HireDate")]                        
        public DateTime HireDate { get; set; }

        // [ColumnMappingAttribute("Address")]                        
        public String Address { get; set; }

        // [ColumnMappingAttribute("HomePhone")]                        
        public String HomePhone { get; set; }

        // [ColumnMappingAttribute("Extension")]                        
        public String Extension { get; set; }

        // [ColumnMappingAttribute("PhotoPath")]                        
        public String PhotoPath { get; set; }

        // [ColumnMappingAttribute("Notes")]                        
        public String Notes { get; set; }

        // [ColumnMappingAttribute("ManagerID")]                        
        public Int32 ManagerID { get; set; }

        // [ColumnMappingAttribute("Salary")]                        
        public Int32 Salary { get; set; }

    }

    // mapping table name: ysdiagram
    public class ysdiagram
    {
        // [ColumnMappingAttribute("name")]                        
        public String name { get; set; }

        // [ColumnMappingAttribute("principal_id")]                        
        public Int32 principal_id { get; set; }

        // [ColumnMappingAttribute("diagram_id")]                        
        public Int32 diagram_id { get; set; }

        // [ColumnMappingAttribute("version")]                        
        public Int32 version { get; set; }

        // [ColumnMappingAttribute("definition")]                        
        public Byte[] definition { get; set; }

    }

    // mapping table name: OrderDetail
    public class OrderDetail
    {
        // [ColumnMappingAttribute("OrderID")]                        
        public Int32 OrderID { get; set; }

        // [ColumnMappingAttribute("ProductID")]                        
        public Int32 ProductID { get; set; }

        // [ColumnMappingAttribute("UnitPrice")]                        
        public Decimal UnitPrice { get; set; }

        // [ColumnMappingAttribute("Quantity")]                        
        public Int16 Quantity { get; set; }

        // [ColumnMappingAttribute("Discount")]                        
        public Single Discount { get; set; }

    }

    // mapping table name: Product
    public class Product
    {
        // [ColumnMappingAttribute("ProductID")]                        
        public Int32 ProductID { get; set; }

        // [ColumnMappingAttribute("ProductName")]                        
        public String ProductName { get; set; }

        // [ColumnMappingAttribute("SupplierID")]                        
        public Int32 SupplierID { get; set; }

        // [ColumnMappingAttribute("CategoryID")]                        
        public Int32 CategoryID { get; set; }

        // [ColumnMappingAttribute("QuantityPerUnit")]                        
        public String QuantityPerUnit { get; set; }

        // [ColumnMappingAttribute("UnitPrice")]                        
        public Decimal UnitPrice { get; set; }

        // [ColumnMappingAttribute("UnitsInStock")]                        
        public Int16 UnitsInStock { get; set; }

        // [ColumnMappingAttribute("UnitsOnOrder")]                        
        public Int16 UnitsOnOrder { get; set; }

        // [ColumnMappingAttribute("ReorderLevel")]                        
        public Int16 ReorderLevel { get; set; }

        // [ColumnMappingAttribute("Discontinued")]                        
        public Boolean Discontinued { get; set; }

    }

    // mapping table name: Supplier
    public class Supplier
    {
        // [ColumnMappingAttribute("SupplierID")]                        
        public Int32 SupplierID { get; set; }

        // [ColumnMappingAttribute("CompanyName")]                        
        public String CompanyName { get; set; }

        // [ColumnMappingAttribute("ContactName")]                        
        public String ContactName { get; set; }

        // [ColumnMappingAttribute("ContactTitle")]                        
        public String ContactTitle { get; set; }

        // [ColumnMappingAttribute("Address")]                        
        public String Address { get; set; }

        // [ColumnMappingAttribute("City")]                        
        public String City { get; set; }

        // [ColumnMappingAttribute("Region")]                        
        public String Region { get; set; }

        // [ColumnMappingAttribute("PostalCode")]                        
        public String PostalCode { get; set; }

        // [ColumnMappingAttribute("Country")]                        
        public String Country { get; set; }

        // [ColumnMappingAttribute("Phone")]                        
        public String Phone { get; set; }

        // [ColumnMappingAttribute("Fax")]                        
        public String Fax { get; set; }

        // [ColumnMappingAttribute("HomePage")]                        
        public String HomePage { get; set; }

    }

    // mapping table name: Order
    public class Order
    {
        // [ColumnMappingAttribute("OrderID")]                        
        public Int32 OrderID { get; set; }

        // [ColumnMappingAttribute("CustomerID")]                        
        public String CustomerID { get; set; }

        // [ColumnMappingAttribute("EmployeeID")]                        
        public Int32 EmployeeID { get; set; }

        // [ColumnMappingAttribute("OrderDate")]                        
        public DateTime OrderDate { get; set; }

        // [ColumnMappingAttribute("RequiredDate")]                        
        public DateTime RequiredDate { get; set; }

        // [ColumnMappingAttribute("ShippedDate")]                        
        public DateTime ShippedDate { get; set; }

        // [ColumnMappingAttribute("ShipVia")]                        
        public Int32 ShipVia { get; set; }

        // [ColumnMappingAttribute("Freight")]                        
        public Decimal Freight { get; set; }

        // [ColumnMappingAttribute("ShipName")]                        
        public String ShipName { get; set; }

        // [ColumnMappingAttribute("ShipAddress")]                        
        public String ShipAddress { get; set; }

        // [ColumnMappingAttribute("ShipCity")]                        
        public String ShipCity { get; set; }

        // [ColumnMappingAttribute("ShipRegion")]                        
        public String ShipRegion { get; set; }

        // [ColumnMappingAttribute("ShipPostalCode")]                        
        public String ShipPostalCode { get; set; }

        // [ColumnMappingAttribute("ShipCountry")]                        
        public String ShipCountry { get; set; }

    }

    // mapping table name: Shipper
    public class Shipper
    {
        // [ColumnMappingAttribute("ShipperID")]                        
        public Int32 ShipperID { get; set; }

        // [ColumnMappingAttribute("CompanyName")]                        
        public String CompanyName { get; set; }

        // [ColumnMappingAttribute("Phone")]                        
        public String Phone { get; set; }

    }





}

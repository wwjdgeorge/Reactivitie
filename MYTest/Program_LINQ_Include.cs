//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System; 
//using System.Linq;
//using System.Collections.Generic;

//namespace MYTest
//{

//    public class Program_LINQ_Include
//    {
//        public static void Main()
//        {
//            // to inserting the data
//            Inserting_Data();
//            using (var context = new EntityContext())
//            {
//                var customers = context.Customers
//                .Include(i => i.Invoices.Select(it => it.Items))
//                .ToList();
//                Displaying_Data(customers);
//            }
//        }
//        public static void Inserting_Data()
//        {
//            using (var context = new EntityContext())
//            {
//                context.BulkInsert(CustomerData());
//                context.BulkInsert(InvoiceData());
//                context.BulkInsert(ItemData());
//            }
//        }
//        public static List<Customer> CustomerData()
//        {
//            List<Customer> list = new List<Customer>()
//{
//new Customer() { Name ="Peter"},
//new Customer() { Name ="Smith"},
//new Customer() { Name ="James"}
//};
//            return list;
//        }
//        public static List<Invoice> InvoiceData()
//        {
//            List<Invoice> list = new List<Invoice>()
//{
//new Invoice() { Date = new DateTime(2020,5,3), CustomerID = 1},
//new Invoice() { Date = DateTime.Now.AddDays(-5), CustomerID = 1},
//new Invoice() { Date = DateTime.Now.AddDays(-3), CustomerID = 1},
//new Invoice() { Date = new DateTime(2020,4,15), CustomerID = 2},
//new Invoice() { Date = new DateTime(2020,2,20), CustomerID = 3},
//new Invoice() { Date = new DateTime(2020,5,22), CustomerID = 3},
//};
//            return list;
//        }
//        public static List<Item> ItemData()
//        {
//            List<Item> list = new List<Item>()
//{
//new Item() { Name = "Mobile-Charger", InvoiceID = 1},
//new Item() { Name = "Laptop-DELL", InvoiceID = 1},
//new Item() { Name = "Stationeries", InvoiceID = 1},
//new Item() { Name = "Note-Books", InvoiceID = 2},
//new Item() { Name = "DataCard", InvoiceID = 2},
//new Item() { Name = "PenDrive", InvoiceID = 3},
//new Item() { Name = "Water-Bottles", InvoiceID = 3},
//new Item() { Name = "Stationeries", InvoiceID = 3},
//new Item() { Name = "DataCard", InvoiceID = 4},
//new Item() { Name = "School-Bags", InvoiceID = 4},
//new Item() { Name = "Table-Chairs", InvoiceID = 4},
//new Item() { Name = "Lap-Table", InvoiceID = 4},
//new Item() { Name = "Mobile-Charger", InvoiceID = 5},
//new Item() { Name = "School-Bags", InvoiceID = 5},
//new Item() { Name = "Stationeries", InvoiceID = 6},
//new Item() { Name = "Laptop-DELL", InvoiceID = 6},
//new Item() { Name = "Loptop-Cover", InvoiceID = 6},
//new Item() { Name = "PenDrive", InvoiceID = 6},
//new Item() { Name = "Memory-Card", InvoiceID = 6},
//new Item() { Name = "Mobile-Charger", InvoiceID = 6},
//new Item() { Name = "School-Bags", InvoiceID = 6},
//new Item() { Name = "Touch-Pad", InvoiceID = 6},
//};
//            return list;
//        }
//        public static void Displaying_Data(List<Customer> list)
//        {
//            foreach (var customer in list)
//            {
//                Console.WriteLine(customer.Name);
//                foreach (var invoice in customer.Invoices)
//                {
//                    Console.WriteLine("\t" + invoice.Date);
//                    foreach (var item in invoice.Items)
//                    {
//                        Console.WriteLine("\t\t" + item.Name);
//                    }
//                }
//            }
//            Console.WriteLine("\t\t");
//        }
//    }
/*
using System.ComponentModel.DataAnnotations;

class DataStore<T> where T : struct
{
    public T Data { get; set; }
    IDictionary<int, string> numberNames = new Dictionary<int, string>();
    numberNames.Add(1,"One"); //adding a key/value using the Add() method
numberNames.Add(2,"Two");
numberNames.Add(3,"Three");
}

class DataStore<T> where T : IEnumerable
{
    public T Data { get; set; }
}
public class Fluent_BookAuthorMap
{
    [Key]
    public int Book_Id { get; set; }
    public int Author_Id { get; set; }

    public Fluent_Book Book { get; set; }
    public Fluent_Author Author { get; set; }
}

public class Fluent_Book
{
    [Key]
    public int BookId { get; set; }
    public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
}

public class Fluent_Author
{
    [Key]
    public int Author_Id { get; set; }

    public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
}
*/
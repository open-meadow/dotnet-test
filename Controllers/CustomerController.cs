using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
        {
            List<Customers> mylist = new List<Customers>();

            mylist.Add(new Customers() { Customers_Id = 1, Customers_Name = "Peter", Customers_Balance = 6200 });
            mylist.Add(new Customers() { Customers_Id = 2, Customers_Name = "Helen", Customers_Balance = 5400 });
            mylist.Add(new Customers() { Customers_Id = 3, Customers_Name = "John", Customers_Balance = 3400 });
            mylist.Add(new Customers() { Customers_Id = 4, Customers_Name = "Rmesh", Customers_Balance = 7500 });
            mylist.Add(new Customers() { Customers_Id = 5, Customers_Name = "Gomez", Customers_Balance = 8000 });
            mylist.Add(new Customers() { Customers_Id = 6, Customers_Name = "Sheila", Customers_Balance = 12000 });


            var myvalue = from c in mylist
                          where c.Customers_Id >= 3 
                          select c;


            return View(myvalue);
        }
}
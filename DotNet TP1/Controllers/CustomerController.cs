using DotNet_TP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_TP1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Details(int id)
        {
            List<Customer> customers = new List<Customer>(){
                new Customer{Id=0,Name="John"},
                new Customer{Id=1, Name="Alex"},
            };
            Customer customer = customers.Find(c => c.Id == id);
            return Content("id : " + id + "\tname: " + customer?.Name);
        }
    }
}

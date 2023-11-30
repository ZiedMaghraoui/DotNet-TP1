using DotNet_TP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_TP1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationdbContext _db;
        public CustomerController(ApplicationdbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var customers = _db.customers.ToList();
            return View(customers);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            _db.customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _db.customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            _db.customers.Update(customer);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Customer customer)
        {
            _db.customers.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

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

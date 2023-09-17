using _01.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NorthwindDbContext _context;

        public EmployeeController(NorthwindDbContext context)
        {
            _context = context;
        }
        public IActionResult Employee()
        {
            return View("AddEmployee");
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("AddEmployee");
        }
    }
}

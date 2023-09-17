using _01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Diagnostics;

namespace _01.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindDbContext _context;

        public HomeController(NorthwindDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employess = _context.Employees.ToList();
            return View(employess);
        }
        
        public IActionResult Order(int id)
        {
            List<Order> orders = _context.Orders.Where(a=> a.EmployeeId == id).ToList();
            return View("Order",orders);
        }

    }
}
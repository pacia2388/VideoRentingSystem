using System.Linq;
using System.Web.Mvc;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }

        //        private List<Customer> GetCustomers()
        //        {
        //            return new List<Customer>()
        //            {
        //                new Customer { Id = 1, Name = "John Smith"},
        //                new Customer {Id = 2, Name = "Mary Williams"}
        //            };
        //        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}
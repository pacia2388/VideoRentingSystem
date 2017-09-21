using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VideoRentingSystem.Models;
using VideoRentingSystem.ViewModels;

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
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
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
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewmodel = new NewCustomerViewModel
            {
                MembershipTypes = membershipType
            };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
    }
}
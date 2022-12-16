using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagment.Controllers
{
    public class AdminUser : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        Context _context;

        public AdminUser(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = um.GetList();
            return View(values);
        }

        public async Task<IActionResult> Details(int id)
        {
            var values = um.TGetById(id);
            return View(values);
        }
        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UserId,FirstName,LastName,Email,Password,TCNo,Phone,ImageURL,CarsPlate,ApartmentOwner,IsDelete,ApartmentId")] User user)
        {
            um.TAdd(user);
            _context.Add(user);
            _context.SaveChanges();
            return View(user);
        }
    }
}

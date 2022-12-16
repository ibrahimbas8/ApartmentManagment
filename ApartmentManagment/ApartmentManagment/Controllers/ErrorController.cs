using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagment.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public IActionResult Error(int code)
        {
            return View();
        }
    }
}

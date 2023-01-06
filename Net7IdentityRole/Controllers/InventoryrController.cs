using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Net7IdentityRole.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InventoryController1 : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia.BLL.ModelVM;
using SocialMedia.BLL.Service.Abstraction;
using SocialMedia.BLL.Service.Implement;
using SocialMedia.DAL.DB;
using SocialMedia.DAL.Entities;

namespace SocialMedia.PLL.Controllers
{
    public class UserController : Controller
    {
        IUserService userService = new UserService();

        public IActionResult Index()
        {
           
            return View(userService.GetUsers());
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateUserVM user)
        {
            if (ModelState.IsValid)
            {
                userService.Create(user);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (ModelState.IsValid)
            {
                var result = userService.GetUserById(id);
                return View(result);          
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateUserVM user)
        {
            if (ModelState.IsValid)
            {
                var result = userService.GetUserById(user.ID);

                userService.Update(user);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

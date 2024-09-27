using Microsoft.AspNetCore.Mvc;
using SocialMedia.BLL.ModelVM;
using SocialMedia.BLL.Service.Abstraction;
using SocialMedia.BLL.Service.Implement;

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
                var userViewModel = new UpdateUserVM
                {
                    Name = result.Name,
                    Age = result.Age,
                    Email = result.Email,
                    Password = result.Password,
                };
                return View(userViewModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateUserVM user)
        {
            if (ModelState.IsValid)
            {
                userService.Update(user);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var person = userService.GetUserById(id);

            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            userService.Delete(id);
            return RedirectToAction(nameof(Index)); // Redirect to the index or listing view
        }

    }
}

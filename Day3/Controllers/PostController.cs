using Microsoft.AspNetCore.Mvc;
using SocialMedia.BLL.ModelVM;
using SocialMedia.BLL.Service.Abstraction;
using SocialMedia.BLL.Service.Implement;

namespace SocialMedia.PLL.Controllers
{
    public class PostController : Controller
    {
        IPostService postService = new PostService();
        //                                                                   Index
        public IActionResult Index()
        {

            return View(postService.GetPosts());
        }
        //                                                                Create Method
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePostVM post)
        {
            if (ModelState.IsValid)
            {
                postService.Create(post);
                return RedirectToAction("Index");
            }
            return View();
        }
        //                                                               Update Method
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (ModelState.IsValid)
            {
                var result = postService.GetPostById(id);
                var userViewModel = new UpdatePostVM
                {
                    Title = result.Title,
                    Description = result.Description,

                };
                return View(userViewModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdatePostVM post)
        {
            if (ModelState.IsValid)
            {
                postService.Update(post);
                return RedirectToAction("Index");
            }
            return View();
        }
        //                                                               Delete Method
        public IActionResult Delete(int id)
        {
            var person = postService.GetPostById(id);

            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            postService.Delete(id);
            return RedirectToAction(nameof(Index)); // Redirect to the index or listing v
        }

    }
}

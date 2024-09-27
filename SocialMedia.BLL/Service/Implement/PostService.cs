using SocialMedia.BLL.ModelVM;
using SocialMedia.BLL.Service.Abstraction;
using SocialMedia.DAL.Entities;
using SocialMedia.DAL.Repo.Abstraction;
using SocialMedia.DAL.Repo.Implement;

namespace SocialMedia.BLL.Service.Implement
{
    public class PostService : IPostService
    {
        IPostRepo Service = new PostRepo();
        public bool Create(CreatePostVM post)
        {
            try
            {
                Post posts = new Post()
                {
                    ID = post.ID,
                    Title = post.Title,
                    Description = post.Description,
                };
                return Service.Create(posts);
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete(int id)
        {

            try
            {
                return Service.Delete(id);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Post GetPostById(int id) => Service.GetPostById(id);

        public List<GetAllPostsVM> GetPosts()
        {
            List<GetAllPostsVM> getAllPostVMs = new List<GetAllPostsVM>();
            var result = Service.GetPosts();
            foreach (var item in result)
            {
                getAllPostVMs.Add(new GetAllPostsVM()
                {
                    Title = item.Title,
                    Description = item.Description,
                });

            }

            return getAllPostVMs;
        }

        public bool Update(UpdatePostVM post)
        {
            try
            {
                Post posts = new Post();
                var existing = Service.GetPostById(post.ID);
                existing.Title = post.Title;
                existing.Description = post.Description;

                return Service.Update(existing);
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}

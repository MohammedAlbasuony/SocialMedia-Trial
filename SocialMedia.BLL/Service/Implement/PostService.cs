using SocialMedia.DAL.Entities;
using SocialMedia.DAL.Repo.Abstraction;
using SocialMedia.DAL.Repo.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BLL.Service.Implement
{
    public class PostService
    {
        IPostRepo Service = new PostRepo();
        public bool Create(Post post)
        {
            try
            {
                return Service.Create(post);
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

        public List<Post> GetPosts() => Service.GetPosts();


        public bool Update(Post post)
        {
            try
            {
                return Service.Update(post);

                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

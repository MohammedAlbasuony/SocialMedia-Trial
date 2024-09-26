using SocialMedia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.Repo.Abstraction
{
    public interface IPostRepo
    {
        List<Post> GetPosts();
        Post GetPostById(int id);
        bool Create(Post post);
        bool Update(Post post);
        bool Delete(int id);

    }
}

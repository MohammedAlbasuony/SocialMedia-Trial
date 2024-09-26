
using SocialMedia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BLL.Service.Abstraction
{
    public interface IPostService
    {
        List<Post> GetPosts();
        Post GetPostById(int id);
        bool Create(Post post);
        bool Update(Post post);
        bool Delete(int id);

    }
}

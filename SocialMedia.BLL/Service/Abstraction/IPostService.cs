
using SocialMedia.BLL.ModelVM;
using SocialMedia.DAL.Entities;

namespace SocialMedia.BLL.Service.Abstraction
{
    public interface IPostService
    {

        bool Create(CreatePostVM post);
        bool Delete(int id);
        Post GetPostById(int id);
        List<GetAllPostsVM> GetPosts();
        bool Update(UpdatePostVM post);


    }
}

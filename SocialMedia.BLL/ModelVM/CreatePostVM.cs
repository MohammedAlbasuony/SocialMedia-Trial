using System.ComponentModel.DataAnnotations;

namespace SocialMedia.BLL.ModelVM
{
    public class CreatePostVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter The Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter The Description")]
        public string Description { get; set; }
    }
}

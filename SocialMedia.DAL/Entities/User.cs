using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.Entities
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public List<Post>? Posts { get; set; }

    }
}

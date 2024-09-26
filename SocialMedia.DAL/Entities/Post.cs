using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.Entities
{
    public class Post
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter The Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter The Description")]
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        [ForeignKey("User")]
        public int? UserID { get; set; }

        public User? User { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BLL.ModelVM
{
    public class UpdatePostVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter The Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter The Description")]
        public string Description { get; set; }
    }
}

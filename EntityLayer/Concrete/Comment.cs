using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int commentId { get; set; }
        public string? commentUser { get; set; }
        public DateTime commentDate { get; set; }
        public string commentContent { get; set; }
        public bool commentState { get; set; }
        public int destinationId { get; set; }
        public Destination Destination { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

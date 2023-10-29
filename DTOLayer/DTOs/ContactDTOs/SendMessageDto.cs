using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.ContactDTOs
{
    public class SendMessageDto
    {
        public string? name { get; set; }
        public string? email { get; set; }
        public string? subject { get; set; }
        public string? messageBody { get; set; }
        public DateTime messageDate { get; set; }
        public bool messageStatus { get; set; }
    }
}

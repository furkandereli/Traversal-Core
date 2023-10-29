using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppUserDTOs
{
    public class AppUserRegisterDTOs
    {
        public string? name { get; set; }

        public string? surname { get; set; }

        public string? username { get; set; }

        public string? email { get; set; }

        public string? password { get; set; }

        public string? confirmPassword { get; set; }
    }
}

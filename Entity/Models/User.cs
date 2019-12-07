using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class User
    {
        [Key]
        public int maUser { get; set; }

        [DisplayName("Tên người dùng")]
        [Required(ErrorMessage = "Tên người dùng không được để trống")]
        public string tenUser { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Users
{
    class User:BaseEntity
    {
        [MaxLength(50)]
        public string UserName { get; set; }
        [MinLength(6)]
        [MaxLength(50)]
        public string Password { get; set; }
        public string Avatar { get; set; }
    }
}

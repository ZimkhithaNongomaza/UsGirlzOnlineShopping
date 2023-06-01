using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping2.Models
{
    public class USLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }

    }
}

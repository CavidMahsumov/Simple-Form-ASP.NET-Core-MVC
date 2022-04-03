using FormASP.NET_Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormASP.NET_Core.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IFormFile File { get; set; }

    }
}

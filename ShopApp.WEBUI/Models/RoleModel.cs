using Microsoft.AspNetCore.Identity;
using ShopApp.WEBUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class RoleModel
    {
        public string Name { get; set; }
    }
    public class RoleDetail
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User> Member { get; set; }
        public IEnumerable<User> Nonmember { get; set; }
    }
    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}

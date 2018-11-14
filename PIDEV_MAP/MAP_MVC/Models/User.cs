using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MAP_MVC.Models
{
    public class User 
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }
        public string  customertype { get; set; }
        public string category { get; set; }
        public string Senority { get; set; }
        public string bussniesprofile { get; set; }
        public int mark { get; set; }
        public string availbliltyType { get; set; }
        public string sector { get; set; }
        public string applciantType { get; set; }


    }


}
    


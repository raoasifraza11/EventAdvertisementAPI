using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventAdvertisementAPIv1._0.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userrole { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string modified_at { get; set; }
       
    }
}
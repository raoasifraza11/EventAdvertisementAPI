using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventAdvertisementAPIv1._0.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Location { get; set; }
        public string Telephone { get; set; }
        public DateTime DateTime { get; set; }

        // Foreign Key For User
        public int UserId { get; set; }
        // Navigation property
        public User User { get; set; }

        // Foreign Key CategoryID
        public int CategoryId { get; set; }
        // Navigation property
        public Category Category { get; set; }
    }
}
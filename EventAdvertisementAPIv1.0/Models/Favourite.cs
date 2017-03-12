using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventAdvertisementAPIv1._0.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        
        // Foreign Key Event
        public int EventId { get; set; }
        // Navigation property
        public Event Event { get; set; }
        

       
    }
    
}
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventAdvertisementAPIv1._0.Models
{
    public class EventAdvertisementAPIv1_0Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EventAdvertisementAPIv1_0Context() : base("name=EventAdvertisementAPIv1_0Context")
        {
        }

        public System.Data.Entity.DbSet<EventAdvertisementAPIv1._0.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<EventAdvertisementAPIv1._0.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<EventAdvertisementAPIv1._0.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<EventAdvertisementAPIv1._0.Models.Favourite> Favourites { get; set; }
    }
}

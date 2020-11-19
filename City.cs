using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestWebService.Models;

namespace TestWebService
{
    public class City: DbContext
    {

        public City():base("DbConnection")
            {
            
            }

            public DbSet<CityModel> Cities { get; set; }
    }
}
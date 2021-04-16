using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;

namespace WebAPIDemo.Data
{
    public class WebAPIDemoContext : DbContext
    {
        public WebAPIDemoContext (DbContextOptions<WebAPIDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIDemo.Models.TodoItems> TodoItems { get; set; }
    }
}

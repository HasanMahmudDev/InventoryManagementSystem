using IMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Data
{
   
        public class InventoryContext : DbContext //inherit EF core
        {
            // use for database connection string, conntectio string, service life, contaxt life time  etc. base(options)
            public InventoryContext(DbContextOptions options) : base(options)
            {

            }
            public virtual DbSet<Unit> Units { get; set; }
        }
    }


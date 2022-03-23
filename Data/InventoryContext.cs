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
            // ডেটাবেস কানেকশন স্ট্রিং পাস করার জন্য ব্যবহার করা হয়। DbContextOptions options
            public InventoryContext(DbContextOptions options) : base(options)
            {

            }
            //DbSet এর প্রোপারটি হিসেবে ডাটাবেস মডেল পাস করা হয়।
            public virtual DbSet<Unit> Units { get; set; }
        }
    }


﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSystem_InnerTrader.Entities.DbSet;

namespace UserSystem_InnerTrader.DataService.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public virtual DbSet<User> Users { get; set; }


       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}

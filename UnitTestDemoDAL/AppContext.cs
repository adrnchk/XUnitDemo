﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemoDAL
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}

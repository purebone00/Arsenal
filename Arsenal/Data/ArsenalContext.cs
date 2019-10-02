﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arsenal.Models;
using Arsenal.Models.ArsenalDataModels;

namespace Arsenal.Data
{
    public class ArsenalContext : DbContext
    {
        public ArsenalContext (DbContextOptions<ArsenalContext> options) : base(options)
        {

        }

        public DbSet<Transaction> Transaction { get; set; }
    }
}

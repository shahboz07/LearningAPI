﻿using LearningAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LearningAPI.DataLayer
{
    public class DataContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
    }
}
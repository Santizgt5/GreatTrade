using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GreatTradePreguntas.Models;

namespace GreatTradePreguntas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GreatTradePreguntas.Models.Product> Product { get; set; }
        public DbSet<GreatTradePreguntas.Models.Question> Question { get; set; }
    }
}

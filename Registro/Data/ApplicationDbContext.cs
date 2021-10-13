using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Registro.Models;

namespace Registro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Productos> Productos { get; set; }
        
       public ApplicationDbContext(DbContextOptions dco) : base(dco) {

        }
    }
}
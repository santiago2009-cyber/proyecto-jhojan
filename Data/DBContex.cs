using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_santiago.Models;

namespace proyecto_santiago.Data
{
    public class DBContex: DbContext
    {
        public DBContex(DbContextOptions<DBContex> options) : base(options)
        {

        }
        
        public DbSet<usuarioModel1> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel1>().HasKey(U => U.UserId);
            modelBuilder.Entity<usuarioModel1>().Property(U => U.UserId).ValueGeneratedOnAdd();
        }
    }
}
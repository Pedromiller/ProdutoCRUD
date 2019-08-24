using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProdutoWebApp.Models;

namespace ProdutoWebApp.Models
{

    public class ProdutoContext : DbContext
    {
        public ProdutoContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("Server=mysql;Port=3306;Database=produtodb;Uid=root;Pwd=123456;");
        }

        public DbSet<ProdutoWebApp.Models.Produtos> Produtos_1 { get; set; }
    }
}

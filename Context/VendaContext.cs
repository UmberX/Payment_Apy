using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payment_API.Models;


namespace Payment_API.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext>options) : base(options)
        {

        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
   
    }
}
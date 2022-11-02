using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace apiContatos.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CARAIDEASA\\MSSQLSERVER05")
        { }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
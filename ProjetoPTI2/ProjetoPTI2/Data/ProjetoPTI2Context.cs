using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoPTI2.Models;

namespace ProjetoPTI2.Data
{
    public class ProjetoPTI2Context : DbContext
    {
        public ProjetoPTI2Context (DbContextOptions<ProjetoPTI2Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoPTI2.Models.CadastroCliente> CadastroCliente { get; set; }

        public DbSet<ProjetoPTI2.Models.CadastroFuncionario> CadastroFuncionario { get; set; }
    }
}

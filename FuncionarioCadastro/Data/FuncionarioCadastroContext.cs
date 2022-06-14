using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FuncionarioCadastro.Models;

    public class FuncionarioCadastroContext : DbContext
    {
        public FuncionarioCadastroContext (DbContextOptions<FuncionarioCadastroContext> options)
            : base(options)
        {
        }

        public DbSet<FuncionarioCadastro.Models.Funcionario>? Funcionario { get; set; }
    }

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.Contexts
{
    public class PgContext : DbContext
    {
        public PgContext()
        {

        }
        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {
        }

        #region DBSETS
        //public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Paciente> Pacientes { get; set; }
        //public DbSet<Procedimento> Procedimentos { get; set; }
        //public DbSet<Profissional> Profissionais { get; set; }
        //public DbSet<Administrador> Administradores { get; set; }
        //public DbSet<Enfermeiro> Enfermeiros { get; set; }

        //public DbSet<Cirurgia> Cirurgias { get; set; }
        //public DbSet<Consulta> Consultas { get; set; }
        //public DbSet<Exame> Exames { get; set; }

        //public DbSet<HistoricoPaciente> HistoricoPacientes { get; set; }
        //public DbSet<HistoricoProfissional> HistoricoProfissionais { get; set; }

        //public DbSet<Endereco> Enderecos { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"Host=db-andersonsantos.cbnpdhcj1uib.us-east-1.rds.amazonaws.com;Database=VisualizadorClinico;Username=andersonSantos;Password=150492ams");
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

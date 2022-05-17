using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Data.Contexts;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Entities;
using VisualizadorClinico.Infra.Entities.Relations;

namespace VisualizadorClinico.Infra.Data.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly PgContext _context;
        public ConsultaRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Consulta Add(Consulta obj, int id_profissional, int id_paciente)
        {
            try
            {
                var consulta = _context.Set<Consulta>().Add(obj);
                _context.SaveChanges();

                var profissionalConsulta = new ProfissionalConsulta
                {
                    id_consulta = consulta.Entity.id_consulta,
                    id_profissional = id_profissional,
                };
                _context.profissionalConsultas.Add(profissionalConsulta);

                HistoricoProfissional historico = new HistoricoProfissional
                {
                    id_profissional = id_profissional,
                    data_hora = obj.data_hora,
                    id_paciente = id_paciente,
                    codigo = obj.codigo,
                    diagnostico = obj.diagnostico,
                    tipo_procedimento = "Consulta"
                };
                _context.HistoricoProfissionais.Add(historico);
                _context.SaveChanges(true);

                HistoricoPaciente historicoPaciente = new HistoricoPaciente
                {
                    id_paciente = id_paciente,
                    id_profissional = id_profissional,
                    codigo = obj.codigo,
                    tipo_procedimento = "Consulta",
                    data_hora = obj.data_hora,
                    diagnostico = obj.diagnostico
                };
                _context.HistoricoPacientes.Add(historicoPaciente);
                _context.SaveChanges(true);

                return consulta.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Consulta GetById(int id)
        {
            try
            {
                var entity = _context.Set<Consulta>().Find(id);

                if (entity == null)
                    return null;
                else
                    return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<Consulta> GetAll()
        {
            try
            {
                var list = _context.Set<Consulta>().ToList();

                if (list == null)
                    return null;
                else
                    return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(Consulta obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Consultas.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Consulta obj)
        {
            try
            {
                _context.Set<Consulta>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }
    }
}
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
    public class ExameRepository : IExameRepository
    {
        private readonly PgContext _context;
        public ExameRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Exame Add(Exame obj)
        {
            try
            {
                var exame = _context.Set<Exame>().Add(obj);
                _context.SaveChanges();

                if(exame == null)
                    return null;

                return exame.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual Exame AddRealized(Exame obj, int id_profissional, int id_paciente)
        {
            try
            {
                var exame = _context.Set<Exame>().Add(obj);
                _context.SaveChanges();

                var profissionalExame = new ProfissionalExame
                {
                    id_exame = exame.Entity.id_exame,
                    id_profissional = id_profissional,
                };
                _context.profissionalExames.Add(profissionalExame);

                HistoricoProfissional historico = new HistoricoProfissional
                {
                    id_profissional = id_profissional,
                    data_hora = obj.data_hora,
                    id_paciente = id_paciente,
                    codigo = obj.codigo,
                    diagnostico = obj.diagnostico,
                    tipo_procedimento = "Exame"
                };
                _context.HistoricoProfissionais.Add(historico);
                _context.SaveChanges(true);

                HistoricoPaciente historicoPaciente = new HistoricoPaciente
                {
                    id_paciente = id_paciente,
                    id_profissional = id_profissional,
                    codigo = obj.codigo,
                    tipo_procedimento = "Exame",
                    data_hora = obj.data_hora,
                    diagnostico = obj.diagnostico
                };
                _context.HistoricoPacientes.Add(historicoPaciente);
                _context.SaveChanges(true);

                return exame.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Exame GetById(int id)
        {
            try
            {
                var entity = _context.Set<Exame>().Find(id);

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

        public virtual IEnumerable<Exame> GetAll()
        {
            try
            {
                var list = _context.Set<Exame>().ToList();

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

        public virtual void Update(Exame obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Exame obj)
        {
            try
            {
                _context.Set<Exame>().Remove(obj);
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
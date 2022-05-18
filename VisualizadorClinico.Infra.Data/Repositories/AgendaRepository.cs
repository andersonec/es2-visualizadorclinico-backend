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
    public class AgendaRepository : IAgendaRepository
    {
        private readonly PgContext _context;
        public AgendaRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Agenda Add(Agenda obj, int id_profissional)
        {
            try
            {
                obj.id_agenda = 0;
                var newAgenda = _context.Set<Agenda>().Add(obj);
                _context.SaveChanges();

                var pAgenda = new ProfissionalAgenda
                {
                    id_agenda = newAgenda.Entity.id_agenda,
                    id_profissional = id_profissional,
                };

                _context.ProfissionalAgendas.Add(pAgenda);
                _context.SaveChanges();

                return newAgenda.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Agenda GetById(int id)
        {
            try
            {
                var entity = _context.Agendas.Where(b => b.id_agenda == id).FirstOrDefault();

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

        public virtual IEnumerable<Agenda> GetAll(int id)
        {
            try
            {
                var listaAgendas = _context.ProfissionalAgendas.Where(b => b.id_profissional == id).ToList();

                var lista = new List<Agenda>();

                for(int i = 0; i < listaAgendas.Count; i++)
                {
                    var agenda = _context.Agendas.Where(p => p.id_agenda == listaAgendas[i].id_agenda).FirstOrDefault();

                    lista.Add(agenda);
                }

                if (lista == null)
                    return null;
                else
                    return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(Agenda obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Agendas.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Agenda obj)
        {
            try
            {
                _context.Set<Agenda>().Remove(obj);
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

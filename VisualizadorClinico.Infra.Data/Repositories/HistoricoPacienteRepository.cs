using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Data.Contexts;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.Repositories
{
    public class HistoricoPacienteRepository : IHistoricoPacienteRepository
    {
        private readonly PgContext _context;
        public HistoricoPacienteRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual void Add(HistoricoPaciente obj)
        {
            try
            {
                _context.Set<HistoricoPaciente>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual HistoricoPaciente GetById(int id)
        {
            try
            {
                var entity = _context.Set<HistoricoPaciente>().Find(id);

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

        public virtual IEnumerable<HistoricoPaciente> GetAll()
        {
            try
            {
                var list = _context.Set<HistoricoPaciente>().ToList();

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

        public virtual void Update(HistoricoPaciente obj)
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

        public virtual void Remove(HistoricoPaciente obj)
        {
            try
            {
                _context.Set<HistoricoPaciente>().Remove(obj);
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
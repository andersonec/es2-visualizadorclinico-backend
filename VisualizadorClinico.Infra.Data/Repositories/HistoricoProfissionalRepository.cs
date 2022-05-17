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
    public class HistoricoProfissionalRepository : IHistoricoProfissionalRepository
    {
        private readonly PgContext _context;
        public HistoricoProfissionalRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual void Add(HistoricoProfissional obj)
        {
            try
            {
                _context.Set<HistoricoProfissional>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual HistoricoProfissional GetById(int id)
        {
            try
            {
                var entity = _context.Set<HistoricoProfissional>().Find(id);

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

        public virtual IEnumerable<HistoricoProfissional> GetAll(int id_profissional)
        {
            try
            {
                var list = _context.HistoricoProfissionais.Where(b => b.id_profissional == id_profissional).ToList();

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

        public virtual void Update(HistoricoProfissional obj)
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

        public virtual void Remove(HistoricoProfissional obj)
        {
            try
            {
                _context.Set<HistoricoProfissional>().Remove(obj);
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
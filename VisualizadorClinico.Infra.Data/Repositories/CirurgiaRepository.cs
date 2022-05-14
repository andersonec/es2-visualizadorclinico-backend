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
    public class CirurgiaRepository : ICirurgiaRepository
    {
        private readonly PgContext _context;
        public CirurgiaRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual void Add(Cirurgia obj)
        {
            try
            {
                _context.Set<Cirurgia>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Cirurgia GetById(int id)
        {
            try
            {
                var entity = _context.Set<Cirurgia>().Find(id);

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

        public virtual IEnumerable<Cirurgia> GetAll()
        {
            try
            {
                var list = _context.Set<Cirurgia>().ToList();

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

        public virtual void Update(Cirurgia obj)
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

        public virtual void Remove(Cirurgia obj)
        {
            try
            {
                _context.Set<Cirurgia>().Remove(obj);
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
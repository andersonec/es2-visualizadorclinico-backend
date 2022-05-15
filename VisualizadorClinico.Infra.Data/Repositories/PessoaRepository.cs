using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PgContext _context;
        public PessoaRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Pessoa Add(Pessoa obj)
        {
            try
            {
                var pessoa = _context.Set<Pessoa>().Add(obj);
                _context.SaveChanges();

                return pessoa.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Pessoa GetById(int id)
        {
            try
            {
                var entity = _context.Set<Pessoa>().Find(id);

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

        public virtual IEnumerable<Pessoa> GetAll()
        {
            try
            {
                var list = _context.Set<Pessoa>().ToList();

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

        public virtual void Update(Pessoa obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Pessoas.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Pessoa obj)
        {
            try
            {
                _context.Set<Pessoa>().Remove(obj);
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

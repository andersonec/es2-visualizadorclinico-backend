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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PgContext _context;
        public UsuarioRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Usuario Add(Usuario obj)
        {
            try
            {
                var usuario = _context.Set<Usuario>().Add(obj);
                _context.SaveChanges();

                return usuario.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Usuario GetById(int id)
        {
            try
            {
                var entity = _context.Set<Usuario>().Find(id);

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

        public virtual IEnumerable<Usuario> GetAll()
        {
            try
            {
                var list = _context.Set<Usuario>().ToList();

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

        public virtual void Update(Usuario obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Usuarios.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Usuario obj)
        {
            try
            {
                _context.Set<Usuario>().Remove(obj);
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
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
    public class PacienteRepository : IPacienteRepository
    {
        private readonly PgContext _context;
        public PacienteRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Paciente Add(Paciente obj)
        {
            try
            {
                var paciente = _context.Set<Paciente>().Add(obj);
                _context.SaveChanges();

                return paciente.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Paciente GetById(string id)
        {
            try
            {
                var entity = _context.Pacientes.Where(b => b.registro_sus == id).FirstOrDefault();

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

        public virtual IEnumerable<Paciente> GetAll()
        {
            try
            {
                var list = _context.Set<Paciente>().ToList();

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

        public virtual void Update(Paciente obj)
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

        public virtual void Remove(Paciente obj)
        {
            try
            {
                _context.Set<Paciente>().Remove(obj);
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

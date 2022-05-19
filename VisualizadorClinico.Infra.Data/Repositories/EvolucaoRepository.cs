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
    public class EvolucaoRepository : IEvolucaoRepository
    {
        private readonly PgContext _context;
        public EvolucaoRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual EvolucaoPaciente Add(EvolucaoPaciente obj)
        {
            try
            {
                var exame = _context.Set<EvolucaoPaciente>().Add(obj);
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

        public virtual EvolucaoPaciente GetById(int id)
        {
            try
            {
                var entity = _context.EvolucaoPacientes.Where(e => e.id_paciente == id).FirstOrDefault();

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

        public virtual IEnumerable<EvolucaoPaciente> GetAll(int id)
        {
            try
            {
                var list = _context.EvolucaoPacientes.Where(e => e.id_paciente == id).ToList();

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

        public virtual void Update(EvolucaoPaciente obj)
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

        public virtual void Remove(EvolucaoPaciente obj)
        {
            try
            {
                _context.Set<EvolucaoPaciente>().Remove(obj);
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
﻿using Microsoft.EntityFrameworkCore;
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
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly PgContext _context;
        public ProfissionalRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Profissional Add(Profissional obj)
        {
            try
            {
                var newProfessional = _context.Set<Profissional>().Add(obj);
                _context.SaveChanges();

                return newProfessional.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Profissional GetById(string id)
        {
            try
            {
                var entity = _context.Profissionais.Where(b => b.registro_profissional.Equals(id)).FirstOrDefault();

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

        public virtual IEnumerable<Profissional> GetAll()
        {
            try
            {
                var list = _context.Set<Profissional>().ToList();

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

        public virtual void Update(Profissional obj)
        {
            try
            {
                //_context.ChangeTracker.Clear();
                _context.Profissionais.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Profissional obj)
        {
            try
            {
                _context.Set<Profissional>().Remove(obj);
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

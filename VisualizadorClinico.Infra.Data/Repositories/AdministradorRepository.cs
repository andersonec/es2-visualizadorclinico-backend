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
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly PgContext _context;
        public AdministradorRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual void Add(Administrador obj)
        {
            try
            {
                _context.Set<Administrador>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Administrador GetById(int id)
        {
            try
            {
                var entity = _context.Set<Administrador>().Find(id);

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

        public virtual IEnumerable<Administrador> GetAll()
        {
            try
            {
                var list = _context.Set<Administrador>().ToList();

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

        public virtual void Update(Administrador obj)
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

        public virtual void Remove(Administrador obj)
        {
            try
            {
                _context.Set<Administrador>().Remove(obj);
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
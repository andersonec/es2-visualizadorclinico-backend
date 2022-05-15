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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly PgContext _context;
        public EnderecoRepository(PgContext Context)
        {
            _context = Context;
        }

        public virtual Endereco Add(Endereco obj, int id_pessoa)
        {
            try
            {
                var endereco = _context.Set<Endereco>().Add(obj);
                _context.SaveChanges();

                var pessoaEndereco = new PessoaEndereco
                {
                    id_pessoa = id_pessoa,
                    id_endereco = endereco.Entity.id_endereco
                };
                _context.pessoaEnderecos.Add(pessoaEndereco);
                _context.SaveChanges();

                return endereco.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual Endereco GetById(int id)
        {
            try
            {
                var entity = _context.pessoaEnderecos.Where(b => b.id_pessoa == id).FirstOrDefault();

                var endereco = _context.Set<Endereco>().Find(entity.id_endereco);

                if (endereco == null)
                    return null;
                else
                    return endereco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<Endereco> GetAll()
        {
            try
            {
                var list = _context.Set<Endereco>().ToList();

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

        public virtual void Update(Endereco obj)
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

        public virtual void Remove(Endereco obj)
        {
            try
            {
                _context.Set<Endereco>().Remove(obj);
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
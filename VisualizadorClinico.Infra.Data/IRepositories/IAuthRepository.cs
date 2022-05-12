using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Entities;

namespace VisualizadorClinico.Infra.Data.IRepositories
{
    public interface IAuthRepository
    {
        Usuario Validate(string login, string senha);
        Token GenerateToken(Usuario usuario);
    }
}

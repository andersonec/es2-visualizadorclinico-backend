using Microsoft.IdentityModel.Tokens;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizadorClinico.Infra.Data.Contexts;
using VisualizadorClinico.Infra.Data.IRepositories;
using VisualizadorClinico.Infra.Entities;
using System.Security.Claims;

namespace VisualizadorClinico.Infra.Data.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly PgContext _context;
        public AuthRepository(PgContext Context)
        {
            _context = Context;
        }
        public Usuario Validate(string login, string senha)
        {
            var user = _context.Usuarios.Where<Usuario>(u => u.login == login && u.senha == senha).FirstOrDefault();

            if (user == null)
                return null;
            else
                user.senha = "**********";
            return user;

        }

        public Token GenerateToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1f2f322704c8234b0c0645ee73ec5a39"); //
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.login.ToString()),
                    new Claim(ClaimTypes.Role, usuario.tipo.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            Token token = new Token();
            var token_access = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            token.Access = tokenHandler.WriteToken(token_access);
            token.Type = "Bearer";
            token.Expires_in = ((DateTime)tokenDescriptor.Expires).Hour * 60 * 60;
            return token;
        }
    }
}

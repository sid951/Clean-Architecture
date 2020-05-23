using Core.Dto;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Auth
{
    public class JwtFactory : IJwtFactory
    {
        public Task<Token> GenerateEncodedToken(int id, string userName)
        {
            throw new NotImplementedException();
        }
    }
}

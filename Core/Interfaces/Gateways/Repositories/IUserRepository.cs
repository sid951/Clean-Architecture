using Core.Domain.Entity;
using Core.Dto.GatewayResponses.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Gateways.Repositories
{
    public interface IUserRepository
    {
        Task<User> FindByName(string userName);
        Task<bool> CheckPassword(User user, string password);
        public Task<CreateUserResponse> Create(User user);
    }
 }

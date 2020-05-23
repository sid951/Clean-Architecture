using AutoMapper;
using Core.Domain.Entity;
using Core.Interfaces.Gateways.Repositories;
using Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Dapper.Repository
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        //public async Task<CreateUserResponse> Create(User user, string password)
        //{
        //    var appUser = _mapper.Map<AppUser>(user);
        //    var identityResult = await _userManager.CreateAsync(appUser, password);
        //    return new CreateUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        //}

        public async Task<User> FindByName(string userName)
        {
            return _mapper.Map<User>(await _userManager.FindByNameAsync(userName));
        }

        public async Task<bool> CheckPassword(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(_mapper.Map<ApplicationUser>(user), password);
        }
    }
}
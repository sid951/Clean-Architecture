using Core.Domain.Entity;
using Core.Dto;
using Core.Interfaces.Gateways.Repositories;
using Core.Interfaces.UseCase;
using Core.USeCaseRequest;
using Core.USeCaseResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.USeCases
{
    public sealed class RegisterUseCase:IRegisterUseCase
    {
        private readonly IUserRepository _userRepository;

        public RegisterUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(RegisterRequest message, IOutputPort<RegisterResponse> outputPort)
        {
            var response = await _userRepository.Create(new User(message.Name, message.UserName, message.NormalizedUserName, message.Email, message.EmailConfirmed, message.PhoneNumber,
            message.PhoneNumberConfirmed, message.TwoFactorEnabled, message.Id, message.PasswordHash));
            outputPort.Handle(response.Success ? new RegisterResponse(response.UserId, true) : new RegisterResponse(response.Errors.Select(e=>e.Description)));
            return response.Success;
        }

    }
}

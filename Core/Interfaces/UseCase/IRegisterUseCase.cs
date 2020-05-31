using Core.USeCaseRequest;
using Core.USeCaseResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.UseCase
{
    public interface IRegisterUseCase : IUseCaseRequestHandler<RegisterRequest, RegisterResponse>
    {

    }
}

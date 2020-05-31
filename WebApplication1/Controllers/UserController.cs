using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.UseCase;
using Core.USeCaseRequest;
using Core.USeCases;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Presenters;

namespace WebApplication1.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILoginUseCase _loginUseCase;
        private readonly LoginPresenter _loginPresenter;
        private readonly IRegisterUseCase _registerUseCase;
        private readonly RegisterPresenter _registerPresenter;

        public UserController(ILoginUseCase loginUseCase, LoginPresenter loginPresenter,IRegisterUseCase registerUseCase,RegisterPresenter registerPresenter)
        {
            _loginUseCase = loginUseCase;
            _loginPresenter = loginPresenter;
            _registerUseCase = registerUseCase;
            _registerPresenter = registerPresenter;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Models.LoginRequest request)
        {
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return BadRequest(ModelState);
            }
            await _loginUseCase.Handle(new LoginRequest(request.UserName, request.Password), _loginPresenter);
            return _loginPresenter.ContentResult;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Models.RegisterRequest request)
        {
            if (!ModelState.IsValid)
            { 
                return BadRequest(ModelState);
            }
            await _registerUseCase.Handle(new RegisterRequest(request.Name, request.UserName, request.NormalizedUserName, request.Email, request.EmailConfirmed, request.PhoneNumber,
            request.PhoneNumberConfirmed, request.TwoFactorEnabled, request.Id, request.PasswordHash),_registerPresenter);
            return _registerPresenter.ContentResult;
        }
    }
}
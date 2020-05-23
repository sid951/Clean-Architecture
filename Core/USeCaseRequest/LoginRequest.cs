using Core.USeCaseResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.USeCaseRequest
{
    public class LoginRequest : IUseCaseRequest<LoginResponse>
    {
        public string UserName { get; }
        public string Password { get; }

        public LoginRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}

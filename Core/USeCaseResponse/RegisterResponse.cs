using Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.USeCaseResponse
{
    public class RegisterResponse : UseCaseResponseMessage
    {
        public int UserId { get; }
        public IEnumerable<string> Errors { get; }

        public RegisterResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public RegisterResponse(int userid, bool success = false, string message = null) : base(success, message)
        {
            UserId = userid;
        }
    }
}

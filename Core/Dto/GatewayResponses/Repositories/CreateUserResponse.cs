using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.GatewayResponses.Repositories
{
    public sealed class CreateUserResponse:BaseGatewayResponse
    {
        public int UserId { get;}

        public CreateUserResponse(int userid, bool success = false,IEnumerable<Error> errors=null):base(success,errors)
        {
            UserId = userid;
        }
    }

}

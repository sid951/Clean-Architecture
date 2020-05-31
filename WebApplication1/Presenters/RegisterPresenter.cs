using Core;
using Core.USeCaseResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApplication1.Serialization;

namespace WebApplication1.Presenters
{
    public sealed class RegisterPresenter : IOutputPort<RegisterResponse>
    {
        public JsonContentResult ContentResult { get; }

        public RegisterPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(RegisterResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }
    }
}

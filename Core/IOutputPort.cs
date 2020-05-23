using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}

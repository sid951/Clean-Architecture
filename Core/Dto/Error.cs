using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto
{
    public sealed  class Error
    {
        public string ErrorCode { get; }
        public string Description { get; }

        public Error(string errorcode, string description)
        {
            ErrorCode = errorcode;
            Description = description;
        }
    }
}

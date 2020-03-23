using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : AccessViolationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}

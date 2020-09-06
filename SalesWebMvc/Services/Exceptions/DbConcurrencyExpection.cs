using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyExpection : ApplicationException
    {
        public DbConcurrencyExpection(string message) : base(message)
        {
        }
    }
}

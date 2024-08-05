using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criando_excessoes.entidades.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}

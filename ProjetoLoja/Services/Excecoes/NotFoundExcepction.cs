using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLoja.Services.Excecoes
{
    public class NotFoundExcepction : ApplicationException
    {
        public NotFoundExcepction(string message) : base(message)
        {
        }
    }
}

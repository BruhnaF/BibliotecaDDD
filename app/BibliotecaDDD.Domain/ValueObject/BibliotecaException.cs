using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDDD.Domain.ValueObject
{
    public class BibliotecaException : Exception
    {
        public BibliotecaException()
        {

        }

        public BibliotecaException(string menssagem): base(menssagem)
        {

        }
    }
}

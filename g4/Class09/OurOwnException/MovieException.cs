using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurOwnException
{
    class MovieException: ApplicationException
    {

        public MovieException() : base()
        {

        }


        public MovieException(string message) : base(message)
        {

        }

    }
}

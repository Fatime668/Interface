using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Pdf :IPrintable
    {
       
        public string Print()
        {
            return "PDF cap edildi";
        }
    }
}

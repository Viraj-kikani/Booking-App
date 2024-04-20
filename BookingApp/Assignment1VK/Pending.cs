using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VK
{
    internal class Pending
    {
        string pSeats;
        string pCustName;

        public Pending(string nseats, string ncustName)
        {
            pSeats = nseats;
            pCustName = ncustName;
        }
        public string GetPSeats()
        {
            return pSeats;
        }
        public string GetPName()
        {
            return pCustName;
        }
    }
}

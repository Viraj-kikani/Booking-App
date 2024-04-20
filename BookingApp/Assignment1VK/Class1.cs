using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VK
{
    internal class Class1
    {
        string seats;
        string custName;

        public Class1(string nseats, string ncustName)
        {
            seats = nseats;
            custName = ncustName;
        }   
        public string GetSeats()
        {
            return seats;
        }
        public string GetName()
        {
            return custName;
        }
    }
}

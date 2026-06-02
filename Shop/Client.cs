using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class Client
    {
        
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
            
        }

        public decimal Balance
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
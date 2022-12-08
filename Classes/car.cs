using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class car
    {
        public car(string make, string model, int year)
        {
            Make= make;
            Model= model;
            year = year;
        }
        public car()
        {

        }

        public string Make { get; set; }   
        public string Model { get; set; }   
        public string year { get; set; }
    }
}

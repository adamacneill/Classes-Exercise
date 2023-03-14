using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string makeInput, string modelInput, int  YearInput)
        {
            Make = Make;
            Model = Model;
            Year = Year;
        }


        public string Make { get; set; }    
        

        public string Model { get; set; }


        public int Year { get; set; }

    }
}

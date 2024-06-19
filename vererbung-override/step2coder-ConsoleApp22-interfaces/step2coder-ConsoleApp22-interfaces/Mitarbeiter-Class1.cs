using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp22_interfaces
{
    internal class Mitarbeiter_Class1:Interface1_Human
    {

        //attribute name und automatisch mit einem getter und setter
        public string name { get; set; }

        public int alter { get; set; }

        public Mitarbeiter_Class1()
        {

            name    = "sabanovic";

            alter   = 38;
       
        }
        //in der abgeleiteten Klasse muss die methode printData ausimplementiert werden
        public void printData()
        {
            //Console.WriteLine("Name:" + name + "Alter:" + alter);

            Console.WriteLine($"Name: {name}, Alter: {alter}");
        }

        //Ende internal class
    }


    //Ende namespace
}

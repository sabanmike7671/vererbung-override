using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp22_interfaces
{

    /* Define the interface durch Projekt und Neues Element hinzufügen schon erstellt
    public interface Interface1_Human
    {
        void printData();
    }
    */

    internal class Kunde_Class1:Interface1_Human
    {

        //attribute name und automatisch mit einem getter und setter
        public string name { get; set; }

        public int alter { get; set; }

        public string id {get; set; }

        public Kunde_Class1()
        {

            alter   = 38;

            name    = "sabanovic";

            id      = "4257241086";

        }

        //Vererbung durch Ausführung von Attribut in Program.cs ohne virtual override
        //in der abgeleiteten Klasse muss die methode printData ausimplementiert werden
        public void printData()
        {
            Console.WriteLine($"Name: {name}, Alter: {alter}, ID: {id}");


        }

        //Ende internal class
    }
    //Ende namespace
}

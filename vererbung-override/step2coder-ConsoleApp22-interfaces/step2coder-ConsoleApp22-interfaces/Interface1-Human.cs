using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step2coder_ConsoleApp22_interfaces
{
    //interface ist eine grob vorlage 
    //alle attribute und methoden müssen dann in der abgeleitete Klassen implementiert werden

    internal interface Interface1_Human
    {

        //attribute name und automatisch mit einem getter und setter
        public string name { get; set; }

        public int alter { get; set; }


        //in der abgeleiteten Klasse muss die methode printData ausimplementiert werden
        public void printData();



        //Ende internal interface
    }

    //Ende namespace 
}

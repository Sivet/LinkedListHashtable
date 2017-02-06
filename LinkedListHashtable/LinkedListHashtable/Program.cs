using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHashtable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HashTable Table = new HashTable();
            Table.AddToTable("simon");
            Table.AddToTable("jonathan");
            Table.AddToTable("Flaske");
            Table.AddToTable("hunde");

            //Den dør hvis vi forsøger at fjerne noget der står først i listen på en plads.
            //Fix: Tilføj til enden i stedet for fronten, hav et tomt node element i starten, som har pladsen i arrayet.
            Table.RemoveFromTable("jonathan");
            Table.RemoveFromTable("hunde");
        }
       
        
    }
}

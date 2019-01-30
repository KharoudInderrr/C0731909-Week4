using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_project
{
    class Program
    {

        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Launch();

            Console.ReadLine();
        }
    }
    class Village
    {



        // Node is an ADT
        // What kind of data do we need in a node?
        public Village nextVillage;
        public String VillageName;
        public String previousVillage;
        public bool isAstrildeHere = false;


    }
    class Countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;
        Village Temp;


        public void Launch()
        {
             First = Maple;
             Last = Ajax;
             
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = "Maple";
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = "Toronto";

            Console.WriteLine(this.displayMap());


        }

        public string displayMap()
        {
            string listOfCities = "";
            // we need to print all the cities
           
            
                listOfCities = listOfCities + First.VillageName;
                Temp = First.nextVillage;
                listOfCities = listOfCities + Temp.VillageName;
            
            return listOfCities;
        }
    }
}


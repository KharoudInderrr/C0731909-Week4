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
        Village Ajax  = new Village();
        Village First;
        public void Launch()
    {
        Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
         Toronto.VillageName = "Toronto";
            Maple.nextVillage = Ajax;
            Ajax.VillageName = "Ajax";



    }


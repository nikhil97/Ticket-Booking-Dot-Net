using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Stand
    {
        public int Stand_id;
        public string name;
        public int seating_capacity;
        public int seatsleft;


        public static Stand Initialising_Stand(int id)
        {
            Stand[] array = new Stand[6];
            array[0] = new Stand();
            array[0].Stand_id = 1;
            array[0].name = "Fox Road Stand";
            array[0].seating_capacity = 5000;


            array[1] = new Stand();
            array[1].Stand_id = 2;
            array[1].name = "Radcliffe Road Stand";
            array[1].seating_capacity = 10000;


            array[2] = new Stand();
            array[2].Stand_id = 3;
            array[2].name = "William Clark Stand";
            array[2].seating_capacity = 5000;


            array[3] = new Stand();
            array[3].Stand_id = 4;
            array[3].name = "New Stand";
            array[3].seating_capacity = 35000;


            array[4] = new Stand();
            array[4].Stand_id = 5;
            array[4].name = "Hound Road Stand";
            array[4].seating_capacity = 10000;


            return array[id];
        }


    }
}



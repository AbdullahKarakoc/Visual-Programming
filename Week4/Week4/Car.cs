using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Car
    {
        public string color = "blue";
        private int TC_id;
        public int tc_id { 
            get;

            set;
        }

        private string name= "Enes";
        public string Name {
            get { return name; }
            set { Name = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Program
    {
        public string model;
        string color = "red";
        int maxSpeed = 200;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public Program( string model, string color)
        {
            model = "Mustang";
        }



        static void Main(string[] args)
        {
            Program program = new Program("Mustang","red");
            program.fullThrottle();
            Console.WriteLine(program.color);

            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            myObj.tc_id = 1234;
            Console.WriteLine(myObj.Name);


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week3
{
    internal class Program
    {

        class MyArray
        {
            double getAverage(int[] arr, int size)
            {
                int i;
                double avg;
                int sum = 0;

                for (i = 0; i < size; ++i)
                {
                    sum += arr[i];
                }
                avg = (double)sum / size;
                return avg;
            }


            static void Main(string[] args)
            {
                //MyArray app = new MyArray();

                //int[] balance = new int[] { 1000, 2, 3, 17, 50 };
                //double avg;

                //avg = app.getAverage(balance, 5);

                //Console.WriteLine("Average value is: {0} ", avg);
                //Console.ReadLine();




                //Array.Reverse(temp);
                //Console.WriteLine("Array after reversing: ");

                //foreach (int i in temp)
                //{
                //    Console.Write(i + " ");
                //}
                //Console.WriteLine();

                //Array.Sort(temp);
                //Console.WriteLine("Array after sorting: ");




                ArrayList list_1 = new ArrayList();
                // OR
                var list_2 = new ArrayList();

                list_1.Add(1);
                list_1.Add("Bill");
                list_1.Add(3.14);
                list_1.Add(true);
                list_1.Add(null);

                var list_3 = new ArrayList()
                {
                    2, "Steve", 6.28, false, null
                };


                int[] arr = new int[] { 1, 2, 3, 4, 5 };

                Queue myQ = new Queue();
                myQ.Enqueue("Hello");
                myQ.Enqueue("World");

                list_1.AddRange(arr);
                list_1.AddRange(myQ);
                list_1.AddRange(list_3);


                foreach (var item in list_1)
                {
                    Console.WriteLine(item + ", ");
                }

                for(int i = 0; i < list_1.Count; i++)
                {
                    Console.WriteLine(list_1[i] + ", ");
                }






            }
        }
    }
}

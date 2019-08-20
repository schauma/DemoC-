using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

            rc_vector<int> vec_1 = new rc_vector<int>();
            //vec_1.RowIdx.Add(0);
            //vec_1.ColIdx.Add(1);
            vec_1.append(0,0);
            vec_1.append(1,1);

            rc_vector<int> vec_2 = new rc_vector<int>();
            vec_2.append(0,0);

            vec_1.difference(vec_2);

        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleAppJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            StudentInfoClass sic = new StudentInfoClass()
            {
                Roll = 1,
                name = "Sandeep",
                courses = new List<string>()
       {
         "Maths",
         "Science",
         "Data Structure",
         ".Net"
        }
            };

            string stringjson = JsonConvert.SerializeObject(sic);
            Console.WriteLine(stringjson);
        }

    }
}

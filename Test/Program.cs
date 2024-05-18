using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (clsPatientsData.Find(2))
            {
                Console.WriteLine("User Updated succefully");
            }
            else
                Console.WriteLine("User Updated Failed");

            //if (clsEmployeesData.Find(2))
            //{
            //    Console.WriteLine("User Deleted succefully");
            //}
            //else
            //    Console.WriteLine("User Deleted Failed");
        }
    }
}

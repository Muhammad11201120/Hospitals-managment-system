using HMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataBusinessLayer;
using System.Data;
using System.Data.SqlClient;
namespace Test
{
    internal class Program
    {
        static void Main( string[] args )
        {

            SqlParameter [] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("EmployeeID", 5);
            parameters[1] = new SqlParameter("PersonID", null);
            parameters[2] = new SqlParameter("Salary", null);

            if (clsEmployeesData.FindEmpolyee(ref parameters))
            {
                Console.WriteLine("done");
            }
            else
                Console.WriteLine("User Updated Failed");

            //if (clsEmployeesData.Find(2))
            //{
            //    Console.WriteLine("User Deleted succefully");
            //}
            //else
            //    Console.WriteLine("User Deleted Failed");

            Console.ReadKey();
        }
    }
}

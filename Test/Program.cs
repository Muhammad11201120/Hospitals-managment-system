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
            if (clsUsersData.AddNewUser(1, "Abdu", "1234", true) != -1)
            {
                Console.WriteLine("User Added succefully");
            }
            else
                Console.WriteLine("User Added Failed");
        }
    }
}

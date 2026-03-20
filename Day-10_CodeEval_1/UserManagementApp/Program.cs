using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementApp.Services;

namespace UserManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication auth = new Authentication();

            auth.Register("john", "Password@123", "john@email.com");

            bool result = auth.Authenticate("john", "Password@123");

            Console.WriteLine(result ? "Login successful" : "Login failed");
            Console.ReadLine();
        }
    }
}

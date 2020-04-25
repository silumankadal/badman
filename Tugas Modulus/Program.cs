using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, password;

            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            Class1 data = new Class1(email, password);
            data.login();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Modulus
{
    class Class1
    {
        public string[,] data, histories; 
        private string email, password, roles = "";
        int book;

        public Class1(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"indriawanakbar@gmail.com", "12345", "superadmin" },
                {"idris@gmail.com", "12345", "user"  }
            };
            histories = new String[2, 4] {
                {"indriawanakbar@gmail.com", "Fisika Dasar", "Dasar Komputer dan Pemrograman", "25-04-2020" },
                {"idris@gmail.com", "Dasar Komputer Pemrograman", "Konsep Jaringan Komputer","25-04-2020" }
            };
        }

        public void login()
        {
            var role = checkCredentials();
            if (role != "false")
            {
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email);
                Console.WriteLine(email + " meminjam buku: ");
                for (int i=1; i<3; i++)
                {
                    Console.WriteLine(histories[book, i]);
                }
                Console.WriteLine("Tanggal pinjaman : " + histories[book, 3]);
            }
            else
            {
                Console.WriteLine("\nInvalid Login");
            }
        }

        private string checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    if (data[i, 0] == histories[i, 0])
                        book = i;
                    roles = data[i, 2];
                    return roles;
                }
            }
            return "false";
        }
    }
}

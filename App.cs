using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassGenerator
{
    internal class App
    {
        public char[] PasswordCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()".ToCharArray();

        public void Generator()
        {
            Random random = new Random();
            Console.WriteLine("Jak dlouhe chces heslo?");
            int delka = int.Parse(Console.ReadLine());
            Console.WriteLine("Tvoje heslo je: ");
            StringBuilder heslo = new StringBuilder();

            for (int i = 0; i < delka; i++)
            {
                int index = random.Next(PasswordCharacters.Length);
                heslo.Append(PasswordCharacters[index]);
            }

            Console.WriteLine(heslo.ToString());
        }
    }
}

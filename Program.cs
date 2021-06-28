using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleRandomPasswordGeneration
{
    class RandomPassword
    {
        public string GetPass(int col)
        {
            int[] symbolsArray = new int[col];
            Random rnd = new Random();
            string password = "";
            for (int i = 0; i < symbolsArray.Length; i++)
            {
                symbolsArray[i] = rnd.Next(50, 100);
                password += (char)symbolsArray[i];
            }
            return password;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите колличество символов для создания пароля.");
            RandomPassword rp = new RandomPassword();
            int MaxPass = Convert.ToInt32(Console.ReadLine());
            string Passwd = rp.GetPass(MaxPass);
            Console.Clear();
            Console.WriteLine("Пароль: {0}", Passwd);
            Console.ReadKey();
        }
    }
}

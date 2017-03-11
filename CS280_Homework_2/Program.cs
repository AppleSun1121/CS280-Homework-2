using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入一隻Pokemon Information");
            Console.Write("請輸入PokemonName:");
            string PokemonName = Console.ReadLine();
            int NationalNo = 0;
            int Height = 0;
            int Weight = 0;
            Console.Write("請輸入NationalNo:");
            try
            {
                NationalNo = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Height:");
            try
            {
                Height = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("身高輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Weight:");
            try
            {
                Weight = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("體重輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Abilities:");
            string Abilities = Console.ReadLine();
            Console.Write("請輸入Category:");
            string Category = Console.ReadLine();
            Console.Write("請輸入Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Name:{0}, NationalNo:{1}, Height:{2}, Weight:{3}, Abilities:{4}, Category:{5}, Gender:{6}",

                PokemonName, NationalNo, Height, Weight, Abilities, Category, Gender);
        }
    }
}
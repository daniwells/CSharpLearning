using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {

        static void generatePrice(float price)
        {
            Console.WriteLine(price);
        }

        static string showMsg(string msg)
        {
            return msg;
        }

        static void Main(string[] args)
        {
            // Int 
            // Float
            // Double
            // Bool
            // String - "Teste"
            // Char - 'a' -> Apenas um único charactere

            //int secondWorldWar = 1942;
            //string favoriteColor = "red";
            //float speed = 1.0f;
            //bool isValid = true;

            //Console.WriteLine(secondWorldWar);
            //Console.WriteLine(favoriteColor);
            //Console.WriteLine(speed);
            //Console.WriteLine(isValid);

            //Console.WriteLine("Hello World\n");
            //Console.WriteLine("What's your name?\n");
            //string name = Console.ReadLine();
            //Console.WriteLine("Pleasure to meet you "+name+"!");

            //var favoriteColor = "red";
            //var productModel = 1967;

            // -----------------------------------------------------------------
            // NÂO USAR (APENAS EM SITUAÇÕES MUITO ESPECÍFICAS)
            //dynamic favoriteColor = "black";
            //favoriteColor = 000;
            //Console.WriteLine(favoriteColor);
            //favoriteColor = 0.0f;
            //Console.WriteLine(favoriteColor);
            // -----------------------------------------------------------------

            //const float pi = (float)Math.PI;

            //Console.WriteLine("Enter the first value");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second value");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third value");
            //int n3 = int.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Option 1");
            //}
            //else if(n1 > n2 || n1 > n3)
            //{
            //    Console.WriteLine("Option 2");
            //}
            //else
            //{
            //    Console.WriteLine("Option 3");
            //}

            // -----------------------------------------------------------------

            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 11)
            //{
            //    Console.WriteLine("You are a child!");
            //}
            //else if (age >= 12 && age <= 18)
            //{
            //    Console.WriteLine("You are a teenager!");
            //}
            //else if (age >= 19 && age <= 60)
            //{
            //    Console.WriteLine("You are a adult!");
            //}
            //else 
            //{
            //    Console.WriteLine("You are old!");
            //}

            // -----------------------------------------------------------------

            //Console.WriteLine(showMsg("MyMessage"));
            //generatePrice(60);

            // -----------------------------------------------------------------


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistLibrary;

namespace lab6
{
   

       

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string sName = Console.ReadLine();

            Console.Write("Введите страну: ");
            string sCountry = Console.ReadLine();

            Console.Write("Введите регион: ");
            string sRegion = Console.ReadLine();

            Console.Write("Введите жанр: ");
            string sGenre = Console.ReadLine();

            Console.Write("Введите цену концерта: ");
            string sSalaryForConcert = Console.ReadLine();

            Console.Write("Введите кл-во концертов в туре: ");
            string sNumberOfConcerts = Console.ReadLine();

            Console.Write("Введите пол? (y-муж, n-жен): ");
            ConsoleKeyInfo sSex = Console.ReadKey();
            Console.WriteLine();

            Artist ourArtist = new Artist(sName, sCountry, sRegion, sGenre);

            ourArtist.SalaryForConcert = int.Parse(sSalaryForConcert);
            ourArtist.NumberOfConcerts = int.Parse(sNumberOfConcerts);
            ourArtist.Sex = sSex.Key == ConsoleKey.Y ? true : false;

            int resGetTourSalary = ourArtist.GetTourSalary();
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данные про объект: ");
            Console.WriteLine("------------------------------------------------");  
            Console.WriteLine(ourArtist);
            Console.WriteLine("Заработок за весь тур: {0}",resGetTourSalary);
            Console.ReadKey();


        }
    }
}

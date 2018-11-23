using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistLibrary
{
     public class Artist
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }
        public string Genre { get; private set; }

        public int SalaryForConcert { get; set; }
        public int NumberOfConcerts { get; set; }

        public bool Sex { get; set; }

        public int GetTourSalary()
        {
            return SalaryForConcert * NumberOfConcerts;
        }

        public Artist(string name, string country, string region, string genre)
        {
            Name = name;
            Country = country;
            Region = region;
            Genre = genre;

        }
        public override string ToString()
        {
            return string.Format("Имя: {0}\nСтрана: {1}\nРегион: {2}\nЖанр: {3}\nМужчина: {4}\nЦена концертов: {5}\nКл-во концертов: {6}", Name, Country, Region,
                Genre, Sex, SalaryForConcert, NumberOfConcerts);

        }
    }
}

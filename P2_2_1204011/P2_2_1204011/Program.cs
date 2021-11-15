using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204011
{
    class Program
    {
        static void Main(string[] args)
        {


            Karakter hero1 = new Karakter("Downey Jr", "Iron Man", "Avenger");
            Karakter hero2 = new Karakter("Robert Pattinson", "Batman", "DC");
            Tim marvel = new Tim("Avengers", "Marvel");
            Tim dc = new Tim("Justice League", "DC Universe");

            Console.WriteLine("Pemeran pertama bernama {0} merupakan {1} dari SuperHero \"{2}\"", hero1.Nama, hero1.Tipe, hero1.Tipe_Karakter);
            Console.WriteLine("Pemeran kedua bernama {0} merupakan {1} dari SuperHero \"{2}\"", hero2.Nama, hero2.Tipe, hero2.Tipe_Karakter);
            Console.WriteLine("Pemeran pertama tergabung pada Tim {0} yang merupakan {1} dari Lisensi \"{2}\"", marvel.Nama, marvel.Tipe, marvel.Lisensi);
            Console.WriteLine("Pemeran kedua tergabung pada Tim {0} yang merupakan {1} dari Lisensi \"{2}\"", dc.Nama, dc.Tipe, dc.Lisensi);
        }
    }
}

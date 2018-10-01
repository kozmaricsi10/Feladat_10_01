using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            var bejegyzesek = new List<Bejegyzes>();

            Bejegyzes b1 = new Bejegyzes("Kiss Jóska", "assadsadsdasdasadasdasdsad");

            bejegyzesek.Add(b1);

            Bejegyzes b2 = new Bejegyzes("Nagy Janika", "kljjhklkljjlkjjkkljéjkjjkél");

            bejegyzesek.Add(b2);

            Console.WriteLine("Kérem adja meg, hogy hány bejegyzést szeretne megadni: ");
            String n = Console.ReadLine();

            int darab = int.Parse(n);

            for (int i = 0; i < darab; i++)
            {
                Console.WriteLine("Kérem adja meg a szerzőt: ");
                String szerzo = Console.ReadLine();

                Console.WriteLine("Kérem adja meg a tartalmat: ");
                String tartalom = Console.ReadLine();

                Bejegyzes b = new Bejegyzes(szerzo, tartalom);

                bejegyzesek.Add(b);
            }

            Random rnd = new Random();

            for (int i = 0; i < (bejegyzesek.Count * 20); i++)
            {
                
                int random = rnd.Next(0, bejegyzesek.Count);

                bejegyzesek[random].Like();

            }

            Console.WriteLine("Mire módósítod a 2. bejegyzésed tartalmát?");
            String ujtartalom = Console.ReadLine();

            bejegyzesek[1].Tartalom = ujtartalom;

            for (int i = 0; i < bejegyzesek.Count; i++)
            {

                Console.WriteLine(bejegyzesek[i].Kiir()); 

            }

            Bejegyzes a = bejegyzesek[0];

            int max2 = bejegyzesek[0].Likeok;
            int min = bejegyzesek[0].Likeok;

            foreach (var e in bejegyzesek)
            {
                if (e.Likeok > max2)
                {
                    max2 = e.Likeok;
                    a = e;
                }

                if (min > e.Likeok)
                {
                    min = e.Likeok;
                }
            }

            Console.WriteLine("A legnébszerűbb bejegyzés ennyi likeot kapott: " + max2);

            if(35 < max2)
            {
                Console.WriteLine("Van olyan bejegyzés ami több mint 35 likeot kapott.\n");
            }

            int keveslikeok = 0;

            for (int i = 0; i < bejegyzesek.Count; i++)
            {

                if(bejegyzesek[i].Likeok < 15)
                {

                    keveslikeok += 1;

                }

            }

            Console.WriteLine(keveslikeok + " olyan bejegyzés van ami 15-nél kevesebb likeot kapott.\n");


            for (int i = (bejegyzesek.Count - 1); i > 0; i--)
            {
                int max = i;

                for (int j = 0; j <= i; j++)

                    if (bejegyzesek[j].Likeok < bejegyzesek[max].Likeok)
                        max = j;
                Bejegyzes swap = bejegyzesek[i];
                bejegyzesek[i] = bejegyzesek[max];
                bejegyzesek[max] = swap;
            }

            for (int i = 0; i < bejegyzesek.Count; i++)
            {

                Console.WriteLine(bejegyzesek[i].Kiir());

            }


            Console.ReadLine();


        }
    }
}

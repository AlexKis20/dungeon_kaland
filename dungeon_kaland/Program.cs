using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon_kaland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöljük a Dungeon kaland szöveges kalandjátékban");
            Console.Write("Kérlek add meg a kalandor nevedet: ");
            string nev=Console.ReadLine();
            Console.WriteLine("Történet : Egy kezdő kalandor vagy aki be lépet az első Dungeon-jébe és különböző veszély fog érni és a megfelelő döntés hozatallal túl kell" +
                " élned és meg kell erősödnöd, ha jó döntéseket hozol akkor akár úgy is ki mehetsz a Dungeon-ből, hogy te leszel a legerősebb kalandor, de az is lehet hogy " +
                "sose jutsz ki.");
            string[] leltar = { "gyógyfőzet", "kötszer" };
            string[] felszereles = { "hosszú kard", "fémpáncél" };
            int HP = 100;
            int sebzes = 100;
            Console.WriteLine();
            Console.WriteLine($"Név: {nev}");
            Console.WriteLine($"A leltárad tartalma: {leltar[0]}, {leltar[1]}");
            Console.WriteLine($"A felszerelésed: {felszereles[0]}, {felszereles[1]}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Sebzés: {sebzes}");
            Console.WriteLine();
            Console.WriteLine("Beléptél a dungeon-be!");
            Console.WriteLine("Előtted két út van, melyiket választod? (jobb | bal)");
            Console.WriteLine($"{nev}: ");
            string valaszUt=Console.ReadLine();
            if (valaszUt.ToLower()=="jobb")
            {
                Console.WriteLine("Elmentél a jobb oldalra és lától egy goblint. Mit teszel?");
                Console.WriteLine("Elmenekülsz, megküzdöl vagy megpróbálsz elmenni mellette (elmenekülök | megküzdök | elmegyek mellette)");
                Console.WriteLine($"{nev}: ");
                string valaszGoblin = Console.ReadLine();
                if (valaszGoblin.ToLower()=="elmenekülök")
                {
                    Console.WriteLine("Ki futottál a dungeon-ból gyáván és semmit nem szereztél, a többi kalandor kinevetett és úgy hívtak hogy gyáva életed végéig.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A játék véget ért!");
                    Console.ResetColor();
                }
                else if (valaszGoblin.ToLower()=="megküzdök")
                {
                    Console.WriteLine("Hírtelen megtámadtad a goblint amire nem számított így könnyen megölted.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Kaptál egy goblin fület!");
                    Console.ResetColor();
                    Console.WriteLine("Tovább mentél és találsz egy ajtót. Be lépsz rajta vagy tovább mész? (be lépek | tovább megyek)");
                    string valaszAjto=Console.ReadLine();
                    if (valaszAjto.ToLower()=="be lépek")
                    {
                        Console.WriteLine("Be mentél az ajtón és bele estél egy csapdába és meghaltál!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A játék véget ért!");
                        Console.ResetColor();
                    }
                    else if (valaszAjto.ToLower()=="tovább megyek")
                    {
                        Console.WriteLine("Tovább mentél és útközben találsz egy fényes csillogó ládát és nem habozva ki nyitod és két tárgy van benne," +
                            " egy berzerker kard ami 200 sebzése van és egy berzerker páncél ami 200 HP-t ad és most se habozva ár is veszed a páncélt és a kardodat is" +
                            " lecseréled");
                        HP += 100;
                        sebzes += 100;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"HP-d megnőt, Jelenlegi HP-d: {HP}");
                        Console.ResetColor ();
                        Console.WriteLine($"Sebzésed megnőtt, Jelenlegi sebzésed: {sebzes}");

                    }
                    else
                    {

                    }
                }
                else if (true)
                {

                }
                else
                {

                }
            }
            else if (true)
            {

            }
            else
            {

            }



            Console.ReadKey();
        }
    }
}

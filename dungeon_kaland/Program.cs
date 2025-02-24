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
            nev:
            Console.Write("Kérlek add meg a kalandor nevedet: ");
            string nev=Console.ReadLine();
            if (nev=="")
            {
                goto nev;
            }
            Console.WriteLine("Történet : Egy kezdő kalandor vagy aki be lépet az első Dungeon-jébe és különböző veszély fog érni és a megfelelő döntés hozatallal túl kell" +
                " élned és meg kell erősödnöd, ha jó döntéseket hozol akkor akár úgy is ki mehetsz a Dungeon-ből, hogy te leszel a legerősebb kalandor, de az is lehet hogy " +
                "sose jutsz ki.");
            string[] leltar = { "gyógyfőzet", "kötszer","","" };
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
            Console.Write($"{nev}: ");
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
                    leltar[2]="goblin fül";
                    Console.ResetColor();
                    Console.WriteLine("Tovább mentél és találsz egy ajtót. Be lépsz rajta vagy tovább mész? (be lépek | tovább megyek)");
                    Console.Write($"{nev}: ");
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
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Sebzésed megnőtt, Jelenlegi sebzésed: {sebzes}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("Miután megszerezted az új felszerelést tovább haladsz és meg lától egy nagy orkot ami ép étkezik egy másik szörny húsával.");
                        Console.WriteLine(" Most mit teszel? Megtámadod vagy ki mész a dungeonból vagy elsettenkedsz mögötte? (megtámadom | kimegyek | elsettenkedek)");
                        Console.Write($"{nev}: ");
                        string valaszOrk=Console.ReadLine();
                        if (valaszOrk.ToLower()=="kimegyek")
                        {
                            Console.WriteLine("inkább kimentél a dungeon-ból és az eddigi összegyűjtött tárgyakat eladtad és ezután be léptél a város őrségbe mert bőven elég volt ennyi kaland és inkább véded a városodat.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A játék véget ért! ");
                            Console.ResetColor();
                        }
                        else if (valaszOrk.ToLower()=="elsettenkedek")
                        {
                            Console.WriteLine("Megpróbáltál elsettenkedni mellette de sajnos rá léptél egy olyan kőre ami be indított egy csapdát és hírtelen megnyílt a föld alattad és bele estél a lyukba ahol sok penge állt ki a földből és felnyársalódtál!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A játék véget ért! ");
                            Console.ResetColor();
                        }
                        else if (valaszOrk.ToLower()=="megtámadom")
                        {
                            Console.WriteLine("Megtámadtad az orkot, de sajna észre vett és tudott reagálni a támadásodra és heves harc után megnyerted a csatát de súlyosan megsérültél.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Jelenlegi HP-d: 40");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Kaptál egy ork fogat!");
                            Console.ResetColor();
                            leltar[3] = "ork fog";
                            poti:
                            Console.WriteLine("Van a táskádban egy gyógyfőzet, mit teszel? Megiszod vagy nem? (megiszom | nem iszom");
                            string megiszod=Console.ReadLine();
                            if (megiszod.ToLower()=="nem iszom")
                            {
                                Console.WriteLine("Nem ittad meg és mivel nem gyógyultál meg így elvéresztél és meghaltál!");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();
                            }
                            else if (megiszod.ToLower()=="megiszom")
                            {
                                Console.WriteLine("Kivetted a táskádból a gyógyfőzetet és megittad, A HP-d visszatöltődött.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Jelenlegi HP-d: 200");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("Tovább mentél és egy nagy kapuhoz értél. Amikor az ajtó elé sétáltál az ajtó kinyílt, te bátran be mentél rajta és egy" +
                                    " terembe értél ahol egy páncél és kard fogadott.A felszerelések aurája hatalmas és sötét erőt árasztott. A kíváncsiság eluralkodott rajtad" +
                                    " és megérintetted a páncélt és kardot, és ahogy megérintetted a berzerker páncélod és kardod átalakult azokra a felszerelésre amit meg éríntettél vagyis a démon páncélra és a démon kardra.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("HP-d megnőt , jelenlegi HP-d: 500");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Sebzésed megnőtt,  jelenlegi sebzésed: 500");
                                Console.ResetColor();
                                Console.WriteLine("Miután megszerezted a démon felszerelést ki mentél a dungeon-ből a többi kalandornak felkeltetted a figyelmüket az erős aurád által és megkaptad a tiszteletüket és ezután egy erős harcosként élted tovább egyedül az életedet. " +
                                    "Miután meghaltál a pokol kapuja nyílt meg előtted.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();

                            }
                            else
                            {
                                goto poti;
                            }
                        }
                        else
                        {

                        }

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


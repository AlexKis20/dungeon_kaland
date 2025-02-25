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
            ConsoleKey billentyu;
            do
            {
                Console.WriteLine("Üdvözöljük a Dungeon kaland szöveges kalandjátékban");
                nev:
                Console.Write("Kérlek add meg a kalandor nevedet: ");
                string nev = Console.ReadLine();
                if (nev == "")
                {
                    goto nev;
                }
                Console.Clear();
                Console.WriteLine("Történet : Egy kezdő kalandor vagy aki be lépet az első Dungeon-jébe és különböző veszély fog érni és a megfelelő döntés hozatallal túl kell" +
                    " élned és meg kell erősödnöd, ha jó döntéseket hozol akkor akár úgy is ki mehetsz a Dungeon-ből, hogy te leszel a legerősebb kalandor, de az is lehet hogy " +
                    "sose jutsz ki.");
                Console.Clear();
                string[] leltar = { "gyógyfőzet", "kötszer", "", "", "" };
                string[] felszereles = { "hosszú kard", "fémpáncél" };
                int HP = 100;
                int sebzes = 100;
                int szerencse = 0;
                Console.WriteLine();
                Console.WriteLine($"Név: {nev}");
                Console.WriteLine($"A leltárad tartalma: {leltar[0]}, {leltar[1]}");
                Console.WriteLine($"A felszerelésed: {felszereles[0]}, {felszereles[1]}");
                Console.WriteLine($"HP: {HP}");
                Console.WriteLine($"Sebzés: {sebzes}");
                jobbBal:
                Console.WriteLine("Beléptél a dungeon-be!");
                Console.WriteLine("Előtted két út van, melyiket választod? (jobb | bal)");
                Console.Write($"{nev}: ");
                string valaszUt = Console.ReadLine();
                if (valaszUt.ToLower() == "jobb")
                {
                    Console.Clear();
                    goblin:
                    Console.WriteLine("Elmentél a jobb oldalra és lától egy goblint. Mit teszel?");
                    Console.WriteLine("Elmenekülsz, megküzdöl vagy megpróbálsz elmenni mellette (elmenekülök | megküzdök | elmegyek mellette)");
                    Console.Write($"{nev}: ");
                    string valaszGoblin = Console.ReadLine();
                    if (valaszGoblin.ToLower() == "elmenekülök")
                    {
                        Console.Clear();
                        Console.WriteLine("Ki futottál a dungeon-ból gyáván és semmit nem szereztél, a többi kalandor kinevetett és úgy hívtak hogy gyáva életed végéig.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A játék véget ért!");
                        Console.ResetColor();
                    }
                    else if (valaszGoblin.ToLower() == "megküzdök")
                    {
                        Console.Clear();
                        Console.WriteLine("Hírtelen megtámadtad a goblint amire nem számított így könnyen megölted.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Kaptál egy goblin fület!");
                        leltar[2] = "goblin fül";
                        Console.ResetColor();
                        ajto:
                        Console.WriteLine("Tovább mentél és találsz egy ajtót. Be lépsz rajta vagy tovább mész? (be lépek | tovább megyek)");
                        Console.Write($"{nev}: ");
                        string valaszAjto = Console.ReadLine();
                        if (valaszAjto.ToLower() == "be lépek")
                        {
                            Console.Clear();
                            Console.WriteLine("Be mentél az ajtón és bele estél egy csapdába és meghaltál!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A játék véget ért!");
                            Console.ResetColor();
                        }
                        else if (valaszAjto.ToLower() == "tovább megyek")
                        {
                            Console.Clear();
                            Console.WriteLine("Tovább mentél és útközben találsz egy fényes csillogó ládát és nem habozva ki nyitod és két tárgy van benne," +
                                " egy berzerker kard ami 200 sebzése van és egy berzerker páncél ami 200 HP-t ad és most se habozva ár is veszed a páncélt és a kardodat is" +
                                " lecseréled");
                            HP += 100;
                            sebzes += 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"HP-d megnőt, Jelenlegi HP-d: {HP}");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Sebzésed megnőtt, Jelenlegi sebzésed: {sebzes}");
                            Console.ResetColor();
                            Console.WriteLine();
                            ork:
                            Console.WriteLine("Miután megszerezted az új felszerelést tovább haladsz és meg lától egy nagy orkot ami ép étkezik egy másik szörny húsával.");
                            Console.WriteLine(" Most mit teszel? Megtámadod vagy ki mész a dungeonból vagy elsettenkedsz mögötte? (megtámadom | kimegyek | elsettenkedek)");
                            Console.Write($"{nev}: ");
                            string valaszOrk = Console.ReadLine();
                            if (valaszOrk.ToLower() == "kimegyek")
                            {
                                Console.Clear();
                                Console.WriteLine("inkább kimentél a dungeon-ból és az eddigi összegyűjtött tárgyakat eladtad és ezután be léptél a város őrségbe mert bőven elég volt ennyi kaland és inkább véded a városodat.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();
                            }
                            else if (valaszOrk.ToLower() == "elsettenkedek")
                            {
                                Console.Clear();
                                Console.WriteLine("Megpróbáltál elsettenkedni mellette de sajnos rá léptél egy olyan kőre ami be indított egy csapdát és hírtelen megnyílt a föld alattad és bele estél a lyukba ahol sok penge állt ki a földből és felnyársalódtál!");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();
                            }
                            else if (valaszOrk.ToLower() == "megtámadom")
                            {
                                Console.Clear();
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
                                Console.Write($"{nev}: ");
                                string megiszod = Console.ReadLine();
                                if (megiszod.ToLower() == "nem iszom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nem ittad meg és mivel nem gyógyultál meg így elvéresztél és meghaltál!");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A játék véget ért! ");
                                    Console.ResetColor();
                                }
                                else if (megiszod.ToLower() == "megiszom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Kivetted a táskádból a gyógyfőzetet és megittad, A HP-d visszatöltődött.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Jelenlegi HP-d: {HP}");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.WriteLine("Tovább mentél és egy nagy kapuhoz értél. Amikor az ajtó elé sétáltál az ajtó kinyílt, te bátran be mentél rajta és egy" +
                                        " terembe értél ahol egy páncél és kard fogadott.A felszerelések aurája hatalmas és sötét erőt árasztott. A kíváncsiság eluralkodott rajtad" +
                                        " és megérintetted a páncélt és kardot, és ahogy megérintetted a berzerker páncélod és kardod átalakult azokra a felszerelésre amit meg éríntettél vagyis a démon páncélra és a démon kardra.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    HP += 300;
                                    Console.WriteLine($"HP-d megnőt , jelenlegi HP-d: {HP}");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    sebzes += 300;
                                    Console.WriteLine($"Sebzésed megnőtt,  jelenlegi sebzésed: {sebzes}");
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
                                    Console.Clear();
                                    goto poti;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                goto ork;
                            }

                        }
                        else
                        {
                            Console.Clear();
                            goto ajto;
                        }
                    }
                    else if (valaszGoblin.ToLower() == "elmegyek mellette")
                    {
                        Console.Clear();
                        Console.WriteLine("Amikor megpróbáltál elmenni mellette észre vett és megtámadott és sikerült is megsebeznie téged, de időben reagáltál rá így sikerült megölnöd, de vesztettél 20 HP-t");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Kaptál egy goblin fület!");
                        leltar[2] = "goblin fül";
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Jelenlegi HP-d: 80");
                        Console.ResetColor();
                        kotozes:
                        Console.WriteLine("Szeretnéd e bekötözni a sérülést? (igen | nem)");
                        Console.Write($"{nev}: ");
                        string igennem = Console.ReadLine();
                        if (igennem.ToLower() == "nem")
                        {
                            Console.Clear();
                            Console.WriteLine("Nem kötözted be a sebedet és tovább mentél, de aközben míg mentél elfertőzött a sebed és muszáj volt ki menned a dungeon-ból és elmenned az orvoshoz.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A játék véget ért! ");
                            Console.ResetColor();
                        }
                        else if (igennem.ToLower() == "igen")
                        {
                            Console.Clear();
                            Console.WriteLine("Be kötözted a sebedet és vissza nyerted a HP - dat.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Jelenlegi HP-d: {HP}");
                            Console.ResetColor();
                            ajto2:
                            Console.WriteLine("Tovább mentél és találsz egy ajtót. Be lépsz rajta vagy tovább mész? (be lépek | tovább megyek)");
                            Console.Write($"{nev}: ");
                            string valaszAjto = Console.ReadLine();
                            if (valaszAjto.ToLower() == "be lépek")
                            {
                                Console.Clear();
                                Console.WriteLine("Be mentél az ajtón és bele estél egy csapdába és meghaltál!");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért!");
                                Console.ResetColor();
                            }
                            else if (valaszAjto.ToLower() == "tovább megyek")
                            {
                                Console.Clear();
                                Console.WriteLine("Tovább mentél és útközben találsz egy fényes csillogó ládát és nem habozva ki nyitod és két tárgy van benne," +
                                    " egy berzerker kard ami 200 sebzése van és egy berzerker páncél ami 200 HP-t ad és most se habozva ár is veszed a páncélt és a kardodat is" +
                                    " lecseréled");
                                HP += 100;
                                sebzes += 100;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"HP-d megnőt, Jelenlegi HP-d: {HP}");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"Sebzésed megnőtt, Jelenlegi sebzésed: {sebzes}");
                                Console.ResetColor();
                                Console.WriteLine();
                                ork2:
                                Console.WriteLine("Miután megszerezted az új felszerelést tovább haladsz és meg lától egy nagy orkot ami ép étkezik egy másik szörny húsával.");
                                Console.WriteLine(" Most mit teszel? Megtámadod vagy ki mész a dungeonból vagy elsettenkedsz mögötte? (megtámadom | kimegyek | elsettenkedek)");
                                Console.Write($"{nev}: ");
                                string valaszOrk = Console.ReadLine();
                                if (valaszOrk.ToLower() == "kimegyek")
                                {
                                    Console.Clear();
                                    Console.WriteLine("inkább kimentél a dungeon-ból és az eddigi összegyűjtött tárgyakat eladtad és ezután be léptél a város őrségbe mert bőven elég volt ennyi kaland és inkább véded a városodat.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A játék véget ért! ");
                                    Console.ResetColor();
                                }
                                else if (valaszOrk.ToLower() == "elsettenkedek")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Megpróbáltál elsettenkedni mellette de sajnos rá léptél egy olyan kőre ami be indított egy csapdát és hírtelen megnyílt a föld alattad és bele estél a lyukba ahol sok penge állt ki a földből és felnyársalódtál!");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A játék véget ért! ");
                                    Console.ResetColor();
                                }
                                else if (valaszOrk.ToLower() == "megtámadom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Megtámadtad az orkot, de sajna észre vett és tudott reagálni a támadásodra és heves harc után megnyerted a csatát de súlyosan megsérültél.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Jelenlegi HP-d: 40");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Kaptál egy ork fogat!");
                                    Console.ResetColor();
                                    leltar[3] = "ork fog";
                                    poti2:
                                    Console.WriteLine("Van a táskádban egy gyógyfőzet, mit teszel? Megiszod vagy nem? (megiszom | nem iszom");
                                    Console.Write($"{nev}: ");
                                    string megiszod = Console.ReadLine();
                                    if (megiszod.ToLower() == "nem iszom")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Nem ittad meg és mivel nem gyógyultál meg így elvéresztél és meghaltál!");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("A játék véget ért! ");
                                        Console.ResetColor();
                                    }
                                    else if (megiszod.ToLower() == "megiszom")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Kivetted a táskádból a gyógyfőzetet és megittad, A HP-d visszatöltődött.");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Jelenlegi HP-d: {HP}");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        Console.WriteLine("Tovább mentél és egy nagy kapuhoz értél. Amikor az ajtó elé sétáltál az ajtó kinyílt, te bátran be mentél rajta és egy" +
                                            " terembe értél ahol egy páncél és kard fogadott.A felszerelések aurája hatalmas és sötét erőt árasztott. A kíváncsiság eluralkodott rajtad" +
                                            " és megérintetted a páncélt és kardot, és ahogy megérintetted a berzerker páncélod és kardod átalakult azokra a felszerelésre amit meg éríntettél vagyis a démon páncélra és a démon kardra.");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        HP += 300;
                                        Console.WriteLine($"HP-d megnőt , jelenlegi HP-d: {HP}");
                                        Console.ResetColor();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        sebzes += 300;
                                        Console.WriteLine($"Sebzésed megnőtt,  jelenlegi sebzésed: {sebzes}");
                                        Console.ResetColor();
                                        Console.WriteLine("Miután megszerezted a démon felszerelést ki mentél a dungeon-ből a többi kalandornak felkeltetted a figyelmüket az erős aurád által és megkaptad a tiszteletüket és ezután egy erős harcosként élted tovább egyedül az életedet. ");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Miután meghaltál a pokol kapuja nyílt meg előtted.");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("A játék véget ért! ");
                                        Console.ResetColor();

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        goto poti2;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    goto ork2;
                                }

                            }
                            else
                            {
                                Console.Clear();
                                goto ajto2;
                            }
                        }


                        else
                        {
                            Console.Clear();
                            goto kotozes;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        goto goblin;
                    }
                }
                else if (valaszUt.ToLower() == "bal")
                {
                    Console.Clear();
                    Console.WriteLine("Elmentél a bal oldali úton, már  10 perc séta után figyelmes lettél egy hangra, horkolásnak tűnt. Közelebb mentél és egy hatalmas trollal találkoztál aki ép aludt. ");
                    troll:
                    Console.WriteLine("Most mit teszel? Kiszaladsz a dungeon-ból, elosonsz mellette vagy megtámadod? (kiszaladok | elosonok | megtámadom)");
                    Console.Write($"{nev}: ");
                    string valasztroll = Console.ReadLine();
                    if (valasztroll.ToLower() == "kiszaladok")
                    {
                        Console.Clear();
                        Console.WriteLine("Kiszaladtál félelmedbe a dungeon-ből , mindenki úgy becézett ezek után hogy a leggyávább kalandor. Ezután gyávaként kell élned.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A játék véget ért! ");
                        Console.ResetColor();
                    }
                    else if (valasztroll.ToLower() == "megtámadom")
                    {
                        Console.Clear();
                        Console.WriteLine("Miközben aludt a troll meghallotta hogy szaladol felé kardal és le ütött téged a nagy bunkósbotjával.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A játék véget ért! ");
                        Console.ResetColor();
                    }
                    else if (valasztroll.ToLower() == "elosonok")
                    {
                        Console.Clear();
                        Console.WriteLine("Halkan elosontál mellette míg aludt és haladtál tovább az úton míg megláttál egy sérült tündért.");
                        tunder:
                        Console.WriteLine("Mit teszel? Ott hagyod a tündért meghalni vagy megmented egy  csepp gyógyfőzettel? (ott hagyom | megmentem)");
                        Console.Write($"{nev}: ");
                        string valasztunder = Console.ReadLine();
                        if (valasztunder.ToLower() == "ott hagyom")
                        {
                            Console.Clear();
                            Console.WriteLine("Ott hagytad a haldokló tündért és tovább mentél de a tündér megátkozott egy halálos átokkal és 5 perc múlva megállt a szíved és meghaltál.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A játék véget ért! ");
                            Console.ResetColor();
                        }
                        else if (valasztunder.ToLower() == "megmentem")
                        {
                            Console.Clear();
                            Console.WriteLine("Leguggoltál a tündér mellé és adtál neki egy csepp gyógyfőzetet és így megmentetted az életét, és hogy kifejezze a háláját megajándékozott téged a jószerencse áldásával ami megnövelte a szerencsédet");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            szerencse += 100;
                            Console.WriteLine($"Szerencséd megnőtt, a szerencséd szintje: {szerencse}%");
                            Console.WriteLine();
                            Console.WriteLine("Miután a tündér elköszönt tőled találtál egy ládát amit ki is nyitottál. A ládában találtál egy páncélt és egy kardot amiknek a nevei szent páncél és szent kard volt. Nem habozva át is vetted a felszerelést és a statjaid meg is növekedtek.");
                            HP += 100;
                            sebzes += 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"HP-d megnőt, Jelenlegi HP-d: {HP}");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Sebzésed megnőtt, Jelenlegi sebzésed: {sebzes}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine("Az új felszereléssel folytattad az utadat és egy hatalmas Kerberoszt találtál aki ép szundikált.");
                            kerberosz:
                            Console.WriteLine("Most mit teszel? Haza mész, megrohamozod vagy hallkan elkúszol mellette? (haza megyek | megrohamozom | elkúszok)");
                            Console.Write($"{nev}: ");
                            string valaszkerberosz = Console.ReadLine();
                            if (valaszkerberosz.ToLower() == "haza megyek")
                            {
                                Console.Clear();
                                Console.WriteLine("Haza mentél, de nem gyűjtöttél semmit így pénzt nem tudtál szerezni , de csatlakoztál a templomos sereghez és hívő lettél végül nyugodt békés életet éltél");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();
                            }
                            else if (valaszkerberosz.ToLower() == "megrohamozom")
                            {
                                Console.Clear();
                                Console.WriteLine("Megrohamoztad a Kerberoszt és sikerült meg lepned , de nagyon kemény ellenfél volt és vesztettél ellene és a vacsorája lettél.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A játék véget ért! ");
                                Console.ResetColor();
                            }
                            else if (valaszkerberosz.ToLower() == "elkúszok")
                            {
                                Console.Clear();
                                Console.WriteLine("Elkúsztál hallkan a Kerberosz mellett és amikor elég messze kerültél tőle folytattad az utadat.");
                                Console.WriteLine();
                                lada:
                                Console.WriteLine("Út közben találtál egy furcsa fa ládát. Mit teszel ? Kinyitod vagy nem és mész tovább ? (kinyitom | nem nyitom)");
                                Console.Write($"{nev}: ");
                                string valaszlada = Console.ReadLine();
                                if (valaszlada.ToLower() == "kinyitom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Megpróbáltad ki nyitni de ez a láda egy mimik volt ami egy olyan szörny ami ládának álcázza magát és egészben lenyelt.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A játék véget ért! ");
                                    Console.ResetColor();
                                }
                                else if (valaszlada.ToLower() == "nem nyitom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nem nyitottad ki és mentél tovább az utadon és néhány perc séta után egy óriási arany ajtóhoz értél, de nem láttál kilincset csak a falon egy kiírást hogy : Csak az léphet be aki elég szerencsés hozzá, és ha te úgy érzed , hogy elég szerencsés vagy érintsd meg az ajtón lévő kristálygömböt.");
                                    Console.WriteLine("Miután el olvastad a szöveget megérintetted a kristálygömböt és kinyílt az arany ajtó, miután teljesen kinyílt be mentél a terembe és egy páncél fogadott és egy kard amiknek az volt a nevük hogy angyal páncél és angyal kard és egy fényes és nyugtató aura vette körül a felszerelést. Habozva  de óvatosan hozzá értél a felszereléshez és a rajtad lévő szent felszerelések át alakultak angyal felszerelésre. A páncél és kard mögött észre vettél egy zsák aranyat ami felet az volt írva a falra hogy vidd el de ne rosszra költsd, csakis jóra.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Szereztél egy zsák aranyat!");
                                    leltar[4] = "egy zsák arany";
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    HP += 300;
                                    Console.WriteLine($"HP-d megnőt , jelenlegi HP-d: {HP}");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    sebzes += 300;
                                    Console.WriteLine($"Sebzésed megnőtt,  jelenlegi sebzésed: {sebzes}");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.WriteLine("Miután eltetted az aranyat ki mentél a dungeon-ból és amikor az emberek megláttak azt érezték hogy egy angyal van előttük és istenítettek téged, de te nem lettél emiatt beképzelt hanem mindenkivel kedves voltál és be léptél az egyházba hogy segíthesd az embereknek és az aranyból építettél egy árvaházat hogy befogadd oda az árvákat és hogy tanítsad és felneveld őket. Boldogan élted le az életedett és soha nem voltál egyedül.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Miután meghaltál a menyország kapuja nyílt meg előtted.");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A játék véget ért! ");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Clear();
                                    goto lada;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                goto kerberosz;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            goto tunder;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        goto troll;
                    }
                }
                else
                {
                    Console.Clear();
                    goto jobbBal;
                }
                vege:
                Console.WriteLine("Kérlek írd be hogy: végszó");
                Console.Write($"{nev}: ");
                string vegszo = Console.ReadLine();
                if (vegszo.ToLower() == "végszó")
                {
                    Console.Clear();
                    Console.WriteLine("Köszönöm és gratulálok hogy végig játszottad a játékomat!");
                    Console.WriteLine("Készítette: Kis Alex János");
                }
                else
                {
                    Console.Clear();
                    goto vege;
                }
                Console.WriteLine();
                Console.WriteLine("Szeretnél játszani még? ( igen(ENTER) | nem (ESC))");
                billentyu = Console.ReadKey(true).Key;
                Console.Clear();
            } while (billentyu != ConsoleKey.Escape);





        }
    }
}


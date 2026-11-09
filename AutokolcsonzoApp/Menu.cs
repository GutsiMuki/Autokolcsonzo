using System.Globalization;
namespace AutokolcsonzoConsole;


public class Menu
{

    //az autókölcsönző service használata...

    public void Futtatas()
    {
        string? valasztas;
        do
        {
            Console.Clear();
            Console.WriteLine("========== AUTÓKÖLCSÖNZŐ ==========");
            Console.WriteLine("1. Autók listázása");
            Console.WriteLine("2. Szabad autók");
            Console.WriteLine("3. Ügyfelek listázása");
            Console.WriteLine("4. Új ügyfél rögzítése");
            Console.WriteLine("5. Bérlés rögzítése");
            Console.WriteLine("6. Autó visszahozatala");
            Console.WriteLine("7. Aktív bérlések");
            Console.WriteLine("8. Késedelmes bérlések");
            Console.WriteLine("9. Kategória statisztika");
            Console.WriteLine("0. Kilépés");
            Console.Write("Választás: ");
            valasztas = Console.ReadLine();
            Console.Clear();

            switch (valasztas)
            {
                case "1": Autok(); break;
                case "2": SzabadAutok(); break;
                case "3": Ugyfelek(); break;
                case "4": UjUgyfel(); break;
                case "5": UjBerles(); break;
                case "6": Visszahozatal(); break;
                case "7": AktivBerlesek(); break;
                case "8": Kesesek(); break;
                case "9": Statisztika(); break;
                case "0": break;
                default: Console.WriteLine("Érvénytelen menüpont!"); break;
            }
            if (valasztas != "0")
            {
                Console.WriteLine("\nEnter a folytatáshoz...");
                Console.ReadLine();
            }
        } while (valasztas != "0");
    }


    private void Autok()
    {
        
        

    }

    private void SzabadAutok()
    {


    }

    private void Ugyfelek()
    {

	//Az ügyfelek listája, jelölve az aktív és inaktív ügyfeleket

    }

    private void UjUgyfel()
    {
        Console.Write("Ügyfél neve: ");
        string nev = Console.ReadLine() ?? "";
        Console.Write("E-mail címe: ");
        string email = Console.ReadLine() ?? "";

	//Új ügyfél rögzítése (ha lehetséges)


    }

    private void UjBerles()
    {

	//Szabad autók listája
	int autoId = EgeszSzam("Autó azonosítója: ");

	//ügyfelek listája
        int ugyfelId = EgeszSzam("Ügyfél azonosítója: ");

        int napok = EgeszSzam("Bérlés hossza (nap): ");

	//kezdet: az aktuális dátum

	//bérlés rögzítése

    }

    private int EgeszSzam(string v)
    {
        throw new NotImplementedException();
    }

    private void Visszahozatal()
    {

	//aktív bérlések listája
        int id = EgeszSzam("Bérlés azonosítója: ");

	//visszahozatal: az aktuális dátum

	//a bérlés "lezárása"
    }

    private void AktivBerlesek()
    {
        //bérlések adatai (rendszám, modell, ügyfél neve), határidővel
    }

    private void Kesesek()
    {

	//bérlések, amik a határidőn túl vannak (a mai naphoz viszonyítva), a késés napjaival
    }

    private void Statisztika()
    {

	//kategóriánként hány bérlés volt eddig

    }


    //HA KELL HASZNÁLD... de az ellenőrzött bekérést csak, ha már működik a program!!!!
    private static DateOnly Datum(string szoveg)
    {
        while (true)
        {
            Console.Write(szoveg);
            if (DateOnly.TryParseExact(Console.ReadLine(), "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var datum))
                return datum;
            Console.WriteLine("Hibás dátum!");
        }
    }
}

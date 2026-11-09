using Autokolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Services
{
    public interface IAutokolcsonzoService
    {
        List<Auto> Autok();
        List<Auto> SzabadAutok();
        List<Ugyfel> Ugyfelek();

        //Az ügyfél egyedi email címmel rendelkezik!
        bool UjUgyfel(string nev, string email);

        //ÁTÍRHATÓ: autó és ügyfél objektumokra
        bool UjBerles(int autoId, int ugyfelId, DateOnly kezdet, int napok);

        bool Visszahozatal(int berlesId, DateOnly datum);

        List<Berles> AktivBerlesek();

        List<Berles> Kesesek(DateOnly datum);

        //Minden bérlés (lezárt és folyamatban lévő összesen), kategóriánként
        List<(string Kategoria, int Darab)> KategoriaStatisztika();

        //BŐVÍTHETŐ...
    }
}

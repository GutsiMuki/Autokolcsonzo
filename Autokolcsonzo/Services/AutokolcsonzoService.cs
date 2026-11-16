using Autokolcsonzo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Services
{
    public class AutokolcsonzoService : IAutokolcsonzoService
    {
        public AutokolcsonzoDbContext Context { get; }
        public AutokolcsonzoService()
        {
            Context = new AutokolcsonzoDbContext();
        }



        public List<Berles> AktivBerlesek()
        {
            return Context.DbBerles.Where(b => b.Visszahozva == null).ToList();
        }

        public List<Auto> Autok()
        {
            return Context.DbAuto.OrderBy(a=>a.Rendszam).ToList();
        }

        public List<(string Kategoria, int Darab)> KategoriaStatisztika()
        {
            throw new NotImplementedException();
        }

        public List<Berles> Kesesek(DateOnly datum)
        {
            throw new NotImplementedException();
        }

        public List<Auto> SzabadAutok()
        {
            return Context.DbAuto.Include(b => b.Berlesek).ToList().Where(a => a.Szabad).ToList();
        }

        public List<Ugyfel> Ugyfelek()
        {
            return Context.DbUgyfel.OrderBy(u => u.Nev).ToList();
        }

        public bool UjBerles(int autoId, int ugyfelId, DateOnly kezdet, int napok)
        {
            throw new NotImplementedException();
        }

        public bool UjUgyfel(Ugyfel U)
        {
            Context.DbUgyfel.Add(U);
            
            if (Context.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public bool Visszahozatal(int berlesId, DateOnly datum)
        {
            throw new NotImplementedException();
        }

        public bool UjGyarto(string nev)
        {
            Gyarto G = new Gyarto { Nev = nev };
            Context.DbGyarto.Add(G);
            if (Context.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public bool UjKategoria(string nev)
        {
            Kategoria K = new Kategoria { Nev = nev };
            Context.DbKategoria.Add(K);
            if (Context.SaveChanges() > 0)
                return true;
            else
                return false;
        }
    }
}

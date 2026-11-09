using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Models
{
    public class Berles
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
        public int UgyfelId { get; set; }
        public Ugyfel Ugyfel { get; set; }
        public DateOnly Kezdete { get; set; }
        public DateOnly Hatarido { get; set; }
        public DateOnly? Visszahozva { get; set; }
        public bool Aktiv { get { return Visszahozva != null ? false : true; } }

        public int KesesNapok(DateOnly Datum)
        {
            if (Aktiv)
            {
                if (Datum > Hatarido)
                {
                    return (Datum.DayNumber - Hatarido.DayNumber);
                }
                else
                {
                    return 0;
                }
            }
            else
                return 0;

        }
    }
}

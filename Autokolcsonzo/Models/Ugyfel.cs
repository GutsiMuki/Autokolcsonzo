using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Models
{

    public class Ugyfel
    {
        public int Id { get; set; }
        public string Nev { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Aktiv { get; set; }

        public List<Berles> Berlesek { get; set; } = new();

    }
}

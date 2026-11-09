using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokolcsonzo.Models
{

    public class Kategoria
    {
        public int Id { get; set; }
        public string Nev { get; set; } = "";

        public List<Auto> Autok { get; set; } = new();
    }
}

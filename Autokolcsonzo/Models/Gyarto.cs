using System.ComponentModel.DataAnnotations.Schema;

namespace Autokolcsonzo.Models
{

    public class Gyarto
    {
        public int Id { get; set; }
        public string Nev { get; set; } = "";

        public List<Auto> Autok { get; set; } = new();

    }
}

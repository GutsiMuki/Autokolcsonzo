using Autokolcsonzo.Services;
using AutokolcsonzoConsole;
using System.ComponentModel.Design;

namespace AutokolcsonzoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAutokolcsonzoService service = new AutokolcsonzoService();

            foreach (var auto in service.Autok())
            {
                Console.WriteLine($"{auto.Rendszam}");
            }

        }
    }
}

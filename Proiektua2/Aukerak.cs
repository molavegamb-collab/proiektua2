
using System.Runtime.InteropServices;

namespace TxokoArgi
{
    public static class Aukerak
    {
        public static string AukeratuEdaria()
        {
            Console.WriteLine("1) Garagardoa");
            Console.WriteLine("2) Freskagarri");
            Console.WriteLine("3) Ura");
            Console.WriteLine("4) Ardo zuria");
            Console.WriteLine("5) Ardo tintoa");
            Console.WriteLine("6) Sagardoa");
            Console.WriteLine("7) Laranjazko zukua");
            Console.WriteLine("8) Kafea");
            Console.WriteLine("9) Tea");
            Console.WriteLine("10) Ura gasarekin");
            
            Console.Write("Aukeratu> ");
            string? aukeratuEdaria = Console.ReadLine();
            switch (aukeratuEdaria)
            {
                case "1":
                    return "Garagardoa";

                case "2":
                    return "Freskagarri";

                case "3":
                    return "Ura";

                case "4":
                    return "Ardo Zuria";

                case "5":
                    return "Ardo tintoa";

                case "6":
                    return "Sagardoa";


                case "7":
                    return "Laranjazko zukua";

                case "8":
                    return "Kafea";

                case "9":
                    return "Tea";

                case "10":
                    return "Ura gasarekin";

                default: 
                    return "Ezezaguna";                
            }

        }

        public static string AukeratuPintxo()
        {
            
            Console.WriteLine("1) Gilda");
            Console.WriteLine("2) Tortilla");
            Console.WriteLine("3) Txistorra");
            Console.WriteLine("4) Kroketa");
            Console.WriteLine("5) Holagarro gallega-ra");
            Console.WriteLine("6) Mini Hamburgesa");
            Console.WriteLine("7) Gazta");
            Console.WriteLine("8) Antxoa");
            Console.WriteLine("9) Mairu pintxoa");
            Console.WriteLine("10) Perretxikuak");
            Console.WriteLine("Aukeratu> ");

            string aukeraPintxo = Console.ReadLine()!;
            switch (aukeraPintxo)
            {
                case "1":
                    return "Gilda";
                
                case "2":
                    return "Tortilla";

                case "3":
                    return "Txistorra";

                case "4":
                    return "Kroketa";

                case "5":
                    return "Holagarro gallega-ra";

                case "6":
                    return "Mini hamburgesa";
                
                case "7":
                    return "Gazta";

                case "8":
                    return "Antxoa";

                case "9":
                    return "Mairu pintxoa";

                case "10":
                    return "Perretxikuak";

                default:
                    return "Ezezaguna";
            }
        }

        public static string AukeratuGozoak()
        {
            
            Console.WriteLine("1) Croissant");
            Console.WriteLine("2) Muffin");
            Console.WriteLine("3) Brownie");
            Console.WriteLine("4) Gaileta");
            Console.WriteLine("5) Donut");
            Console.WriteLine("6) Gaztako tarta");
            Console.WriteLine("7) Pasteltxoa");
            Console.WriteLine("8) Txokolatea");
            Console.Write("Aukeratu> ");

            string? aukeraPintxo = Console.ReadLine();         // HEMEN SARTU BEHARKO DITUT GUZTIAK
            
            switch (aukeraPintxo)
            {
                case "1":
                    return "Croissant";

                case "2":
                    return "Muffin";

                case "3":
                    return "Brownie";
                
                case "4":
                    return "Gaileta";

                case "5":
                    return "Donut";

                case "6":
                    return "Gaztako tarta";

                case "7":
                    return "pasteltxoa";
                
                case "8":
                    return "Txokolatea";

                default: 
                    return "Ezezaguna";
            }
        }


    }
}
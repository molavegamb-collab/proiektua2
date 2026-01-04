using System.Runtime.CompilerServices;
namespace TxokoArgi
{
    public class Menua    // Hemen egongo da gehiena
    {
        private List<Eskaera> eskaerak;

        private string? mota;
        private string? produktua;

        public Menua(List<Eskaera> eskaerakLista)
        {
            this.eskaerak = eskaerakLista;
            this.mota = null;
            this.produktua = null;
        }

        public void HasierakoMenua()
        {
            Console.Clear();
            Console.WriteLine(  "=====================================");
            Console.WriteLine("   TXOKO ARGIA  -  JARAUTAKO TABERNA   ");
            Console.WriteLine(  "=====================================");

            Console.WriteLine("1) Eskaera bat");
            Console.WriteLine("2) Ikusi lehenago egin diren eskaerak");
            Console.WriteLine("3) Atera");
            Console.WriteLine("4) Azpi menua (kudeaketa)");

            Console.Write("Erantzuna> "); // BErriz txukunago gelditzeko

            string? mezua = Console.ReadLine();
            int erantzuna = mezua != null ? int.Parse(mezua) : 0;

            switch (erantzuna)
            {
                case 1:
                    EskaerakSortu();
                    break;
                
                case 2:
                    IkusiEskaerak();
                    break;

                case 3:
                    Irten();
                    break;

                case 4:
                    AzpiMenu();
                    break;
                    
                default:
                    Console.WriteLine("[!] Aukera baliogabea, saiatu berriro");
                    break;

            }

        }

        private void EskaerakSortu() // Funtizoetan banatzen dut
        {
            Console.Clear();
            Console.WriteLine("[+] Sortu eskaera berri bat:");

            Console.Write("[+] bezeroaren izena sartu: ");
            string? izena = Console.ReadLine();

            // mota aukeratu

            Console.WriteLine("\nEskaera mota");
            Console.WriteLine("1) Edaria");
            Console.WriteLine("2) Pintxo");
            Console.WriteLine("3) Edaria eta Pintxo");
            Console.WriteLine("4) Gozoak");
            Console.Write("Erantzuna> ");

            string? aukeraEskaera = Console.ReadLine();
            
            if (aukeraEskaera == "1")
            {
                mota = "Edaria";
                produktua = Aukerak.AukeratuEdaria();

            }

            else if (aukeraEskaera == "2")
            {
                mota = "Pintxo";
                produktua = Aukerak.AukeratuPintxo();
            }

            else if (aukeraEskaera == "3")
            {
                mota = "Edaria eta pintxo";
                string edaria = Aukerak.AukeratuEdaria();
                string pintxo = Aukerak.AukeratuPintxo();
                produktua = edaria + pintxo;
            }

            else if (aukeraEskaera == "4")
            {
                mota = "Gozoak";
                produktua = Aukerak.AukeratuGozoak();
            }
            else
            {
                mota = "Ezezaguna";
                produktua = "Ezezaguna";
            }

            Console.Write("Kopurua sartu: ");
            int kopurua;
            while (!int.TryParse(Console.ReadLine(), out kopurua) || kopurua < 1)
            {
                Console.WriteLine("Sartu balio egoki bat");
            }

            Eskaera berria = new Eskaera(izena ?? "Ezezaguna", mota, produktua, kopurua);

            eskaerak.Add(berria);

            Console.WriteLine("\n [+] Eskaera gorde da");
            Console.WriteLine("Sakatu ENTER menu-ra itzultzeko...");
            Console.ReadLine();
        }  

        public void IkusiEskaerak()
        {
            Console.Clear();
            Console.WriteLine("======== EGINDAKO ESKAERAK ==========");

            if (eskaerak.Count == 0)
            {
                Console.WriteLine("\n[!] Oraindikan ez dira eskaerak egin");
                Console.WriteLine("\nSakatu ENTER menu-ra itzultzeko...");
                Console.ReadLine();
                return;
            }

            int i = 1;
            foreach (Eskaera e in eskaerak)  //Eskaerak lista rekorritzen du eta buelta bakoitzean 'e' eskaera desberdin bat errepresentzatzen
            {
                Console.WriteLine($"{i}. Bezeroa: {e.getIzena()}");
                Console.WriteLine($" Mota: {e.getMota()}");
                Console.WriteLine($" Produktua: {e.getProduktua()}");
                Console.WriteLine($" Kopurua: {e.getKopurua()}");
                i++;             
            }

            Console.WriteLine("\nSakatu ENTER menura itzultzeko...");
            Console.ReadLine();
        }



        public void Irten()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("  MILA ESKER ETORTZEAGATIK ");
            Console.WriteLine("===========================");
        
        
            Console.WriteLine($"Gaur guztira egin dituzu {eskaerak.Count} eskeaera");

            // Balorazioa

            
            int balorazioa;
            Console.Write("Mesedez baloratu gure zerbitzua 1etik 5era: ");
            
            while (!int.TryParse(Console.ReadLine(), out balorazioa) || balorazioa < 1 || balorazioa > 5){

                Console.Write("[!] Sartu balio bat 1 eta 5 artean mesedez: ");
                
            }

            if (balorazioa == 1 || balorazioa == 2)
            {
                Console.WriteLine("[+] Eskerrikasko etortzeagatik, hobetzen saiatuko gara");
            }
            else if (balorazioa == 3)
            {
                Console.WriteLine("[+] Eskerrikasko etortzeagatik, hobetzen saiatuko gara");
            }

            else
            {
                Console.WriteLine("[+] Eskerrikasko, pozten gara gustatu zaizula");
            }

            Console.WriteLine("\nSakatu ENTER jarraitzeko...");
            Console.ReadLine();
            Environment.Exit(0);

        }

        

        public void AzpiMenu()
        {
            int aukera = 0;
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("     AZPI - MENUA        ");
            Console.WriteLine("=========================");

            Console.WriteLine("1) Begiratu eskaerak");
            Console.WriteLine("2) Aldatu edariak");
            Console.WriteLine("3) Aldatu Pintxoak");
            Console.WriteLine("4) Aldatu gozoak");
            Console.WriteLine("5) Prezioak erakutsi");
            Console.WriteLine("6) Joan ordainketara");
            Console.WriteLine("7) Joan menu nagusira");

            Console.Write("Aukeratu> ");

            string? azpimenu = Console.ReadLine();
            int azpimenu_erantzuna = azpimenu != null ? int.Parse(azpimenu) : 0;

            switch (azpimenu_erantzuna)
            {
                case 1:
                    IkusiEskaerak();
                    break;

                case 2:
                    AldatuEdaria();
                    break;

                case 3:
                    AldatuPintxoa();
                    break;

                case 4:
                    AldatuGozoak();
                    break;

                case 5:
                    Prezioak();
                    break;

                case 6:
                    Console.WriteLine("Ordaintzen...");
                    Console.WriteLine("\n[+] Ordainduta!");
                    Console.ReadLine();
                    break;

                case 7:
                    return;

                default:
                    Console.WriteLine("[!] Aukera okerra, saiatu berriz");
                    break;
            }

            Console.WriteLine("\nSakatu ENTER jarraitzeko...");
            Console.ReadLine();

        }  

        public void AldatuEdaria()
        {
            Console.Clear();
            Console.WriteLine("======== ALDATU EDARIAK ==========");

            if (eskaerak.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("[!] Ez dago eskaerarik");
                return;
            }

            for (int i = 0; i < eskaerak.Count; i++)
            {
                Eskaera e = eskaerak[i];
                Console.WriteLine($"{i + 1}. {e.getIzena()}, {e.getProduktua()}, ({e.getMota()})");
            }
            Console.Write("Zein aldatu nahi duzu?");
            int aukera = int.Parse(Console.ReadLine()!);


            string berria = Aukerak.AukeratuEdaria();
            Eskaera hautatuta = eskaerak[aukera - 1];
            hautatuta.setProduktua(berria);
            hautatuta.setMota("Edaria");

            Console.WriteLine("\n[+] Dena ongi joan da, aldaketak gorde dira");
            
                       
        }

        public void AldatuPintxoa()
        {
            Console.Clear();
            Console.WriteLine("=== ALDATU PINTXOAK ===");    

            if (eskaerak.Count == 0)
            {
                Console.WriteLine("[!] Ez dago eskaerarik");
                return;
            }

            for (int i = 0; i < eskaerak.Count; i++)
            {
                Eskaera e = eskaerak[i];
                Console.WriteLine($"{i + 1}. {e.getIzena()}, {e.getProduktua()}, ({e.getMota()})");
            }
            Console.Write("Zein aldatu nahi duzu (1, 2, 3...)? ");
            int aukera = int.Parse(Console.ReadLine()!);

            string berria = Aukerak.AukeratuPintxo();
            Eskaera hautatuta = eskaerak[aukera - 1];
            hautatuta.setProduktua(berria);
            hautatuta.setMota("Pintxo");


            Console.WriteLine("Dena ongi joan da, aldaketak gorde dira"); 

        }

        public void AldatuGozoak()
        {
            Console.Clear();
            Console.WriteLine("=== ALDATU GOZOAK ===");

            if (eskaerak.Count == 0)
            {
                Console.WriteLine("[!] Ez dago eskaerarik");
                return;
            }

            for (int i = 0; i < eskaerak.Count; i++)
            {
                Eskaera e = eskaerak[i];
                Console.WriteLine($"{i + 1}. {e.getIzena()}, {e.getProduktua()}, ({e.getMota()})");
            }

            Console.WriteLine("Zein aldatu nahi duzu (1, 2, 3...)? ");
            int aukera = int.Parse(Console.ReadLine()!);

            string berria = Aukerak.AukeratuGozoak();
            Eskaera hautatuta = eskaerak[aukera - 1];
            hautatuta.setProduktua(berria);
            hautatuta.setMota("Gozoak");


            Console.WriteLine("Dena ongi joan da, aldaketak gorde dira");        
        } 
        


        public void Prezioak()
        {
            Console.Clear();
            Console.WriteLine("=== PREZIOAK ===");

            if (eskaerak.Count == 0)
            {
                Console.WriteLine("[!] Hemen ez dago eskaerarik");
                Console.ReadLine();
                return;
            }

            double totala = 0;

            foreach (Eskaera e in eskaerak)
            {
                double prezioa = 0;

                if (e.getMota() == "Edaria")
                    prezioa = 2.5;

                else if (e.getMota() == "Pintxo")
                    prezioa = 3.0;

                else if (e.getMota() == "Gozoak")
                    prezioa = 2.0;

                else if (e.getMota() == "Edaria eta pintxo")
                    prezioa = 5.0;


                double guztira = prezioa * e.getKopurua();
                totala += guztira;

                Console.WriteLine($"{e.getIzena()}, {e.getMota()} x{e.getKopurua()} = {guztira}€");

            }

            Console.WriteLine("--------------------");
            Console.WriteLine($"GUZTIRA: {totala} €");

            Console.WriteLine("\nSakatu ENTER jarraitzeko...");
            Console.ReadLine();

        }
    } 
}    
            







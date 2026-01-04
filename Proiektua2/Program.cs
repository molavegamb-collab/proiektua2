namespace TxokoArgi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eskaera> eskaerak = new List<Eskaera>();
            Menua menu = new Menua(eskaerak);

            while ( 0 != 1)
            {
                menu.HasierakoMenua(); // Hemen deitzen dut hasierako menu-ra
            }
            
        
        }
    }

}

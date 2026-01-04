namespace TxokoArgi
{
    public class Eskaera
    {
        private string izena;
        private string mota;
        private string produktua;
        private int kopurua;

        public Eskaera(string izena, string mota, string produktua, int kopurua)
        {
        
            this.izena = izena;          // "this" hau baliatuko dugu goian definitutako atributeei deitzeko
            this.mota = mota;
            this.produktua = produktua;
            this.kopurua = kopurua;
    }


        // Hemen geter eta seter metodoak egingo ditugu:
        public string getIzena()
        {
            return izena;
        }
    
        public string getMota()
        {
            return mota;
        }
        public string getProduktua()
        {
            return produktua;
        }
        public int getKopurua()
        {
            return kopurua;
        }   


        public void setProduktua(string berria)
        {
            produktua = berria;
        }

        public void setMota(string berria)
        {
            mota = berria;
        }

    
        }   
    }
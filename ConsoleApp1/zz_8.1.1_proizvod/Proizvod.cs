namespace zz_8._1._1_proizvod
{
    internal class Proizvod
    {
        public string Naziv = "";
        public double Cijena;
        public double Marza;
        public double Porez;

        internal double MaloprodajnaCijena()
        {
            double mpc = 0;
            mpc = (double)(Cijena + Marza + Porez);

            return mpc;
           
        }



    }
}
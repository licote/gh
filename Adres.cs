namespace AplikacjaPracownicy
{
    public class Adres
    { 
        private string ulica = "";
        private string miasto = "";
        private string numerDomu = "";

        public string Ulica { get => ulica; set => ulica = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string NumerDomu { get => numerDomu; set => numerDomu = value; }

        public Adres() {}
        
        public Adres(string ulica, string miasto, string numerDomu) {
            this.ulica = ulica;    
            this.miasto = miasto;
            this.numerDomu = numerDomu;
        }

        public Adres(Adres adres) {
            this.ulica = adres.ulica;
            this.miasto = adres.miasto;
            this.numerDomu = adres.numerDomu;
        }

        public override string ToString()
        {
            return this.ulica + " " + this.numerDomu + " " + this.miasto;
        }
    }
}
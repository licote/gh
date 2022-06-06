namespace AplikacjaPracownicy
{
    public class Data
    {
        private int dzien;
        private string miesiac;
        private int rok;
        
        public static readonly string[] miesiace = {"styczen", "luty", "marzec", 
                                                    "kwiecien", "maj", "czerwiec", 
                                                    "lipiec", "sierpien", "wrzesien",
                                                    "pazdziernik", "listopad", "grudzien"};

        public int Dzien { get => dzien; set => dzien = value; }
        public string Miesiac { get => miesiac; set => miesiac = value; }
        public int Rok { get => rok; set => rok = value; }

        public Data() {
            dzien = 0;
            miesiac = "";
            rok = 0;
        }

        public Data(int dzien, string miesiac, int rok)
        {
            this.dzien = dzien;
            this.miesiac = miesiac;
            this.rok = rok;
        }
        public Data(Data data) {
            this.dzien = data.dzien;
            this.miesiac = data.miesiac;
            this.rok = data.rok;
        }

        public override string ToString()
        {
            return this.Dzien + " " + this.Miesiac + " " + this.Rok;
        }
        public static string zwrocMiesiac(int miesiac) {
            if(miesiac > 11 || miesiac < 0) return "n/a";
            return miesiace[miesiac];
        }
    }
}
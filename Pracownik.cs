namespace AplikacjaPracownicy
{
    public class Pracownik
    {
        string imie = " ";
        string nazwisko = " ";
        Data dataUrodzenia = new Data(0, "", 0);
        Adres adresZamieszkania = new Adres("", "", "");

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public Data DataUrodzenia { get => dataUrodzenia; }
        public Adres AdresZamieszkania { get => adresZamieszkania; }
        public Zawod zawod { get => Zawod.Pracownik;}

        public Pracownik() { }

        public Pracownik(string imie, string nazwisko, Data dataUrodzenia, Adres adresZamieszkania) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.adresZamieszkania = adresZamieszkania;
        }
        
        public Pracownik(Pracownik pracownik) {
            this.imie = pracownik.imie;
            this.nazwisko = pracownik.nazwisko;
            this.dataUrodzenia = pracownik.dataUrodzenia;
            this.adresZamieszkania = pracownik.adresZamieszkania;
        }

        public override string ToString()
        {
            return this.imie + " " + this.nazwisko + " " + this.dataUrodzenia + " " + this.adresZamieszkania;
        }

        public virtual string FormatWyjsciowy() {
            return "Imie, nazwisko: " + this.imie + " " + this.nazwisko + 
            "\n" + "Data urodzenia: " + this.dataUrodzenia + 
            "\n" + "Adres zamieszkania: " + this.adresZamieszkania;
        }
        public virtual Pracownik Clone() {
            return this;
        }

        public virtual string SzczegolyZawodu() {
            return "brak";
        }

        public string DataToString() {
            return this.dataUrodzenia.ToString();
        }
        
        public string AdresToString() {
            return this.adresZamieszkania.ToString();
        }

        public virtual void ZapisConsole() {
            Console.WriteLine("Imie, nazwisko: " + this.imie + " " + this.nazwisko + 
                 "\n" + "Data urodzenia: " + this.dataUrodzenia +
                 "\n" + "Adres zamieszkania: " + this.adresZamieszkania + "\n");
        }

        public virtual void OdczytConsole() {
            Console.WriteLine("Podaj dane(Imie, Nazwisko, DD, MM, YYYY, Ulica, nrDomu, Miasto): \n ");
            string[] s = Console.ReadLine().Split(' ');
            
            this.imie = s[0];
            this.nazwisko = s[1];
            this.dataUrodzenia.Dzien = int.Parse(s[2]);
            this.dataUrodzenia.Miesiac = Data.zwrocMiesiac(int.Parse(s[3]) - 1);
            this.dataUrodzenia.Rok = int.Parse(s[4]);
            this.adresZamieszkania.Ulica = s[5];
            this.adresZamieszkania.NumerDomu = s[6];
            this.adresZamieszkania.Miasto = s[7];
        }
     }
}
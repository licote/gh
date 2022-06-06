namespace AplikacjaPracownicy
{
    public class Sortowanie
    {
        public class PoNazwisku : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y) {
                return x.Nazwisko.CompareTo(y.Nazwisko);
            }
        }
        public class PoImieniu : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y) {
                return x.Imie.CompareTo(y.Imie);
            }
        }
        public class PoUlicy : IComparer<Pracownik>
        {
            public int Compare(Pracownik x, Pracownik y) {
                return x.AdresZamieszkania.Ulica.CompareTo(y.AdresZamieszkania.Ulica);
            }
        }
    }
}
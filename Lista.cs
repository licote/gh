using System.Collections.Generic;

namespace AplikacjaPracownicy
{
    public class Lista
    {
        List<Pracownik> lista = new List<Pracownik>();

        public Lista() { }

        public void Dodaj(Pracownik pracownik) {
            lista.Add(pracownik.Clone());
        }

        public void WstawWPolozenie(int index, Pracownik pracownik){
            lista.Insert(index, pracownik.Clone());
        }

        public int Usun(string nazwisko) {
            int index = lista.IndexOf(lista.Find(p => p.Nazwisko.Equals(nazwisko)));
            lista.RemoveAt(index);
            return index == -1 ? -1 : index;
        }

        void Usun(int index) {
            lista.RemoveAt(index);
        }

        public Pracownik Szukaj(string nazwisko) {
            Pracownik pracownik = lista.Find(p => p.Nazwisko.Equals(nazwisko));
            return pracownik == null ? null : pracownik;
        }   

        public void Sortuj(IComparer<Pracownik> ic) {
            lista.Sort(ic);
        }

        public void Wyczysc() {
            lista.Clear();
        }

        public void ZapisConsole(){
            foreach(Pracownik p in lista) {
                p.ZapisConsole();
            }
        }
        public void OdczytConsole() {
            Pracownik p = new Pracownik();
            p.OdczytConsole();
            lista.Add(p);
        }

    }
}
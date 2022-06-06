namespace AplikacjaPracownicy
{
    class Aplikacja
     {         
        static void Main(string[] args)
        {
            string s = "##################################################";
            Pracownik pracownik1 = new Pracownik("Jakub",
                                              "Trytytkiewicz",
                                              new Data(13, Data.zwrocMiesiac(3), 1997),
                                              new Adres("Zlota", "Rzeszow", "13"));

            Pracownik pracownik2 = new Pracownik("Wojciech",
                                                "Gola",
                                                new Data(29, Data.zwrocMiesiac(1), 2016),
                                                new Adres("Gruba", "Krakow", "33"));
            Pracownik pracownik3 = new Pracownik("Naapada",
                                                "Nabang",
                                                new Data(29, Data.zwrocMiesiac(10), 1337),
                                                new Adres("Polna", "Milan", "69"));
            Lista lista = new Lista();

            lista.Dodaj(pracownik1);
            lista.Dodaj(pracownik2);
            lista.Dodaj(pracownik3);

            IComparer<Pracownik> ic = new Sortowanie.PoUlicy();
            lista.Sortuj(ic);
            //lista.ZapisConsole();
            //Console.WriteLine(s);

            ic = new Sortowanie.PoImieniu();
            lista.Sortuj(ic);
            //lista.ZapisConsole();
            //Console.WriteLine(s);

            lista.WstawWPolozenie(0, pracownik1);
            //lista.ZapisConsole();
            //Console.WriteLine(s);

            //lista.OdczytConsole();
            //lista.ZapisConsole();

            //lista.Wyczysc();
            //lista.ZapisConsole();
            //Console.WriteLine(s);

            //Pracownik p = lista.Szukaj("Gola");
            //p.ZapisConsole();

            //lista.ZapisConsole();
            //lista.Usun("Trytytkiewicz");
            //lista.ZapisConsole();

        }
    }
}
using System;

class clasy
{
    class Ksiazka
{
    public string tytul { get; set; }
    public string autor { get; set; }
    public int rok_wydania { get; set; }
    public int liczba_stron { get; set; }
    public Ksiazka(string tytul, string autor, int rok_wydania, int liczba_stron)
    {
        this.tytul = tytul;
        this.autor = autor;
        this.rok_wydania = rok_wydania;
        this.liczba_stron = liczba_stron;
    }
    public void wyswietlinformacje()
    {
        Console.WriteLine($"Tytul: {tytul}, Autor:  {autor}, rok wydania: {rok_wydania}, liczba stron: {liczba_stron} ");

    }
        public void edytujdane(string nowy_tytul, string nowy_autor, int nowy_rok_wydania, int nowa_liczba_stron)
        {
            this.tytul = nowy_tytul;
            this.autor = nowy_autor;
            this.rok_wydania = nowy_rok_wydania;
            this.liczba_stron = nowa_liczba_stron;
        }
    }
    
    static void Main(string[] args)
    {
        Ksiazka ksiazka = new Ksiazka("Dziady", "A. Mickiweicz", 1823, 400);
        ksiazka.wyswietlinformacje();
        Console.WriteLine("podaj nowy tytul");
        string nowy_tytul=Console.ReadLine();
        Console.WriteLine("podaj nowego autora");
        string nowy_autor= Console.ReadLine();
        Console.WriteLine("podaj nowy rok wydania");
        int nowy_rok_wydania = int.Parse(Console.ReadLine());
        Console.WriteLine("podaj nowa liczbe stron");
        int nowa_liczba_stron = int.Parse(Console.ReadLine());
        ksiazka.edytujdane(nowy_tytul, nowy_autor, nowy_rok_wydania, nowa_liczba_stron);
        ksiazka.wyswietlinformacje();
    }
}
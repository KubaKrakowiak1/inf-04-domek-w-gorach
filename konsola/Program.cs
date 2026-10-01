class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj x:");
        int szukana = int.Parse(Console.ReadLine());
        int[] tab = new int[50];

        Wypelnij(tab, szukana);
        foreach (int i in tab)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(Szukaj(szukana, tab));
    }

    static void Wypelnij(int[] tab, int szukanaLiczba)
    {
        Random rnd = new();

        for(int i = 0;  i < tab.Length; i++)
        {
            int liczba = rnd.Next(1, 101);
            tab[i] = liczba;
        }
        tab[tab.Length - 1] = szukanaLiczba;
    }

    static string Szukaj(int szukanaLiczba, int[] tab)
    {
        int indeks = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] == szukanaLiczba)
            {
                indeks = i;
                break;
            }
        }
        Console.WriteLine();
        foreach(int i in tab)
        {
            Console.Write($"{i},");
        }
        Console.WriteLine("");
        Console.WriteLine("Indeks: ");
        return indeks.ToString();
    }
}
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main (string[] args)
    {
        int los;
        int n = 20;
        int min = 0;
        int max = 0;
        int srednia = 0; 
        int suma = 0;
        int[] tab = new int[n];

        for(int i = 0; i < n; i++)
        {

            Random losowa = new Random();
            los = losowa.Next(1,100);
            /* Console.WriteLine(los); */
            tab[i] = los;
            Console.WriteLine($"{tab[i]}");
            suma += tab[i];
            if ( i == 0)
            {
                min = tab[i];
                max = tab[i];
            }
            else
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
        }

        Console.WriteLine($"Suma: {suma}");
        srednia = suma / n;
        Console.WriteLine($"Srednia: {srednia}");
        Console.WriteLine($"Wartość minimalna: {min}");
        Console.WriteLine($"Wartość maksymalna: {max}");



    }




}
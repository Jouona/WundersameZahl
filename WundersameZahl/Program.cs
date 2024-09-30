namespace WundersameZahl;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("WundersameZahl" + Environment.NewLine);
        Console.WriteLine("Willst du den manuellen Modus benutzen?");

        IMode mode;
        ISort sort = new BubbleSort();

        bool manual = Helpers.Abfrage();
        if (manual) {
            mode = new ManualMode();
                
        }
        else {
            Console.WriteLine("Wo soll der QuickMode beginnen?");
            int begin = Helpers.IntEingabeLesen();
            Console.WriteLine("Wo soll der QuickMode enden?");
            int end = Helpers.IntEingabeLesen();

            mode = new QuickMode(begin, end);
        }

        mode.Run(AnzahlSchritteBerechnen);
        sort.Sort(mode.Results);

        Console.WriteLine();
        Console.WriteLine("Von allen Results ist der kürzeste Durchlauf bei " + mode.Results[0] + " Durchläufen.");
    }

    static int AnzahlSchritteBerechnen(int ausgangszahl) {
        int counter = 0;
        while (ausgangszahl != 1) {
            counter++;

            if (ausgangszahl % 2 == 0) {
                ausgangszahl /= 2;
            }
            else {
                ausgangszahl *= 3;
                ausgangszahl++;
            }
        }

        return counter;
    }
}
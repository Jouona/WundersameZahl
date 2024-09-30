namespace WundersameZahl;

public interface IMode {
    List<int> Results { get; }
    void Run(Func<int, int> schritteBerechnen);
}

public class ManualMode : IMode {
    public List<int> Results { get; } = new();

    public void Run(Func<int, int> schritteBerechnen) {
        do {
            Console.WriteLine("Ausgangszahl eingeben: ");
            Results.Add(schritteBerechnen(Helpers.IntEingabeLesen()));
            Console.WriteLine("Willst du noch eine Zahl eingeben?");
        } while (Helpers.Abfrage());
    }
}

public class QuickMode : IMode {
    public List<int> Results { get; } = new();

    int end;
    int begin;

    public QuickMode(int begin, int end) {
        this.end = end;
        this.begin = begin;
    }

    public void Run(Func<int, int> schritteBerechnen) {
        for (; begin < end; begin++) {
            Results.Add(schritteBerechnen(begin));
        }
    }
}
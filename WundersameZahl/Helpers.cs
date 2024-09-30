namespace WundersameZahl;

public class Helpers {
    public static int IntEingabeLesen(bool allowZeroAndNegative = false) {
        int ausgangszahl = 0;
        try {
            ausgangszahl = Convert.ToInt32(Console.ReadLine());
            if (!allowZeroAndNegative && ausgangszahl <= 0) {
                throw new Exception("Cant be zero or negative");
            }
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            return IntEingabeLesen();
        }

        return ausgangszahl;
    }

    public static bool Abfrage() {
        Console.WriteLine("y/n");
        char yOrN = Convert.ToChar(Console.ReadLine());
        if (yOrN == 'y') {
            return true;
        }
        else if (yOrN == 'n') {
            return false;
        }
        else {
            Console.WriteLine("Korrekte Eingabe erforderlich");
            return Abfrage();
        }
    }
}
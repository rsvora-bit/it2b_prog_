class Program
{
    static void Main()
    {
        Utok kopnuti = new Utok("Kopnuti", 10);
        Utok kousnuti = new Utok("Kousnuti", 15);
        Utok placnuti = new Utok("Placnuti", 8);
        Utok megaUder = new Utok("Mega uder", 20);

        Cichnamon cichnak = new Cichnamon("Cichnak", 100, kopnuti, megaUder);
        Cichnamon brnak = new Cichnamon("Brnak", 90, placnuti, kousnuti);
        Cichnamon ajtak = new Cichnamon("Ajtak", 80, kopnuti, kousnuti);

        Console.WriteLine("Zadej jmeno trenera:");
        string jmeno = Console.ReadLine();

        Trener hrac = new Trener(jmeno);

        hrac.PridatCichnamona(cichnak);
        hrac.PridatCichnamona(brnak);
        hrac.PridatCichnamona(ajtak);

        Console.WriteLine("Tvoji Cichnamoni:");
        hrac.VypisCichnamony();

        Console.WriteLine("Vyber Cichnamona:");
        int volba = int.Parse(Console.ReadLine());

        hrac.VyberCichnamona(volba);

        Console.WriteLine("Vybral sis:");
        hrac.Vybrany.VypisInfo();

        Cichnamon protivnik = new Cichnamon("Nepritel", 100, placnuti, megaUder);

        Console.WriteLine("Protivnik:");
        protivnik.VypisInfo();

        ---------
    }
}
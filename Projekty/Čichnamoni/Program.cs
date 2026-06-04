class Program
{
    static void Main()
    {
        bool zapnuto = true;

        while (zapnuto)
        {
            Console.WriteLine("---- Cichnamoni ----");
            Console.WriteLine("1) Hrat");
            Console.WriteLine("2) Konec");

            int volbaMenu = int.Parse(Console.ReadLine());

            if (volbaMenu == 1)
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

                Console.WriteLine("Vyber si Cichnamona:");
                hrac.VypisCichnamony();

                int volba = int.Parse(Console.ReadLine());
                hrac.VyberCichnamona(volba);

                Cichnamon protivnik = new Cichnamon("Nepritel", 100, placnuti, megaUder);

                bool leceni = true;

                while (hrac.Vybrany.JeNazivu() && protivnik.JeNazivu())
                {
                    Console.WriteLine("Tvuj stav:");
                    hrac.Vybrany.VypisInfo();

                    Console.WriteLine("Protivnik:");
                    protivnik.VypisInfo();

                    Console.WriteLine("Vyber akci:");
                    Console.WriteLine("1) Zakladni utok");
                    Console.WriteLine("2) Specialni utok");
                    Console.WriteLine("3) Leceni");

                    int akce = int.Parse(Console.ReadLine());

                    if (akce == 1)
                    {
                        hrac.Vybrany.Zautoc(protivnik);
                    }
                    else if (akce == 2)
                    {
                        hrac.Vybrany.SpecialniZautoc(protivnik);
                    }
                    else if (akce == 3)
                    {
                        if (leceni)
                        {
                            hrac.Vybrany.Uzdrav(20);
                            leceni = false;
                            Console.WriteLine("Cichnamon se vylecil");
                        }
                        else
                        {
                            Console.WriteLine("Leceni uz bylo pouzito");
                        }
                    }

                    if (protivnik.JeNazivu())
                    {
                        protivnik.Zautoc(hrac.Vybrany);
                    }
                }

                if (hrac.Vybrany.JeNazivu())
                {
                    Console.WriteLine("Vyhral jsi");
                    hrac.ZvysLevel();
                    Console.WriteLine("Level trenera: " + hrac.Level);
                }
                else
                {
                    Console.WriteLine("Prohral jsi");
                }
            }
            else if (volbaMenu == 2)
            {
                zapnuto = false;
            }
        }

        Console.WriteLine("Hra byla ukoncena");
    }
}
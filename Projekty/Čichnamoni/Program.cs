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
                Utok zbytecnaOtazka = new Utok("Zbytecna otazka", 10);
                Utok prepadovka = new Utok("Prepadovka", 20);

                Utok hadani = new Utok("Hadani", 8);
                Utok pisemka = new Utok("Pisemka", 15);

                Utok malta = new Utok("Malta", 10);
                Utok brnoTU = new Utok("BrnoTU", 15);

                Cichnamon grosik = new Cichnamon("Grosik", 100, zbytecnaOtazka, prepadovka);
                Cichnamon panM = new Cichnamon("Pan M", 90, hadani, pisemka);
                Cichnamon prokorny = new Cichnamon("Prokorny", 80, malta, brnoTU);

                Console.WriteLine("Zadej jmeno trenera:");
                string jmeno = Console.ReadLine();

                Trener hrac = new Trener(jmeno);

                hrac.PridatCichnamona(grosik);
                hrac.PridatCichnamona(panM);
                hrac.PridatCichnamona(prokorny);

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
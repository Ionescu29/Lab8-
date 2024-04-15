// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Un tren este compus din: o locomotiva si mai multe tipuri de vagoane
class Tren
{
    //Trenul va avea un nume precum si urmatoarele metode
    private string nume;
    public Tren (string nume)
    {
        this.nume = nume;
    }
    //Adauga vagon: Aceasta metoda va permite adaugarea vagoanelor la tren
    public void AdaugaVagon()
    {
        Console.WriteLine($"se pot adauga vagoane");
    }
    //Pleaca din gara: La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni locomotiva
    public void PleacaDinGara()
    {
        Console.WriteLine($"trenul va pleca din gara");
    }
    // Opreste in gara: La aceasta comanda, trenul va opri locomotiva,
    // va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1 
    public void OpresteInGara()
    {
        Console.WriteLine($"trenul va orpi in gara");
    }
}
class Locomotiva: Tren 
{
    // Locomotiva va avea
    //O metoda de pornire, la apelul careia,
    //aceasta va confirma faptul ca a pornit printr-un mesaj afisat in consola, 
    public void Pornire()
    {
        Console.WriteLine($"locomotiva a pornit");
    }
    //O metoda de oprire, la apelul careia,
    //aceasta va confirma faptul ca a oprit printr-un mesaj afisat in consola,
    public void Oprire()
    {
        Console.WriteLine($"Locomotiva s-a oprit");
    }
}
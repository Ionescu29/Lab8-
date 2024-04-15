using Lab8Ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab8Ex1
{
    //Vagoanele vor avea masa si anul fabricatiei si vor fi de mai multe tipuri
    internal class Vagoane
    {
        private int masa;
        private int andefabricatie;
        public Vagoane(int masa, int andefabricatie)
        {
            this.masa = masa;
            this.andefabricatie = andefabricatie;
        }
    }
}
//Vagoane de marfa, care vor avea tipul marfii (cereale/carbuni/otel) precum si capacitatea in tone
class VagoaneDeMarfa: Vagoane
{
    private string tipulmarfii;
    private int capacitate;
    public Vagoanemarfa(string tipulmarfii, int capacitate)
    {
        this.tipulmarfii = tipulmarfii;
        this.capacitate = capacitate;
    }
}
//Vagoane pentru persoane, care vor avea numar de locuri
class VagoaneDePersoane: Vagoane
{
    private int numardelocuri;
    public VagoaneDePersoane(int numardelocuri)
    {
        this.numardelocuri = numardelocuri;
    }
    //O metoda care va inchide usile si va confirma in consola inchiderea usilor
    public void InchideUsile()
    {
        Console.WriteLine($"se vor inchide usile");
    }
    //O metoda care va deschide usile si va confirma in consola deschiderea usilor
    public void DeschideUsile()
    {
        Console.WriteLine($"se vor deschide usile");
    }
}
//Vagoane clasa I, pentru persoane

class VagoaneClasaI : Vagoane
{
    //O metoda de pornire a aerului conditionat care va afisa acest lucru pe ecran
    public void AerConditioant()
    {
        Console.WriteLine($"Se porneste aerul conditionat");
    }
    //O metoda de oprire a aerului conditionat care va afisa acest lucru pe ecran
    public void OprireAC()
    {
        Console.WriteLine($"SE opreste aerul codnitionat");
    }
}
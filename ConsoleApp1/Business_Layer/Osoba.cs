using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
public abstract class Osoba

{
    public DateTime datumNastanka;
    public string prezime = "";
    private string ime = "";

    public string Ime
    {
        get => ime;
        set => ime = ToUpper.FirstCharToUpper(value);
    }

    public Osoba()
    {
        this.datumNastanka = DateTime.Now;
        Console.WriteLine("Pozvana metoda Osoba:Osoba()");
    }

    protected Osoba(string v1, string v2)
    {
        this.ime = v1;
        this.prezime = v2;
    }
}
}
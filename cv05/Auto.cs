using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Auto
{
    public enum TypPaliva { Benzin, Nafta };
    public TypPaliva typPaliva { get; protected set; }
    public int Palivo { get; protected set; }
    public int VelkostNadrze { get; protected set; }

    private Autoradio radio = new Autoradio();

    public void Natankuj(TypPaliva typPaliva, int mnozstvo)
    {
        if (typPaliva == this.typPaliva && mnozstvo <= (VelkostNadrze - Palivo))
        {
            Palivo += mnozstvo;
        }
        else
        {
            Console.WriteLine("Neplatny typ paliva alebo neplatny pocet paliva je viac nez sa zmesti");
        }
    }
    protected double StavNadrze
    {
        get
        {
            if (VelkostNadrze == 0) return 0;
            return ((double)Palivo / VelkostNadrze) * 100;
        }
    }

    public void radioshow()
    {
        Console.Write(radio.ToString());
    }

    public void setradio(string xd)
    {
        radio.setRadio(xd);
    }
    public void NastavPredvolbuRadio(int xd)
    {
        radio.NastavPredvolbu(xd);
    }
    public void nastavNaPredvolbuRadio(int xd)
    {
        radio.PreladNaPredvolbu(xd);
    }
    public void setKmitocet(double xd)
    {
        radio.NaladenyKmitocet =xd;
    }
    

}


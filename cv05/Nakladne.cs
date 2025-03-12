using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Nakladne : Auto
    {
        private int MaxNaklad;
        private int PrepravovanyNaklad;


    public Nakladne(TypPaliva typPaliva, int VekostNadrze, int Palivo, int MaxNaklad)
    {
        this.typPaliva = typPaliva;
        this.VelkostNadrze = VekostNadrze;
        this.Palivo = Palivo;
        this.MaxNaklad = MaxNaklad;
        this.PrepravovanyNaklad = 0;
    }
    public override string ToString()
        {

            return $"┌─────────────── NÁKLADNÉ VOZIDLO ───────────────┐\n" +
                   $"│ Typ paliva:            {typPaliva}  │\n" +
                   $"│ Veľkosť nádrže:        {VelkostNadrze} litrov     │\n" +
                   $"│ Stav nadrze:       {StavNadrze:F1} %      │\n" +
                   $"│ Aktualne paliva:       {Palivo} litrov )     │\n" +
                   $"│ Maximálna nosnosť:     {MaxNaklad} kg          │\n" +
                   $"│ Aktuálny náklad:       {PrepravovanyNaklad} kg │\n" +
                   $"└───────────────────────────────────────────────┘";
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Osobne : Auto
    {
        private int MaxOsoby;
        private int PrepravovaneOsoby;

        public void setMaxOsoby(int MaxOsoby)
        {
            this.MaxOsoby = MaxOsoby;
            PrepravovaneOsoby = 0;
        }

        public void setPrepravovaneOsoby(int PrepravovaneOsoby)
        {
            this.PrepravovaneOsoby = PrepravovaneOsoby;
        }

        public Osobne(TypPaliva typPaliva,int VekostNadrze,int Palivo,int MaxOsoby)
    {
        this.typPaliva = typPaliva;
        this.VelkostNadrze = VekostNadrze;
        this.Palivo = Palivo;
        this.MaxOsoby=MaxOsoby;
        this.PrepravovaneOsoby=0;
    }
        public override string ToString()
        {

            return $"┌─────────────── OSOBNÉ VOZIDLO ────────────────┐\n" +
                   $"│ Typ paliva:            {typPaliva} │\n" +
                   $"│ Veľkosť nádrže:        {VelkostNadrze} litrov     │\n" +
                   $"│ Stav nadrze:       {StavNadrze:F1} %     │\n" +
                   $"│ Aktualne palivo:       {Palivo} litrov   │\n" +
                   $"│ Maximálna kapacita:    {MaxOsoby} osôb         │\n" +
                   $"│ Aktuálny počet osôb:   {PrepravovaneOsoby}  │\n" +
                   $"└───────────────────────────────────────────────┘";
        }
    }


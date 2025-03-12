using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Autoradio
    {
        Dictionary<int, double> xdset = new Dictionary<int, double>();
    public double NaladenyKmitocet;
        private bool Radio = false;

        public void setRadio(string setor)
        {
            if (setor == "on")
            {
                Radio = true;
            }
            else if (setor == "off")
            {
                Radio = false;
            }

        }

    public void NastavPredvolbu(int Predvolba)
    {
        xdset[Predvolba] = NaladenyKmitocet;
    }

        public void PreladNaPredvolbu(int Predvolba)
        {
            if (Radio && xdset.ContainsKey(Predvolba))
            {
                NaladenyKmitocet = xdset[Predvolba];
            }
        }
        public override string ToString()
        {

            return $"┌─────────────── Radio ──────────────────────────┐\n" +
                   $"│Autorádio - Stav: {(Radio ? "Zapnuté" : "Vypnuté")}│ \n" +
                   $"│Naladený kmitočet: {NaladenyKmitocet} MHz │\n" +
                   $"└───────────────────────────────────────────────┘\n";
        }
    }

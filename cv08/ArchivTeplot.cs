using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{
    class ArchivTeplot
    {
        private SortedDictionary<int, RocnaTeplota> _archiv = new();

        public void Load(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Soubor {filePath} neexistuje.");
                    return;
                }

                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(':');
                    if (parts.Length != 2)
                    {
                        Console.WriteLine($"Chybný formát řádku: {line}");
                        continue;
                    }

                    if (!int.TryParse(parts[0], out int rok))
                    {
                        Console.WriteLine($"Chybný formát roku: {parts[0]}");
                        continue;
                    }

                    try
                    {
                        var teploty = parts[1].Split(';').Select(t => double.Parse(t.Trim())).ToList();
                        if (teploty.Count != 12)
                        {
                            Console.WriteLine($"Nesprávný počet teplot pro rok {rok}");
                            continue;
                        }
                        _archiv[rok] = new RocnaTeplota(rok, teploty);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Chyba při parsování teplot pro rok {rok}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba při načítání souboru: {ex.Message}");
            }
        }

        public void Save(string filePath)
        {
            using var writer = new StreamWriter(filePath);
            foreach (var rokTeplota in _archiv.Values)
            {
                writer.WriteLine($"{rokTeplota.Rok}: {string.Join("; ", rokTeplota.MesacneTeploty)}");
            }
        }

        public void Kalibrace(double konstanta)
        {
            foreach (var rokTeplota in _archiv.Values)
            {
                for (int i = 0; i < rokTeplota.MesacneTeploty.Count; i++)
                {
                    rokTeplota.MesacneTeploty[i] += konstanta;
                }
            }
        }

        public RocnaTeplota? Vyhledej(int rok) => _archiv.TryGetValue(rok, out var teplota) ? teplota : null;

        public void TiskTeplot()
        {
            foreach (var rokTeplota in _archiv.Values)
            {
                Console.WriteLine($"{rokTeplota.Rok}: {string.Join("; ", rokTeplota.MesacneTeploty)}");
            }
        }

        public void TiskPrumernychRocnichTeplot()
        {
            foreach (var rokTeplota in _archiv.Values)
            {
                Console.WriteLine($"{rokTeplota.Rok}: {rokTeplota.PriemRocnaTeplota:F2}°C");
            }
        }

        public void TiskPrumernychMesicnichTeplot()
        {
            double[] prumerneTeploty = new double[12];
            int pocetRoku = _archiv.Count;

            for (int mesic = 0; mesic < 12; mesic++)
            {
                var teploty = _archiv.Values.Select(rt => rt.MesacneTeploty[mesic]).ToList();
                prumerneTeploty[mesic] = teploty.Average();
            }

            Console.WriteLine("Prům.: " + string.Join("; ", prumerneTeploty.Select(t => t.ToString("F1"))));
        }
    }
}

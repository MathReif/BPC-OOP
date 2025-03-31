using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{

    public class RocnaTeplota
    {
        public int Rok { get; set; }

        public List<double> MesacneTeploty { get; set; }

        public RocnaTeplota(int Rok, List<double> mesicniTeploty)
        {
            this.Rok = Rok;
            MesacneTeploty = mesicniTeploty;
        }
    
        public double MaxTeplota => MesacneTeploty.Max();
        public double MinTeplota => MesacneTeploty.Min();
        public double PriemRocnaTeplota => MesacneTeploty.Average();

    }
}

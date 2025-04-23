using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11.EFCore
{
    public class Hodnoceni
    {
        [Key]public int IdStudent { get; set; }
        [Key]public string ZkratkaPredmet { get; set; }
        public DateTime Datumt { get; set; }
        public int Znamka { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}

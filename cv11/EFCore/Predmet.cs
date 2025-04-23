using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11.EFCore
{
    public class Predmet
    {
        [Key]public string Zkratka { get; set; }
        public string Nazev { get; set; }

        public ICollection<Hodnoceni> Hodnoceni { get; set; }
        public ICollection<StudentPredmet> StudentPredmet { get; set; }
    }
}

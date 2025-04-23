using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11.EFCore
{
    public class StudentPredmet
    {
        [Key]public int IdStudent { get; set; }
        [Key]public string ZkratkaPredmet { get; set; }

        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}

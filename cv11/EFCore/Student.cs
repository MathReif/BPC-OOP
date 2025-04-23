using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cv11.EFCore
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public ICollection<Hodnoceni> Hodnoceni { get; set; }
        public ICollection<StudentPredmet> StudentPredmet { get; set; }
    }
}

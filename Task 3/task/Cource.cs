using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Cource
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Credidts { get; set; }

        [ForeignKey("teachers")]
        public int TeacherId { get; set; }
        public Teachers Teachers { get; set; }


        public List<Enrollment> Student { get; set; }

    }
}

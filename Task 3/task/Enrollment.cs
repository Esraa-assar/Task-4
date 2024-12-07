using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        [ForeignKey("cource")]
        public int CourceId { get; set; }
        public Cource Cource { get; set; }

        [ForeignKey("student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

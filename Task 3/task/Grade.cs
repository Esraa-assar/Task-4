﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Enrollment Enrollment { get; set; }

    }
}

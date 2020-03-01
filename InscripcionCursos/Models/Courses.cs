using System;
using System.Collections.Generic;

namespace InscripcionCursos.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Students = new HashSet<Students>();
        }

        public int IdCourse { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public int? Size { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}

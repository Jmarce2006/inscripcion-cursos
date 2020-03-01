using System;
using System.Collections.Generic;

namespace InscripcionCursos.Models
{
    public partial class Students
    {
        public int IdStudent { get; set; }
        public int? IdCourse { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Courses IdCourseNavigation { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionCursos.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
    }
}

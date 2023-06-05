﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Yrye.DataAccess
{
    public class Serie
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Director { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public bool RegistroActivo { get; set; }
    }
}

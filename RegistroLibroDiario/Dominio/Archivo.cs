﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Archivo
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public string Fecha { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Egreso { get; set; }

    }
}

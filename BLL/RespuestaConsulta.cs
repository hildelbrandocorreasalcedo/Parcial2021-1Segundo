﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<Cursos> Cursos { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Cursos Curso { get; set; }
        public bool Error { get; set; }
    }
}

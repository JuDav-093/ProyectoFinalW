﻿using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CitasBL
    {
        public List<CitasCLS> ListarCitas()
        {
            CitasDAL obj = new CitasDAL();
            return obj.ListarCitas();
        }
    }
}

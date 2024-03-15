﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values (" + usuariorol.IdUsuario + ","
                                                          + usuariorol.IdRol + ",' "
                                                          + usuariorol.FechaAsigna + "','"
                                                          + usuariorol.Estado + "')";
            conexion.Ejecutar(consulta);
        }
    }
}

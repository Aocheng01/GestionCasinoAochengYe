﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCasinoAochengYe.dto
{
    internal class Usuario
    {
        public int id { get; set; }

        public string nombre_usuario { get; set; }

        public string contraseña { get; set; }

        public bool esAdministrador { get; set; }

        public DateTime fechaCreacion { get; set; }

        public Usuario(string nombre_usuario, string contraseña, bool esAdministrador, DateTime fechaCreacion)
        {
            this.nombre_usuario = nombre_usuario;
            this.contraseña = contraseña;
            this.esAdministrador = esAdministrador;
            this.fechaCreacion = fechaCreacion;
        }
        public Usuario(int id, string nombre_usuario, string contraseña, bool esAdministrador, DateTime fechaCreacion)
        {
            this.id = id;
            this.nombre_usuario = nombre_usuario;
            this.contraseña = contraseña;
            this.esAdministrador = esAdministrador;
            this.fechaCreacion = fechaCreacion;
        }



    }


}

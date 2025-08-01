﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionCasinoAochengYe.dto;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace GestionCasinoAochengYe.dao
{
    internal class DaoUsuario
    {
        public void CrearUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.nombre_usuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío");
                return;
            }

            try
            {
                // Hash de la contraseña con BCrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuario.contraseña);

                string query = "INSERT INTO usuarios (nombre_usuario, contraseña, esAdministrador, fecha_creacion) VALUES (@nombre_usuario, @contraseña, @esAdministrador, @fecha_creacion)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@nombre_usuario", usuario.nombre_usuario);
                mySqlCommand.Parameters.AddWithValue("@contraseña", hashedPassword);
                mySqlCommand.Parameters.AddWithValue("@esAdministrador", usuario.esAdministrador);
                mySqlCommand.Parameters.AddWithValue("@fecha_creacion", usuario.fechaCreacion);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario creado con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre. Por favor, elige otro nombre.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el usuario.");
                }
            }
        }

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                string query = "SELECT * FROM usuarios";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Usuario usuario = new Usuario
                    (
                        mySqlDataReader.GetInt32(0),
                        mySqlDataReader.GetString(1),
                        mySqlDataReader.GetString(2),
                        mySqlDataReader.GetBoolean(3),
                        mySqlDataReader.GetDateTime(4)
                    );
                    listaUsuarios.Add(usuario);
                }
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al obtener los usuarios.");
            }
            return listaUsuarios;
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.nombre_usuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío");
                return;
            }
            try
            {
                // Hash de la nueva contraseña con BCrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuario.contraseña);

                string query = "UPDATE usuarios SET nombre_usuario = @nombre_usuario, contraseña = @contraseña, esAdministrador = @esAdministrador, fecha_creacion = @fecha_creacion WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@nombre_usuario", usuario.nombre_usuario);
                mySqlCommand.Parameters.AddWithValue("@contraseña", hashedPassword);
                mySqlCommand.Parameters.AddWithValue("@esAdministrador", usuario.esAdministrador);
                mySqlCommand.Parameters.AddWithValue("@fecha_creacion", usuario.fechaCreacion);
                mySqlCommand.Parameters.AddWithValue("@id", usuario.id);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al actualizar el usuario.");
            }
        }

        public void EliminarUsuario(int id)
        {
            try
            {
                string query = "DELETE FROM usuarios WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@id", id);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al eliminar el usuario.");
            }
        }
    }
}

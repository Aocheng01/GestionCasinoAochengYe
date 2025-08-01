﻿using GestionCasinoAochengYe.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.dao
{
    internal class DaoPartida
    {
            public void CrearPartida(Partida partida)
            {
                try
                {
                    string query = "INSERT INTO partidas (id_cliente, fecha, apuesta, ganancia) VALUES (@id_cliente, @fecha, @apuesta, @ganancia)";
                    Conexion objetoConexion = new Conexion();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                    mySqlCommand.Parameters.AddWithValue("@id_cliente", partida.id_cliente);
                    mySqlCommand.Parameters.AddWithValue("@fecha", partida.fecha);
                    mySqlCommand.Parameters.AddWithValue("@apuesta", partida.apuesta);
                    mySqlCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);

                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Partida creada con éxito");
                    objetoConexion.cerrarConexion();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ocurrió un error al registrar la partida.");
                }
            }

        public List<Partida> ObtenerPartidas()
        {
            List<Partida> listaPartidas = new List<Partida>();
            try
            {
                string query = "SELECT * FROM partidas";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Partida partida = new Partida
                    (
                        mySqlDataReader.GetInt32(1),
                        mySqlDataReader.GetDateTime(2),
                        mySqlDataReader.GetDouble(3),
                        mySqlDataReader.GetDouble(4)
                    )
                    {
                        id_partida = mySqlDataReader.GetInt32(0)
                    };
                    listaPartidas.Add(partida);
                }
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al obtener las partidas.");
            }
            return listaPartidas;
        }
        public void ActualizarPartida(Partida partida)
        {
            try
            {
                string query = "UPDATE partidas SET id_cliente = @id_cliente, fecha = @fecha, apuesta = @apuesta, ganancia = @ganancia WHERE id_partida = @id_partida";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@id_cliente", partida.id_cliente);
                mySqlCommand.Parameters.AddWithValue("@fecha", partida.fecha);
                mySqlCommand.Parameters.AddWithValue("@apuesta", partida.apuesta);
                mySqlCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);
                mySqlCommand.Parameters.AddWithValue("@id_partida", partida.id_partida);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Partida actualizada con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al actualizar la partida.");
            }
        }
        public void EliminarPartida(int id_partida)
        {
            try
            {
                string query = "DELETE FROM partidas WHERE id_partida = @id_partida";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@id_partida", id_partida);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Partida eliminada con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al eliminar la partida.");
            }
        }
    }
}


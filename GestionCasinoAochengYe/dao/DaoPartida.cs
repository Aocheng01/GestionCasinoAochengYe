using GestionCasinoAochengYe.dto;
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
            if (partida.fecha > DateTime.Now)
            {
                MessageBox.Show("La fecha de la partida no puede ser posterior a la fecha actual.");
                return;
            }

            try
            {
                string query = "INSERT INTO partidas (id_cliente, fecha, apuesta, ganancia, juego, usuario_modificacion) VALUES (@id_cliente, @fecha, @apuesta, @ganancia, @juego, @usuarioModificacion)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@id_cliente", partida.id_cliente);
                mySqlCommand.Parameters.AddWithValue("@fecha", partida.fecha);
                mySqlCommand.Parameters.AddWithValue("@apuesta", partida.apuesta);
                mySqlCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);
                mySqlCommand.Parameters.AddWithValue("@juego", partida.juego);
                mySqlCommand.Parameters.AddWithValue("@usuarioModificacion", partida.usuarioModificacion);

                mySqlCommand.ExecuteNonQuery();
                objetoConexion.cerrarConexion();

                // Abrir una nueva conexión para actualizar el saldo del cliente
                Conexion objetoConexionSaldo = new Conexion();
                string updateSaldoQuery = "UPDATE clientes SET saldo = saldo + @ganancia WHERE id = @id_cliente";
                MySqlCommand updateSaldoCommand = new MySqlCommand(updateSaldoQuery, objetoConexionSaldo.establecerConexion());
                updateSaldoCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);
                updateSaldoCommand.Parameters.AddWithValue("@id_cliente", partida.id_cliente);

                updateSaldoCommand.ExecuteNonQuery();
                objetoConexionSaldo.cerrarConexion();

                MessageBox.Show("Partida creada y saldo actualizado con éxito");
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
                        mySqlDataReader.GetDouble(4),
                        mySqlDataReader.GetString(5),
                        mySqlDataReader.GetString(6)
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
        public void ActualizarPartida(int id, Partida partida)
        {
            if (partida.fecha > DateTime.Now)
            {
                MessageBox.Show("La fecha de la partida no puede ser posterior a la fecha actual.");
                return;
            }

            try
            {

                string query = "UPDATE partidas SET fecha = @fecha, apuesta = @apuesta, ganancia = @ganancia, juego = @juego, usuario_modificacion = @usuarioModificacion WHERE id_partida = @id_partida";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                mySqlCommand.Parameters.AddWithValue("@fecha", partida.fecha);
                mySqlCommand.Parameters.AddWithValue("@apuesta", partida.apuesta);
                mySqlCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);
                mySqlCommand.Parameters.AddWithValue("@juego", partida.juego);
                mySqlCommand.Parameters.AddWithValue("@usuarioModificacion", partida.usuarioModificacion);
                mySqlCommand.Parameters.AddWithValue("@id_partida", id);

                int filasAfectadas = mySqlCommand.ExecuteNonQuery();
                objetoConexion.cerrarConexion();

                if (filasAfectadas > 0)
                {
                    // Abrir una nueva conexión para actualizar el saldo del cliente
                    Conexion objetoConexionSaldo = new Conexion();
                    string updateSaldoQuery = "UPDATE clientes SET saldo = saldo + @ganancia WHERE id = (SELECT id_cliente FROM partidas WHERE id_partida = @id_partida)";
                    MySqlCommand updateSaldoCommand = new MySqlCommand(updateSaldoQuery, objetoConexionSaldo.establecerConexion());
                    updateSaldoCommand.Parameters.AddWithValue("@ganancia", partida.ganancia);
                    updateSaldoCommand.Parameters.AddWithValue("@id_partida", id);

                    updateSaldoCommand.ExecuteNonQuery();
                    objetoConexionSaldo.cerrarConexion();

                    MessageBox.Show("Partida y saldo del cliente actualizados con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró la partida para actualizar.");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Ocurrió un error al actualizar la partida: " + e.Message);
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


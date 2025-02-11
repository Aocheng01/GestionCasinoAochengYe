using GestionCasinoAochengYe.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.dao
{
    internal class DaoCliente
    {
        
            public void CrearCliente(Cliente cliente)
            {
                if (string.IsNullOrEmpty(cliente.nombre) || string.IsNullOrEmpty(cliente.apellido))
                {
                    MessageBox.Show("El nombre y apellido no pueden estar vacíos");
                    return;
                }

                try
                {
                    string query = "INSERT INTO clientes (nombre, apellido, email, telefono, saldo) VALUES (@nombre, @apellido, @email, @telefono, @saldo)";
                    Conexion objetoConexion = new Conexion();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                    mySqlCommand.Parameters.AddWithValue("@nombre", cliente.nombre);
                    mySqlCommand.Parameters.AddWithValue("@apellido", cliente.apellido);
                    mySqlCommand.Parameters.AddWithValue("@email", cliente.email);
                    mySqlCommand.Parameters.AddWithValue("@telefono", cliente.telefono);
                    mySqlCommand.Parameters.AddWithValue("@saldo", cliente.saldo);

                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cliente creado con éxito");
                    objetoConexion.cerrarConexion();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ocurrió un error al registrar el cliente.");
                }
            }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                string query = "SELECT * FROM clientes";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Cliente cliente = new Cliente
                    (
                        mySqlDataReader.GetInt32(0),
                        mySqlDataReader.GetString(1),
                        mySqlDataReader.GetString(2),
                        mySqlDataReader.GetString(3),
                        mySqlDataReader.GetString(4),
                        mySqlDataReader.GetDouble(5)
                    );
                    listaClientes.Add(cliente);
                }
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al obtener los clientes.");
            }
            return listaClientes;
        }

        public void ActualizarCliente(int id, Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.nombre) || string.IsNullOrEmpty(cliente.apellido))
            {
                MessageBox.Show("El nombre y apellido no pueden estar vacíos");
                return;
            }

            try
            {
                string query = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono, saldo = @saldo WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@nombre", cliente.nombre);
                mySqlCommand.Parameters.AddWithValue("@apellido", cliente.apellido);
                mySqlCommand.Parameters.AddWithValue("@email", cliente.email);
                mySqlCommand.Parameters.AddWithValue("@telefono", cliente.telefono);
                mySqlCommand.Parameters.AddWithValue("@saldo", cliente.saldo);
                mySqlCommand.Parameters.AddWithValue("@id", cliente.id);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al actualizar el cliente.");
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                string query = "DELETE FROM clientes WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@id", id);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado con éxito");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocurrió un error al eliminar el cliente.");
            }
        }

        
        }
    }



 
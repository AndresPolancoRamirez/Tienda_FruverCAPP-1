using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Entities;

namespace DataLayer
{
    public class ClientesData
    {
        public static MySqlConnection ConexionBD()
        {
            MySqlConnection conex = new MySqlConnection
            ("Server=127.0.0.1;"+ 
             "Database=bdfruvercapp;"+
             "Uid=root;"+
             "Pwd=;"+
             "SslMode=None");

            return conex;
        }
            public static bool GuardarCliente(Clientes_Entity cliente)
            {
                    MySqlConnection conex = ConexionBD();
                conex.Open();
                string sql = @" INSERT INTO tbclientes
                                (TipoDocumento, NumeroDocumento, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Email, Direccion, Telefono, FechaNacimiento)
                                 VALUES
                                (@TipoDocumento, @NumeroDocumento, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Email, @Direccion, @Telefono, @FechaNacimiento)";
                MySqlCommand cmd = new MySqlCommand(sql, conex);

                cmd.Parameters.AddWithValue("@TipoDocumento",cliente.tipo_documento);
                cmd.Parameters.AddWithValue("@NumeroDocumento",cliente.numero_documento);
                cmd.Parameters.AddWithValue("@PrimerNombre",cliente.primer_nombre);
                cmd.Parameters.AddWithValue("@SegundoNombre",cliente.segundo_nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido",cliente.primer_apellido);
                cmd.Parameters.AddWithValue("@SegundoApellido",cliente.segundo_apellido);
                cmd.Parameters.AddWithValue("@Email",cliente.email);
                cmd.Parameters.AddWithValue("@Direccion",cliente.direccion);
                cmd.Parameters.AddWithValue("@Telefono",cliente.telefono);
                cmd.Parameters.AddWithValue("@FechaNacimiento",cliente.fecha_nacimiento);

                int NumeroFilas = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (NumeroFilas >0)
                {
                    return true;
                }
                else{
                    return false;
                    }
                }

            public static List<Clientes_Entity> ObtenerClientes()
            {
                List<Clientes_Entity> clientes = new List<Clientes_Entity>();
                MySqlConnection conex = new MySqlConnection();
                conex = ConexionBD();
                conex.Open();
                string sql = "SELECT * FROM tbclientes order by id_Clientes desc" ;

                MySqlCommand cmd = new MySqlCommand(sql, conex);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(CargarCliente(reader));
                }
                return clientes;
            }
            public static Clientes_Entity CargarCliente(MySqlDataReader reader)
            {
                Clientes_Entity cliente = new Clientes_Entity();
                cliente.tipo_documento = Convert.ToString(reader["TipoDocumento"]);
                cliente.numero_documento = Convert.ToString(reader["NumeroDocumento"]);
                cliente.primer_nombre = Convert.ToString(reader["PrimerNombre"]);
                cliente.segundo_nombre = Convert.ToString(reader["SegundoNombre"]);
                cliente.primer_apellido = Convert.ToString(reader["PrimerApellido"]);
                cliente.segundo_apellido = Convert.ToString(reader["SegundoApellido"]);
                cliente.email = Convert.ToString(reader["Email"]);
                cliente.direccion = Convert.ToString(reader["Direccion"]);
                cliente.telefono = Convert.ToString(reader["Telefono"]);


                return cliente;
            
            }


        }
}


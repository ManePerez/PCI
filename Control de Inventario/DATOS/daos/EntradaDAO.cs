using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.modelo;
using MySql.Data.MySqlClient;
using DATOS.modelo;
using DATOS.util;
namespace DATOS.daos
{
    public class EntradaDAO
    {
        Conexion cn = new Conexion();
        public bool Registrar(int id, int can, decimal precio, int codUsu, DateTime fech)
        {

            if (cn.Conectar())
            {
                try
                {
                    /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
                    //Conexion.conexion.Open();

                    /// AGREGAR EL REGISTRO A LA BASE DE DATOS
                    MySqlCommand comando = new MySqlCommand("call insertEntrada(@CodigoP, @cantidadPro,@precioUni,@codigoUsu, @fecha)", Conexion.conexion);
                    comando.Parameters.AddWithValue("CodigoP", id);
                    comando.Parameters.AddWithValue("cantidadPro", can);
                    comando.Parameters.AddWithValue("precioUni", precio);
                    comando.Parameters.AddWithValue("codigoUsu", codUsu);
                    comando.Parameters.AddWithValue("fecha", fech);

                    comando.ExecuteNonQuery();

                    /// FINALIZAMOS LA CONEXION CERRAMOS TODO
                    comando.Dispose();
                    Conexion.conexion.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    Conexion.conexion.Close();
                }                
            }
            return false;
        }
    }
}

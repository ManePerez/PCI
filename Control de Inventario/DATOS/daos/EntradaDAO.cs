using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.modelo;
<<<<<<< HEAD
using MySql.Data.MySqlClient;
using DATOS.modelo;
using DATOS.util;
=======
using DATOS.util;
using MySql.Data.MySqlClient;
using System.Data;

>>>>>>> 61d1c949b525fc8e7da0440e1c9da6ac6234ef27
namespace DATOS.daos
{
    public class EntradaDAO
    {
<<<<<<< HEAD
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
=======
        public List<Entrada> getAllReporte()
        {
            List<Entrada> lista = new List<Entrada>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM Entrada;");
            DataTable dt = datos.Tables[0];
            Entrada e;
            foreach (DataRow r in dt.Rows)
            {
                e = new Entrada();
                e.codigo = (int)r.ItemArray[0];
                e.codigoProducto = (int)r.ItemArray[1];
                e.cantidadProductos = (int)r.ItemArray[2];
                e.codigoUsuario = (int)r.ItemArray[3];
                e.fecha = (DateTime)r.ItemArray[4];
                lista.Add(e);
            }
            return lista;
>>>>>>> 61d1c949b525fc8e7da0440e1c9da6ac6234ef27
        }
    }
}

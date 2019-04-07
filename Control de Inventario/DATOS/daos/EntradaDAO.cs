using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.modelo;
using DATOS.util;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATOS.daos
{
    public class EntradaDAO
    {
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
        }
    }
}

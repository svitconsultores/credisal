using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace reportes
{
    class BD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=ce;Uid=root;pwd=;");

            conectar.Open();

            return conectar;
        }
    }
}

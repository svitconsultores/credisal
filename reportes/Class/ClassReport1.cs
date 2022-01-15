using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace reportes.Class
{
    class ClassReport1
    {
        /*
         * public static List<Movpres> Buscar(string codigopre, double saldo, double p110401, double int_aplic, double manejo)
        {
            List<Movpres> lista = new List<Movpres>();
            MySqlCommand com = new MySqlCommand(String.Format("select CODIGOPRE as CODIGO, (select mIN(SALDO) " +
                "from movpres m2 where CODIGOPRE = CODIGO AND TIPO != 1 and month(FECHA) = 10 - 1 ) " +
                "as SALDO_ANTERIOR,        " +
                "min(SALDO),       " +
                "SUM(P110401) " +
                "as CAPITAL,       " +
                "SUM(INT_APLIC) " +
                "as INTcodigoERES,       " +
                "SUM(MANEJO) " +
                "as MANEJO " +
                "from movpres m where TIPO != 1 and month(FECHA) = 10 and COMPROBANT != 1 AND YEAR(FECHA) = 2017 GROUP by CODIGOPRE"), BD.ObtenerConexion());
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Movpres mov = new Movpres();
                mov.codigopre = reader.GetString(0);
                mov.saldo = reader.GetDouble(1);
                mov.p110401 = reader.GetDouble(2);
                mov.manejo = reader.GetDouble(3);

                lista.Add(mov);

            }
            return lista;
        }
        */
        public class Movpres
        {
        }
        public Movpres ObtenerMoviemientos()
        {
            Movpres mov = new Movpres();
            MySqlConnection con = BD.ObtenerConexion();

            MySqlCommand com = new MySqlCommand(String.Format("select CODIGOPRE as CODIGO, (select mIN(SALDO) " +
                "from movpres m2 where CODIGOPRE = CODIGO AND TIPO != 1 and month(FECHA) = 10 - 1 ) " +
                "as SALDO_ANTERIOR,        " +
                "min(SALDO),       " +
                "SUM(P110401) " +
                "as CAPITAL,       " +
                "SUM(INT_APLIC) " +
                "as INTcodigoERES,       " +
                "SUM(MANEJO) " +
                "as MANEJO " +
                "from movpres m where TIPO != 1 and month(FECHA) = 10 and COMPROBANT != 1 AND YEAR(FECHA) = 2017 GROUP by CODIGOPRE"), con);

            MySqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                mov.codigopre = reader.GetString(0);
                mov.saldo = reader.GetDouble(1);
                mov.p110401 = reader.GetDouble(2);
                mov.manejo = reader.GetDouble(3);
            }

            con.Close();
            return mov;
        }
       }
     }


       /* codigopre string
        saldo double
        P110401 double
        int_aplic double
        manejo double*/


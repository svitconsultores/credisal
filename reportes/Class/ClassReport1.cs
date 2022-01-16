using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace reportes.Class
{
    class ClassReport1
    {
        BD con = new BD();
        private static ArrayList ListCodigo = new ArrayList();
        private static ArrayList ListSaldoAnterior = new ArrayList();
        private static ArrayList ListSaldoActual = new ArrayList();
        private static ArrayList ListCapital = new ArrayList();
        private static ArrayList ListInteres = new ArrayList();
        private static ArrayList ListManejo = new ArrayList();
        private static ArrayList ListClientes = new ArrayList();
        public class Movpres
        {
            
        }
       

        public void GetData()
        {
            try
            {
               
                con.Open();

                string query = "select CODIGOPRE as CODIGO, (select mIN(SALDO) " +
                "from movpres m2 where CODIGOPRE = m.CODIGOPRE AND TIPO != 1 and month(FECHA) = 10 - 1 ) " +
                "as SALDO_ANTERIOR,        " +
                "min(SALDO) as SALDO_ACTUAL,       " +
                "SUM(P110401) " +
                "as CAPITAL,       " +
                "SUM(INT_APLIC) " +
                "as INTERES,       " +
                "SUM(MANEJO) " +
                "as MANEJO, " +
                "CONCAT(m3.NOMBRE, ' ', m3.APELLIDO) as NAMECLIENT " +
                "from movpres m " +
                "inner join maeasoc m3 on m3.CODIGO = substring(m.CODIGOPRE, 1, 7) " +
                "where TIPO != 1 and month(FECHA) = 10 and COMPROBANT != 1 AND YEAR(FECHA) = 2017 GROUP by CODIGOPRE";

                
                MySqlDataReader row;
                row = con.ExecuteReader(query);


                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListCodigo.Add(row["CODIGO"].ToString());
                        ListSaldoAnterior.Add(row["SALDO_ANTERIOR"].ToString());
                        ListSaldoActual.Add(row["SALDO_ACTUAL"].ToString());
                        ListCapital.Add(row["CAPITAL"].ToString());
                        ListInteres.Add(row["INTERES"].ToString());
                        ListManejo.Add(row["MANEJO"].ToString());
                        ListClientes.Add(row["NAMECLIENT"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        public void updateDatagrid(DataGridView NameGrid)
        {
            NameGrid.Rows.Clear();

            try {
                if (ListCodigo.Count > 0)
                {
                    for (int i = 0; i < ListCodigo.Count; i++)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();

                        newRow.CreateCells(NameGrid);
                        newRow.Cells[0].Value = ListCodigo[i];
                        newRow.Cells[1].Value = ListSaldoAnterior[i];
                        newRow.Cells[2].Value = ListSaldoActual[i];
                        newRow.Cells[3].Value = ListCapital[i];
                        newRow.Cells[4].Value = ListInteres[i];
                        newRow.Cells[5].Value = ListManejo[i];
                        newRow.Cells[6].Value = ListClientes[i];
                        NameGrid.Rows.Add(newRow);
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }


           

            
        }

    }
}


       /* codigopre string
        saldo double
        P110401 double
        int_aplic double
        manejo double*/


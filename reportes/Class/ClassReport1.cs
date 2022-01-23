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
using SpreadsheetLight;
//import PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;

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
        private static ArrayList ListFecha = new ArrayList();

        SLDocument sl = new SLDocument();
        DataGridView grid = new DataGridView();
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

        public void GetDataButton(int mes, int anio)
        {

            try
            {

                con.Open();

                string query = "select CODIGOPRE as CODIGO, (select mIN(SALDO) " +
                "from movpres m2 where CODIGOPRE = m.CODIGOPRE AND TIPO != 1 and month(FECHA) = " + Convert.ToInt32(mes) + " - 1 ) " +
                "as SALDO_ANTERIOR,        " +
                "min(SALDO) as SALDO_ACTUAL,       " +
                "SUM(P110401) " +
                "as CAPITAL,       " +
                "SUM(INT_APLIC) " +
                "as INTERES,       " +
                "SUM(MANEJO) " +
                "as MANEJO, " +
                "fecha, " +
                "CONCAT(m3.NOMBRE, ' ', m3.APELLIDO) as NAMECLIENT " +
                "from movpres m " +
                "inner join maeasoc m3 on m3.CODIGO = substring(m.CODIGOPRE, 1, 7) " +
                "where TIPO != 1 and month(FECHA) = " + Convert.ToInt32(mes) + " and COMPROBANT != 1 AND YEAR(FECHA) = " + Convert.ToInt32(anio) + " GROUP by CODIGOPRE";


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
                        ListFecha.Add(row["fecha"].ToString());
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
                        newRow.Cells[7].Value = ListFecha[i];
                        NameGrid.Rows.Add(newRow);
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                ListCodigo.Clear();
                ListSaldoAnterior.Clear();
                ListSaldoActual.Clear();
                ListCapital.Clear();
                ListInteres.Clear();
                ListManejo.Clear();
                ListClientes.Clear();
                ListFecha.Clear();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
  
        }
        
        public void exportExcel(DataGridView Grid)
        {
            
            int iC = 2;
            foreach(DataGridViewColumn column in Grid.Columns)
            {
                sl.SetCellValue(3, iC, column.HeaderText.ToString());
                iC++;
            }

            int iR = 4;

            foreach(DataGridViewRow row in Grid.Rows)
            {
                
                sl.SetCellValue(iR, 2, row.Cells[0].Value?.ToString());
                sl.SetCellValue(iR, 3, row.Cells[1].Value?.ToString());
                sl.SetCellValue(iR, 4, row.Cells[2].Value?.ToString());
                sl.SetCellValue(iR, 5, row.Cells[3].Value?.ToString());
                sl.SetCellValue(iR, 6, row.Cells[4].Value?.ToString());
                sl.SetCellValue(iR, 7, row.Cells[5].Value?.ToString());
                sl.SetCellValue(iR, 8, row.Cells[6].Value?.ToString());
                sl.SetCellValue(iR, 9, row.Cells[7].Value?.ToString());
                iR++;                    
            }

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Reporte_General_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx";
            save.Title = "Guardar Archivo";
            save.CheckPathExists = true;
            save.DefaultExt = "xlsx";

            if(save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.SaveAs(save.FileName);
                    MessageBox.Show("Archivo Exportado con Exito!");
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void exportPDF(DataGridView grid)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF Files|*.pdf";
            //save.FilterIndex = 0;
            string name = "Reporte_General_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; 
           // save.CheckPathExists = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    save.FileName = name;
                    Document doc = new Document(PageSize.LETTER.Rotate());
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\admin\Desktop\prueba.pdf", FileMode.Create));

                    doc.AddTitle("Credisal");
                    doc.AddCreator("Credisal");
                    doc.Open();

                    //encabezado del doc
                    iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    doc.Add(new Paragraph("Credisal"));
                    doc.Add(new Paragraph("Reporte General"));
                    doc.Add(Chunk.NEWLINE);
                    //encabezado de la tabla

                    PdfPTable table = new PdfPTable(8);
                    table.DefaultCell.Padding = 3;
                    table.WidthPercentage = 100;
                    table.TotalWidth = 260;
                    float[] widths = new float[] { 30f, 20f, 20f, 20f, 20f, 20f, 100f, 30f};
                    table.SetWidths(widths);

                    //titulo del encabezado de la tabla
                    foreach (DataGridViewColumn column in grid.Columns)
                    {

                        PdfPCell headerName = new PdfPCell(new Phrase(column.HeaderText.ToString(), font));
                        headerName.BorderWidth = 0;
                        headerName.BorderWidthBottom = 0.75f;
                        table.AddCell(headerName);
                    }

                    //recorremos el grid y llenamos la tabla con los valores obtenidos

                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        PdfPCell data1 = new PdfPCell(new Phrase(row.Cells[0].Value?.ToString()));
                        table.AddCell(data1);
                        PdfPCell data2 = new PdfPCell(new Phrase(row.Cells[1].Value?.ToString()));
                        table.DefaultCell.Padding = 2;
                        table.AddCell(data2);
                        PdfPCell data3 = new PdfPCell(new Phrase(row.Cells[2].Value?.ToString()));
                        data3.Colspan = 1;
                        table.AddCell(data3);
                        PdfPCell data4 = new PdfPCell(new Phrase(row.Cells[3].Value?.ToString()));
                        table.AddCell(data4);
                        PdfPCell data5 = new PdfPCell(new Phrase(row.Cells[4].Value?.ToString()));
                        table.AddCell(data5);
                        PdfPCell data6 = new PdfPCell(new Phrase(row.Cells[5].Value?.ToString()));
                        table.AddCell(data6);
                        PdfPCell data7 = new PdfPCell(new Phrase(row.Cells[6].Value?.ToString()));
                        table.AddCell(data7);
                        PdfPCell data8 = new PdfPCell(new Phrase(row.Cells[7].Value?.ToString()));
                        table.AddCell(data8);
                    }

                    doc.Add(table);


                    doc.Close();
                    MessageBox.Show("Archivo Exportado con Exito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
           // writer.Close();

        }
    }
}


       /* codigopre string
        saldo double
        P110401 double
        int_aplic double
        manejo double*/


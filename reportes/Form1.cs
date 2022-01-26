using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;




namespace reportes
{
    public partial class Form1 : Form
    {
        Class.ClassReport1 c = new Class.ClassReport1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // c.GetDataButton(10, 2017);
            btnBuscar.Enabled = false;
            btnExcel.Enabled = false;
            btnPdf.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int mes = this.cbbMes.SelectedIndex + 1;
            int anio = Convert.ToInt32(this.cbbanio.SelectedItem);
            Class.ClassReport1 c = new Class.ClassReport1();

            c.GetDataButton(mes, anio);
            dgvReport1.Rows.Clear();
            c.updateDatagrid(dgvReport1);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            c.exportExcel(dgvReport1);

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            c.exportPDF(dgvReport1);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(cbbanio.Text == "Añ:" && cbbMes.Text == "Mes:")
            {
                btnBuscar.Enabled = true;
                btnExcel.Enabled = false;
                btnPdf.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
                btnExcel.Enabled = true;
                btnPdf.Enabled = true;

            }
        }
    }
}

﻿using System;
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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Class.ClassReport1 c = new Class.ClassReport1();
            c.GetData();


            c.updateDatagrid(dgvReport1);*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int mes = this.cbbMes.SelectedIndex + 1;
            int anio = Convert.ToInt32(this.cbbanio.SelectedItem);
            MessageBox.Show(mes.ToString() + " " + anio.ToString());
            Class.ClassReport1 c = new Class.ClassReport1();
            c.GetDataButton(mes, anio);

            c.updateDatagrid(dgvReport1);
        }
    }
}

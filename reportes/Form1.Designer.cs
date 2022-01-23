
namespace reportes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDOANTERIOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDOACTUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPITAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANEJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMes = new System.Windows.Forms.ComboBox();
            this.cbbanio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvReport1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.SALDOANTERIOR,
            this.SALDOACTUAL,
            this.CAPITAL,
            this.INTERES,
            this.MANEJO,
            this.CLIENTES,
            this.fecha});
            this.dgvReport1.Location = new System.Drawing.Point(12, 123);
            this.dgvReport1.Name = "dgvReport1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvReport1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReport1.RowTemplate.Height = 33;
            this.dgvReport1.Size = new System.Drawing.Size(1322, 489);
            this.dgvReport1.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.MinimumWidth = 8;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 150;
            // 
            // SALDOANTERIOR
            // 
            this.SALDOANTERIOR.HeaderText = "Saldo Anterior";
            this.SALDOANTERIOR.MinimumWidth = 8;
            this.SALDOANTERIOR.Name = "SALDOANTERIOR";
            this.SALDOANTERIOR.Width = 150;
            // 
            // SALDOACTUAL
            // 
            this.SALDOACTUAL.HeaderText = "Saldo Actual";
            this.SALDOACTUAL.MinimumWidth = 8;
            this.SALDOACTUAL.Name = "SALDOACTUAL";
            this.SALDOACTUAL.Width = 150;
            // 
            // CAPITAL
            // 
            this.CAPITAL.HeaderText = "Capital";
            this.CAPITAL.MinimumWidth = 8;
            this.CAPITAL.Name = "CAPITAL";
            this.CAPITAL.Width = 150;
            // 
            // INTERES
            // 
            this.INTERES.HeaderText = "Interes";
            this.INTERES.MinimumWidth = 8;
            this.INTERES.Name = "INTERES";
            this.INTERES.Width = 150;
            // 
            // MANEJO
            // 
            this.MANEJO.HeaderText = "Manejo";
            this.MANEJO.MinimumWidth = 8;
            this.MANEJO.Name = "MANEJO";
            this.MANEJO.Width = 150;
            // 
            // CLIENTES
            // 
            this.CLIENTES.HeaderText = "Cliente";
            this.CLIENTES.MinimumWidth = 8;
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Width = 150;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // cbbMes
            // 
            this.cbbMes.FormattingEnabled = true;
            this.cbbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbbMes.Location = new System.Drawing.Point(12, 74);
            this.cbbMes.Name = "cbbMes";
            this.cbbMes.Size = new System.Drawing.Size(182, 33);
            this.cbbMes.TabIndex = 1;
            this.cbbMes.Text = "Mes:";
            // 
            // cbbanio
            // 
            this.cbbanio.FormattingEnabled = true;
            this.cbbanio.Items.AddRange(new object[] {
            "2017",
            "2021",
            "2022"});
            this.cbbanio.Location = new System.Drawing.Point(230, 74);
            this.cbbanio.Name = "cbbanio";
            this.cbbanio.Size = new System.Drawing.Size(182, 33);
            this.cbbanio.TabIndex = 2;
            this.cbbanio.Text = "Año:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Location = new System.Drawing.Point(442, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcel.Location = new System.Drawing.Point(606, 39);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(86, 78);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPdf.Location = new System.Drawing.Point(698, 39);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(86, 78);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1367, 638);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbanio);
            this.Controls.Add(this.cbbMes);
            this.Controls.Add(this.dgvReport1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDOANTERIOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDOACTUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPITAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTERES;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANEJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTES;
        private System.Windows.Forms.ComboBox cbbMes;
        private System.Windows.Forms.ComboBox cbbanio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
    }
}


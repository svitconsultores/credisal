
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
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDOANTERIOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDOACTUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPITAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANEJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMes = new System.Windows.Forms.ComboBox();
            this.cbbanio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport1
            // 
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.SALDOANTERIOR,
            this.SALDOACTUAL,
            this.CAPITAL,
            this.INTERES,
            this.MANEJO,
            this.CLIENTES});
            this.dgvReport1.Location = new System.Drawing.Point(12, 123);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.RowHeadersWidth = 62;
            this.dgvReport1.RowTemplate.Height = 33;
            this.dgvReport1.Size = new System.Drawing.Size(1121, 407);
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
            this.btnBuscar.Location = new System.Drawing.Point(442, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 553);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbanio);
            this.Controls.Add(this.cbbMes);
            this.Controls.Add(this.dgvReport1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}



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
            this.dgvReport1.Location = new System.Drawing.Point(8, 16);
            this.dgvReport1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.RowHeadersWidth = 62;
            this.dgvReport1.RowTemplate.Height = 33;
            this.dgvReport1.Size = new System.Drawing.Size(785, 244);
            this.dgvReport1.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            // 
            // SALDOANTERIOR
            // 
            this.SALDOANTERIOR.HeaderText = "Saldo Anterior";
            this.SALDOANTERIOR.Name = "SALDOANTERIOR";
            // 
            // SALDOACTUAL
            // 
            this.SALDOACTUAL.HeaderText = "Saldo Actual";
            this.SALDOACTUAL.Name = "SALDOACTUAL";
            // 
            // CAPITAL
            // 
            this.CAPITAL.HeaderText = "Capital";
            this.CAPITAL.Name = "CAPITAL";
            // 
            // INTERES
            // 
            this.INTERES.HeaderText = "Interes";
            this.INTERES.Name = "INTERES";
            // 
            // MANEJO
            // 
            this.MANEJO.HeaderText = "Manejo";
            this.MANEJO.Name = "MANEJO";
            // 
            // CLIENTES
            // 
            this.CLIENTES.HeaderText = "Cliente";
            this.CLIENTES.Name = "CLIENTES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 294);
            this.Controls.Add(this.dgvReport1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}


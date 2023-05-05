namespace Proyecto1
{
    partial class frmGestionDeGastosMensuales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionDeGastosMensuales));
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblComido = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.lblSaldoRestante2 = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(4, 36);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(81, 20);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Depòsito";
            this.lblDeposito.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(104, 32);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(142, 26);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.Text = "0";
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtDeposito_TextChanged);
            this.txtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposito_KeyPress);
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblComido);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mrcGastosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.Location = new System.Drawing.Point(12, 105);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(274, 140);
            this.mrcGastosFijos.TabIndex = 2;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "GASTOS FIJOS";
            this.mrcGastosFijos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(104, 93);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(142, 26);
            this.txtComida.TabIndex = 5;
            this.txtComida.Text = "0";
            this.txtComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComida_KeyPress);
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(104, 58);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(142, 26);
            this.txtImpuestos.TabIndex = 4;
            this.txtImpuestos.Text = "0";
            this.txtImpuestos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtImpuestos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuestos_KeyPress);
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(104, 23);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(142, 26);
            this.txtAlquiler.TabIndex = 3;
            this.txtAlquiler.Text = "0";
            this.txtAlquiler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlquiler_KeyPress);
            // 
            // lblComido
            // 
            this.lblComido.AutoSize = true;
            this.lblComido.Location = new System.Drawing.Point(4, 96);
            this.lblComido.Name = "lblComido";
            this.lblComido.Size = new System.Drawing.Size(69, 20);
            this.lblComido.TabIndex = 2;
            this.lblComido.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(4, 61);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(93, 20);
            this.lblImpuestos.TabIndex = 1;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(4, 26);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(69, 20);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.Location = new System.Drawing.Point(12, 12);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(274, 76);
            this.mrcIngresos.TabIndex = 3;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "INGRESOS";
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
            this.mrcGastosVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVarios.Location = new System.Drawing.Point(12, 267);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Size = new System.Drawing.Size(274, 76);
            this.mrcGastosVarios.TabIndex = 4;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "GASTOS VARIOS";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(106, 28);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(140, 26);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.Text = "0";
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 31);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 20);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(81, 387);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(98, 47);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(188, 387);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(98, 47);
            this.cmdCalcular.TabIndex = 5;
            this.cmdCalcular.Text = "CALCULAR";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            this.cmdCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante.Location = new System.Drawing.Point(13, 346);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(159, 20);
            this.lblSaldoRestante.TabIndex = 6;
            this.lblSaldoRestante.Text = "Saldo Restante     ";
            // 
            // lblSaldoRestante2
            // 
            this.lblSaldoRestante2.AutoSize = true;
            this.lblSaldoRestante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante2.Location = new System.Drawing.Point(176, 346);
            this.lblSaldoRestante2.Name = "lblSaldoRestante2";
            this.lblSaldoRestante2.Size = new System.Drawing.Size(0, 20);
            this.lblSaldoRestante2.TabIndex = 6;
            this.lblSaldoRestante2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(160, 346);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(19, 20);
            this.lblpeso.TabIndex = 6;
            this.lblpeso.Text = "$";
            this.lblpeso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmGestionDeGastosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 447);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblSaldoRestante2);
            this.Controls.Add(this.lblSaldoRestante);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVarios);
            this.Controls.Add(this.mrcIngresos);
            this.Controls.Add(this.mrcGastosFijos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionDeGastosMensuales";
            this.Text = "Gestiòn de Gastos Mensuales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblComido;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Label lblSaldoRestante;
        private System.Windows.Forms.Label lblSaldoRestante2;
        private System.Windows.Forms.Label lblpeso;
    }
}


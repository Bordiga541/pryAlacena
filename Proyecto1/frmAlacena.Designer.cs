namespace Proyecto1
{
    partial class frmAlacena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.mrcAlmacenado = new System.Windows.Forms.GroupBox();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblProducto2 = new System.Windows.Forms.Label();
            this.lblLugar2 = new System.Windows.Forms.Label();
            this.lstAlimento2 = new System.Windows.Forms.ComboBox();
            this.lstLugar2 = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lstAlimento = new System.Windows.Forms.ComboBox();
            this.mrcAlmacenar = new System.Windows.Forms.GroupBox();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.mrcControlDeAlimentos = new System.Windows.Forms.GroupBox();
            this.cmdComida = new System.Windows.Forms.RadioButton();
            this.cmdLimpieza = new System.Windows.Forms.RadioButton();
            this.cmdMedicamento = new System.Windows.Forms.RadioButton();
            this.cmdComida1 = new System.Windows.Forms.RadioButton();
            this.cmdLimpieza1 = new System.Windows.Forms.RadioButton();
            this.cmdMedicamento1 = new System.Windows.Forms.RadioButton();
            this.nudCantidad = new System.Windows.Forms.DomainUpDown();
            this.nudCantidadMinima = new System.Windows.Forms.DomainUpDown();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.lblFechaDeVencimiento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento1 = new System.Windows.Forms.Label();
            this.mrcAlmacenado.SuspendLayout();
            this.mrcAlmacenar.SuspendLayout();
            this.mrcControlDeAlimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcAlmacenado
            // 
            this.mrcAlmacenado.Controls.Add(this.lblVencimiento1);
            this.mrcAlmacenado.Controls.Add(this.cmdMedicamento1);
            this.mrcAlmacenado.Controls.Add(this.cmdLimpieza1);
            this.mrcAlmacenado.Controls.Add(this.lblCantidad3);
            this.mrcAlmacenado.Controls.Add(this.cmdComida1);
            this.mrcAlmacenado.Controls.Add(this.lblCantidad2);
            this.mrcAlmacenado.Controls.Add(this.lblProducto2);
            this.mrcAlmacenado.Controls.Add(this.lblLugar2);
            this.mrcAlmacenado.Controls.Add(this.lstAlimento2);
            this.mrcAlmacenado.Controls.Add(this.lstLugar2);
            this.mrcAlmacenado.Location = new System.Drawing.Point(12, 307);
            this.mrcAlmacenado.Name = "mrcAlmacenado";
            this.mrcAlmacenado.Size = new System.Drawing.Size(445, 158);
            this.mrcAlmacenado.TabIndex = 0;
            this.mrcAlmacenado.TabStop = false;
            this.mrcAlmacenado.Text = "ALMACENADO";
            this.mrcAlmacenado.Enter += new System.EventHandler(this.mrcAlmacenado_Enter);
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Location = new System.Drawing.Point(358, 90);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(69, 20);
            this.lblCantidad3.TabIndex = 6;
            this.lblCantidad3.Text = "______";
            this.lblCantidad3.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Location = new System.Drawing.Point(358, 59);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(52, 20);
            this.lblCantidad2.TabIndex = 5;
            this.lblCantidad2.Text = "Cant.";
            // 
            // lblProducto2
            // 
            this.lblProducto2.AutoSize = true;
            this.lblProducto2.Location = new System.Drawing.Point(168, 59);
            this.lblProducto2.Name = "lblProducto2";
            this.lblProducto2.Size = new System.Drawing.Size(81, 20);
            this.lblProducto2.TabIndex = 4;
            this.lblProducto2.Text = "Producto";
            // 
            // lblLugar2
            // 
            this.lblLugar2.AutoSize = true;
            this.lblLugar2.Location = new System.Drawing.Point(6, 59);
            this.lblLugar2.Name = "lblLugar2";
            this.lblLugar2.Size = new System.Drawing.Size(55, 20);
            this.lblLugar2.TabIndex = 3;
            this.lblLugar2.Text = "Lugar";
            // 
            // lstAlimento2
            // 
            this.lstAlimento2.FormattingEnabled = true;
            this.lstAlimento2.Location = new System.Drawing.Point(168, 82);
            this.lstAlimento2.Name = "lstAlimento2";
            this.lstAlimento2.Size = new System.Drawing.Size(188, 28);
            this.lstAlimento2.TabIndex = 1;
            // 
            // lstLugar2
            // 
            this.lstLugar2.FormattingEnabled = true;
            this.lstLugar2.Location = new System.Drawing.Point(6, 82);
            this.lstLugar2.Name = "lstLugar2";
            this.lstLugar2.Size = new System.Drawing.Size(156, 28);
            this.lstLugar2.TabIndex = 0;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(245, 229);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(92, 25);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(346, 229);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(92, 25);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(368, 62);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cant.";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(168, 62);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(81, 20);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(2, 63);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(55, 20);
            this.lblLugar.TabIndex = 3;
            this.lblLugar.Text = "Lugar";
            // 
            // lstAlimento
            // 
            this.lstAlimento.FormattingEnabled = true;
            this.lstAlimento.Location = new System.Drawing.Point(168, 85);
            this.lstAlimento.Name = "lstAlimento";
            this.lstAlimento.Size = new System.Drawing.Size(198, 28);
            this.lstAlimento.TabIndex = 1;
            // 
            // mrcAlmacenar
            // 
            this.mrcAlmacenar.Controls.Add(this.dtpFecha);
            this.mrcAlmacenar.Controls.Add(this.lblFechaDeVencimiento);
            this.mrcAlmacenar.Controls.Add(this.chkCaduca);
            this.mrcAlmacenar.Controls.Add(this.nudCantidadMinima);
            this.mrcAlmacenar.Controls.Add(this.nudCantidad);
            this.mrcAlmacenar.Controls.Add(this.cmdMedicamento);
            this.mrcAlmacenar.Controls.Add(this.cmdLimpieza);
            this.mrcAlmacenar.Controls.Add(this.cmdComida);
            this.mrcAlmacenar.Controls.Add(this.cmdCancelar);
            this.mrcAlmacenar.Controls.Add(this.cmdGuardar);
            this.mrcAlmacenar.Controls.Add(this.lblCantidad);
            this.mrcAlmacenar.Controls.Add(this.lblProducto);
            this.mrcAlmacenar.Controls.Add(this.lblLugar);
            this.mrcAlmacenar.Controls.Add(this.lstAlimento);
            this.mrcAlmacenar.Controls.Add(this.lstLugar);
            this.mrcAlmacenar.Location = new System.Drawing.Point(12, 28);
            this.mrcAlmacenar.Name = "mrcAlmacenar";
            this.mrcAlmacenar.Size = new System.Drawing.Size(445, 261);
            this.mrcAlmacenar.TabIndex = 0;
            this.mrcAlmacenar.TabStop = false;
            this.mrcAlmacenar.Text = "ALMACENAR";
            // 
            // lstLugar
            // 
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Location = new System.Drawing.Point(6, 86);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(156, 28);
            this.lstLugar.TabIndex = 0;
            // 
            // mrcControlDeAlimentos
            // 
            this.mrcControlDeAlimentos.Controls.Add(this.mrcAlmacenado);
            this.mrcControlDeAlimentos.Controls.Add(this.mrcAlmacenar);
            this.mrcControlDeAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcControlDeAlimentos.Location = new System.Drawing.Point(12, 12);
            this.mrcControlDeAlimentos.Name = "mrcControlDeAlimentos";
            this.mrcControlDeAlimentos.Size = new System.Drawing.Size(469, 475);
            this.mrcControlDeAlimentos.TabIndex = 8;
            this.mrcControlDeAlimentos.TabStop = false;
            this.mrcControlDeAlimentos.Text = "Control de Alacena";
            // 
            // cmdComida
            // 
            this.cmdComida.AutoSize = true;
            this.cmdComida.Location = new System.Drawing.Point(14, 25);
            this.cmdComida.Name = "cmdComida";
            this.cmdComida.Size = new System.Drawing.Size(87, 24);
            this.cmdComida.TabIndex = 7;
            this.cmdComida.TabStop = true;
            this.cmdComida.Text = "Comida";
            this.cmdComida.UseVisualStyleBackColor = true;
            // 
            // cmdLimpieza
            // 
            this.cmdLimpieza.AutoSize = true;
            this.cmdLimpieza.Location = new System.Drawing.Point(151, 25);
            this.cmdLimpieza.Name = "cmdLimpieza";
            this.cmdLimpieza.Size = new System.Drawing.Size(98, 24);
            this.cmdLimpieza.TabIndex = 7;
            this.cmdLimpieza.TabStop = true;
            this.cmdLimpieza.Text = "Limpieza";
            this.cmdLimpieza.UseVisualStyleBackColor = true;
            // 
            // cmdMedicamento
            // 
            this.cmdMedicamento.AutoSize = true;
            this.cmdMedicamento.Location = new System.Drawing.Point(293, 25);
            this.cmdMedicamento.Name = "cmdMedicamento";
            this.cmdMedicamento.Size = new System.Drawing.Size(134, 24);
            this.cmdMedicamento.TabIndex = 7;
            this.cmdMedicamento.TabStop = true;
            this.cmdMedicamento.Text = "Medicamento";
            this.cmdMedicamento.UseVisualStyleBackColor = true;
            // 
            // cmdComida1
            // 
            this.cmdComida1.AutoSize = true;
            this.cmdComida1.Location = new System.Drawing.Point(14, 25);
            this.cmdComida1.Name = "cmdComida1";
            this.cmdComida1.Size = new System.Drawing.Size(87, 24);
            this.cmdComida1.TabIndex = 7;
            this.cmdComida1.TabStop = true;
            this.cmdComida1.Text = "Comida";
            this.cmdComida1.UseVisualStyleBackColor = true;
            // 
            // cmdLimpieza1
            // 
            this.cmdLimpieza1.AutoSize = true;
            this.cmdLimpieza1.Location = new System.Drawing.Point(151, 25);
            this.cmdLimpieza1.Name = "cmdLimpieza1";
            this.cmdLimpieza1.Size = new System.Drawing.Size(98, 24);
            this.cmdLimpieza1.TabIndex = 7;
            this.cmdLimpieza1.TabStop = true;
            this.cmdLimpieza1.Text = "Limpieza";
            this.cmdLimpieza1.UseVisualStyleBackColor = true;
            // 
            // cmdMedicamento1
            // 
            this.cmdMedicamento1.AutoSize = true;
            this.cmdMedicamento1.Location = new System.Drawing.Point(293, 25);
            this.cmdMedicamento1.Name = "cmdMedicamento1";
            this.cmdMedicamento1.Size = new System.Drawing.Size(134, 24);
            this.cmdMedicamento1.TabIndex = 7;
            this.cmdMedicamento1.TabStop = true;
            this.cmdMedicamento1.Text = "Medicamento";
            this.cmdMedicamento1.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(372, 85);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(66, 26);
            this.nudCantidad.TabIndex = 8;
            this.nudCantidad.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // nudCantidadMinima
            // 
            this.nudCantidadMinima.Location = new System.Drawing.Point(6, 120);
            this.nudCantidadMinima.Name = "nudCantidadMinima";
            this.nudCantidadMinima.Size = new System.Drawing.Size(156, 26);
            this.nudCantidadMinima.TabIndex = 9;
            this.nudCantidadMinima.Text = "Cantidad Mìnima";
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Location = new System.Drawing.Point(6, 155);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(89, 24);
            this.chkCaduca.TabIndex = 10;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(2, 192);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(188, 20);
            this.lblFechaDeVencimiento.TabIndex = 11;
            this.lblFechaDeVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(191, 189);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(123, 26);
            this.dtpFecha.TabIndex = 12;
            // 
            // lblVencimiento1
            // 
            this.lblVencimiento1.AutoSize = true;
            this.lblVencimiento1.Location = new System.Drawing.Point(2, 125);
            this.lblVencimiento1.Name = "lblVencimiento1";
            this.lblVencimiento1.Size = new System.Drawing.Size(228, 20);
            this.lblVencimiento1.TabIndex = 8;
            this.lblVencimiento1.Text = "Vencimiento: ___________";
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 499);
            this.Controls.Add(this.mrcControlDeAlimentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.mrcAlmacenado.ResumeLayout(false);
            this.mrcAlmacenado.PerformLayout();
            this.mrcAlmacenar.ResumeLayout(false);
            this.mrcAlmacenar.PerformLayout();
            this.mrcControlDeAlimentos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcAlmacenado;
        private System.Windows.Forms.Label lblCantidad3;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Label lblProducto2;
        private System.Windows.Forms.Label lblLugar2;
        private System.Windows.Forms.ComboBox lstAlimento2;
        private System.Windows.Forms.ComboBox lstLugar2;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox lstAlimento;
        private System.Windows.Forms.GroupBox mrcAlmacenar;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.GroupBox mrcControlDeAlimentos;
        private System.Windows.Forms.RadioButton cmdMedicamento;
        private System.Windows.Forms.RadioButton cmdLimpieza;
        private System.Windows.Forms.RadioButton cmdComida;
        private System.Windows.Forms.RadioButton cmdMedicamento1;
        private System.Windows.Forms.RadioButton cmdLimpieza1;
        private System.Windows.Forms.RadioButton cmdComida1;
        private System.Windows.Forms.DomainUpDown nudCantidad;
        private System.Windows.Forms.Label lblVencimiento1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaDeVencimiento;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.DomainUpDown nudCantidadMinima;
    }
}
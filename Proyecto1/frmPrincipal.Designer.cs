namespace Proyecto1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdControlDeGastos = new System.Windows.Forms.Button();
            this.cmdControlDeAlacena = new System.Windows.Forms.Button();
            this.picControlDeGastos = new System.Windows.Forms.PictureBox();
            this.picControlDeAlacena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picControlDeGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControlDeAlacena)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdControlDeGastos
            // 
            this.cmdControlDeGastos.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdControlDeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdControlDeGastos.Location = new System.Drawing.Point(43, 24);
            this.cmdControlDeGastos.Name = "cmdControlDeGastos";
            this.cmdControlDeGastos.Size = new System.Drawing.Size(215, 85);
            this.cmdControlDeGastos.TabIndex = 0;
            this.cmdControlDeGastos.Text = "Control De Gastos";
            this.cmdControlDeGastos.UseVisualStyleBackColor = false;
            this.cmdControlDeGastos.Click += new System.EventHandler(this.cmdControlDeGastos_Click);
            // 
            // cmdControlDeAlacena
            // 
            this.cmdControlDeAlacena.BackColor = System.Drawing.Color.Khaki;
            this.cmdControlDeAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdControlDeAlacena.Location = new System.Drawing.Point(301, 24);
            this.cmdControlDeAlacena.Name = "cmdControlDeAlacena";
            this.cmdControlDeAlacena.Size = new System.Drawing.Size(281, 85);
            this.cmdControlDeAlacena.TabIndex = 0;
            this.cmdControlDeAlacena.Text = "Control de Alacena";
            this.cmdControlDeAlacena.UseVisualStyleBackColor = false;
            this.cmdControlDeAlacena.Click += new System.EventHandler(this.cmdControlDeAlacena_Click);
            // 
            // picControlDeGastos
            // 
            this.picControlDeGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picControlDeGastos.Image = global::Proyecto1.Properties.Resources.Captura_de_pantalla_2023_04_21_134839;
            this.picControlDeGastos.Location = new System.Drawing.Point(43, 115);
            this.picControlDeGastos.Name = "picControlDeGastos";
            this.picControlDeGastos.Size = new System.Drawing.Size(215, 317);
            this.picControlDeGastos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControlDeGastos.TabIndex = 1;
            this.picControlDeGastos.TabStop = false;
            this.picControlDeGastos.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picControlDeAlacena
            // 
            this.picControlDeAlacena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picControlDeAlacena.Image = global::Proyecto1.Properties.Resources.Captura_de_pantalla_2023_04_21_141703;
            this.picControlDeAlacena.Location = new System.Drawing.Point(301, 115);
            this.picControlDeAlacena.Name = "picControlDeAlacena";
            this.picControlDeAlacena.Size = new System.Drawing.Size(281, 317);
            this.picControlDeAlacena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControlDeAlacena.TabIndex = 1;
            this.picControlDeAlacena.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 455);
            this.Controls.Add(this.picControlDeGastos);
            this.Controls.Add(this.picControlDeAlacena);
            this.Controls.Add(this.cmdControlDeAlacena);
            this.Controls.Add(this.cmdControlDeGastos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.picControlDeGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControlDeAlacena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdControlDeGastos;
        private System.Windows.Forms.Button cmdControlDeAlacena;
        private System.Windows.Forms.PictureBox picControlDeAlacena;
        private System.Windows.Forms.PictureBox picControlDeGastos;
    }
}
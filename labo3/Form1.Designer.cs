namespace labo3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jugadoresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frecuenciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endulzadasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.valorEndulzadaTextBox = new System.Windows.Forms.TextBox();
            this.valorRegaloTextBox = new System.Windows.Forms.TextBox();
            this.CrearJuego = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecuenciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endulzadasNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catidad de jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de inicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destape";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de la endulzada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor del regalo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frecuencia de endulzadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero de endulzadas";
            // 
            // jugadoresNumericUpDown
            // 
            this.jugadoresNumericUpDown.Location = new System.Drawing.Point(62, 69);
            this.jugadoresNumericUpDown.Name = "jugadoresNumericUpDown";
            this.jugadoresNumericUpDown.Size = new System.Drawing.Size(128, 20);
            this.jugadoresNumericUpDown.TabIndex = 7;
            // 
            // frecuenciaNumericUpDown
            // 
            this.frecuenciaNumericUpDown.Location = new System.Drawing.Point(338, 133);
            this.frecuenciaNumericUpDown.Name = "frecuenciaNumericUpDown";
            this.frecuenciaNumericUpDown.Size = new System.Drawing.Size(128, 20);
            this.frecuenciaNumericUpDown.TabIndex = 8;
            // 
            // endulzadasNumericUpDown
            // 
            this.endulzadasNumericUpDown.Location = new System.Drawing.Point(338, 69);
            this.endulzadasNumericUpDown.Name = "endulzadasNumericUpDown";
            this.endulzadasNumericUpDown.Size = new System.Drawing.Size(128, 20);
            this.endulzadasNumericUpDown.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(66, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // valorEndulzadaTextBox
            // 
            this.valorEndulzadaTextBox.Location = new System.Drawing.Point(338, 196);
            this.valorEndulzadaTextBox.Name = "valorEndulzadaTextBox";
            this.valorEndulzadaTextBox.Size = new System.Drawing.Size(129, 20);
            this.valorEndulzadaTextBox.TabIndex = 12;
            // 
            // valorRegaloTextBox
            // 
            this.valorRegaloTextBox.Location = new System.Drawing.Point(338, 246);
            this.valorRegaloTextBox.Name = "valorRegaloTextBox";
            this.valorRegaloTextBox.Size = new System.Drawing.Size(129, 20);
            this.valorRegaloTextBox.TabIndex = 13;
            // 
            // CrearJuego
            // 
            this.CrearJuego.Location = new System.Drawing.Point(221, 259);
            this.CrearJuego.Name = "CrearJuego";
            this.CrearJuego.Size = new System.Drawing.Size(95, 36);
            this.CrearJuego.TabIndex = 14;
            this.CrearJuego.Text = "Crear juego";
            this.CrearJuego.UseVisualStyleBackColor = true;
            this.CrearJuego.Click += new System.EventHandler(this.CrearJuego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 302);
            this.Controls.Add(this.CrearJuego);
            this.Controls.Add(this.valorRegaloTextBox);
            this.Controls.Add(this.valorEndulzadaTextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.endulzadasNumericUpDown);
            this.Controls.Add(this.frecuenciaNumericUpDown);
            this.Controls.Add(this.jugadoresNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amigo Secreto";
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecuenciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endulzadasNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown jugadoresNumericUpDown;
        private System.Windows.Forms.NumericUpDown frecuenciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown endulzadasNumericUpDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox valorEndulzadaTextBox;
        private System.Windows.Forms.TextBox valorRegaloTextBox;
        private System.Windows.Forms.Button CrearJuego;
    }
}


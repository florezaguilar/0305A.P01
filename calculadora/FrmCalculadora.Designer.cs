namespace calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdIgual = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdMenos = new System.Windows.Forms.Button();
            this.CmdMas = new System.Windows.Forms.Button();
            this.Cmdpor = new System.Windows.Forms.Button();
            this.Cmdentre = new System.Windows.Forms.Button();
            this.Cmdpunto = new System.Windows.Forms.Button();
            this.Cmd3 = new System.Windows.Forms.Button();
            this.Cmd6 = new System.Windows.Forms.Button();
            this.Cmd9 = new System.Windows.Forms.Button();
            this.CmdC = new System.Windows.Forms.Button();
            this.Cmd0 = new System.Windows.Forms.Button();
            this.Cmd2 = new System.Windows.Forms.Button();
            this.Cmd1 = new System.Windows.Forms.Button();
            this.Cmd5 = new System.Windows.Forms.Button();
            this.Cmd4 = new System.Windows.Forms.Button();
            this.Cmd8 = new System.Windows.Forms.Button();
            this.Cmd7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdIgual
            // 
            this.CmdIgual.Location = new System.Drawing.Point(202, 139);
            this.CmdIgual.Name = "CmdIgual";
            this.CmdIgual.Size = new System.Drawing.Size(41, 81);
            this.CmdIgual.TabIndex = 34;
            this.CmdIgual.Text = "=";
            this.CmdIgual.UseVisualStyleBackColor = true;
            this.CmdIgual.Click += new System.EventHandler(this.CmdIgual_Click);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(202, 50);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(41, 38);
            this.CmdEliminar.TabIndex = 33;
            this.CmdEliminar.Text = "←";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdMenos
            // 
            this.CmdMenos.Location = new System.Drawing.Point(155, 182);
            this.CmdMenos.Name = "CmdMenos";
            this.CmdMenos.Size = new System.Drawing.Size(41, 38);
            this.CmdMenos.TabIndex = 21;
            this.CmdMenos.Text = "-";
            this.CmdMenos.UseVisualStyleBackColor = true;
            this.CmdMenos.Click += new System.EventHandler(this.CmdMenos_Click);
            // 
            // CmdMas
            // 
            this.CmdMas.Location = new System.Drawing.Point(155, 138);
            this.CmdMas.Name = "CmdMas";
            this.CmdMas.Size = new System.Drawing.Size(41, 38);
            this.CmdMas.TabIndex = 30;
            this.CmdMas.Text = "+";
            this.CmdMas.UseVisualStyleBackColor = true;
            this.CmdMas.Click += new System.EventHandler(this.CmdMas_Click);
            // 
            // Cmdpor
            // 
            this.Cmdpor.Location = new System.Drawing.Point(155, 94);
            this.Cmdpor.Name = "Cmdpor";
            this.Cmdpor.Size = new System.Drawing.Size(41, 38);
            this.Cmdpor.TabIndex = 31;
            this.Cmdpor.Text = "*";
            this.Cmdpor.UseVisualStyleBackColor = true;
            this.Cmdpor.Click += new System.EventHandler(this.Cmdpor_Click);
            // 
            // Cmdentre
            // 
            this.Cmdentre.Location = new System.Drawing.Point(155, 50);
            this.Cmdentre.Name = "Cmdentre";
            this.Cmdentre.Size = new System.Drawing.Size(41, 38);
            this.Cmdentre.TabIndex = 32;
            this.Cmdentre.Text = "/";
            this.Cmdentre.UseVisualStyleBackColor = true;
            this.Cmdentre.Click += new System.EventHandler(this.Cmdentre_Click);
            // 
            // Cmdpunto
            // 
            this.Cmdpunto.Location = new System.Drawing.Point(108, 182);
            this.Cmdpunto.Name = "Cmdpunto";
            this.Cmdpunto.Size = new System.Drawing.Size(41, 38);
            this.Cmdpunto.TabIndex = 18;
            this.Cmdpunto.Text = ".";
            this.Cmdpunto.UseVisualStyleBackColor = true;
            this.Cmdpunto.Click += new System.EventHandler(this.Cmdpunto_Click);
            // 
            // Cmd3
            // 
            this.Cmd3.Location = new System.Drawing.Point(108, 138);
            this.Cmd3.Name = "Cmd3";
            this.Cmd3.Size = new System.Drawing.Size(41, 38);
            this.Cmd3.TabIndex = 23;
            this.Cmd3.Text = "3";
            this.Cmd3.UseVisualStyleBackColor = true;
            this.Cmd3.Click += new System.EventHandler(this.Cmd3_Click);
            // 
            // Cmd6
            // 
            this.Cmd6.Location = new System.Drawing.Point(108, 94);
            this.Cmd6.Name = "Cmd6";
            this.Cmd6.Size = new System.Drawing.Size(41, 38);
            this.Cmd6.TabIndex = 26;
            this.Cmd6.Text = "6";
            this.Cmd6.UseVisualStyleBackColor = true;
            this.Cmd6.Click += new System.EventHandler(this.Cmd6_Click);
            // 
            // Cmd9
            // 
            this.Cmd9.Location = new System.Drawing.Point(108, 50);
            this.Cmd9.Name = "Cmd9";
            this.Cmd9.Size = new System.Drawing.Size(41, 38);
            this.Cmd9.TabIndex = 29;
            this.Cmd9.Text = "9";
            this.Cmd9.UseVisualStyleBackColor = true;
            this.Cmd9.Click += new System.EventHandler(this.Cmd9_Click);
            // 
            // CmdC
            // 
            this.CmdC.Location = new System.Drawing.Point(203, 94);
            this.CmdC.Name = "CmdC";
            this.CmdC.Size = new System.Drawing.Size(41, 38);
            this.CmdC.TabIndex = 20;
            this.CmdC.Text = "C";
            this.CmdC.UseVisualStyleBackColor = true;
            this.CmdC.Click += new System.EventHandler(this.CmdC_Click);
            // 
            // Cmd0
            // 
            this.Cmd0.Location = new System.Drawing.Point(14, 183);
            this.Cmd0.Name = "Cmd0";
            this.Cmd0.Size = new System.Drawing.Size(88, 38);
            this.Cmd0.TabIndex = 19;
            this.Cmd0.Text = "0";
            this.Cmd0.UseVisualStyleBackColor = true;
            this.Cmd0.Click += new System.EventHandler(this.Cmd0_Click);
            // 
            // Cmd2
            // 
            this.Cmd2.Location = new System.Drawing.Point(61, 138);
            this.Cmd2.Name = "Cmd2";
            this.Cmd2.Size = new System.Drawing.Size(41, 38);
            this.Cmd2.TabIndex = 22;
            this.Cmd2.Text = "2";
            this.Cmd2.UseVisualStyleBackColor = true;
            this.Cmd2.Click += new System.EventHandler(this.Cmd2_Click);
            // 
            // Cmd1
            // 
            this.Cmd1.Location = new System.Drawing.Point(14, 139);
            this.Cmd1.Name = "Cmd1";
            this.Cmd1.Size = new System.Drawing.Size(41, 38);
            this.Cmd1.TabIndex = 17;
            this.Cmd1.Text = "1";
            this.Cmd1.UseVisualStyleBackColor = true;
            this.Cmd1.Click += new System.EventHandler(this.Cmd1_Click);
            // 
            // Cmd5
            // 
            this.Cmd5.Location = new System.Drawing.Point(61, 94);
            this.Cmd5.Name = "Cmd5";
            this.Cmd5.Size = new System.Drawing.Size(41, 38);
            this.Cmd5.TabIndex = 25;
            this.Cmd5.Text = "5";
            this.Cmd5.UseVisualStyleBackColor = true;
            this.Cmd5.Click += new System.EventHandler(this.Cmd5_Click);
            // 
            // Cmd4
            // 
            this.Cmd4.Location = new System.Drawing.Point(14, 95);
            this.Cmd4.Name = "Cmd4";
            this.Cmd4.Size = new System.Drawing.Size(41, 38);
            this.Cmd4.TabIndex = 24;
            this.Cmd4.Text = "4";
            this.Cmd4.UseVisualStyleBackColor = true;
            this.Cmd4.Click += new System.EventHandler(this.Cmd4_Click);
            // 
            // Cmd8
            // 
            this.Cmd8.Location = new System.Drawing.Point(61, 50);
            this.Cmd8.Name = "Cmd8";
            this.Cmd8.Size = new System.Drawing.Size(41, 38);
            this.Cmd8.TabIndex = 28;
            this.Cmd8.Text = "8";
            this.Cmd8.UseVisualStyleBackColor = true;
            this.Cmd8.Click += new System.EventHandler(this.Cmd8_Click);
            // 
            // Cmd7
            // 
            this.Cmd7.Location = new System.Drawing.Point(14, 51);
            this.Cmd7.Name = "Cmd7";
            this.Cmd7.Size = new System.Drawing.Size(41, 38);
            this.Cmd7.TabIndex = 27;
            this.Cmd7.Text = "7";
            this.Cmd7.UseVisualStyleBackColor = true;
            this.Cmd7.Click += new System.EventHandler(this.Cmd7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 32);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 242);
            this.Controls.Add(this.CmdIgual);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdMenos);
            this.Controls.Add(this.CmdMas);
            this.Controls.Add(this.Cmdpor);
            this.Controls.Add(this.Cmdentre);
            this.Controls.Add(this.Cmdpunto);
            this.Controls.Add(this.Cmd3);
            this.Controls.Add(this.Cmd6);
            this.Controls.Add(this.Cmd9);
            this.Controls.Add(this.CmdC);
            this.Controls.Add(this.Cmd0);
            this.Controls.Add(this.Cmd2);
            this.Controls.Add(this.Cmd1);
            this.Controls.Add(this.Cmd5);
            this.Controls.Add(this.Cmd4);
            this.Controls.Add(this.Cmd8);
            this.Controls.Add(this.Cmd7);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(280, 280);
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "FrmCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdIgual;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdMenos;
        private System.Windows.Forms.Button CmdMas;
        private System.Windows.Forms.Button Cmdpor;
        private System.Windows.Forms.Button Cmdentre;
        private System.Windows.Forms.Button Cmdpunto;
        private System.Windows.Forms.Button Cmd3;
        private System.Windows.Forms.Button Cmd6;
        private System.Windows.Forms.Button Cmd9;
        private System.Windows.Forms.Button CmdC;
        private System.Windows.Forms.Button Cmd0;
        private System.Windows.Forms.Button Cmd2;
        private System.Windows.Forms.Button Cmd1;
        private System.Windows.Forms.Button Cmd5;
        private System.Windows.Forms.Button Cmd4;
        private System.Windows.Forms.Button Cmd8;
        private System.Windows.Forms.Button Cmd7;
        private System.Windows.Forms.TextBox textBox1;
    }
}


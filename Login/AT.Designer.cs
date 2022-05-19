namespace Login
{
    partial class AT
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
            this.TxtDmaj = new System.Windows.Forms.TextBox();
            this.TxtDmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDmaj
            // 
            this.TxtDmaj.BackColor = System.Drawing.Color.LightGray;
            this.TxtDmaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDmaj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDmaj.ForeColor = System.Drawing.Color.Black;
            this.TxtDmaj.Location = new System.Drawing.Point(109, 64);
            this.TxtDmaj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtDmaj.Name = "TxtDmaj";
            this.TxtDmaj.Size = new System.Drawing.Size(72, 14);
            this.TxtDmaj.TabIndex = 1;
            this.TxtDmaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDmaj_KeyPress);
            // 
            // TxtDmin
            // 
            this.TxtDmin.BackColor = System.Drawing.Color.LightGray;
            this.TxtDmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDmin.ForeColor = System.Drawing.Color.Black;
            this.TxtDmin.Location = new System.Drawing.Point(109, 97);
            this.TxtDmin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtDmin.Name = "TxtDmin";
            this.TxtDmin.Size = new System.Drawing.Size(72, 14);
            this.TxtDmin.TabIndex = 2;
            this.TxtDmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDmin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Área del Rombo";
            // 
            // Btncalcular
            // 
            this.Btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncalcular.FlatAppearance.BorderSize = 0;
            this.Btncalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btncalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncalcular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncalcular.ForeColor = System.Drawing.Color.LightGray;
            this.Btncalcular.Location = new System.Drawing.Point(20, 161);
            this.Btncalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(72, 24);
            this.Btncalcular.TabIndex = 4;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = false;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // TxtArea
            // 
            this.TxtArea.BackColor = System.Drawing.Color.LightGray;
            this.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtArea.Enabled = false;
            this.TxtArea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.ForeColor = System.Drawing.Color.Black;
            this.TxtArea.Location = new System.Drawing.Point(109, 130);
            this.TxtArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(72, 15);
            this.TxtArea.TabIndex = 8;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlimpiar.FlatAppearance.BorderSize = 0;
            this.Btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.Btnlimpiar.Location = new System.Drawing.Point(109, 161);
            this.Btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(72, 24);
            this.Btnlimpiar.TabIndex = 9;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click_1);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnsalir.FlatAppearance.BorderSize = 0;
            this.Btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.ForeColor = System.Drawing.Color.LightGray;
            this.Btnsalir.Location = new System.Drawing.Point(195, 161);
            this.Btnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(72, 24);
            this.Btnsalir.TabIndex = 10;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Diagonal Mayor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diagonal Menor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Área";
            // 
            // AT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(294, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDmin);
            this.Controls.Add(this.TxtDmaj);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area del rombo.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDmaj;
        private System.Windows.Forms.TextBox TxtDmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


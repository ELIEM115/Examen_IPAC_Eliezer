namespace EliezerMartinez
{
    partial class Menu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Formulario3Button = new System.Windows.Forms.Button();
            this.Formulario2Button = new System.Windows.Forms.Button();
            this.Formulario1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ir al :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ir al :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ir al :";
            // 
            // Formulario3Button
            // 
            this.Formulario3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario3Button.Location = new System.Drawing.Point(578, 213);
            this.Formulario3Button.Name = "Formulario3Button";
            this.Formulario3Button.Size = new System.Drawing.Size(167, 54);
            this.Formulario3Button.TabIndex = 9;
            this.Formulario3Button.Text = "FORMULARIO 3";
            this.Formulario3Button.UseVisualStyleBackColor = true;
            this.Formulario3Button.Click += new System.EventHandler(this.Formulario3Button_Click);
            // 
            // Formulario2Button
            // 
            this.Formulario2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario2Button.Location = new System.Drawing.Point(313, 213);
            this.Formulario2Button.Name = "Formulario2Button";
            this.Formulario2Button.Size = new System.Drawing.Size(167, 54);
            this.Formulario2Button.TabIndex = 8;
            this.Formulario2Button.Text = "FORMULARIO 2";
            this.Formulario2Button.UseVisualStyleBackColor = true;
            this.Formulario2Button.Click += new System.EventHandler(this.Formulario2Button_Click);
            // 
            // Formulario1Button
            // 
            this.Formulario1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario1Button.Location = new System.Drawing.Point(55, 213);
            this.Formulario1Button.Name = "Formulario1Button";
            this.Formulario1Button.Size = new System.Drawing.Size(167, 54);
            this.Formulario1Button.TabIndex = 7;
            this.Formulario1Button.Text = "FORMULARIO 1";
            this.Formulario1Button.UseVisualStyleBackColor = true;
            this.Formulario1Button.Click += new System.EventHandler(this.Formulario1Button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Formulario3Button);
            this.Controls.Add(this.Formulario2Button);
            this.Controls.Add(this.Formulario1Button);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Formulario3Button;
        private System.Windows.Forms.Button Formulario2Button;
        private System.Windows.Forms.Button Formulario1Button;
    }
}


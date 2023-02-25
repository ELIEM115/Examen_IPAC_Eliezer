namespace EliezerMartinez
{
    partial class Formulario_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Precio2TextBox = new System.Windows.Forms.TextBox();
            this.Producto2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Precio1TextBox = new System.Windows.Forms.TextBox();
            this.Producto1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese el precio unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ingrese el nombre del segundo producto:";
            // 
            // Precio2TextBox
            // 
            this.Precio2TextBox.Location = new System.Drawing.Point(61, 281);
            this.Precio2TextBox.Name = "Precio2TextBox";
            this.Precio2TextBox.Size = new System.Drawing.Size(144, 20);
            this.Precio2TextBox.TabIndex = 15;
            // 
            // Producto2TextBox
            // 
            this.Producto2TextBox.Location = new System.Drawing.Point(61, 203);
            this.Producto2TextBox.Name = "Producto2TextBox";
            this.Producto2TextBox.Size = new System.Drawing.Size(144, 20);
            this.Producto2TextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese el precio unitario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese el nombre del primer producto:";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(310, 232);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(79, 69);
            this.CalcularButton.TabIndex = 11;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Precio1TextBox
            // 
            this.Precio1TextBox.Location = new System.Drawing.Point(61, 139);
            this.Precio1TextBox.Name = "Precio1TextBox";
            this.Precio1TextBox.Size = new System.Drawing.Size(144, 20);
            this.Precio1TextBox.TabIndex = 10;
            // 
            // Producto1TextBox
            // 
            this.Producto1TextBox.Location = new System.Drawing.Point(61, 60);
            this.Producto1TextBox.Name = "Producto1TextBox";
            this.Producto1TextBox.Size = new System.Drawing.Size(144, 20);
            this.Producto1TextBox.TabIndex = 9;
            // 
            // Formulario_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(451, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Precio2TextBox);
            this.Controls.Add(this.Producto2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.Precio1TextBox);
            this.Controls.Add(this.Producto1TextBox);
            this.Name = "Formulario_2";
            this.Text = "Formulario_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Precio2TextBox;
        private System.Windows.Forms.TextBox Producto2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox Precio1TextBox;
        private System.Windows.Forms.TextBox Producto1TextBox;
    }
}
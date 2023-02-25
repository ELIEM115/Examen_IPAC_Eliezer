namespace EliezerMartinez
{
    partial class Formulario_3
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
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EjecutarButton.Location = new System.Drawing.Point(305, 145);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(76, 89);
            this.EjecutarButton.TabIndex = 3;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = false;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 277);
            this.listBox1.TabIndex = 2;
            // 
            // Formulario_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(433, 371);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Formulario_3";
            this.Text = "Formulario_3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}
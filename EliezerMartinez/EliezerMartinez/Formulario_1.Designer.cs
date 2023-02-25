namespace EliezerMartinez
{
    partial class Formulario_1
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.listBoxMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.Color.SpringGreen;
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(299, 172);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(149, 57);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // listBoxMeses
            // 
            this.listBoxMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxMeses.FormattingEnabled = true;
            this.listBoxMeses.Location = new System.Drawing.Point(12, 22);
            this.listBoxMeses.Name = "listBoxMeses";
            this.listBoxMeses.Size = new System.Drawing.Size(235, 355);
            this.listBoxMeses.TabIndex = 2;
            // 
            // Formulario_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(497, 433);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.listBoxMeses);
            this.Name = "Formulario_1";
            this.Text = "Formulario_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ListBox listBoxMeses;
    }
}
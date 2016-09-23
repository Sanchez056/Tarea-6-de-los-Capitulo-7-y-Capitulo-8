namespace Ejerccio4_Capitulo_8
{
    partial class SumaNumeroNegativo
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
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.DigiteNumero1label = new System.Windows.Forms.Label();
            this.DigiteNumero2label2 = new System.Windows.Forms.Label();
            this.DigiteNumero1textBox1 = new System.Windows.Forms.TextBox();
            this.DigiteNumero2textBox2 = new System.Windows.Forms.TextBox();
            this.ResultadotextBox1 = new System.Windows.Forms.TextBox();
            this.Resultadolabel1 = new System.Windows.Forms.Label();
            this.Comentariolabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(80, 77);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 0;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // DigiteNumero1label
            // 
            this.DigiteNumero1label.AutoSize = true;
            this.DigiteNumero1label.Location = new System.Drawing.Point(13, 25);
            this.DigiteNumero1label.Name = "DigiteNumero1label";
            this.DigiteNumero1label.Size = new System.Drawing.Size(83, 13);
            this.DigiteNumero1label.TabIndex = 1;
            this.DigiteNumero1label.Text = "Digite Numero 1";
            // 
            // DigiteNumero2label2
            // 
            this.DigiteNumero2label2.AutoSize = true;
            this.DigiteNumero2label2.Location = new System.Drawing.Point(136, 25);
            this.DigiteNumero2label2.Name = "DigiteNumero2label2";
            this.DigiteNumero2label2.Size = new System.Drawing.Size(83, 13);
            this.DigiteNumero2label2.TabIndex = 2;
            this.DigiteNumero2label2.Text = "Digite Numero 2";
            // 
            // DigiteNumero1textBox1
            // 
            this.DigiteNumero1textBox1.Location = new System.Drawing.Point(16, 51);
            this.DigiteNumero1textBox1.Name = "DigiteNumero1textBox1";
            this.DigiteNumero1textBox1.Size = new System.Drawing.Size(80, 20);
            this.DigiteNumero1textBox1.TabIndex = 3;
            // 
            // DigiteNumero2textBox2
            // 
            this.DigiteNumero2textBox2.Location = new System.Drawing.Point(139, 51);
            this.DigiteNumero2textBox2.Name = "DigiteNumero2textBox2";
            this.DigiteNumero2textBox2.Size = new System.Drawing.Size(80, 20);
            this.DigiteNumero2textBox2.TabIndex = 4;
            // 
            // ResultadotextBox1
            // 
            this.ResultadotextBox1.Location = new System.Drawing.Point(16, 176);
            this.ResultadotextBox1.Name = "ResultadotextBox1";
            this.ResultadotextBox1.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox1.TabIndex = 5;
            // 
            // Resultadolabel1
            // 
            this.Resultadolabel1.AutoSize = true;
            this.Resultadolabel1.Location = new System.Drawing.Point(16, 157);
            this.Resultadolabel1.Name = "Resultadolabel1";
            this.Resultadolabel1.Size = new System.Drawing.Size(55, 13);
            this.Resultadolabel1.TabIndex = 6;
            this.Resultadolabel1.Text = "Resultado";
            // 
            // Comentariolabel1
            // 
            this.Comentariolabel1.AutoSize = true;
            this.Comentariolabel1.Location = new System.Drawing.Point(-3, 103);
            this.Comentariolabel1.Name = "Comentariolabel1";
            this.Comentariolabel1.Size = new System.Drawing.Size(394, 13);
            this.Comentariolabel1.TabIndex = 7;
            this.Comentariolabel1.Text = "Si es una Suma de numero Negativo se Colocaran dos parentecis en el Resultado";
            // 
            // SumaNumeroNegativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.Comentariolabel1);
            this.Controls.Add(this.Resultadolabel1);
            this.Controls.Add(this.ResultadotextBox1);
            this.Controls.Add(this.DigiteNumero2textBox2);
            this.Controls.Add(this.DigiteNumero1textBox1);
            this.Controls.Add(this.DigiteNumero2label2);
            this.Controls.Add(this.DigiteNumero1label);
            this.Controls.Add(this.Calcularbutton1);
            this.Name = "SumaNumeroNegativo";
            this.Text = "Suma de Numero Negativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton1;
        private System.Windows.Forms.Label DigiteNumero1label;
        private System.Windows.Forms.Label DigiteNumero2label2;
        private System.Windows.Forms.TextBox DigiteNumero1textBox1;
        private System.Windows.Forms.TextBox DigiteNumero2textBox2;
        private System.Windows.Forms.TextBox ResultadotextBox1;
        private System.Windows.Forms.Label Resultadolabel1;
        private System.Windows.Forms.Label Comentariolabel1;
    }
}


namespace Ejerccio5_Capitulo_8
{
    partial class OrdenAlfabeticoCadena
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
            this.DigiteCadenaLetralabel1 = new System.Windows.Forms.Label();
            this.DigiteCadena1textBox1 = new System.Windows.Forms.TextBox();
            this.OrdenarAlfabeticamentebutton1 = new System.Windows.Forms.Button();
            this.Comentariolabel1 = new System.Windows.Forms.Label();
            this.ResultadoCadenaOrdenadasLabel = new System.Windows.Forms.Label();
            this.ResultadoCadenasOrdenadastextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DigiteCadenaLetralabel1
            // 
            this.DigiteCadenaLetralabel1.AutoSize = true;
            this.DigiteCadenaLetralabel1.Location = new System.Drawing.Point(12, 25);
            this.DigiteCadenaLetralabel1.Name = "DigiteCadenaLetralabel1";
            this.DigiteCadenaLetralabel1.Size = new System.Drawing.Size(121, 13);
            this.DigiteCadenaLetralabel1.TabIndex = 0;
            this.DigiteCadenaLetralabel1.Text = "Digite Cadena de Letras";
            // 
            // DigiteCadena1textBox1
            // 
            this.DigiteCadena1textBox1.Location = new System.Drawing.Point(15, 41);
            this.DigiteCadena1textBox1.Name = "DigiteCadena1textBox1";
            this.DigiteCadena1textBox1.Size = new System.Drawing.Size(124, 20);
            this.DigiteCadena1textBox1.TabIndex = 1;
            // 
            // OrdenarAlfabeticamentebutton1
            // 
            this.OrdenarAlfabeticamentebutton1.Location = new System.Drawing.Point(78, 67);
            this.OrdenarAlfabeticamentebutton1.Name = "OrdenarAlfabeticamentebutton1";
            this.OrdenarAlfabeticamentebutton1.Size = new System.Drawing.Size(75, 23);
            this.OrdenarAlfabeticamentebutton1.TabIndex = 4;
            this.OrdenarAlfabeticamentebutton1.Text = "Ordenar";
            this.OrdenarAlfabeticamentebutton1.UseVisualStyleBackColor = true;
            this.OrdenarAlfabeticamentebutton1.Click += new System.EventHandler(this.OrdenarAlfabeticamentebutton1_Click);
            // 
            // Comentariolabel1
            // 
            this.Comentariolabel1.AutoSize = true;
            this.Comentariolabel1.Location = new System.Drawing.Point(12, 93);
            this.Comentariolabel1.Name = "Comentariolabel1";
            this.Comentariolabel1.Size = new System.Drawing.Size(234, 13);
            this.Comentariolabel1.TabIndex = 5;
            this.Comentariolabel1.Text = "Ordenar de Forma Alfabeticamente Una Cadena";
            // 
            // ResultadoCadenaOrdenadasLabel
            // 
            this.ResultadoCadenaOrdenadasLabel.AutoSize = true;
            this.ResultadoCadenaOrdenadasLabel.Location = new System.Drawing.Point(12, 153);
            this.ResultadoCadenaOrdenadasLabel.Name = "ResultadoCadenaOrdenadasLabel";
            this.ResultadoCadenaOrdenadasLabel.Size = new System.Drawing.Size(94, 13);
            this.ResultadoCadenaOrdenadasLabel.TabIndex = 6;
            this.ResultadoCadenaOrdenadasLabel.Text = "Cadena Ordenada";
            // 
            // ResultadoCadenasOrdenadastextBox3
            // 
            this.ResultadoCadenasOrdenadastextBox3.Location = new System.Drawing.Point(15, 169);
            this.ResultadoCadenasOrdenadastextBox3.Name = "ResultadoCadenasOrdenadastextBox3";
            this.ResultadoCadenasOrdenadastextBox3.Size = new System.Drawing.Size(271, 20);
            this.ResultadoCadenasOrdenadastextBox3.TabIndex = 7;
            // 
            // OrdenAlfabeticoCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.ResultadoCadenasOrdenadastextBox3);
            this.Controls.Add(this.ResultadoCadenaOrdenadasLabel);
            this.Controls.Add(this.Comentariolabel1);
            this.Controls.Add(this.OrdenarAlfabeticamentebutton1);
            this.Controls.Add(this.DigiteCadena1textBox1);
            this.Controls.Add(this.DigiteCadenaLetralabel1);
            this.Name = "OrdenAlfabeticoCadena";
            this.Text = "Ordenar en Orden Alfabetico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DigiteCadenaLetralabel1;
        private System.Windows.Forms.TextBox DigiteCadena1textBox1;
        private System.Windows.Forms.Button OrdenarAlfabeticamentebutton1;
        private System.Windows.Forms.Label Comentariolabel1;
        private System.Windows.Forms.Label ResultadoCadenaOrdenadasLabel;
        private System.Windows.Forms.TextBox ResultadoCadenasOrdenadastextBox3;
    }
}


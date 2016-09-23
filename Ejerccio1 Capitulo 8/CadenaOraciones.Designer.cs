namespace Ejerccio1_Capitulo_8
{
    partial class CadenaOraciones
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
            this.SepararOracionbutton1 = new System.Windows.Forms.Button();
            this.DigiteCadenaOracionlabel1 = new System.Windows.Forms.Label();
            this.DigiteCadenaOraciontextBox1 = new System.Windows.Forms.TextBox();
            this.ResultadolistBox1 = new System.Windows.Forms.ListBox();
            this.Comentariolabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SepararOracionbutton1
            // 
            this.SepararOracionbutton1.Location = new System.Drawing.Point(61, 76);
            this.SepararOracionbutton1.Name = "SepararOracionbutton1";
            this.SepararOracionbutton1.Size = new System.Drawing.Size(120, 23);
            this.SepararOracionbutton1.TabIndex = 0;
            this.SepararOracionbutton1.Text = "Separar Oracion";
            this.SepararOracionbutton1.UseVisualStyleBackColor = true;
            this.SepararOracionbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DigiteCadenaOracionlabel1
            // 
            this.DigiteCadenaOracionlabel1.AutoSize = true;
            this.DigiteCadenaOracionlabel1.Location = new System.Drawing.Point(12, 34);
            this.DigiteCadenaOracionlabel1.Name = "DigiteCadenaOracionlabel1";
            this.DigiteCadenaOracionlabel1.Size = new System.Drawing.Size(88, 13);
            this.DigiteCadenaOracionlabel1.TabIndex = 1;
            this.DigiteCadenaOracionlabel1.Text = "Digite la  Oracion";
            // 
            // DigiteCadenaOraciontextBox1
            // 
            this.DigiteCadenaOraciontextBox1.Location = new System.Drawing.Point(12, 50);
            this.DigiteCadenaOraciontextBox1.Name = "DigiteCadenaOraciontextBox1";
            this.DigiteCadenaOraciontextBox1.Size = new System.Drawing.Size(260, 20);
            this.DigiteCadenaOraciontextBox1.TabIndex = 3;
            // 
            // ResultadolistBox1
            // 
            this.ResultadolistBox1.FormattingEnabled = true;
            this.ResultadolistBox1.Location = new System.Drawing.Point(12, 136);
            this.ResultadolistBox1.Name = "ResultadolistBox1";
            this.ResultadolistBox1.Size = new System.Drawing.Size(179, 69);
            this.ResultadolistBox1.TabIndex = 5;
            // 
            // Comentariolabel1
            // 
            this.Comentariolabel1.AutoSize = true;
            this.Comentariolabel1.Location = new System.Drawing.Point(3, 208);
            this.Comentariolabel1.Name = "Comentariolabel1";
            this.Comentariolabel1.Size = new System.Drawing.Size(378, 13);
            this.Comentariolabel1.TabIndex = 6;
            this.Comentariolabel1.Text = "al Separar la Oracion la  palabras se colocan cada una en una linea en la Lista";
            // 
            // CadenaOraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.Comentariolabel1);
            this.Controls.Add(this.ResultadolistBox1);
            this.Controls.Add(this.DigiteCadenaOraciontextBox1);
            this.Controls.Add(this.DigiteCadenaOracionlabel1);
            this.Controls.Add(this.SepararOracionbutton1);
            this.Name = "CadenaOraciones";
            this.Text = "Cadena de Oraciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SepararOracionbutton1;
        private System.Windows.Forms.Label DigiteCadenaOracionlabel1;
        private System.Windows.Forms.TextBox DigiteCadenaOraciontextBox1;
        private System.Windows.Forms.ListBox ResultadolistBox1;
        private System.Windows.Forms.Label Comentariolabel1;
    }
}


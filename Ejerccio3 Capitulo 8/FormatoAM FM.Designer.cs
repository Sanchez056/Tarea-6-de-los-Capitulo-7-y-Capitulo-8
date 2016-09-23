namespace Ejerccio3_Capitulo_8
{
    partial class FormatoAMFM
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
            this.CambiarFormatobutton1 = new System.Windows.Forms.Button();
            this.DigiteHoralabel = new System.Windows.Forms.Label();
            this.DigiteHoratextBox1 = new System.Windows.Forms.TextBox();
            this.FormatoHoratextBox2 = new System.Windows.Forms.TextBox();
            this.LaHoratextBox3 = new System.Windows.Forms.TextBox();
            this.LaHoraLabel = new System.Windows.Forms.Label();
            this.FormatoHoralabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CambiarFormatobutton1
            // 
            this.CambiarFormatobutton1.Location = new System.Drawing.Point(130, 51);
            this.CambiarFormatobutton1.Name = "CambiarFormatobutton1";
            this.CambiarFormatobutton1.Size = new System.Drawing.Size(102, 23);
            this.CambiarFormatobutton1.TabIndex = 0;
            this.CambiarFormatobutton1.Text = "Cambiar Formato";
            this.CambiarFormatobutton1.UseVisualStyleBackColor = true;
            this.CambiarFormatobutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DigiteHoralabel
            // 
            this.DigiteHoralabel.AutoSize = true;
            this.DigiteHoralabel.Location = new System.Drawing.Point(12, 33);
            this.DigiteHoralabel.Name = "DigiteHoralabel";
            this.DigiteHoralabel.Size = new System.Drawing.Size(60, 13);
            this.DigiteHoralabel.TabIndex = 1;
            this.DigiteHoralabel.Text = "Digite Hora";
            // 
            // DigiteHoratextBox1
            // 
            this.DigiteHoratextBox1.Location = new System.Drawing.Point(13, 54);
            this.DigiteHoratextBox1.Name = "DigiteHoratextBox1";
            this.DigiteHoratextBox1.Size = new System.Drawing.Size(100, 20);
            this.DigiteHoratextBox1.TabIndex = 2;
            // 
            // FormatoHoratextBox2
            // 
            this.FormatoHoratextBox2.Location = new System.Drawing.Point(150, 136);
            this.FormatoHoratextBox2.Name = "FormatoHoratextBox2";
            this.FormatoHoratextBox2.Size = new System.Drawing.Size(45, 20);
            this.FormatoHoratextBox2.TabIndex = 4;
            // 
            // LaHoratextBox3
            // 
            this.LaHoratextBox3.Location = new System.Drawing.Point(12, 136);
            this.LaHoratextBox3.Name = "LaHoratextBox3";
            this.LaHoratextBox3.Size = new System.Drawing.Size(100, 20);
            this.LaHoratextBox3.TabIndex = 5;
            // 
            // LaHoraLabel
            // 
            this.LaHoraLabel.AutoSize = true;
            this.LaHoraLabel.Location = new System.Drawing.Point(12, 108);
            this.LaHoraLabel.Name = "LaHoraLabel";
            this.LaHoraLabel.Size = new System.Drawing.Size(45, 13);
            this.LaHoraLabel.TabIndex = 6;
            this.LaHoraLabel.Text = "La Hora";
            // 
            // FormatoHoralabel3
            // 
            this.FormatoHoralabel3.AutoSize = true;
            this.FormatoHoralabel3.Location = new System.Drawing.Point(147, 108);
            this.FormatoHoralabel3.Name = "FormatoHoralabel3";
            this.FormatoHoralabel3.Size = new System.Drawing.Size(45, 13);
            this.FormatoHoralabel3.TabIndex = 7;
            this.FormatoHoralabel3.Text = "Formato";
            // 
            // FormatoAMFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FormatoHoralabel3);
            this.Controls.Add(this.LaHoraLabel);
            this.Controls.Add(this.LaHoratextBox3);
            this.Controls.Add(this.FormatoHoratextBox2);
            this.Controls.Add(this.DigiteHoratextBox1);
            this.Controls.Add(this.DigiteHoralabel);
            this.Controls.Add(this.CambiarFormatobutton1);
            this.Name = "FormatoAMFM";
            this.Text = "Formato FM/AM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CambiarFormatobutton1;
        private System.Windows.Forms.Label DigiteHoralabel;
        private System.Windows.Forms.TextBox DigiteHoratextBox1;
        private System.Windows.Forms.TextBox FormatoHoratextBox2;
        private System.Windows.Forms.TextBox LaHoratextBox3;
        private System.Windows.Forms.Label LaHoraLabel;
        private System.Windows.Forms.Label FormatoHoralabel3;
    }
}


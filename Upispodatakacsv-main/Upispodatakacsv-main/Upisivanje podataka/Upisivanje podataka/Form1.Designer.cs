namespace Upisivanje_podataka
{
    partial class Form1
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_godinaRodjenja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_upis = new System.Windows.Forms.Button();
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.btn_brisanje = new System.Windows.Forms.Button();
            this.txt_ispis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(233, 219);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 26);
            this.txt_email.TabIndex = 3;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(233, 98);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(213, 26);
            this.txt_prezime.TabIndex = 1;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(233, 37);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(213, 26);
            this.txt_ime.TabIndex = 0;
            this.txt_ime.TextChanged += new System.EventHandler(this.txt_ime_TextChanged);
            // 
            // txt_godinaRodjenja
            // 
            this.txt_godinaRodjenja.Location = new System.Drawing.Point(233, 162);
            this.txt_godinaRodjenja.Name = "txt_godinaRodjenja";
            this.txt_godinaRodjenja.Size = new System.Drawing.Size(213, 26);
            this.txt_godinaRodjenja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina Rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // btn_upis
            // 
            this.btn_upis.Location = new System.Drawing.Point(106, 296);
            this.btn_upis.Name = "btn_upis";
            this.btn_upis.Size = new System.Drawing.Size(107, 34);
            this.btn_upis.TabIndex = 8;
            this.btn_upis.Text = "Upis";
            this.btn_upis.UseVisualStyleBackColor = true;
            this.btn_upis.Click += new System.EventHandler(this.btn_upis_Click);
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.Location = new System.Drawing.Point(262, 296);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(107, 34);
            this.btn_Spremi.TabIndex = 9;
            this.btn_Spremi.Text = "Spremanje";
            this.btn_Spremi.UseVisualStyleBackColor = true;
            this.btn_Spremi.Click += new System.EventHandler(this.btn_Spremi_Click);
            // 
            // btn_brisanje
            // 
            this.btn_brisanje.Location = new System.Drawing.Point(413, 296);
            this.btn_brisanje.Name = "btn_brisanje";
            this.btn_brisanje.Size = new System.Drawing.Size(107, 34);
            this.btn_brisanje.TabIndex = 10;
            this.btn_brisanje.Text = "Brisanje";
            this.btn_brisanje.UseVisualStyleBackColor = true;
            this.btn_brisanje.Click += new System.EventHandler(this.btn_brisanje_Click);
            // 
            // txt_ispis
            // 
            this.txt_ispis.Location = new System.Drawing.Point(570, 37);
            this.txt_ispis.Name = "txt_ispis";
            this.txt_ispis.Size = new System.Drawing.Size(519, 208);
            this.txt_ispis.TabIndex = 11;
            this.txt_ispis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.Controls.Add(this.txt_ispis);
            this.Controls.Add(this.btn_brisanje);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.btn_upis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_godinaRodjenja);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_email);
            this.Name = "Form1";
            this.Text = "UpisivanjePodataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_godinaRodjenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_upis;
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.Button btn_brisanje;
        private System.Windows.Forms.RichTextBox txt_ispis;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upisivanje_podataka
{
    public partial class Form1 : Form
    {
        List<Osoba> listaOsoba = new List<Osoba>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_brisanje_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_godinaRodjenja.Clear(); 
            txt_ime.Clear();
            txt_prezime.Clear();
        }

        private void btn_upis_Click(object sender, EventArgs e)
        {
            // Osoba osoba = new Osoba();
            try
            {
                Osoba osoba = new Osoba(txt_ime.Text, txt_prezime.Text, txt_email.Text, Convert.ToInt16(txt_godinaRodjenja.Text));
               /* osoba.Ime = txt_ime.Text;
                osoba.Prezime = txt_prezime.Text;
                osoba.Email = txt_email.Text;
                osoba.GodinaRodjena = Convert.ToInt16(txt_godinaRodjenja.Text);
               */
                txt_email.Clear();
                txt_godinaRodjenja.Clear();
                txt_ime.Clear();
                txt_prezime.Clear();
                txt_ime.Focus();

              DialogResult upit =  MessageBox.Show("Želi teli unesti još podataka", "Upit",
                  MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                switch(upit) { 
                case DialogResult.Yes:
                        {
                            listaOsoba.Add(osoba);
                            break;
                        }
                        case DialogResult.No:
                        {
                            listaOsoba.Add(osoba);
                            txt_ime.Enabled = false;    
                            txt_prezime.Enabled = false;    
                            txt_godinaRodjenja.Enabled = false;
                            txt_email.Enabled = false;
                            break;
                        }
                }
            }
            catch(Exception greska) { 
                MessageBox.Show(greska.Message,"Pogrešan unos"
                  ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }   
        }

        private void txt_ime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Spremi_Click(object sender, EventArgs e)
        {

            /*
            // txt_ispis.Text = osoba.ToString();
            txt_ispis.Text = "ime,prezime,goddina rođenja, email" + Environment.NewLine;
           foreach(Osoba osoba in listaOsoba)
            {
                txt_ispis.AppendText(osoba.ToString() + "\n");

            }
            */
            string putanjaDatoteke = "C:\\Users\\Ucenik\\Documents\\Testcsv\\osobe.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(putanjaDatoteke))
                {
                    sw.WriteLine("Ime,prezime,godina rođenja,email");

                    foreach (Osoba osoba in listaOsoba)
                    {
                        sw.WriteLine(osoba.ToString());
                    }
                }
                MessageBox.Show("Podatci su uspjesno spremljeni u csv datoteku!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom spremanja podataka" + ex.Message, "pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}

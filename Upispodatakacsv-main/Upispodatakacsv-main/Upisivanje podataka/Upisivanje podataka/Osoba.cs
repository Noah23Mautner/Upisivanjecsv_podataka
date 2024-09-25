using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upisivanje_podataka
{
    internal class Osoba
    {
        string ime, prezime, email;
        int godinaRodjena;

        public Osoba() { }

        public Osoba(string ime, string prezime, string email, int godinaRodjena)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.godinaRodjena = godinaRodjena;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public int GodinaRodjena { get => godinaRodjena; set => godinaRodjena = value; }

        public override string ToString()
        {
            string ispis = this.Ime + "," + this.Prezime + "," + this.Email + "," + this.GodinaRodjena;
            return ispis;
        }
    }
}

using System;

namespace ConsoleApp5
{
    class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwisko;

        public getImie()
        {

        }
        public getNazwisko()
        {

        }
    }

    class Produkt 
    {
        private string nazwa;
        private double cena;
        private string opis;

        public getNazwa()
        {

        }
        public getCena()
        {

        }
        public getOpis()
        {

        }
        public produkt(nazwa, cena, opis)
        {

        }
    }

    class Uzytkownik
    {
        private string login;
        private string haslo;
        private void profil;

        public void loguj()
        {

        }

        public Uzytkownik(profil aprofil)
        {
            this profil = aprofil;
        }
    }

    class Koszyk
    {
        private int id;
        private void string;
        private void uzytkownik;

        public int getId()
        {

        } 

        public operation()
        {

        }

        public void setUzytownik(uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
        public Koszyk(produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
    }

    class LibraryManagmentSystem
    {
        static void Main(string[] args)
        {
            produkt p1 = new Produkt();

            profil pr1 = new Profil();

            uzytkownik u1 = new uzytkownik(k1);
            Koszyk k1 = new koszyk();
            u1.setKoszyk(k1);
        }
    }
}

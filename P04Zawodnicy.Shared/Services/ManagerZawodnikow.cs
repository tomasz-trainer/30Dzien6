using P02PolaczenieZBaza;
using P04Zawodnicy.Shared.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Zawodnicy.Shared.Services
{
    public class ManagerZawodnikow
    {
        //PolaczenieZBaza pzb;
        //public ManagerZawodnikow()
        //{
        //    pzb = new PolaczenieZBaza();
        //}
        PolaczenieZBaza pzb = new PolaczenieZBaza();



        public Zawodnik[] WczytajZawodnikow(string sciezka)
        {
           object[][] dane =  pzb.WyslijPolecenieSQL("select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost,waga from zawodnicy");

           mapujZawodnikow(dane, out Zawodnik[] zawodnicy);
           return zawodnicy;
        }

        private void mapujZawodnikow(object[][] dane, out Zawodnik[] zawodnicy)
        {
            zawodnicy = new Zawodnik[dane.Length];

            for (int i = 0; i < dane.Length; i++)
            {
                var w = dane[i]; // i-ty wiersz 
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)w[0];

                if (w[1] != DBNull.Value)
                    z.Id_trenera = (int)w[1];

                z.Imie = (string)w[2];
                z.Nazwisko = (string)w[3];
                z.Kraj = (string)w[4];

                if (w[5] != DBNull.Value)
                    z.DataUrodzenia = (DateTime)w[5];

                if (w[6] != DBNull.Value)
                    z.Wzrost = (int)w[6];

                if (w[7] != DBNull.Value)
                    z.Waga = (int)w[7];

                zawodnicy[i] = z;
            }

        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            throw new NotImplementedException();
        }


        public string[] PodajKraje()
        {
            throw new NotImplementedException();
        }


        public double PodajSredniWzrost(string kraj)
        {
            throw new NotImplementedException();
        }

        //sortowanie bąbelkowe (ang. Bubble Sort).
        public void PosorotujZawodnikowPoNazwisku(Zawodnik[] posortowaniZawodnicy)
        {
         
        }

        public void Dodaj(Zawodnik zawodnik)
        {
           
        }

        public void Usun(Zawodnik zawodnik)
        {
            
        }

        public void Edytuj(Zawodnik zawodnik)
        {
            
        }

        private Zawodnik wyszukajZawodnika(Zawodnik zawodnik)
        {
            throw new NotImplementedException();
        }


        private void zapisz()
        {
            
        }
    }
}

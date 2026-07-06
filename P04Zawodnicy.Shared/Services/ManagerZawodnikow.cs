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

            throw new NotImplementedException();
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

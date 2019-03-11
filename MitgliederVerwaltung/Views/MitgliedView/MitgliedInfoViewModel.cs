using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    internal class MitgliedInfoViewModel : ViewModelBasis
    {
        private string _name;
        private string _vorname;

        private string _geburtsdatum;
        private Konstanten.Erwerbstaetigkeiten _auflistung;

        private string _beitrittsdatum;
        private string _kontakt;

        private string _strasse;
        private string _hausnr;

        private string _plz;
        private string _ort;

        private string _kontonr;
        private float _kontostand;
               

        public Konstanten.Erwerbstaetigkeiten Auflistung
        {
            get { return _auflistung; }
            set
            {
                _auflistung = value;
                SetProperty(ref _auflistung, value);
            }
        }

        public Window Fenster { get; set; }

        public string Geburtsdatum
        {
            get { return _geburtsdatum; }
            set { SetProperty(ref _geburtsdatum, value); }
        }

        public string Beitrittsdatum
        {
            get { return _beitrittsdatum; }
            set { SetProperty(ref _beitrittsdatum, value); }
        }

        public string Hausnr
        {
            get { return _hausnr; }
            set { SetProperty(ref _hausnr, value); }
        }

        public string Kontakt
        {
            get { return _kontakt; }
            set { SetProperty(ref _kontakt, value); }
        }

        public IEnumerable<Konstanten.Erwerbstaetigkeiten> MyEnumTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(Konstanten.Erwerbstaetigkeiten)).Cast<Konstanten.Erwerbstaetigkeiten>();
            }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Ort
        {
            get { return _ort; }
            set { SetProperty(ref _ort, value); }
        }

        public string Plz
        {
            get { return _plz; }
            set { SetProperty(ref _plz, value); }
        }

        public string Strasse
        {
            get { return _strasse; }
            set { SetProperty(ref _strasse, value); }
        }

        public string Vorname
        {
            get { return _vorname; }
            set { SetProperty(ref _vorname, value); }
        }

        public string Kontonr
        {
            get { return _kontonr; }
            set { SetProperty(ref _kontonr, value); }
        }

        public float Kontostand
        {
            get { return _kontostand; }
            set { SetProperty(ref _kontostand, value); }
        }

        public MitgliedInfoViewModel(Mitglied mitglied, Window fenster) : this(fenster)
        {
            Name = mitglied.Nachname;
            Vorname = mitglied.Vorname;

            Geburtsdatum = mitglied.Geburtsdatum.ToString("dd.MM.yyyy");
            Auflistung = mitglied.Erwerbstaetigkeit;

            Beitrittsdatum = mitglied.Beitrittsdatum.ToString("dd.MM.yyyy");
            Kontakt = mitglied.Email;

            Strasse = mitglied.Anschrift.Strasse;
            Hausnr = mitglied.Anschrift.Hausnummer;

            Plz = mitglied.Anschrift.Postleitzahl;
            Ort = mitglied.Anschrift.Ort;

            Kontonr = mitglied.Konto.Kontonummer;
            Kontostand = mitglied.Konto.Kontostand;
        }

        public MitgliedInfoViewModel(Window fenster)
        {
            Fenster = fenster;
        }
    }
}

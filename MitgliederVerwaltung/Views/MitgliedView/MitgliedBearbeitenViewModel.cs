using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Windows;
using System.Windows.Documents;
using MitgliederVerwaltung.Basis;
using MitgliederVerwaltung.Objekte;
using MitgliederVerwaltung.Services;

namespace MitgliederVerwaltung.Views.MitgliedView
{
    internal class MitgliedBearbeitenViewModel : ViewModelBasis
    {

        public bool IstBearbeitung { get; set; }

        public int MitgliedId { get; set; }

        private Konstanten.Erwerbstaetigkeiten _auflistung;

        private DateTime _geburtsdatum;

        private string _hausnr;

        private string _kontakt;

        private string _name;

        private string _ort;

        private string _plz;

        private string _strasse;

        private string _titel;
        private string _vorname;

        public DelegateCommand Abbrechen { get; set; }

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

        public DateTime Geburtsdatum
        {
            get { return _geburtsdatum; }
            set { SetProperty(ref _geburtsdatum, value); }
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

        public DelegateCommand Speichern { get; set; }

        public string Strasse
        {
            get { return _strasse; }
            set { SetProperty(ref _strasse, value); }
        }

        public string Titel
        {
            get { return _titel; }
            set { SetProperty(ref _titel, value); }
        }

        public string Vorname
        {
            get { return _vorname; }
            set { SetProperty(ref _vorname, value); }
        }

        public MitgliedBearbeitenViewModel(Window fenster)
        {
            Fenster = fenster;

            Speichern = new DelegateCommand(o => OnSpeichernKlick());
            Abbrechen = new DelegateCommand(o => OnAbbrechenKlick());
            Titel = "Mitglied Hinzufügen";
            Geburtsdatum = DateTime.Today;
            IstBearbeitung = false;
        }

        public MitgliedBearbeitenViewModel(Mitglied mitglied, Window fenster) : this(fenster)
        {
            Vorname = mitglied.Vorname;
            Name = mitglied.Nachname;
            Geburtsdatum = mitglied.Geburtsdatum;
            Auflistung = mitglied.Erwerbstaetigkeit;
            Kontakt = mitglied.Email;
            Strasse = mitglied.Anschrift.Strasse;
            Hausnr = mitglied.Anschrift.Hausnummer;
            Plz = mitglied.Anschrift.Postleitzahl;
            Ort = mitglied.Anschrift.Ort;
            Titel = "Mitglied Bearbeiten";
            IstBearbeitung = true;
            MitgliedId = mitglied.MitgliedId;
        }

        public void OnAbbrechenKlick()
        {
            Fenster.Close();
        }


        public void OnSpeichernKlick()
        {
            if (string.IsNullOrWhiteSpace(Vorname) || string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Kontakt) || string.IsNullOrWhiteSpace(Strasse) ||
                string.IsNullOrWhiteSpace(Hausnr) || string.IsNullOrWhiteSpace(Plz) || string.IsNullOrWhiteSpace(Ort))
            {
                MessageBox.Show("Es wurden nicht alle Werte eingegeben.", "Abbruch");
                return;
            }

            Anschrift anschrift = new Anschrift(Plz, Ort, Strasse, Hausnr);
            Konto konto = new Konto(100);
            //DateTime myDate = DateTime.ParseExact(Geburtsdatum, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Mitglied mitglied = new Mitglied(Vorname, Name, Geburtsdatum, anschrift, Auflistung, konto, Kontakt);
            if (IstBearbeitung)
            {
                mitglied.MitgliedId = MitgliedId;
                VereinService.Instanz.AktualisiereMitglied(mitglied);

            }
            else
                VereinService.Instanz.FuegeMitgliedHinzu(mitglied);

            Fenster.Close();
        }
    }
}
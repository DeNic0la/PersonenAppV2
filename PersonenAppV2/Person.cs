using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenAppV2 {

    [Serializable()]
    public class Person {
        private static int sAnzahlPersonen = 0;
        private const int minEintrittsjahr = 1975;
        private const double maxSalaer = 99999.95;
        public int mPersNr { get; private set; }
        public string mAnrede { get; set; }
        public string mName { get; set; }
        public string mVorname { get; set; }
        public string mPlz { get; set; }
        public string mOrt { get; set; }
        private int _Eintrittsjahr;
        public int mEintrittsjahr {
            get { return this._Eintrittsjahr; }
            set {
                _Eintrittsjahr = value;
                if (value < minEintrittsjahr) { _Eintrittsjahr = minEintrittsjahr; }
                if (value > 2020) { _Eintrittsjahr = 2020; }
            }
        }
        private double _Salaer;
        public double mSalaer {
            get { return this._Salaer; }
            set {
                _Salaer = value;
                if (value < 0) { _Salaer = 0; }
                if (value > maxSalaer) { _Salaer = maxSalaer; }
            }
        }
        public double mPensum { get; set; }


        public Person() {
            mPersNr = sAnzahlPersonen;
            sAnzahlPersonen++;

        }
        public Person(String Anrede, String Name, String Vorname) {
            mPersNr = sAnzahlPersonen;
            sAnzahlPersonen++;
            mAnrede = Anrede;
            mName = Name;
            mVorname = Vorname;
        }
        public Person(String Name, String Vorname, int Eintrittsjahr) {
            mPersNr = sAnzahlPersonen;
            sAnzahlPersonen++;
            mName = Name;
            mVorname = Vorname;
            mEintrittsjahr = Eintrittsjahr;
        }
        public static Double CalculateLohn(double Salaer, int Pensum) {
            return Salaer * Pensum / 100;
        }
        public Double CalculateLohn() {
            return mSalaer * mPensum / 100;
        }
    }
}

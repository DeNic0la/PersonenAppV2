﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenAppV2 {
    class Person {
        private static int sAnzahlPersonen = 0;
        private const int minEintrittsjahr = 1975;
        private const double maxSalaer = 99999.95;
        protected int mPersNr { get; }
        protected string mAnrede { get; set; }
        protected string mName { get; set; }
        protected string mVorname { get; set; }
        protected string mPlz { get; set; }
        protected string mOrt { get; set; }
        protected int mEintrittsjahr {
            get { return mEintrittsjahr; }
            set {
                mEintrittsjahr = value;
                if (value < minEintrittsjahr) { mEintrittsjahr = minEintrittsjahr; }
                if (value > 2020) { mEintrittsjahr = 2020; }
            }
        }
        protected double mSalaer {
            get { return mSalaer; }
            set {
                mSalaer = value;
                if (value < 0) { mSalaer = 0; }
                if (value > maxSalaer) { mSalaer = maxSalaer; }
            }
        }
        protected double mPensum { get; set; }

        
        public Person() {
            mPersNr = sAnzahlPersonen;
            sAnzahlPersonen++;
           
        }
        public Person(String Anrede,String Name, String Vorname) {
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

    }

}

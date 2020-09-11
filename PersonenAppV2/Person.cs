using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenAppV2 {
    class Person {
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
            mPersNr = -1;
            mAnrede = "Frau";
            mName = "Neue Person";
            mVorname = "";
            mPlz = "6000";
            mOrt = "Luzern";
            mEintrittsjahr = DateTime.Now.Year;
            mSalaer = 5000.00;
            mPensum = 100;

        }
    }

}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PersonenAppV2.Properties;

namespace PersonenAppV2 {
    public partial class frmHaupt : Form {
        //Membervariablen
        List<Person> mPersonen = new List<Person>();
        private int mPosition = 0;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public frmHaupt() {
            InitializeComponent();
        }

        /// <summary>
        /// Ereignis das ausgeführt wird, wenn das Formular auf dem Bildschirm angezeigt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e) {
            for (int i = 1; i <= 3; i++) {
                Person p = new Person();
                p.mName = ("Neue Person (" + Convert.ToString(i) + ")");
                mPersonen.Add(p);
            }
            mPosition = 1; 	//Das erste Personenobjekt soll visualisiert werden
            FillForm();

        }

        /// <summary>
        /// Methode welche die via Membervariable m_Position indexierte Person auf dem Formular anzeigt
        /// </summary>
        private void FillForm() {
            txtNavigation.Text = Convert.ToString(mPosition) + "/" + Convert.ToString(mPersonen.Count);
            if (mPersonen.Count == 0)
                return;
            Person p = mPersonen[mPosition - 1];
            txtPersNr.Text = Convert.ToString(p.mPersNr);
            txtNamen.Text = p.mName;
            txtVornamen.Text = p.mVorname;
            txtPLZ.Text = p.mPlz;
            txtOrt.Text = p.mOrt;
            txtEintrittsjahr.Text = Convert.ToString(p.mEintrittsjahr);
            txtSalaer.Text = Convert.ToString(p.mSalaer);
            txtPensum.Text = Convert.ToString(p.mPensum);

        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "|<--" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFirst(object sender, EventArgs e) {
            mPosition = 1;
            FillForm();
        }
        /// <summary>
        /// /Ereignis das ausgeführt wird, wenn der User auf "<--" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPrevious(object sender, EventArgs e) {
            if (mPosition > 1) {
                mPosition--;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "-->" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNext(object sender, EventArgs e) {
            if (mPosition < mPersonen.Count) {
                mPosition++;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "-->|" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLast(object sender, EventArgs e) {
            if (mPersonen.Count > 0) {
                mPosition = mPersonen.Count;
                FillForm();
            }
        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Änderungen speichern" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave(object sender, EventArgs e) {
            Person p = mPersonen[mPosition - 1];
            p.mName = txtNamen.Text;
            p.mVorname = txtVornamen.Text;

            p.mPlz = txtPLZ.Text;
            p.mOrt = txtOrt.Text;
            try { p.mEintrittsjahr = Convert.ToInt32(txtEintrittsjahr.Text); }
            catch (Exception ex) { Console.Out.Write(ex); }
            try { p.mSalaer = Convert.ToDouble(txtSalaer.Text); }
            catch (Exception ex) { Console.Out.Write(ex); }
            try { p.mPensum = Convert.ToDouble(txtPensum.Text); }
            catch (Exception ex) { Console.Out.Write(ex); }

        }
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Änderungen verwerfen" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAbort(object sender, EventArgs e) {
            FillForm();
        }
    }
}

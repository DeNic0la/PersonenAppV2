using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        private void Einlesen() {
            if (DialogResult.No == MessageBox.Show("Möchten Sie die Daten aus einer Datei laden?", "Laden", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                //Objekte nicht aus einer Datei laden sondern einfach drei Standardobjekte erstellen
                for (int i = 1; i <= 3; i++) {
                    Person p = new Person();
                    p.mName = ("Neue Person (" + Convert.ToString(i) + ")");
                    mPersonen.Add(p);
                }
            }
            else {
                //Objekte aus einer Datei laden 
                string sPfad = Application.StartupPath + "\\MyObject.pd7";
                if (DialogResult.No == MessageBox.Show("Möchten Sie die Datei im Applikationsverzeichnis lesen?", "Informationen einlesen",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "pd7 files (*.json)|*.pd7|All files (*.*)|*";
                    if (DialogResult.OK == ofd.ShowDialog())
                        sPfad = ofd.FileName;
                    else
                        return;
                }
                try {
                    JsonSerializerNicola jsn = new JsonSerializerNicola();
                    MessageBox.Show(sPfad);
                    Object obj = jsn.JsonDesirialize(typeof(List<Person>),sPfad);

                    mPersonen = (List<Person>)obj;

                    /*
                    FileStream myStream = new FileStream(sPfad, FileMode.Open);
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    mPersonen = (List<Person>)binFormatter.Deserialize(myStream);
                    myStream.Close();*/
                }
                catch (Exception ex) {
                    //Falls ein Fehler passiert, Fehlermeldung ausgeben
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            string sPfad = Application.StartupPath + "\\MyObject.pd7";
            if (DialogResult.No == MessageBox.Show("Möchten Sie die Daten im Applikationsverzeichnis speichern?", "Speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "pd7 files (*.json)|*.json|All files (*.*)|*";
                sfd.DefaultExt = "pd7";
                if (DialogResult.OK == sfd.ShowDialog())
                    sPfad = sfd.FileName;
                else
                    return;

            }

            JsonSerializerNicola js = new JsonSerializerNicola();
            js.JsonSerialize(mPersonen, sPfad);
           /* string jsonString;
            Person test = new Person();
            FileStream myStream = new FileStream(sPfad, FileMode.Create);
            jsonString = JsonConvert.SerializeObject(test);
            JsonSerializer ser = new Newtonsoft.Json.JsonSerializer();//https://www.youtube.com/watch?v=Ib3jnD158NI






            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(myStream, mPersonen);
            myStream.Close();
           */

        }

        /// <summary>
        /// Ereignis das ausgeführt wird, wenn das Formular auf dem Bildschirm angezeigt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e) {
            Einlesen();
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
            checkForUnsavedData();
            mPosition = 1;
            FillForm();
        }
        /// <summary>
        /// /Ereignis das ausgeführt wird, wenn der User auf "<--" klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPrevious(object sender, EventArgs e) {
            checkForUnsavedData();
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
            checkForUnsavedData();
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
            checkForUnsavedData();
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
        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Löschen bzw - " klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDelete(object sender, EventArgs e) {
            if (mPersonen.Count <= 1)
                return;
            mPersonen.RemoveAt(mPosition - 1);
            if (mPosition >= mPersonen.Count)
                mPosition--;
            FillForm();
        }

        /// <summary>
        /// Ereignis das ausgeführt wird, wenn der User auf "Hinzufügen bzw + " klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAdd(object sender, EventArgs e) {
            checkForUnsavedData();
            FormNeu f = new FormNeu();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.Abort)
                return;
            mPersonen.Add(new Person("", f.Name, f.Vorname));
            OnLast(this, null);
        }
        private void checkForUnsavedData() {
            Person p = mPersonen[mPosition - 1];
            if (txtPersNr.Text == Convert.ToString(p.mPersNr) && txtNamen.Text == p.mName && txtVornamen.Text == p.mVorname && txtPLZ.Text == p.mPlz && txtOrt.Text == p.mOrt && txtEintrittsjahr.Text == Convert.ToString(p.mEintrittsjahr) && txtSalaer.Text == Convert.ToString(p.mSalaer) && txtPensum.Text == Convert.ToString(p.mPensum))
                return;
            if (MessageBox.Show("Sie haben ungespeicherte Änderungen, möchten sie diese Speichern", "Ungespeicherte Änderungen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OnSave(this, null);

        }
    }
}

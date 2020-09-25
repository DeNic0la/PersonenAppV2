using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonenAppV2 {
    public partial class FormNeu : Form {

        public string Name = "";
        public string Vorname = "";
        public FormNeu() {
            InitializeComponent();
        }

        private void btnAbort_Click(object sender, EventArgs e) {
            this.Close();
            DialogResult = DialogResult.Abort;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Name = txtName.Text;
            Vorname = txtVorname.Text;
        }
    }
}

namespace PersonenAppV2 {
    partial class frmHaupt {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNavigation = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPensum = new System.Windows.Forms.TextBox();
            this.lblPensum = new System.Windows.Forms.Label();
            this.txtSalaer = new System.Windows.Forms.TextBox();
            this.lblSalaer = new System.Windows.Forms.Label();
            this.txtEintrittsjahr = new System.Windows.Forms.TextBox();
            this.lblEintrittsjahr = new System.Windows.Forms.Label();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.txtVornamen = new System.Windows.Forms.TextBox();
            this.lblVornamen = new System.Windows.Forms.Label();
            this.txtNamen = new System.Windows.Forms.TextBox();
            this.lblNamen = new System.Windows.Forms.Label();
            this.txtPersNr = new System.Windows.Forms.TextBox();
            this.lblPersNr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(268, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(83, 47);
            this.panel5.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(44, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnDelete);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAdd);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtNavigation);
            this.panel4.Controls.Add(this.btnLast);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.btnFirst);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 47);
            this.panel4.TabIndex = 7;
            // 
            // txtNavigation
            // 
            this.txtNavigation.Location = new System.Drawing.Point(88, 10);
            this.txtNavigation.Name = "txtNavigation";
            this.txtNavigation.ReadOnly = true;
            this.txtNavigation.Size = new System.Drawing.Size(93, 20);
            this.txtNavigation.TabIndex = 11;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(222, 8);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(29, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "-->¦";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.OnLast);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(187, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "-->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.OnNext);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(52, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(29, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<--";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.OnPrevious);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(17, 8);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(29, 23);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "¦<--";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.OnFirst);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(162, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Änderungen speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(17, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Änderungen verwerfen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnAbort);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPensum);
            this.panel3.Controls.Add(this.lblPensum);
            this.panel3.Controls.Add(this.txtSalaer);
            this.panel3.Controls.Add(this.lblSalaer);
            this.panel3.Controls.Add(this.txtEintrittsjahr);
            this.panel3.Controls.Add(this.lblEintrittsjahr);
            this.panel3.Controls.Add(this.txtOrt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPLZ);
            this.panel3.Controls.Add(this.lblPLZ);
            this.panel3.Controls.Add(this.txtVornamen);
            this.panel3.Controls.Add(this.lblVornamen);
            this.panel3.Controls.Add(this.txtNamen);
            this.panel3.Controls.Add(this.lblNamen);
            this.panel3.Controls.Add(this.txtPersNr);
            this.panel3.Controls.Add(this.lblPersNr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 217);
            this.panel3.TabIndex = 2;
            // 
            // txtPensum
            // 
            this.txtPensum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPensum.Location = new System.Drawing.Point(212, 146);
            this.txtPensum.Name = "txtPensum";
            this.txtPensum.Size = new System.Drawing.Size(89, 20);
            this.txtPensum.TabIndex = 15;
            // 
            // lblPensum
            // 
            this.lblPensum.AutoSize = true;
            this.lblPensum.Location = new System.Drawing.Point(157, 149);
            this.lblPensum.Name = "lblPensum";
            this.lblPensum.Size = new System.Drawing.Size(48, 13);
            this.lblPensum.TabIndex = 14;
            this.lblPensum.Text = "Pensum:";
            // 
            // txtSalaer
            // 
            this.txtSalaer.Location = new System.Drawing.Point(78, 145);
            this.txtSalaer.Name = "txtSalaer";
            this.txtSalaer.Size = new System.Drawing.Size(78, 20);
            this.txtSalaer.TabIndex = 13;
            // 
            // lblSalaer
            // 
            this.lblSalaer.AutoSize = true;
            this.lblSalaer.Location = new System.Drawing.Point(14, 149);
            this.lblSalaer.Name = "lblSalaer";
            this.lblSalaer.Size = new System.Drawing.Size(34, 13);
            this.lblSalaer.TabIndex = 12;
            this.lblSalaer.Text = "Salär:";
            // 
            // txtEintrittsjahr
            // 
            this.txtEintrittsjahr.Location = new System.Drawing.Point(78, 119);
            this.txtEintrittsjahr.Name = "txtEintrittsjahr";
            this.txtEintrittsjahr.Size = new System.Drawing.Size(78, 20);
            this.txtEintrittsjahr.TabIndex = 11;
            // 
            // lblEintrittsjahr
            // 
            this.lblEintrittsjahr.AutoSize = true;
            this.lblEintrittsjahr.Location = new System.Drawing.Point(14, 122);
            this.lblEintrittsjahr.Name = "lblEintrittsjahr";
            this.lblEintrittsjahr.Size = new System.Drawing.Size(61, 13);
            this.lblEintrittsjahr.TabIndex = 10;
            this.lblEintrittsjahr.Text = "Eintrittsjahr:";
            // 
            // txtOrt
            // 
            this.txtOrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrt.Location = new System.Drawing.Point(168, 94);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(133, 20);
            this.txtOrt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ort:";
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(78, 94);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(54, 20);
            this.txtPLZ.TabIndex = 7;
            // 
            // lblPLZ
            // 
            this.lblPLZ.AutoSize = true;
            this.lblPLZ.Location = new System.Drawing.Point(14, 97);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(30, 13);
            this.lblPLZ.TabIndex = 6;
            this.lblPLZ.Text = "PLZ:";
            // 
            // txtVornamen
            // 
            this.txtVornamen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVornamen.Location = new System.Drawing.Point(78, 68);
            this.txtVornamen.Name = "txtVornamen";
            this.txtVornamen.Size = new System.Drawing.Size(223, 20);
            this.txtVornamen.TabIndex = 5;
            // 
            // lblVornamen
            // 
            this.lblVornamen.AutoSize = true;
            this.lblVornamen.Location = new System.Drawing.Point(14, 71);
            this.lblVornamen.Name = "lblVornamen";
            this.lblVornamen.Size = new System.Drawing.Size(58, 13);
            this.lblVornamen.TabIndex = 4;
            this.lblVornamen.Text = "Vornamen:";
            // 
            // txtNamen
            // 
            this.txtNamen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamen.Location = new System.Drawing.Point(78, 42);
            this.txtNamen.Name = "txtNamen";
            this.txtNamen.Size = new System.Drawing.Size(223, 20);
            this.txtNamen.TabIndex = 3;
            // 
            // lblNamen
            // 
            this.lblNamen.AutoSize = true;
            this.lblNamen.Location = new System.Drawing.Point(14, 45);
            this.lblNamen.Name = "lblNamen";
            this.lblNamen.Size = new System.Drawing.Size(44, 13);
            this.lblNamen.TabIndex = 2;
            this.lblNamen.Text = "Namen:";
            // 
            // txtPersNr
            // 
            this.txtPersNr.Location = new System.Drawing.Point(78, 16);
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.ReadOnly = true;
            this.txtPersNr.Size = new System.Drawing.Size(54, 20);
            this.txtPersNr.TabIndex = 1;
            // 
            // lblPersNr
            // 
            this.lblPersNr.AutoSize = true;
            this.lblPersNr.Location = new System.Drawing.Point(14, 19);
            this.lblPersNr.Name = "lblPersNr";
            this.lblPersNr.Size = new System.Drawing.Size(42, 13);
            this.lblPersNr.TabIndex = 0;
            this.lblPersNr.Text = "PersNr:";
            // 
            // frmHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(367, 350);
            this.Name = "frmHaupt";
            this.Text = "Personen App v2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNavigation;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPLZ;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.TextBox txtVornamen;
        private System.Windows.Forms.Label lblVornamen;
        private System.Windows.Forms.TextBox txtNamen;
        private System.Windows.Forms.Label lblNamen;
        private System.Windows.Forms.TextBox txtPersNr;
        private System.Windows.Forms.Label lblPersNr;
        private System.Windows.Forms.TextBox txtPensum;
        private System.Windows.Forms.Label lblPensum;
        private System.Windows.Forms.TextBox txtSalaer;
        private System.Windows.Forms.Label lblSalaer;
        private System.Windows.Forms.TextBox txtEintrittsjahr;
        private System.Windows.Forms.Label lblEintrittsjahr;
    }
}


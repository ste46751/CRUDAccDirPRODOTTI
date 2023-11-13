namespace CRUDAccDirPRODOTTI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Prezzo = new System.Windows.Forms.TextBox();
            this.bttn_aggiungi = new System.Windows.Forms.Button();
            this.bttn_modifica = new System.Windows.Forms.Button();
            this.txt_nuovoN = new System.Windows.Forms.TextBox();
            this.txt_nuovoP = new System.Windows.Forms.TextBox();
            this.txt_cerca = new System.Windows.Forms.TextBox();
            this.bttn_ElimLog = new System.Windows.Forms.Button();
            this.bttn_ElimFisic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttn_cerca = new System.Windows.Forms.Button();
            this.bttn_cercaElim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_elimina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(44, 79);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(96, 20);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Prezzo
            // 
            this.txt_Prezzo.Location = new System.Drawing.Point(196, 79);
            this.txt_Prezzo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Prezzo.Name = "txt_Prezzo";
            this.txt_Prezzo.Size = new System.Drawing.Size(96, 20);
            this.txt_Prezzo.TabIndex = 1;
            // 
            // bttn_aggiungi
            // 
            this.bttn_aggiungi.Location = new System.Drawing.Point(429, 56);
            this.bttn_aggiungi.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(135, 48);
            this.bttn_aggiungi.TabIndex = 2;
            this.bttn_aggiungi.Text = "Aggiungi Prodotto";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
            // 
            // bttn_modifica
            // 
            this.bttn_modifica.Location = new System.Drawing.Point(89, 306);
            this.bttn_modifica.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_modifica.Name = "bttn_modifica";
            this.bttn_modifica.Size = new System.Drawing.Size(135, 48);
            this.bttn_modifica.TabIndex = 3;
            this.bttn_modifica.Text = "Modifica Prodotto";
            this.bttn_modifica.UseVisualStyleBackColor = true;
            this.bttn_modifica.Click += new System.EventHandler(this.bttn_modifica_Click_1);
            // 
            // txt_nuovoN
            // 
            this.txt_nuovoN.Location = new System.Drawing.Point(54, 266);
            this.txt_nuovoN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nuovoN.Name = "txt_nuovoN";
            this.txt_nuovoN.Size = new System.Drawing.Size(96, 20);
            this.txt_nuovoN.TabIndex = 4;
            // 
            // txt_nuovoP
            // 
            this.txt_nuovoP.Location = new System.Drawing.Point(174, 266);
            this.txt_nuovoP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nuovoP.Name = "txt_nuovoP";
            this.txt_nuovoP.Size = new System.Drawing.Size(96, 20);
            this.txt_nuovoP.TabIndex = 5;
            // 
            // txt_cerca
            // 
            this.txt_cerca.Location = new System.Drawing.Point(111, 146);
            this.txt_cerca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cerca.Name = "txt_cerca";
            this.txt_cerca.Size = new System.Drawing.Size(96, 20);
            this.txt_cerca.TabIndex = 6;
            // 
            // bttn_ElimLog
            // 
            this.bttn_ElimLog.Location = new System.Drawing.Point(362, 236);
            this.bttn_ElimLog.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_ElimLog.Name = "bttn_ElimLog";
            this.bttn_ElimLog.Size = new System.Drawing.Size(135, 48);
            this.bttn_ElimLog.TabIndex = 7;
            this.bttn_ElimLog.Text = "Eliminazione Logica";
            this.bttn_ElimLog.UseVisualStyleBackColor = true;
            this.bttn_ElimLog.Click += new System.EventHandler(this.bttn_ElimLog_Click);
            // 
            // bttn_ElimFisic
            // 
            this.bttn_ElimFisic.Location = new System.Drawing.Point(522, 236);
            this.bttn_ElimFisic.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_ElimFisic.Name = "bttn_ElimFisic";
            this.bttn_ElimFisic.Size = new System.Drawing.Size(135, 48);
            this.bttn_ElimFisic.TabIndex = 8;
            this.bttn_ElimFisic.Text = "Eliminazione Fisica";
            this.bttn_ElimFisic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserisci il nome del prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inserisci il prezzo del prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inserisci il nome del prodotto da modificare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nuovo nome del prodotto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nuovo prezzo del prodotto";
            // 
            // bttn_cerca
            // 
            this.bttn_cerca.Location = new System.Drawing.Point(111, 178);
            this.bttn_cerca.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_cerca.Name = "bttn_cerca";
            this.bttn_cerca.Size = new System.Drawing.Size(95, 27);
            this.bttn_cerca.TabIndex = 14;
            this.bttn_cerca.Text = "cerca prodotto";
            this.bttn_cerca.UseVisualStyleBackColor = true;
            this.bttn_cerca.Click += new System.EventHandler(this.bttn_cerca_Click);
            // 
            // bttn_cercaElim
            // 
            this.bttn_cercaElim.Location = new System.Drawing.Point(457, 178);
            this.bttn_cercaElim.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_cercaElim.Name = "bttn_cercaElim";
            this.bttn_cercaElim.Size = new System.Drawing.Size(95, 27);
            this.bttn_cercaElim.TabIndex = 17;
            this.bttn_cercaElim.Text = "cerca prodotto";
            this.bttn_cercaElim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Inserisci il nome del prodotto da cancellare";
            // 
            // txt_elimina
            // 
            this.txt_elimina.Location = new System.Drawing.Point(457, 146);
            this.txt_elimina.Margin = new System.Windows.Forms.Padding(2);
            this.txt_elimina.Name = "txt_elimina";
            this.txt_elimina.Size = new System.Drawing.Size(96, 20);
            this.txt_elimina.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 434);
            this.Controls.Add(this.bttn_cercaElim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_elimina);
            this.Controls.Add(this.bttn_cerca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_ElimFisic);
            this.Controls.Add(this.bttn_ElimLog);
            this.Controls.Add(this.txt_cerca);
            this.Controls.Add(this.txt_nuovoP);
            this.Controls.Add(this.txt_nuovoN);
            this.Controls.Add(this.bttn_modifica);
            this.Controls.Add(this.bttn_aggiungi);
            this.Controls.Add(this.txt_Prezzo);
            this.Controls.Add(this.txt_Nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Prezzo;
        private System.Windows.Forms.Button bttn_aggiungi;
        private System.Windows.Forms.Button bttn_modifica;
        private System.Windows.Forms.TextBox txt_nuovoN;
        private System.Windows.Forms.TextBox txt_nuovoP;
        private System.Windows.Forms.TextBox txt_cerca;
        private System.Windows.Forms.Button bttn_ElimLog;
        private System.Windows.Forms.Button bttn_ElimFisic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttn_cerca;
        private System.Windows.Forms.Button bttn_cercaElim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_elimina;
    }
}


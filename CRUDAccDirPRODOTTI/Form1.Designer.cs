﻿namespace CRUDAccDirPRODOTTI
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_elimina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(59, 97);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(127, 22);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Prezzo
            // 
            this.txt_Prezzo.Location = new System.Drawing.Point(261, 97);
            this.txt_Prezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Prezzo.Name = "txt_Prezzo";
            this.txt_Prezzo.Size = new System.Drawing.Size(127, 22);
            this.txt_Prezzo.TabIndex = 1;
            // 
            // bttn_aggiungi
            // 
            this.bttn_aggiungi.Location = new System.Drawing.Point(572, 69);
            this.bttn_aggiungi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(180, 59);
            this.bttn_aggiungi.TabIndex = 2;
            this.bttn_aggiungi.Text = "Aggiungi Prodotto";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
            // 
            // bttn_modifica
            // 
            this.bttn_modifica.Location = new System.Drawing.Point(119, 377);
            this.bttn_modifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_modifica.Name = "bttn_modifica";
            this.bttn_modifica.Size = new System.Drawing.Size(180, 59);
            this.bttn_modifica.TabIndex = 3;
            this.bttn_modifica.Text = "Modifica Prodotto";
            this.bttn_modifica.UseVisualStyleBackColor = true;
            this.bttn_modifica.Click += new System.EventHandler(this.bttn_modifica_Click_1);
            // 
            // txt_nuovoN
            // 
            this.txt_nuovoN.Location = new System.Drawing.Point(72, 327);
            this.txt_nuovoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nuovoN.Name = "txt_nuovoN";
            this.txt_nuovoN.Size = new System.Drawing.Size(127, 22);
            this.txt_nuovoN.TabIndex = 4;
            // 
            // txt_nuovoP
            // 
            this.txt_nuovoP.Location = new System.Drawing.Point(232, 327);
            this.txt_nuovoP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nuovoP.Name = "txt_nuovoP";
            this.txt_nuovoP.Size = new System.Drawing.Size(127, 22);
            this.txt_nuovoP.TabIndex = 5;
            // 
            // txt_cerca
            // 
            this.txt_cerca.Location = new System.Drawing.Point(148, 180);
            this.txt_cerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cerca.Name = "txt_cerca";
            this.txt_cerca.Size = new System.Drawing.Size(127, 22);
            this.txt_cerca.TabIndex = 6;
            // 
            // bttn_ElimLog
            // 
            this.bttn_ElimLog.Location = new System.Drawing.Point(483, 290);
            this.bttn_ElimLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_ElimLog.Name = "bttn_ElimLog";
            this.bttn_ElimLog.Size = new System.Drawing.Size(180, 59);
            this.bttn_ElimLog.TabIndex = 7;
            this.bttn_ElimLog.Text = "Eliminazione Logica";
            this.bttn_ElimLog.UseVisualStyleBackColor = true;
            this.bttn_ElimLog.Click += new System.EventHandler(this.bttn_ElimLog_Click);
            // 
            // bttn_ElimFisic
            // 
            this.bttn_ElimFisic.Location = new System.Drawing.Point(696, 290);
            this.bttn_ElimFisic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_ElimFisic.Name = "bttn_ElimFisic";
            this.bttn_ElimFisic.Size = new System.Drawing.Size(180, 59);
            this.bttn_ElimFisic.TabIndex = 8;
            this.bttn_ElimFisic.Text = "Eliminazione Fisica";
            this.bttn_ElimFisic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserisci il nome del prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inserisci il prezzo del prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inserisci il nome del prodotto da modificare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nuovo nome del prodotto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nuovo prezzo del prodotto";
            // 
            // bttn_cerca
            // 
            this.bttn_cerca.Location = new System.Drawing.Point(148, 219);
            this.bttn_cerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_cerca.Name = "bttn_cerca";
            this.bttn_cerca.Size = new System.Drawing.Size(127, 33);
            this.bttn_cerca.TabIndex = 14;
            this.bttn_cerca.Text = "cerca prodotto";
            this.bttn_cerca.UseVisualStyleBackColor = true;
            this.bttn_cerca.Click += new System.EventHandler(this.bttn_cerca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Inserisci il nome del prodotto da cancellare";
            // 
            // txt_elimina
            // 
            this.txt_elimina.Location = new System.Drawing.Point(612, 219);
            this.txt_elimina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_elimina.Name = "txt_elimina";
            this.txt_elimina.Size = new System.Drawing.Size(127, 22);
            this.txt_elimina.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 534);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_elimina;
    }
}


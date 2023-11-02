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
            this.bttn_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(58, 97);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(127, 22);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Prezzo
            // 
            this.txt_Prezzo.Location = new System.Drawing.Point(261, 97);
            this.txt_Prezzo.Name = "txt_Prezzo";
            this.txt_Prezzo.Size = new System.Drawing.Size(127, 22);
            this.txt_Prezzo.TabIndex = 1;
            // 
            // bttn_aggiungi
            // 
            this.bttn_aggiungi.Location = new System.Drawing.Point(557, 60);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(180, 59);
            this.bttn_aggiungi.TabIndex = 2;
            this.bttn_aggiungi.Text = "Aggiungi Prodotto";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
            // 
            // bttn_file
            // 
            this.bttn_file.Location = new System.Drawing.Point(58, 12);
            this.bttn_file.Name = "bttn_file";
            this.bttn_file.Size = new System.Drawing.Size(180, 59);
            this.bttn_file.TabIndex = 3;
            this.bttn_file.Text = "Crea File";
            this.bttn_file.UseVisualStyleBackColor = true;
            this.bttn_file.Click += new System.EventHandler(this.bttn_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 534);
            this.Controls.Add(this.bttn_file);
            this.Controls.Add(this.bttn_aggiungi);
            this.Controls.Add(this.txt_Prezzo);
            this.Controls.Add(this.txt_Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Prezzo;
        private System.Windows.Forms.Button bttn_aggiungi;
        private System.Windows.Forms.Button bttn_file;
    }
}


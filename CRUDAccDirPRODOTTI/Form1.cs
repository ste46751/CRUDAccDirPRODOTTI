using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAccDirPRODOTTI
{
    public partial class Form1 : Form
    {
        public string[] prodotti = new string[100];
        public int NumeroRecord;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("./Lista.dat"))
            {
                leggiEsalva();
            }
            else
            {
              CreaFile();
            }
            
        }
        public void CreaFile()
        {
            FileStream file = new FileStream("./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(file);
            string chiocciola = "@";
            byte[] strInByte;

            string riga = chiocciola.PadRight(32) + chiocciola.PadRight(32);
            strInByte = Encoding.Default.GetBytes(riga);

            for (int i = 1; i <= 100; i++)
            {
                bw.Write(strInByte);
            }

            NumeroRecord = 0;

            file.Close();
            bw.Close();
        }
        
        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            string numero = txt_Prezzo.Text;
            bool controllo = int.TryParse(numero, out _);//TryParse converte un numero da stringa a intero, se non riesce da controllo==false
            //se le text box sono vuote appare il messaggio appare schermo fino a quando entrambi i campi non saranno pieni
            if (String.IsNullOrEmpty(txt_Nome.Text) || String.IsNullOrEmpty(txt_Prezzo.Text))
            {
                MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
            }
            //se sono presenti lettere nel campo dedicato al prezzo non permette di continuare
            else if (controllo == false)
            {
                MessageBox.Show("Non puoi inserire lettere in questo campo");
                txt_Prezzo.Text = ("");
            }
            //quando le text box sono compilate i dati vengono salvati all'interno dell'array
            else
            {
                FileStream file = new FileStream("Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter f_out = new BinaryWriter(file);

                byte[] strInByte;
                int size = 64;
                string Nome = txt_Nome.Text, Prezzo = txt_Prezzo.Text;

                string riga = Nome.PadRight(32) + Prezzo.PadRight(32);

                strInByte = Encoding.Default.GetBytes(riga);

                f_out.BaseStream.Seek((NumeroRecord) * size, SeekOrigin.Begin);
                f_out.Write(strInByte);

                NumeroRecord++;

                f_out.Close();
                file.Close();
            }
        }

        public void leggiEsalva()// funzione che scrive i nomi dei prodotti nell'array e si posiziona sulla prima riga utilizzabile
        {
            FileStream file = new FileStream("./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(file);

            string prodotto;
            bool controllo = false;

            while (controllo == false)
            {
                br.BaseStream.Seek((NumeroRecord) * 64, 0);
                
                byte[] bit = br.ReadBytes(32);

                prodotto = Encoding.ASCII.GetString(bit, 0, bit.Length).Trim();

                if (prodotto[0] != '@')
                {
                    prodotti[NumeroRecord] = prodotto;
                    NumeroRecord++;
                }
                else
                {
                    controllo = true;
                }

            }

            file.Close();
            br.Close();
        }

        private void bttn_modifica_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter f_out = new BinaryWriter(file);

            string cercaprod=txt_cerca.Text;

            for(int i = 0; i < NumeroRecord; i++)
            {
                if (cercaprod == prodotti[i])
                {
                    byte[] strInByte;
                    int size = 64;
                    string Nome = txt_nuovoN.Text, Prezzo = txt_nuovoP.Text;

                    string riga = Nome.PadRight(32) + Prezzo.PadRight(32);

                    strInByte = Encoding.Default.GetBytes(riga);

                    f_out.BaseStream.Seek((i) * size, SeekOrigin.Begin);
                    f_out.Write(strInByte);
                }
            }

            file.Close();
            f_out.Close();
        }
    }
}

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
using static CRUDAccDirPRODOTTI.Form1;

namespace CRUDAccDirPRODOTTI
{
    public partial class Form1 : Form
    {

        public struct prodotti
        {
            public string Nome;
            public int posizione;
        }
        public prodotti[] p= new prodotti[100];
        public int NumeroRecord;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("./Lista.dat") && File.Exists("./Struct.txt"))
            {
                salvaStruct();
            }
            else if (File.Exists("./Lista.dat") && File.Exists("./Struct.txt")==false)
            {
                leggiEsalva();
            }
            else if (File.Exists("./Lista.dat") == false && File.Exists("./Struct.txt") )
            {
                CreaFile();
                var file = new FileStream("Struct.txt", FileMode.Truncate, FileAccess.Write, FileShare.Read);
                StreamWriter sw = new StreamWriter(file);
                sw.Write(string.Empty);
                sw.Close();
            }
            else
            {
              CreaFile();
            }
            
        }

        //FUNZIONE CHE LEGGE IL FILE TXT E SALVA LA POSIZIONE E IL NOME DEL PRODOTTO NELL'ARRAY 
        public void salvaStruct()
        {
            StreamReader sr = new StreamReader(@"Struct.txt");
            string linea = sr.ReadLine();
            

            do
            {
                if(linea !=null)
                {
                    string[] l = linea.Split(';');

                    p[NumeroRecord].Nome = l[0];
                    p[NumeroRecord].posizione = Convert.ToInt16(l[1]);
                    NumeroRecord++;

                    linea = sr.ReadLine();
                }

            }
            while(linea!=null);

            sr.Close();
        }
        //FUNZIONE CHE IN CASO NON ESISTA LA STRUCT, LEGGE IL DAT E SALVA IL NOME E  LA POSIZIONE DEI PRODOTTI
        public void leggiEsalva()
        {
            FileStream file = new FileStream("./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(file);

            string prodotto;
            bool controllo = false;

            while (controllo == false)
            {
                br.BaseStream.Seek((NumeroRecord) * 64, 0);

                byte[] bit = br.ReadBytes(30);

                prodotto = Encoding.ASCII.GetString(bit, 0, bit.Length).Trim();

                if (prodotto[0] != '@')
                {
                    p[NumeroRecord].Nome = prodotto;
                    p[NumeroRecord].posizione = NumeroRecord;
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
        //IN CASO NON ESISTA IL FILE DAT, LO CREA E LO RIEMPIE CON CHIOCCIOLE
        public void CreaFile()
        {
            FileStream file = new FileStream("./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(file);
            string chiocciola = "@";
            byte[] strInByte;

            string riga = chiocciola.PadRight(30) + chiocciola.PadRight(30) + chiocciola.PadRight(4);
            strInByte = Encoding.Default.GetBytes(riga);

            for (int i = 1; i <= 100; i++)
            {
                bw.Write(strInByte);
            }

            NumeroRecord = 0;

            file.Close();
            bw.Close();
        }
        //QUANDO VIENE CHIUSO IL PROGRAMMA VIENE CREATO O APERTO IL FILE TXT, E VENGONO SALVATI I NOMI E LE POSIZIONI
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream f = new FileStream("./Struct.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(f);

            for (int i = 0; i < NumeroRecord; i++)
            {
                sw.WriteLine(p[i].Nome + ";" + p[i].posizione + ";");
            }
            

            sw.Close();
        }
        //PULSANTE AGGIUNGI, QUNDO VIENE PREMUTO IL NOME, IL PREZZO E LA QUANTITA' VENGONO SALVATI NEL FILE DAT
        //MENTRE NELL'ARRAY VENGONO AGGIUNTI SOLO IL NOME E IL PREZZO
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
                FileStream file = new FileStream("./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter f_out = new BinaryWriter(file);
                BinaryReader br = new BinaryReader(file);

                byte[] strInByte;
                int size = 64;
                string Nome = txt_Nome.Text, Prezzo = txt_Prezzo.Text;

                string riga = Nome.PadRight(32) + Prezzo.PadRight(32);

                strInByte = Encoding.Default.GetBytes(riga);
                string prodotto;
                bool c = false;

                int n = 0;

                while (c == false) 
                {
                    br.BaseStream.Seek((n) * 64, 0);

                    byte[] bit = br.ReadBytes(30);

                    prodotto = Encoding.ASCII.GetString(bit, 0, bit.Length).Trim();

                    if (prodotto[0] != '@')
                    {
                        n++;
                        
                    }
                    else
                    {
                        p[n].Nome = Nome;
                        p[n].posizione = n;

                        f_out.BaseStream.Seek((n) * size, SeekOrigin.Begin);
                        f_out.Write(strInByte);

                        MessageBox.Show("Prodotto aggiunto");

                        
                        NumeroRecord++;
                        c = true;
                    }
                }

                OrdALf();

                f_out.Close();
                file.Close();

                txt_Nome.Clear();txt_Prezzo.Clear();
            }
        }
        
        private void OrdALf()
        {
            //ordinamento BubbleSort che sfrutta la funzione CompareTo per confrontare i nomi dei prodotti
            for (int i = 0; i <NumeroRecord; i++)
            {
                for (int j = i + 1; j < NumeroRecord; j++)
                {
                    if (p[i].Nome.CompareTo(p[j].Nome) > 0)
                    {
                        string scelta = p[i].Nome;
                        p[i].Nome = p[j].Nome;
                        p[j].Nome = scelta;

                        int n = p[i].posizione;
                        p[i].posizione = p[j].posizione;
                        p[j].posizione = n;
                    }
                }
            }
        }

       /* private void bttn_modifica_Click(object sender, EventArgs e)
        {
            if (NumeroRecord != 0)
            {
                FileStream file = new FileStream("Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter f_out = new BinaryWriter(file);

                string cercaprod = txt_cerca.Text;
                string numero = txt_nuovoP.Text;
                bool controllo = int.TryParse(numero, out _);//TryParse converte un numero da stringa a intero, se non riesce da controllo==false
                //se le text box sono vuote appare il messaggio appare schermo fino a quando entrambi i campi non saranno pieni
                if (String.IsNullOrEmpty(txt_cerca.Text) || String.IsNullOrEmpty(txt_nuovoN.Text) || String.IsNullOrEmpty(txt_nuovoP.Text))
                {
                    MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
                }
                //se sono presenti lettere nel campo dedicato al prezzo non permette di continuare
                else if (controllo == false)
                {
                    MessageBox.Show("Non puoi inserire lettere in questo campo");
                    txt_nuovoP.Text = ("");
                }
                //quando le text box sono compilate i dati vengono salvati all'interno dell'array
                else
                {
                    for (int i = 0; i < NumeroRecord; i++)
                    {
                        if (cercaprod == p[i].Nome)
                        {
                           
                            byte[] strInByte;
                            int size = 64;
                            string Nome = txt_nuovoN.Text, Prezzo = txt_nuovoP.Text;

                            string riga = Nome.PadRight(32) + Prezzo.PadRight(32);

                            strInByte = Encoding.Default.GetBytes(riga);

                            f_out.BaseStream.Seek((i) * size, SeekOrigin.Begin);
                            f_out.Write(strInByte);

                            MessageBox.Show("Prodotto modificato");
                        }
                    }
                }
            
                txt_cerca.Clear(); txt_nuovoN.Clear(); txt_nuovoP.Clear();

                file.Close();
                f_out.Close();
            }
            else
            {
                MessageBox.Show("Non puoi modificare il file perchè è vuoto");
            }
        }
/*
        private void ElimLog_Click(object sender, EventArgs e)
        {
            if (NumeroRecord != 0)
            {
                FileStream file = new FileStream("Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter f_out = new BinaryWriter(file);

                string cercaprod = txt_cerca.Text;
                
                //se le text box sono vuote appare il messaggio appare schermo fino a quando entrambi i campi non saranno pieni
                if (String.IsNullOrEmpty(txt_cerca.Text))
                {
                    MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
                }
                //quando le text box sono compilate i dati vengono salvati all'interno dell'array
                else
                {
                    for (int i = 0; i < NumeroRecord; i++)
                    {
                        if (cercaprod == prodotti[i])
                        {

                            byte[] strInByte;
                            int size = 64;
                            string Nome = prodotti[i];
                            prodotti[i] = '0' + prodotti[i];

                            string riga = '0'+Nome.PadRight(30) + '0';

                            strInByte = Encoding.Default.GetBytes(riga);

                            f_out.BaseStream.Seek((i) * size, SeekOrigin.Begin);
                            f_out.Write(strInByte);

                            MessageBox.Show("Prodotto eliminato");
                        }
                    }
                }

                txt_cerca.Clear(); txt_nuovoN.Clear(); txt_nuovoP.Clear();

                file.Close();
                f_out.Close();
            }
            else
            {
                MessageBox.Show("Non puoi eliminare il file perchè è vuoto");
            }
        }

        private void ElimFisic_Click(object sender, EventArgs e)
        {

            if (NumeroRecord != 0)
            {
                FileStream file = new FileStream("Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter f_out = new BinaryWriter(file);

                string cercaprod = txt_cerca.Text;

                //se le text box sono vuote appare il messaggio appare schermo fino a quando entrambi i campi non saranno pieni
                if (String.IsNullOrEmpty(txt_cerca.Text))
                {
                    MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
                }
                //quando le text box sono compilate i dati vengono salvati all'interno dell'array
                else
                {
                    for (int i = 0; i < NumeroRecord; i++)
                    {
                        if (cercaprod == prodotti[i])
                        {

                            byte[] strInByte;
                            int size = 64;
                            
                            string chiocciola = "@";
                            

                            string riga = chiocciola.PadRight(32) + chiocciola.PadRight(32);

                            prodotti[i] = null;

                            NumeroRecord--;
                            

                            strInByte = Encoding.Default.GetBytes(riga);

                            f_out.BaseStream.Seek((i) * size, SeekOrigin.Begin);
                            f_out.Write(strInByte);

                            MessageBox.Show("Prodotto eliminato");
                        }
                    }
                }

                txt_cerca.Clear(); txt_nuovoN.Clear(); txt_nuovoP.Clear();

                file.Close();
                f_out.Close();
            }
            else
            {
                MessageBox.Show("Non puoi eliminare il file perchè è vuoto");
            }
        }*/
    }
}

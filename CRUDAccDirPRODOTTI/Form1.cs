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
        public struct Prodotto
        {
            public string Nome;
            public float Prezzo;
        }
        public Prodotto[] p;
        
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto[100];

        }

        private void bttn_file_Click(object sender, EventArgs e)
        {
            
            FileStream f_in_out=new FileStream(@"./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter f_out = new BinaryWriter(f_in_out);
            BinaryReader f_in = new BinaryReader(f_in_out);

            string Nome = "@", Prezzo = "@",riga;
            byte[] strInByte;
            int TOTRecord = 100;

            // preparo il file con 100 record vuoti
            riga = Nome.PadRight(32) + Prezzo.PadRight(32);
            strInByte = Encoding.Default.GetBytes(riga);
            for (int i = 1; i <= TOTRecord; i++)
            {
                f_out.Write(strInByte);
            }
             
            f_out.Close();
            f_in_out.Close();

        }

        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            FileStream f_in_out = new FileStream(@"./Lista.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter f_out = new BinaryWriter(f_in_out);
            BinaryReader f_in = new BinaryReader(f_in_out);

            int NumeroRecord = 1;
            byte[] strInByte;
            int size = 64;

            string Nome = txt_Nome.Text, Prezzo = txt_Prezzo.Text;

            string riga = Nome.PadRight(32) + Prezzo.PadRight(32);

            strInByte = Encoding.Default.GetBytes(riga);  // 64 byte totali

            // posizionamento IN SCRITTURA
            f_out.BaseStream.Seek((NumeroRecord - 1) * size, SeekOrigin.Begin);

            f_out.Write(strInByte);

            f_out.Close();
            f_in_out.Close();
        }
    }
}

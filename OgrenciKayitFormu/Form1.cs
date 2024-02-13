using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add(sayac+"-"+txtAdSoyad.Text+" "+txtOkulNo.Text+" "+maskedTextBoxDogumTarihi.Text+" "+combobox1Cinsiyet.Text+" "+txtSinif.Text+" "+combobox2Bolum.Text);
            sayac++;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtOkulNo.Clear();
            txtSinif.Clear();     
            maskedTextBoxDogumTarihi.Clear();
            lstGoster.Items.Clear();
            combobox1Cinsiyet.ResetText(); //COMBOBOX BÖYLE TEMİZLENİR
            combobox2Bolum.ResetText();    //COMBOBOX BÖYLE TEMİZLENİR
            sayac = 1;
        }
    }
}

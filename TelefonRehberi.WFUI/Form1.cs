using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonRehberi.BLL;

namespace TelefonRehberi.WFUI
{
    public partial class Form1 : Form
    {
        TelefonRehberi.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new TelefonRehberi.BLL.BusinessLogicLayer();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int Sonuc = BLL.KullaniciKontrol(txt_kullaniciadi.Text, txt_sifre.Text);
            if(Sonuc > 0)
            {
                AnaForm form = new AnaForm();
                form.Show();
            }
            else if(Sonuc  == -100)
            {
                MessageBox.Show("Form alanlarını eksiksiz doldurunuz.");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");
            }
        }
    }
}

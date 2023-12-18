using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mat_sınıfı_1200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text);//sayısal olarak texti çevirdik

            //işlemler
            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2);//txt içindeki sayının karesi(2. kuvveti)
            double sayiKarakok = Math.Sqrt(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double sayiAsagıYuvarlama = Math.Floor(sayi);
            double sayiYuvarla = Math.Round(sayi);
            //Round,Floor,Ceil

            //sonuçları yazdır
            lblMutlak.Text = "Sayının Mutlak Değeri :" + sayiMutlak.ToString();
            lblUst.Text = "Sayının Kuvveti:" + sayiUs.ToString();
            lblKok.Text = "Sayının Kare Kökü:" + sayiKarakok.ToString();
            lblYukarıYuvarla.Text = "Sayını Yukarı Yuvarlama:" + sayiYukariYuvarla.ToString();
            lblAsagıYuvarla.Text = "Sayını Aşağı Yuvarlama :" + sayiAsagıYuvarlama.ToString();
            lblYuvarla.Text = "Sayını Yuvarla :" + sayiYuvarla.ToString();

        }
    }
}

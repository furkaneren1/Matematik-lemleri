using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bütün_işlemle
{
    public partial class FormButunislemler : Form
    {
        public FormButunislemler()
        {
            InitializeComponent();
        }
        private double Topla (double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        private double cıkarma(double sayi1, double sayi2)
        {
            return sayi1- sayi2;
        }
        private double bolu(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
        private double carpı(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        private void EkranıHazırla() {
            txtBirinciSayi.Text = txtIkincisayi.Text = "0";
            txtBirinciSayi.Focus();
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToDouble(txtBirinciSayi.Text);
                Convert.ToDouble(txtIkincisayi.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        private void BtnToplama_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                double toplam = Topla(Convert.ToDouble(txtBirinciSayi.Text), Convert.ToDouble(txtIkincisayi.Text));
                txtSonuc.Text = toplam.ToString();
            }
            else
            {
                txtSonuc.Text = "Girdiğiniz Değerle Hatalı";
            }
            EkranıHazırla();
        }

        private void BtnEksi_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                double eksi= cıkarma(Convert.ToDouble(txtBirinciSayi.Text), Convert.ToDouble(txtIkincisayi.Text));
                txtSonuc.Text = eksi.ToString();
            }
            else
            {
                txtSonuc.Text = "Girdiğiniz Değerle Hatalı";
            }
            EkranıHazırla();
        }

        private void BtnCarpi_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                double carpım = carpı(Convert.ToDouble(txtBirinciSayi.Text), Convert.ToDouble(txtIkincisayi.Text));
                txtSonuc.Text = carpım.ToString();
            }
            else
            {
                txtSonuc.Text = "Girdiğiniz Değerle Hatalı";
            }
            EkranıHazırla();
        }

        private void BtnBolu_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                double bolum = bolu(Convert.ToDouble(txtBirinciSayi.Text), Convert.ToDouble(txtIkincisayi.Text));
                txtSonuc.Text = bolum.ToString();
            }
            else
            {
                txtSonuc.Text = "Girdiğiniz Değerle Hatalı";
            }
            EkranıHazırla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranıHazırla();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranıHazırla();
        }

        private void TxtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
            char.IsLetter(e.KeyChar)|| 
            char.IsSymbol(e.KeyChar)|| 
            char.IsWhiteSpace(e.KeyChar)||
            char.IsPunctuation(e.KeyChar)
                )
            e.Handled = true;
        }

        private void TxtIkincisayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
            char.IsLetter(e.KeyChar) ||
            char.IsSymbol(e.KeyChar) ||
            char.IsWhiteSpace(e.KeyChar) ||
            char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }
    }
}

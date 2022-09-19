using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCKimlikSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            lbl_Sonuc.Text = "Sonuç:";
            int yil;
            long kimlikNo;
            bool durum;

            if (txt_yil.Text.Trim().Length == 0 || txt_tc.Text.Trim().Length == 0)
            {
                lbl_Sonuc.Text += " Kayıt Bulunamadı (-)";
            }

            else
            {
                yil = int.Parse(txt_yil.Text);
                kimlikNo = long.Parse(txt_tc.Text);
                try
                {
                    using (TC_Sorgula.KPSPublicSoapClient service = new TC_Sorgula.KPSPublicSoapClient { })
                    {
                        durum = service.TCKimlikNoDogrula(kimlikNo, txt_isim.Text, txt_soyisim.Text, yil);
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                if (durum)
                {
                    lbl_Sonuc.Text += " Kayıtlar eşleşti (+)";
                }
                else
                {
                    lbl_Sonuc.Text += " Kayıt Bulunamadı (-)";
                }
            }
           
        }
    }
}

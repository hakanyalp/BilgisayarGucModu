using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // oturumu kilitleyebilmek için

namespace Bilgisayar_Güç_Modu
{
    public partial class BilgisayarGucModu : Form
    {
        public BilgisayarGucModu()
        {
            InitializeComponent();
        }
        int saat = 0;
        int dakika = 0;
        int saniye = 0;

        private void txtDakika_TextChanged(object sender, EventArgs e)
        {
            if (txtDakika.Text != "" && txtDakika.Text != "0")
            {
                if (Convert.ToInt32(txtDakika.Text) > 5999)
                {
                    txtDakika.Text = txtDakika.Text.Substring(0, txtDakika.Text.Length - 1);    // büyük değer girdiğinde en son girdiği değeri silmek için kullanıyoruz
                    MessageBox.Show("Bu kadar büyük değer giremezsin!");
                }
                else
                {
                    Console.Beep(2000, 5);
                    dakika = Convert.ToInt32(txtDakika.Text);
                    lstDakika.SelectedIndex = -1;
                    SaatGoruntusunuDuzenle();
                }
            }
            else if(lstDakika.SelectedIndex == -1)
            {
                timer1.Enabled = false;
                btnIptal.Visible = false;
            }
        }

        private void lstDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIslem.SelectedIndex == -1)
            {
                lstIslem.SelectedIndex = 1;
                Console.Beep(2000, 5);
                dakika = Convert.ToInt32(lstDakika.Items[lstDakika.SelectedIndex]);
                SaatGoruntusunuDuzenle();
                txtDakika.Clear();
                //MessageBox.Show("Lütfen önce yapmak istediğiniz işlemi seçin!");
            }
            else if (lstDakika.SelectedIndex != -1)
            {
                Console.Beep(2000, 5);
                dakika = Convert.ToInt32(lstDakika.Items[lstDakika.SelectedIndex]);
                SaatGoruntusunuDuzenle();
                txtDakika.Clear();
            }
        }
        private void SaatGoruntusunuDuzenle()
        {
            btnIptal.Visible = true;
            timer1.Enabled = false;
            timer1.Enabled = true;
            saniye = 0;
            lblSaniye.Text = "0";
            saat = dakika / 60;
            lblSaat.Text = saat.ToString();
            dakika = dakika - saat * 60;
            lblDakika.Text = dakika.ToString();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnIptal.Visible = false;
            timer1.Enabled = false;
            Console.Beep(2000, 5);
            txtDakika.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(saat == 0 && dakika == 0 && saniye == 0)
            {
                timer1.Enabled = false;
                btnIptal.Visible = false;
                if (lstIslem.SelectedIndex == 0)
                    BilgisayariKapat();
                else if (lstIslem.SelectedIndex == 1)
                    UykuyaAl();
                else if (lstIslem.SelectedIndex == 2)
                    OturumuKilitle();
                else if (lstIslem.SelectedIndex == 3)
                    YenidenBaslat();
            }
            else if (saniye == 0)   // saniye 0 olduğunda saat ya da dakika varsa oradan saniye almalıyız
            {
                if(dakika > 0)
                {
                    saniye = 60;
                    dakika -= 1;
                    lblDakika.Text = dakika.ToString();
                    saniye -= 1;           // else bloğuna girmeyeceği için elsedeki kodun aynısını yazdım
                    lblSaniye.Text = saniye.ToString();
                }
                else if(saat > 0)
                {
                    saniye = 60;
                    saat -= 1;
                    lblSaat.Text = saat.ToString();
                    dakika = 59;
                    lblDakika.Text = dakika.ToString();
                    saniye -= 1;          // else bloğuna girmeyeceği için elsedeki kodun aynısını yazdım
                    lblSaniye.Text = saniye.ToString();
                }
            }
            else
            {
                saniye -= 1;
                lblSaniye.Text = saniye.ToString();
            }
            if(saat == 0 && dakika == 3 && saniye == 0)     // 3 dk kala uyarı sesi vereceğiz
            {
                Console.Beep(500, 1500);
            }
        }
        private void BilgisayariKapat()
        {
            System.Diagnostics.Process.Start("shutdown", "-f -s -t 0");  // (t'yi silmeyi dene) sonuna 0 yazmak gerekebilir kontrol et
        }
        private void UykuyaAl()
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();

        private void OturumuKilitle()
        {
            LockWorkStation();
        }
        private void YenidenBaslat()
        {
            System.Diagnostics.Process.Start("shutdown", "/r -f -t 0");
        }

        private void txtDakika_KeyPress(object sender, KeyPressEventArgs e)
        {
            // yalnız sayı girilmesini sağlayalım
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDakika, "Sadece sayı girebilirsiniz!");
            }
            else
                errorProvider1.Clear();
            // işlem seçilmemişken girişi engelleyelim
            if (lstIslem.SelectedIndex == -1)
            {
                lstIslem.SelectedIndex = 1;
                /*e.Handled = true;
                MessageBox.Show("Lütfen önce yapmak istediğiniz işlemi seçin!");*/
            }

        }
        private void lstIslem_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDakika.Focus();
            Console.Beep(1000,10);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Console.Beep(2000, 5);
            Application.ExitThread();
        }
    }
}

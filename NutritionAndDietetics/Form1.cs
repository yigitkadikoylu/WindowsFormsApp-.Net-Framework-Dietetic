using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionAndDietetics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSutD_Leave(object sender, EventArgs e)
        {
            try
            {
                int SutD = Convert.ToInt32(txtSutD.Text);
                txtSutCho.Text = (9 * SutD).ToString();
                txtSutPro.Text = (6 * SutD).ToString();
                txtSutYag.Text = (6 * SutD).ToString();
                lblSutEnerji.Text = ((4 * Convert.ToInt32(txtSutCho.Text)) + (4 * Convert.ToInt32(txtSutPro.Text)) + (9 * Convert.ToInt32(txtSutYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n"+"\n"+ex);
            }
        }

        private void txtEtD_Leave(object sender, EventArgs e)
        {
            try
            {
                int etD = Convert.ToInt32(txtEtD.Text);
                txtEtCho.Text = (0 * etD).ToString();
                txtEtPro.Text = (6 * etD).ToString();
                txtEtYag.Text = (5 * etD).ToString();
                lblEtEnerji.Text = ((4 * Convert.ToInt32(txtEtCho.Text)) + (4 * Convert.ToInt32(txtEtPro.Text)) + (9 * Convert.ToInt32(txtEtYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }

        }

        private void txtEYGD_Leave(object sender, EventArgs e)
        {
            try
            {
                int eygD = Convert.ToInt32(txtEYGD.Text);
                txtEYGCho.Text = (15 * eygD).ToString();
                txtEYGPro.Text = (2 * eygD).ToString();
                txtEYGYag.Text = (0 * eygD).ToString();
                lblEygEnerji.Text = ((4 * Convert.ToInt32(txtEYGCho.Text)) + (4 * Convert.ToInt32(txtEYGPro.Text)) + (9 * Convert.ToInt32(txtEYGYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }


        }

        private void txtSebzeD_Leave(object sender, EventArgs e)
        {
            try
            {
                int sebzeD = Convert.ToInt32(txtSebzeD.Text);
                txtSebzeCho.Text = (6 * sebzeD).ToString();
                txtSebzePro.Text = (1 * sebzeD).ToString();
                txtSebzeYag.Text = (0 * sebzeD).ToString();
                lblSebzeEnerji.Text = ((4 * Convert.ToInt32(txtSebzeCho.Text)) + (4 * Convert.ToInt32(txtSebzePro.Text)) + (9 * Convert.ToInt32(txtSebzeYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }
        }

        private void txtMeyveD_Leave(object sender, EventArgs e)
        {
            try
            {
                int meyveD = Convert.ToInt32(txtMeyveD.Text);
                txtMeyveCho.Text = (12 * meyveD).ToString();
                txtMeyvePro.Text = (0 * meyveD).ToString();
                txtMeyveYag.Text = (0 * meyveD).ToString();
                lblMeyveEnerji.Text = ((4 * Convert.ToInt32(txtMeyveCho.Text)) + (4 * Convert.ToInt32(txtMeyvePro.Text)) + (9 * Convert.ToInt32(txtMeyveYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }
        }

        private void txtYagD_Leave(object sender, EventArgs e)
        {
            try
            {
                int yagD = Convert.ToInt32(txtYagD.Text);
                txtYagCho.Text = (0 * yagD).ToString();
                txtYagPro.Text = (0 * yagD).ToString();
                txtYagYag.Text = (5 * yagD).ToString();
                lblYagEnerji.Text = ((4 * Convert.ToInt32(txtYagCho.Text)) + (4 * Convert.ToInt32(txtYagPro.Text)) + (9 * Convert.ToInt32(txtYagYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }
        }

        private void txtSekerD_Leave(object sender, EventArgs e)
        {
            try
            {
                int sekerD = Convert.ToInt32(txtSekerD.Text);
                txtSekerCho.Text = (5 * sekerD).ToString();
                txtSekerPro.Text = (0 * sekerD).ToString();
                txtSekerYag.Text = (0 * sekerD).ToString();
                lblSekerEnerji.Text = ((4 * Convert.ToInt32(txtSekerCho.Text)) + (4 * Convert.ToInt32(txtSekerPro.Text)) + (9 * Convert.ToInt32(txtSekerYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }

        }

        private void txtPelteD_Leave(object sender, EventArgs e)
        {
            try
            {
                int pelteD = Convert.ToInt32(txtPelteD.Text);
                txtPelteCho.Text = (20 * pelteD).ToString();
                txtPeltePro.Text = (0 * pelteD).ToString();
                txtPelteYag.Text = (0 * pelteD).ToString();
                lblPelteEnerji.Text = ((4 * Convert.ToInt32(txtPelteCho.Text)) + (4 * Convert.ToInt32(txtPeltePro.Text)) + (9 * Convert.ToInt32(txtPelteYag.Text))).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("bilinmedik bir hata oluştu yetkili ile görüşün.. \n\n" + "\n" + ex);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float toplamenerji = (Convert.ToSingle(lblSutEnerji.Text) + Convert.ToSingle(lblEtEnerji.Text) + Convert.ToSingle(lblEygEnerji.Text) + Convert.ToSingle(lblSebzeEnerji.Text) + Convert.ToSingle(lblMeyveEnerji.Text) + Convert.ToSingle(lblYagEnerji.Text) + Convert.ToSingle(lblSekerEnerji.Text) + Convert.ToSingle(lblPelteEnerji.Text));
            float choToplam = (Convert.ToSingle(txtSutCho.Text) + Convert.ToSingle(txtEtCho.Text) + Convert.ToSingle(txtEYGCho.Text) + Convert.ToSingle(txtMeyveCho.Text) + Convert.ToSingle(txtPelteCho.Text) + Convert.ToSingle(txtSebzeCho.Text) + Convert.ToSingle(txtSekerCho.Text) + Convert.ToSingle(txtYagCho.Text));
            float proteinToplam = (Convert.ToSingle(txtSutPro.Text) + Convert.ToSingle(txtEtPro.Text) + Convert.ToSingle(txtEYGPro.Text) + Convert.ToSingle(txtMeyvePro.Text) + Convert.ToSingle(txtPeltePro.Text) + Convert.ToSingle(txtSebzePro.Text) + Convert.ToSingle(txtSekerPro.Text) + Convert.ToSingle(txtYagPro.Text));
            float yagToplam = (Convert.ToSingle(txtSutYag.Text) + Convert.ToSingle(txtEtYag.Text) + Convert.ToSingle(txtEYGYag.Text) + Convert.ToSingle(txtMeyveYag.Text) + Convert.ToSingle(txtPelteYag.Text) + Convert.ToSingle(txtSebzeYag.Text) + Convert.ToSingle(txtSekerYag.Text) + Convert.ToSingle(txtYagYag.Text));
            lblToplamEnerji.Text =toplamenerji.ToString();
            lblChoToplam.Text = choToplam.ToString()+"g";
            lblProteinToplam.Text = proteinToplam.ToString() + "g";
            lblYagToplam.Text = yagToplam.ToString() + "g";
            lblChoKcalCevir.Text = (choToplam * 4).ToString()+"kcal";
            lblProKcalCevir.Text = (proteinToplam * 4).ToString() + "kcal";
            lblYagKcalCevir.Text = (yagToplam * 9).ToString() + "kcal";
            lblChoYuzde.Text = "%" + (((choToplam * 4) * 100) / Convert.ToSingle(lblToplamEnerji.Text)).ToString();
            lblProYuzde.Text = "%" + (((proteinToplam * 4) * 100) / Convert.ToSingle(lblToplamEnerji.Text)).ToString();
            lblYagYuzde.Text = "%" + (((yagToplam * 9) * 100) / Convert.ToSingle(lblToplamEnerji.Text)).ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double bkiBoy = Convert.ToSingle(txtBkiBoy.Text);
            double bkiKilo = Convert.ToSingle(txtBkiKilo.Text);
            double bkiSonuc = bkiKilo / (bkiBoy*bkiBoy);
            if(bkiSonuc<18.5)
            MessageBox.Show(bkiSonuc.ToString()+"ZAYIF");
            else if(bkiSonuc>=18.5 &&bkiSonuc<24.9)
            {
                MessageBox.Show(bkiSonuc.ToString()+"  NORMAL");
            }
            else if (bkiSonuc >= 18.5 && bkiSonuc < 24.9)
            {
                MessageBox.Show(bkiSonuc.ToString() + "  NORMAL");
            }
            else if (bkiSonuc >= 25 && bkiSonuc < 29.9)
            {
                MessageBox.Show(bkiSonuc.ToString() + "  FAZLA KİLOLU");
            }
            else if (bkiSonuc >= 30 && bkiSonuc < 34.9)
            {
                MessageBox.Show(bkiSonuc.ToString() + "  BİRİNCİ DERECE OBEZ");
            }
            else if (bkiSonuc >= 35 && bkiSonuc < 39.9)
            {
                MessageBox.Show(bkiSonuc.ToString() + "  İKİNCİ DERECE OBEZ");
            }
            else if (bkiSonuc >=40)
            {
                MessageBox.Show(bkiSonuc.ToString() + "  MORBİD OBEZ");
            }



        }
    }
}

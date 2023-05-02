using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace hafızaOyunu
{
    public partial class Form1 : Form
    {
        

        Image[] resimler =
        {
            Properties.Resources.cihck_hicks,
            Properties.Resources.doc_hudson,
            Properties.Resources.guido,
            Properties.Resources.king,
            Properties.Resources.luigi,
            Properties.Resources.mater,
            Properties.Resources.mcquen,
            Properties.Resources.sally
        };

        int[] indeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        bool cevap;

        PictureBox ilkKutu;
        int ilkIndeks, bulunan, deneme, sayac = 1;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Enabled = false;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            resimleriKaristir();
        }

        private void resimleriKaristir()
        {
            Random rnd = new Random();

            for (int i = 0; i < 16; i++)
            {
                int sayi = rnd.Next(16);

                int gecici = indeksler[i];
                indeksler[i] = indeksler[sayi];
                indeksler[sayi] = gecici;
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox kutu = (PictureBox)sender;
            
            int kutuNo = int.Parse(kutu.Name.Substring(10));
            int indeksNo = indeksler[kutuNo - 1];
            kutu.Image = resimler[indeksNo];
            kutu.Refresh();

            if (ilkKutu == null)
            {
                ilkKutu = kutu;
                ilkIndeks = indeksNo;
                cevap = false;
                deneme++;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);

                ilkKutu.Image = null;
                kutu.Image = null;

                if (ilkIndeks == indeksNo)
                {
                    bulunan++;
                    cevap = true;
                    ilkKutu.Visible = false;
                    kutu.Visible = false;
                    label2.Visible = true;
                    timer1.Enabled = true;

                    
                   


                    if (bulunan == 8)
                    {
                        if(deneme <= 16)
                        {
                            MessageBox.Show(sayac + ".oyun: Tebrikler " + deneme + ". deneme de buldunuz. 120 puan aldınız.");
                            listBox1.Items.Add(sayac + ". oyun, Deneme: " + deneme + ", Puan: 120");
                        }
                            
                        else if(bulunan <= 20 && bulunan > 16)
                        {
                            MessageBox.Show(sayac + ".oyun: Tebrikler " + deneme + ". deneme de buldunuz. 100 puan aldınız.");
                            listBox1.Items.Add(sayac + ". oyun, Deneme: " + deneme + ", Puan: 100");
                        }
                            
                        else
                        {
                            MessageBox.Show(sayac + ".oyun: Tebrikler " + deneme + ". deneme de buldunuz. 80 puan aldınız.");
                            listBox1.Items.Add(sayac + ". oyun, Deneme: " + deneme + ", Puan: 80");
                        }
                            
                        bulunan = 0;
                        deneme = 0;
                        
                        sayac++;
                        foreach (Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }
                        resimleriKaristir();
                    }

                    
                }

                label3.Text = "Deneme: " + deneme;

                if(cevap == false)
                {
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\yanlisCevap.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\dogruCevap.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                ilkKutu = null;
            }
        }


       
    }
}

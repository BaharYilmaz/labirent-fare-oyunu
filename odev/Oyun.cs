﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Oyun : Form
    {
    //    Image imgYol = Image.FromFile(@"C:\Users\ZİŞAN\Documents\GitHub\odev\odev\resources\yol_.jpg");
    //    Image imgLabirent = Image.FromFile(@"C:\Users\ZİŞAN\Documents\GitHub\odev\odev\resources\maze_.jpg");
    //    Image imgFare1 = Image.FromFile(@"C:\Users\ZİŞAN\Documents\GitHub\odev\odev\resources\mice1.png");
    //    Image imgFare2 = Image.FromFile(@"C:\Users\ZİŞAN\Documents\GitHub\odev\odev\resources\mice2.png");
    //    Image imgPeynir = Image.FromFile(@"C:\Users\ZİŞAN\Documents\GitHub\odev\odev\resources\cheese.png");
        Image imgYol = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\yol_.jpg");
        Image imgLabirent = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\maze_.jpg");
        Image imgFare1 = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\mice1.png");
        Image imgFare2 = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\mice2.png");
        Image imgPeynir = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\cheese.png");


       
        private void Oyun_Load(object sender, EventArgs e)
        {
            dgv_olustur();
            timer_labirent.Interval = 200;
            
        }
        public Oyun()
        {
            InitializeComponent();
        }
        
        int fareX=10;
        int fareY=10;
        int peynirX;
        int peynirY;
        int kuzey = 0;
        int guney = 0;
        int bati = 0;
        int dogu = 0;
        int hucredegeri = 0;
        int hamleSayisi = 0;

        public void dgv_olustur()
        {
            dgv_labirent.Columns.Clear();
            dgv_labirent.Rows.Clear();

            for (int i = 0; i < 12; i++)
            {
                DataGridViewImageColumn resim = new DataGridViewImageColumn();
                resim.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgv_labirent.Columns.Add(resim);

            }
            dgv_labirent.Rows.Add(12);

            dgv_labirent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewRow dgvRow in dgv_labirent.Rows)
            {
                dgvRow.Height = dgv_labirent.Columns[0].Width;
            }
            labirentOlustur();

        }

        public void labirentOlustur()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    dgv_labirent[i, j].Value = imgYol;
                    dgv_labirent[i, j].Tag = 1;// yol tag 1
                }

            }
            
            for (int i = 0; i < 12; i++)//üst-alt duvar
            {
                dgv_labirent[i, 0].Value = imgLabirent; dgv_labirent[i, 0].Tag = 100;
                dgv_labirent[i, 11].Value = imgLabirent; dgv_labirent[i, 11].Tag = 100;
            }
            for (int i = 0; i < 12; i++)//yan duvarlar
            {
                dgv_labirent[0, i].Value = imgLabirent; dgv_labirent[0, i].Tag = 100;
                dgv_labirent[11, i].Value = imgLabirent; dgv_labirent[11, i].Tag = 100;
            }
            for (int i = 2; i < 10; i++)
            {
                dgv_labirent[i, 2].Value = imgLabirent; dgv_labirent[i, 2].Tag = 100; //labirent duvar tag 100
                dgv_labirent[i, 8].Value = imgLabirent; dgv_labirent[i, 8].Tag = 100;
            }
            for (int i = 3; i < 10; i++)
            {
                if (dgv_labirent[2, i] != dgv_labirent[2, 6])
                {
                    dgv_labirent[2, i].Value = imgLabirent; dgv_labirent[2, i].Tag = 100;
                }
            }
            for (int i = 3; i < 6; i++)
            {
                dgv_labirent[i, 5].Value = imgLabirent; dgv_labirent[i, 5].Tag = 100;
            }
            for (int i = 4; i < 8; i++)
            {
                dgv_labirent[7, i].Value = imgLabirent; dgv_labirent[7, i].Tag = 100;
            }
            dgv_labirent[5, 4].Value = imgLabirent; dgv_labirent[5, 4].Tag = 100;
            dgv_labirent[8, 4].Value = imgLabirent; dgv_labirent[8, 4].Tag = 100;
            dgv_labirent[9, 4].Value = imgLabirent; dgv_labirent[9, 4].Tag = 100;
            dgv_labirent[4, 7].Value = imgLabirent; dgv_labirent[4, 7].Tag = 100;
            dgv_labirent[5, 9].Value = imgLabirent; dgv_labirent[5, 9].Tag = 100;
            dgv_labirent[8, 9].Value = imgLabirent; dgv_labirent[8, 9].Tag = 100;
            dgv_labirent[9, 6].Value = imgLabirent; dgv_labirent[9, 6].Tag = 100;
            dgv_labirent[10, 6].Value = imgLabirent; dgv_labirent[10, 6].Tag = 100;

            dgv_labirent[10, 10].Value = imgFare1;
            dgv_labirent[10, 10].Tag = 10;//fare tag 10
            

            Random rastgele = new Random();
            
            for (; ; )
            {
                peynirX = rastgele.Next(0, 12);
                peynirY = rastgele.Next(0, 12);

                if(dgv_labirent[peynirX,peynirY].Value== imgYol)
                {
                    dgv_labirent[peynirX, peynirY].Value = imgPeynir;
                    dgv_labirent[peynirX, peynirY].Tag = 0;
                    break;
                }
            }
            
            
        }

        public int fareBul()
        {
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = imgFare1;

            kuzey = Convert.ToInt32(dgv_labirent.Rows[fareY - 1].Cells[fareX].Tag);
            guney = Convert.ToInt32(dgv_labirent.Rows[fareY + 1].Cells[fareX].Tag);
            bati = Convert.ToInt32(dgv_labirent.Rows[fareY].Cells[fareX - 1].Tag);
            dogu = Convert.ToInt32(dgv_labirent.Rows[fareY].Cells[fareX + 1].Tag);

            if (kuzey <= bati && kuzey <= dogu && kuzey <= guney)
            {
                if (kuzey != 100)//duvar
                {
                    hucredegeri = kuzey;
                    if (kuzey == 0)//peynir
                    {
                        timer_labirent.Stop();
                        timer_labirent.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[fareY - 1].Cells[fareX] = yeniFareKonum;
                    dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol; //eski fare konumuna yol eklenir
                    fareY--;
                    hamleSayisi += 1;
                }

            }
            else if (bati <= kuzey && bati <= dogu & bati <= guney)
            {
                if (bati != 100)
                {
                    hucredegeri = bati;
                    if (bati == 0)
                    {
                        timer_labirent.Stop();
                        timer_labirent.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[fareY].Cells[fareX - 1] = yeniFareKonum;
                    dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol;
                    fareX--;
                    hamleSayisi += 1;
                }
            }
            else if (guney <= kuzey && guney <= bati && guney <= dogu)
            {
                if (guney != 100)
                {
                    hucredegeri = guney;
                    if (guney == 0)
                    {
                        timer_labirent.Stop();
                        timer_labirent.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[fareY + 1].Cells[fareX] = yeniFareKonum;
                    dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol;
                    fareY++;
                    hamleSayisi += 1;
                }
            }
            else if (dogu <= kuzey && dogu <= bati && dogu <= guney)
            {
                if (dogu != 100)
                {
                    hucredegeri = dogu;
                    if (dogu == 0)
                    {
                        timer_labirent.Stop();
                        timer_labirent.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[fareY].Cells[fareX + 1] = yeniFareKonum;
                    dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol;
                    fareX++;
                    hamleSayisi += 1;
                }
            }
            return 0;

        }

        private void timer_labirent_Tick(object sender, EventArgs e)
        {
            int valuable=fareBul();
            if(valuable==1)
            {
                alert();
            }
        }

        
 
        private void btn_tekKisiOyna_Click(object sender, EventArgs e)
        {
          
            lblHamle.Text = "";


        }

        private void TekKisiOyna(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right && (int)dgv_labirent[fareX + 1, fareY].Tag != 100)
            {
                if (e.KeyData == Keys.Right && (int)dgv_labirent[fareX+1, fareY].Tag == 0)
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[++fareX, fareY].Value = imgFare1;
                    alert();
                }
                else
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[++fareX, fareY].Value = imgFare1;
                }

            }
            if (e.KeyData == Keys.Left && (int)dgv_labirent[fareX - 1, fareY].Tag != 100)
            {
                if (e.KeyData == Keys.Left && (int)dgv_labirent[fareX - 1, fareY].Tag == 0)
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[--fareX, fareY].Value = imgFare1;
                    alert();
                }
                else
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[--fareX, fareY].Value = imgFare1;
                }
            }

            if (e.KeyData == Keys.Up && (int)dgv_labirent[fareX, fareY - 1].Tag != 100)
            {
                if (e.KeyData == Keys.Up && (int)dgv_labirent[fareX, fareY - 1].Tag == 0)
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[fareX, --fareY].Value = imgFare1;
                    alert();
                }
                else
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[fareX, --fareY].Value = imgFare1;
                }
            }

            if (e.KeyData == Keys.Down && (int)dgv_labirent[fareX, fareY + 1].Tag != 100)
            {
                if (e.KeyData == Keys.Down && (int)dgv_labirent[fareX, fareY + 1].Tag == 0)
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[fareX, ++fareY].Value = imgFare1;
                    alert();
                }
                else
                {
                    hamleSayisi += 1;
                    dgv_labirent[fareX, fareY].Value = null;
                    dgv_labirent[fareX, fareY].Value = imgYol;
                    dgv_labirent[fareX, ++fareY].Value = imgFare1;

                }
            }
            
        }

        public void alert()
        {
            MessageBox.Show("Peynir " + hamleSayisi+ " hamlede bulundu.");
            dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol;//fare eski konumuna yol eklenir
            dgv_labirent[10, 10].Value = imgFare1;
            dgv_labirent[10, 10].Tag = 10;//fare tag 10
            dgv_labirent[peynirX, peynirY].Value = imgYol;//peynirin eski konumuna yol eklendi.
            dgv_labirent[peynirX, peynirY].Tag = 1;//yeni yola 1 atanır
            fareX = 10;
            fareY = 10;
            lblHamle.Text = hamleSayisi.ToString();
            hamleSayisi = 0;

            Random rastgele = new Random();

            for (; ; )
            {
                peynirX = rastgele.Next(0, 12);
                peynirY = rastgele.Next(0, 12);

                if (dgv_labirent[peynirX, peynirY].Value == imgYol)
                {
                    dgv_labirent[peynirX, peynirY].Value = imgPeynir;
                    dgv_labirent[peynirX, peynirY].Tag = 0;
                    break;
                }
            }
        }

        private void btn_bilgisayarOyna_Click(object sender, EventArgs e)
        {
            timer_labirent.Enabled = true;
            timer_labirent.Start();

            lblHamle.Text = "";
        }
    }
}

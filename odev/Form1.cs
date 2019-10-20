using System;
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
    public partial class Form1 : Form
    {
        Image imgYol = Image.FromFile(@"C: \Users\BHR\source\repos\odev\odev\resources\yol_.jpg");
        Image imgLabirent = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\maze_.jpg");
        Image imgFare1 = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\mice1.png");
        Image imgFare2 = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\mice2.png");
        Image imgPeynir = Image.FromFile(@"C:\Users\BHR\source\repos\odev\odev\resources\cheese.png");
        
        int fareX;
        int fareY;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_olustur();
            timer_labirent.Interval = 200;

        }

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
                    if (dgv_labirent[i, j] != dgv_labirent[6, 7])
                    {
                        dgv_labirent[i, j].Value = imgYol; dgv_labirent[i, j].Tag = 1;// yol tag 1

                    }
                    else
                    {
                        dgv_labirent[i, j].Value = imgYol;
                        dgv_labirent[i, j].Value = imgPeynir; dgv_labirent[i, j].Tag = 0;//peynir tag 0
                    }

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

            dgv_labirent[10, 10].Value = imgFare1; dgv_labirent[10, 10].Tag = 10;//fare tag 10
            fareX = 10;
            fareY = 10;


        
    }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            btn_basla.Enabled = false;
            timer_labirent.Enabled = true;
            timer_labirent.Start();
        }

        public int fareBul()
        {
            int kuzey = 0;
            int guney = 0;
            int bati = 0;
            int dogu = 0;
            int hucredegeri = 0;
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = imgFare1;
            
            kuzey = Convert.ToInt32(dgv_labirent.Rows[fareY - 1].Cells[fareX].Tag);
            guney = Convert.ToInt32(dgv_labirent.Rows[fareY + 1].Cells[fareX].Tag);
            bati = Convert.ToInt32(dgv_labirent.Rows[fareY].Cells[fareX - 1].Tag);
            dogu = Convert.ToInt32(dgv_labirent.Rows[fareY].Cells[fareX + 1].Tag);

            if(kuzey<=bati && kuzey<=dogu &&kuzey<=guney )
            {
                if(kuzey!=100)//duvar
                {
                    hucredegeri = kuzey;
                    if(kuzey==0)//peynir
                    {
                        timer_labirent.Stop();
                        timer_labirent.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[fareY - 1].Cells[fareX] = yeniFareKonum;
                    dgv_labirent.Rows[fareY].Cells[fareX].Value = imgYol; //eski fare konumuna yok eklenir
                    fareY--;
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
                }
            }
            else if (dogu <= kuzey && dogu <= bati && dogu <= guney)
            {
                if (dogu != 100 )
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
                }
            }
            return 0;

        }

        public void fareBulManuel()
        { }

        public void fareBulCiftKisi()
        { }

        private void timer_labirent_Tick(object sender, EventArgs e)
        {
            int returnValue = fareBul();
            if(returnValue==1)
            {
                MessageBox.Show("PEYNİR BULUNDU!");
            }

        }
    }
}

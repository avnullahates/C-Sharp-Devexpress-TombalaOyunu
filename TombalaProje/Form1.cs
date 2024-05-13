using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TombalaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SayilarTablo", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (rbOtomatik.Checked == true)
            {
                rbElile.Checked = false;
            }
            if (rbElile.Checked == true)
            {
                rbOtomatik.Checked = false;
            }
            Listele();
        }

        int i = 0;
        int[] sayilar = new int[90];
        int sayac1 = 0;
        int sayac2 = 0;
        int sayac3 = 0;
        int geriSayim = 0;
        string sayilarDizi = "";

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Random randomSayi = new Random();
            geriSayim++;
            lblSayim.Text = geriSayim + ". Sayi:";
            if (i == 90)
            {
                dialog();
            }
        ise:
            int sayi = randomSayi.Next(1, 91);

            int yokIse = Array.IndexOf(sayilar, sayi);

            if (yokIse == -1)// 90 tane sayi icerisinde ayni sayiyi vermmemesi icin
            {
                sayilar[i] = sayi;
                lvCekilenSayilar.Items.Add(sayi.ToString());
                lblCekilenSayi.Text = sayi.ToString();
                i++;

            }
            else
            {
                goto ise; //array icindeki sayiyi 0 yapmamasi icin
            }

            if (rbOtomatik.Checked == true)
            {
                foreach (Button x in this.gbKart.Controls)
                {
                    if (x.Text == lblCekilenSayi.Text)
                    {
                        x.Enabled = false;
                        x.Text = "";
                        x.BackColor = Color.Red;
                    }
                }
            }

            if (rbElile.Checked == true)
            {
                foreach (Button x in this.gbKart.Controls)
                {
                    x.Click += (s, args) =>   //grupbox icindeki buttonlara tiklandiginda
                    {
                        var butonTiklanan = (Button)s;
                        if (butonTiklanan.Text == lblCekilenSayi.Text)
                        {
                            butonTiklanan.Text = "";
                            butonTiklanan.Enabled = false;
                            butonTiklanan.BackColor = Color.Red;
                        }
                    };
                }
            }
            sayilarDizi = sayilarDizi + sayi.ToString() + ",";



            DataTable dt2 = new DataTable();
            SqlCommand komut2 = new SqlCommand("SELECT TOP 1 ID FROM SayilarTablo ORDER BY ID DESC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblId.Text = dr2[0].ToString();

            }
            bgl.baglanti().Close();
            string id = LblId.Text;
           
           

            
                SqlCommand sayilarDuzenle = new SqlCommand("update SayilarTablo set SAYILAR = @P2 where ID=@P3", bgl.baglanti());
                sayilarDuzenle.Parameters.AddWithValue("@P2", sayilarDizi.ToString());
                sayilarDuzenle.Parameters.AddWithValue("@P3", id.ToString());
                sayilarDuzenle.ExecuteNonQuery();
                bgl.baglanti().Close();
            

            Listele();



            if (btn11.Text == "" && btn31.Text == "" && btn51.Text == "" && btn71.Text == "" && btn81.Text == "")
            {
                if (sayac1 == 0)
                {
                    MessageBox.Show("Tebrikler Çinko");
                    sayac1++;
                }
            }
            if (btn22.Text == "" && btn42.Text == "" && btn62.Text == "" && btn82.Text == "" && btn92.Text == "")
            {
                if (sayac2 == 0)
                {
                    MessageBox.Show("Tebrikler Çinko");
                    sayac2++;
                }
            }
            if (btn31.Text == "" && btn33.Text == "" && btn53.Text == "" && btn73.Text == "" && btn93.Text == "")
            {
                if (sayac3 == 0)
                {
                    MessageBox.Show("Tebrikler Çinko");
                    sayac3++;
                }
            }

            if (btn11.Text == "" && btn31.Text == "" && btn51.Text == "" && btn71.Text == "" && btn81.Text == "" && btn22.Text == "" && btn42.Text == "" && btn62.Text == "" && btn82.Text == "" && btn92.Text == "" && btn31.Text == "" && btn33.Text == "" && btn53.Text == "" && btn73.Text == "" && btn93.Text == "")
            {
                MessageBox.Show("Tebrikler Tombala");
                dialog();
            }

        }

        private void btnBasla_Click_1(object sender, EventArgs e)
        {
            btnTasCek.Enabled = true;
            listBox1.Items.Clear();
            lblCekilenSayi.Text = "";


            int[] sayilarKart1 = new int[2];
            Random randomKart = new Random();

            //1-9 
            int i = 0;
            while (i < 2)
            {
                int sayi1 = randomKart.Next(1, 10);

                int yokIse = Array.IndexOf(sayilarKart1, sayi1);
                if (yokIse == -1)
                {
                    sayilarKart1[i] = sayi1;

                    listBox1.Items.Add(sayi1);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart1);
                        btn13.Text = sayilarKart1[i].ToString();
                        btn11.Text = sayilarKart1[i - 1].ToString();
                    }
                }
                i++;
            }

            //10-19
            int sayi2 = randomKart.Next(10, 20);
            btn22.Text = sayi2.ToString();
            listBox1.Items.Add(sayi2);

            //20-29
            int[] sayilarKart3 = new int[2];
            i = 0;
            while (i < 2)
            {
                int sayi3 = randomKart.Next(20, 30);
                int yokIse3 = Array.IndexOf(sayilarKart3, sayi3);
                if (yokIse3 == -1)
                {
                    sayilarKart3[i] = sayi3;
                    listBox1.Items.Add(sayi3);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart3);
                        btn33.Text = sayilarKart3[i].ToString();
                        btn31.Text = sayilarKart3[i - 1].ToString();
                    }
                }
                i++;
            }


            //30-39
            int sayi4 = randomKart.Next(30, 40);
            btn42.Text = sayi4.ToString();
            listBox1.Items.Add(sayi4);

            //40-49
            int[] sayilarKart5 = new int[2];
            i = 0;
            while (i < 2)
            {
                int sayi5 = randomKart.Next(40, 50);
                int yokIse5 = Array.IndexOf(sayilarKart5, sayi5);
                if (yokIse5 == -1)
                {
                    sayilarKart5[i] = sayi5;
                    listBox1.Items.Add(sayi5);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart5);
                        btn53.Text = sayilarKart5[i].ToString();
                        btn51.Text = sayilarKart5[i - 1].ToString();
                    }
                }
                i++;
            }

            //50-59
            int sayi6 = randomKart.Next(50, 60);
            btn62.Text = sayi6.ToString();
            listBox1.Items.Add(sayi6);

            //60-69
            int[] sayilarKart7 = new int[2];
            i = 0;
            while (i < 2)
            {
                int sayi7 = randomKart.Next(60, 70);
                int yokIse7 = Array.IndexOf(sayilarKart7, sayi7);
                if (yokIse7 == -1)
                {
                    sayilarKart7[i] = sayi7;
                    listBox1.Items.Add(sayi7);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart7);
                        btn73.Text = sayilarKart7[i].ToString();
                        btn71.Text = sayilarKart7[i - 1].ToString();
                    }
                }
                i++;
            }

            //70-79
            int[] sayilarKart8 = new int[2];
            i = 0;
            while (i < 2)
            {
                int sayi8 = randomKart.Next(70, 80);
                int yokIse8 = Array.IndexOf(sayilarKart8, sayi8);
                if (yokIse8 == -1)
                {
                    sayilarKart8[i] = sayi8;
                    listBox1.Items.Add(sayi8);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart8);
                        btn82.Text = sayilarKart8[i].ToString();
                        btn81.Text = sayilarKart8[i - 1].ToString();
                    }
                }
                i++;
            }

            //80 90
            int[] sayilarKart9 = new int[2];
            i = 0;
            while (i < 2)
            {
                int sayi9 = randomKart.Next(80, 91);
                int yokIse9 = Array.IndexOf(sayilarKart9, sayi9);
                if (yokIse9 == -1)
                {
                    sayilarKart9[i] = sayi9;
                    listBox1.Items.Add(sayi9);
                    if (i == 1)
                    {
                        Array.Sort(sayilarKart9);
                        btn93.Text = sayilarKart9[i].ToString();
                        btn92.Text = sayilarKart9[i - 1].ToString();
                    }
                }
                i++;
            }

            foreach (Button x in this.gbKart.Controls)
            {
                if (x.Text != "" && x.Text != "1")
                {
                    x.BackColor = Color.White;
                    x.ForeColor = Color.Red;
                    x.Font = new Font("Microsoft YaHei", 36, FontStyle.Bold);
                }
            }

            for (int a = 0; a < listBox1.Items.Count; a++)
            {
                LblSayilarimiz.Text += listBox1.Items[a] + ",";
            }
            SqlCommand oyuncuSayiEkle = new SqlCommand("insert into SayilarTablo (BIRINCIOYUNCU) values (@P5)", bgl.baglanti());
            oyuncuSayiEkle.Parameters.AddWithValue("@P5",LblSayilarimiz.Text);
            oyuncuSayiEkle.ExecuteNonQuery();
            bgl.baglanti().Close();


            Listele();
            //DataTable dt2 = new DataTable();
            //SqlCommand komut2 = new SqlCommand("SELECT TOP 1 ID FROM SayilarTablo ORDER BY ID DESC", bgl.baglanti());
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    LblId.Text = dr2[0].ToString();

            //}
            //bgl.baglanti().Close();
            //string id = LblId.Text;

            btnBasla.Enabled = false;
        }

        void dialog()
        {
            DialogResult secenek = MessageBox.Show("Oyun bitti. Tekrar başlamak istemisiniz.", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            else
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}

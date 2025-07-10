using AForge.Video;
using AForge.Video.DirectShow;
using Market_Otomasyonu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;


namespace Market_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);

            }
            cmbKamera.SelectedIndex = 0;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (kameram != null && kameram.IsRunning)
            {
                kameram.SignalToStop();
                kameram.WaitForStop();
            }
            this.Hide();  //çalışan pencereyi sakla
            AdminKategoriİşlemleri categorypage = new AdminKategoriİşlemleri();
            categorypage.Show();//ilk pencerre kapanır ikinci pencere açılır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kameram != null && kameram.IsRunning)
            {
                kameram.SignalToStop();
                kameram.WaitForStop();
            }
            this.Hide();
            AdminÜrünİşlemleri productPage = new AdminÜrünİşlemleri();
            productPage.Show();
        }



        private void btnBaslat_Click(object sender, EventArgs e)
        {

            if (kameram == null || !kameram.IsRunning)
            {
                kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
                kameram.NewFrame += VideoCaptureDevice_NewFrame;
                kameram.Start();
            }
        }
        public static double FindProductPrice(string Barcode)
        {
            SqlCommand commandFindProductPrice = new SqlCommand("select ProductPrice from TableProduct where ProductBarcode=@p1", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandFindProductPrice.Parameters.AddWithValue("@p1", Barcode);
            SqlDataReader dr = commandFindProductPrice.ExecuteReader();
            double price = 0;
            while (dr.Read())
            {
                price = Convert.ToDouble(dr[0]);
            }
            dr.Close();
            return price;
        }
        double sum = 0;
        double price = 0;
        

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true,
                Options = new ZXing.Common.DecodingOptions
                {
                    TryHarder = true,
                    PossibleFormats = new List<BarcodeFormat>
        {
            BarcodeFormat.CODE_128,
            BarcodeFormat.EAN_13,
            BarcodeFormat.UPC_A
        }
                }
            };

            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if (sonuc != null && !string.IsNullOrEmpty(sonuc.Text))
            {
                string barkod = sonuc.Text;

                if (txtBarcode != null && txtBarcode.IsHandleCreated)
                {
                    txtBarcode.Invoke(new MethodInvoker(() =>
                    {
                        string temp_barcode =" ";
                        if(temp_barcode== barkod)
                        {

                        }
                        else
                        {
                                temp_barcode = barkod;
                                txtBarcode.Text = barkod;
                                 price = FindProductPrice(barkod);
                            if (price == 0)
                            {
                       
                           }
                                sum += price;
                                if (richTextBox1 != null)
                                richTextBox1.Text = sum.ToString();
                        }
                    }
                            
                        
                        

                   ));
                }
            }
            PictureBox1.Image = GoruntulenenBarkod;
        }
        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (kameram != null && kameram.IsRunning)
            {
                kameram.SignalToStop();
                kameram.WaitForStop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sum = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sum += price;
            richTextBox1.Text = sum.ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            sum -= price;
            richTextBox1.Text = sum.ToString();

        }
    }

}

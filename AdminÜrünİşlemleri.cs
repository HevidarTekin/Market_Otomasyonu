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
    public partial class AdminÜrünİşlemleri : Form
    {
        public AdminÜrünİşlemleri()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        public  void LoadProducts()
        {
            SqlCommand commandList = new SqlCommand("SELECT p.ProductID, p.ProductName, p.ProductPrice, p.ProductBarcode, c.CategoryName FROM TableProduct p INNER JOIN TableCategory c ON p.ProductCategory = c.CategoryID", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgProduct.DataSource = dt;
        }
        public void LoadCategories()
        {
            SqlCommand commandLoadCategories = new SqlCommand("select * from TableCategory",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            cmbBoxCategory.DisplayMember = "CategoryName";
            cmbBoxCategory.ValueMember = "CategoryID";
            SqlDataAdapter daLoadCategories = new SqlDataAdapter(commandLoadCategories);
            DataTable dtLoadCategories = new DataTable();
            daLoadCategories.Fill(dtLoadCategories);
            cmbBoxCategory.DataSource = dtLoadCategories;
          
        }
        private void AdminÜrünİşlemleri_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (Cihazlar.Count > 0)
            {
                foreach (FilterInfo cihaz in Cihazlar)
                {
                    cmbKamera.Items.Add(cihaz.Name);
                }
                cmbKamera.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Kamera bulunamadı.");
            }

            LoadProducts();
            LoadCategories();

        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newforms = new Form1();
            newforms.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("INSERT INTO TableProduct (ProductName,ProductCategory,ProductPrice,ProductBarcode) values (@pname,@pcategory,@pprice,@pbarcode)", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandAdd.Parameters.AddWithValue("@pname",tboxProductName.Text);
            commandAdd.Parameters.AddWithValue("@pcategory",Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pprice",tboxProductPrice.Text);
            commandAdd.Parameters.AddWithValue("@pbarcode",tboxProductBarcode.Text);
            commandAdd.ExecuteNonQuery();
            IncreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("Ürün Başarıyla Eklendi");
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableProduct where ProductID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid", Convert.ToInt32(tboxDelete.Text));
            commandDelete.ExecuteNonQuery();
            DescreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("Ürün Başarıyla Silindi");

        }
        String SelectedID;
        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProduct.CurrentRow==null)
            {

            }
            else
            {
                SelectedID = dgProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                lblSelectedID.Text = SelectedID;
            }
             

        }
        public  void IncreaseCategoryCount()
        {
            SqlCommand commandıncrease = new SqlCommand("Update TableCategory set CategoryCount+=1 where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
          commandıncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandıncrease.ExecuteNonQuery();
        }
        public void DescreaseCategoryCount()
        {
            SqlCommand commandıncrease = new SqlCommand("Update TableCategory set CategoryCount-=1 where CategoryID=@pid", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandıncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandıncrease.ExecuteNonQuery();
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (Cihazlar == null || Cihazlar.Count == 0)
            {
                MessageBox.Show("Kamera listesi boş. Lütfen kamerayı kontrol et.");
                return;
            }

            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();

        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (eventArgs.Frame == null) return;
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);
            if (sonuc != null)
            {
                tboxProductBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    tboxProductBarcode.Text = sonuc.ToString();
                }
                ));
            }
            PictureBox1.Image = GoruntulenenBarkod;
        }
        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (kameram != null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

    


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
using Market_Otomasyonu.Classes;
namespace Market_Otomasyonu
{
    public partial class AdminKategoriİşlemleri : Form
    {
        public AdminKategoriİşlemleri()
        {
            InitializeComponent();
        }
        public void LoadCategories()
        {
            SqlCommand commandListCategories = new SqlCommand("Select * from TableCategory",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(commandListCategories);
            DataTable dt = new DataTable();
            da.Fill(dt);//tabloyu doldur
            dataGridView1.DataSource = dt;//tabloyu görselde göster gibi bir şey
        }
        private void AdminKategoriİşlemleri_Load(object sender, EventArgs e)
        {
            LoadCategories();

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlCommand CommandAddCategory = new SqlCommand("Insert into TableCategory (CategoryName) values(@pname)",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            CommandAddCategory.Parameters.AddWithValue("@pname", tboxCategoryName.Text);
            CommandAddCategory.ExecuteNonQuery();
            LoadCategories();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableCategory where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(SelectedID));
            int result = commandDelete.ExecuteNonQuery();
            if (result > 0)
            {
                LoadCategories();
                MessageBox.Show("Veri başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Silinecek kategori bulunamadı.");
            }
        }
        string SelectedID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["CategoryID"] != null)
            {
                SelectedID = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
                lblSelectedID.Text = SelectedID;
            }
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newforms = new Form1();
            newforms.Show();
        }
    }
}

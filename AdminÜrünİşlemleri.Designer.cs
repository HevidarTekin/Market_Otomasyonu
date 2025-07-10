namespace Market_Otomasyonu
{
    partial class AdminÜrünİşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnMW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.tboxProductPrice = new System.Windows.Forms.TextBox();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxDelete = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(29, 12);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(643, 174);
            this.dgProduct.TabIndex = 0;
            // 
            // btnMW
            // 
            this.btnMW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.btnMW.Location = new System.Drawing.Point(509, 209);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(163, 46);
            this.btnMW.TabIndex = 1;
            this.btnMW.Text = "Ana Ekrana Dön";
            this.btnMW.UseVisualStyleBackColor = false;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxProductBarcode);
            this.groupBox1.Controls.Add(this.tboxProductPrice);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(29, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(19, 39);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(175, 24);
            this.cmbBoxCategory.TabIndex = 0;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(19, 93);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(154, 22);
            this.tboxProductName.TabIndex = 1;
            // 
            // tboxProductPrice
            // 
            this.tboxProductPrice.Location = new System.Drawing.Point(19, 137);
            this.tboxProductPrice.Name = "tboxProductPrice";
            this.tboxProductPrice.Size = new System.Drawing.Size(154, 22);
            this.tboxProductPrice.TabIndex = 2;
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Location = new System.Drawing.Point(19, 181);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(154, 22);
            this.tboxProductBarcode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün kategorisi seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün adı giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün fiyatı giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün barkodu giriniz";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ürünü Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(51, 71);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedID.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxDelete);
            this.groupBox2.Controls.Add(this.lblSelectedID);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(267, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sil";
            // 
            // tboxDelete
            // 
            this.tboxDelete.Location = new System.Drawing.Point(33, 68);
            this.tboxDelete.Name = "tboxDelete";
            this.tboxDelete.Size = new System.Drawing.Size(132, 22);
            this.tboxDelete.TabIndex = 10;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(689, 85);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(373, 222);
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(689, 55);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(375, 24);
            this.cmbKamera.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // AdminÜrünİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1136, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.dgProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminÜrünİşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminÜrünİşlemleri";
            this.Load += new System.EventHandler(this.AdminÜrünİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnMW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.TextBox tboxProductPrice;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tboxDelete;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.Button button1;
    }
}
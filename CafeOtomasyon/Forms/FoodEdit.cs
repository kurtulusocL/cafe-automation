using CafeOtomasyon.Data;
using CafeOtomasyon.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Forms
{
    public partial class FoodEdit : Form
    {
        ApplicationDbContext _db;
        Food food = new Food();

        public FoodEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedValue = "";
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridFood.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                CategoryName = i.Category.Name,
                i.Price,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridFood.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                CategoryName = i.Category.Name,
                i.Price,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void FoodEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Yemek ismi ile arama yapabilirsiniz");
            FormLoad();

            cmbCategory.DataSource = _db.Categories.Include("Drinks").Include("Foods").OrderBy(i => i.Drinks.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridFood.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                CategoryName = i.Category.Name,
                i.Price,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).Where(i => i.Name.Contains(txtSearch.Text)).ToList();
        }

        private void radioCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCreate.Checked)
            {
                FormLoad();
            }
        }

        private void radioUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdated.Checked)
            {
                UpdatedDate();
            }
        }

        private void radioCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCategory.Checked)
            {
                dtGridFood.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
                {
                    i.Id,
                    i.Name,
                    CategoryName = i.Category.Name,
                    i.Price,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.CategoryId
                }).OrderBy(i => i.CategoryName).ToList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridFood.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridFood.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridFood.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "dosyaadı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {

                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodAdd add = new FoodAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FoodList list = new FoodList();
            this.Hide();
            list.Show();
        }

        private void dtGridFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridFood.CurrentRow;

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
            txtPrice.Text = txtPrice.Text.ToString();
            cmbCategory.SelectedValue = row.Cells["CategoryId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var foodId = (int)txtName.Tag;
            food = _db.Foods.FirstOrDefault(i => i.Id == foodId);

            food.Name = txtName.Text;
            food.Price = Convert.ToDecimal(txtPrice.Text);
            food.CategoryId = (int)cmbCategory.SelectedValue;
            food.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var foodId = (int)dtGridFood.CurrentRow.Cells["Id"].Value;
            food = _db.Foods.FirstOrDefault(i => i.Id == foodId);

            _db.Foods.Remove(food);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}

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
    public partial class DrinkEdit : Form
    {
        ApplicationDbContext _db;
        Drink drink = new Drink();

        public DrinkEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtSearch.Clear();
            txtPrice.Clear();
            txtName.Clear();
            cmbCategory.SelectedValue = "";
        }

        void FormLoad()
        {
            dtGridDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.Price,
                CategoryName = i.Category.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.Price,
                CategoryName = i.Category.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void DrinkEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "İçecek ismi ile arama yapabilirsiniz");

            cmbCategory.DataSource = _db.Categories.Include("Drinks").Include("Foods").OrderBy(i => i.Drinks.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.Price,
                CategoryName = i.Category.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).Where(i=>i.Name.Contains(txtSearch.Text)).ToList();
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
                dtGridDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Select(i => new
                {
                    i.Id,
                    i.Name,
                    i.Price,
                    CategoryName = i.Category.Name,
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

        private void btnList_Click(object sender, EventArgs e)
        {
            DrinkList list = new DrinkList();
            this.Hide();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DrinkAdd add = new DrinkAdd();
            this.Hide();
            add.Show();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridDrink.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridDrink.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridDrink.Rows)
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

        private void dtGridDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridDrink.CurrentRow;

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            cmbCategory.SelectedValue = row.Cells["CategoryId"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var drinkId = (int)txtName.Tag;
            drink = _db.Drinks.FirstOrDefault(i => i.Id == drinkId);

            drink.Name = txtName.Text;
            drink.Price = Convert.ToDecimal(txtPrice.Text);
            drink.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            drink.CategoryId = (int)cmbCategory.SelectedValue;

            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var drinkId = (int)dtGridDrink.CurrentRow.Cells["Id"].Value;
            drink = _db.Drinks.FirstOrDefault(i => i.Id == drinkId);

            _db.Drinks.Remove(drink);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}

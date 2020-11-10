using CafeOtomasyon.Data;
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
    public partial class FoodList : Form
    {
        ApplicationDbContext _db;

        public FoodList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                YiyecekAdı = i.Name,
                KategoriAdı = i.Category.Name,
                Fiyatı = i.Price,
                SiparişSayısı = i.Bills.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                YiyecekAdı = i.Name,
                KategoriAdı = i.Category.Name,
                Fiyatı = i.Price,
                SiparişSayısı = i.Bills.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void FoodList_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Yemek ismi ile arama yapabilirsiniz");
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
            {
                YiyecekAdı = i.Name,
                KategoriAdı = i.Category.Name,
                Fiyatı = i.Price,
                SiparişSayısı = i.Bills.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).Where(i=>i.YiyecekAdı.Contains(txtSearch.Text)).ToList();
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

        private void radioBillCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBillCount.Checked)
            {
                dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
                {
                    YiyecekAdı = i.Name,
                    KategoriAdı = i.Category.Name,
                    Fiyatı = i.Price,
                    SiparişSayısı = i.Bills.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.SiparişSayısı).ToList();
            }
        }

        private void radioCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCategory.Checked)
            {
                dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
                {
                    YiyecekAdı = i.Name,
                    KategoriAdı = i.Category.Name,
                    Fiyatı = i.Price,
                    SiparişSayısı = i.Bills.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.KategoriAdı).ToList();
            }
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioName.Checked)
            {
                dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
                {
                    YiyecekAdı = i.Name,
                    KategoriAdı = i.Category.Name,
                    Fiyatı = i.Price,
                    SiparişSayısı = i.Bills.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.YiyecekAdı).ToList();
            }
        }

        private void radioPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPrice.Checked)
            {
                dtGridFoodList.DataSource = _db.Foods.Include("Category").Include("Bills").Select(i => new
                {
                    YiyecekAdı = i.Name,
                    KategoriAdı = i.Category.Name,
                    Fiyatı = i.Price,
                    SiparişSayısı = i.Bills.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.Fiyatı).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FoodEdit edit = new FoodEdit();
            this.Hide();
            edit.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridFoodList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridFoodList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridFoodList.Rows)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}

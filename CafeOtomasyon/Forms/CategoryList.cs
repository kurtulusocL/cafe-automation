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
    public partial class CategoryList : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
            {
                Adı = i.Name,
                İçecekSayısı = i.Drinks.Count(),
                YiyecekSayısı = i.Foods.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
            {
                Adı = i.Name,
                İçecekSayısı = i.Drinks.Count(),
                YiyecekSayısı = i.Foods.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            FormLoad();
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

        private void radioDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDrinks.Checked)
            {
                dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
                {
                    Adı = i.Name,
                    İçecekSayısı = i.Drinks.Count(),
                    YiyecekSayısı = i.Foods.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.İçecekSayısı).ToList();
            }
        }

        private void radioFoods_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFoods.Checked)
            {
                dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
                {
                    Adı = i.Name,
                    İçecekSayısı = i.Drinks.Count(),
                    YiyecekSayısı = i.Foods.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.YiyecekSayısı).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryEdit edit = new CategoryEdit();
            this.Hide();
            edit.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridCategoryList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridCategoryList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridCategoryList.Rows)
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

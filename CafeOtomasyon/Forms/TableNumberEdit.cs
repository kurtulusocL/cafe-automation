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
    public partial class TableNumberEdit : Form
    {
        ApplicationDbContext _db;
        TableNumber number = new TableNumber();

        public TableNumberEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtNumber.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridTableNumber.DataSource = _db.TableNumbers.Include("Tables").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridTableNumber.DataSource = _db.TableNumbers.Include("Tables").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void TableNumberEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTableNumber.DataSource = _db.TableNumbers.Include("Tables").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i => i.Name.Contains(txtNumber.Text)).ToList();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridTableNumber.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridTableNumber.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridTableNumber.Rows)
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
            TableNumberAdd add = new TableNumberAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            TableNumberList list = new TableNumberList();
            this.Hide();
            list.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableAdd tAdd = new TableAdd();
            this.Hide();
            tAdd.Show();
        }

        private void dtGridTableNumber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridTableNumber.CurrentRow;

            txtNumber.Text = row.Cells["Name"].Value.ToString();
            txtNumber.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var numberId = (int)txtNumber.Tag;
            number = _db.TableNumbers.FirstOrDefault(i => i.Id == numberId);

            number.Name = txtNumber.Text;
            number.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var numberId = (int)dtGridTableNumber.CurrentRow.Cells["Id"].Value;
            number = _db.TableNumbers.FirstOrDefault(i => i.Id == numberId);

            _db.TableNumbers.Remove(number);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}

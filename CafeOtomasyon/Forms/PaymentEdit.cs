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
    public partial class PaymentEdit : Form
    {
        ApplicationDbContext _db;
        Payment pyment = new Payment();

        public PaymentEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridPayment.DataSource = _db.Payments.Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridPayment.DataSource = _db.Payments.Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void PaymentEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridPayment.DataSource = _db.Payments.Include("Bills").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.Name.Contains(txtName.Text)).ToList();
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

        private void btnList_Click(object sender, EventArgs e)
        {
            PaymentList list = new PaymentList();
            this.Hide();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PaymentAdd add = new PaymentAdd();
            this.Hide();
            add.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridPayment.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridPayment.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridPayment.Rows)
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

        private void dtGridPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridPayment.CurrentRow;

            txtName.Text = row.Cells["Name"].Value.ToString();
            txtName.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var pymentId = (int)txtName.Tag;
            pyment = _db.Payments.FirstOrDefault(i => i.Id == pymentId);

            pyment.Name = txtName.Text;
            pyment.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var pymentId = (int)dtGridPayment.CurrentRow.Cells["Id"].Value;
            pyment = _db.Payments.FirstOrDefault(i => i.Id == pymentId);

            _db.Payments.Remove(pyment);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}

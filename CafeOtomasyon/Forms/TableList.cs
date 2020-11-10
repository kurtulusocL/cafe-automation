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
    public partial class TableList : Form
    {
        ApplicationDbContext _db;

        public TableList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                MüşteriGeliş = i.CustomerArriving,
                MüşteriAyrılma = i.CustomerLeaving,
                YiyecekAdı = i.Food.Name,
                İçecekAdı = i.Drink.Name,
                MasaNo = i.TableNumber.Name,
                MasaUygunMu = i.IsEmpty,
                ÖdemeYapıldıMı = i.IsPaid,
                RezervasyonMu = i.IsRezervation,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                MüşteriGeliş = i.CustomerArriving,
                MüşteriAyrılma = i.CustomerLeaving,
                YiyecekAdı = i.Food.Name,
                İçecekAdı = i.Drink.Name,
                MasaNo = i.TableNumber.Name,
                MasaUygunMu = i.IsEmpty,
                ÖdemeYapıldıMı = i.IsPaid,
                RezervasyonMu = i.IsRezervation,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void boşMasaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableEmpty empty = new TableEmpty();
            this.Hide();
            empty.Show();
        }

        private void doluMasaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableFull full = new TableFull();
            this.Hide();
            full.Show();
        }

        private void masaDüzenlemeSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableCustomerRegisterEdit registerEdit = new TableCustomerRegisterEdit();
            this.Hide();
            registerEdit.Show();
        }

        private void TableList_Load(object sender, EventArgs e)
        {
            FormLoad();
            toolTip1.SetToolTip(txtSearch, "Masa numarası ile arama yapabilirsiniz");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                MüşteriGeliş = i.CustomerArriving,
                MüşteriAyrılma = i.CustomerLeaving,
                YiyecekAdı = i.Food.Name,
                İçecekAdı = i.Drink.Name,
                MasaNo = i.TableNumber.Name,
                MasaUygunMu = i.IsEmpty,
                ÖdemeYapıldıMı = i.IsPaid,
                RezervasyonMu = i.IsRezervation,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).Where(i=>i.MasaNo.Contains(txtSearch.Text)).ToList();
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

        private void radioTableNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTableNo.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.MasaNo).ToList();
            }
        }

        private void radioStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStatus.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i=>i.MasaUygunMu==true).OrderByDescending(i => i.MüşteriGeliş).ToList();
            }
        }

        private void radioPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPaid.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.ÖdemeYapıldıMı == true).OrderByDescending(i => i.MüşteriAyrılma.Value.ToString()).ToList();
            }
        }

        private void radioRezerve_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRezerve.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).Where(i => i.RezervasyonMu == true).OrderByDescending(i => i.MüşteriGeliş).ToList();
            }
        }

        private void radioDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDrink.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.İçecekAdı).ToList();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    MüşteriGeliş = i.CustomerArriving,
                    MüşteriAyrılma = i.CustomerLeaving,
                    YiyecekAdı = i.Food.Name,
                    İçecekAdı = i.Drink.Name,
                    MasaNo = i.TableNumber.Name,
                    MasaUygunMu = i.IsEmpty,
                    ÖdemeYapıldıMı = i.IsPaid,
                    RezervasyonMu = i.IsRezervation,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.YiyecekAdı).ToList();
            }
        }

        private void btnEmptyTable_Click(object sender, EventArgs e)
        {
            TableEmpty empty = new TableEmpty();
            this.Hide();
            empty.Show();
        }

        private void btnFullTable_Click(object sender, EventArgs e)
        {
            TableFull full = new TableFull();
            this.Hide();
            full.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TableCustomerRegisterEdit registerEdit = new TableCustomerRegisterEdit();
            this.Hide();
            registerEdit.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridTable.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridTable.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridTable.Rows)
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

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
    public partial class BillList : Form
    {
        ApplicationDbContext _db;

        public BillList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                FaturaNo = i.BillNo,
                MüşteriAdSoyad = i.CustomerNameSurname,
                YiyecekAdı = i.Food.Name,
                YiecekSayısı = i.FoodPiece,
                YiyecekÜcreti = i.FoodPrice,
                İçecekAdı = i.Drink.Name,
                İçecekSayısı = i.DrinkPiece,
                İçecekÜcreti = i.DrinkPrice,
                ToplamFiyat = i.TotalPrice,
                ÖdenmeDurumu = i.Table.IsPaid,
                İşlemiYapan = i.Employee.NameSurname,
                ÖdenmeŞekli = i.Payment.Name,
                MasaNumarası = i.Table.TableNumber.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                FaturaNo = i.BillNo,
                MüşteriAdSoyad = i.CustomerNameSurname,
                YiyecekAdı = i.Food.Name,
                YiecekSayısı = i.FoodPiece,
                YiyecekÜcreti = i.FoodPrice,
                İçecekAdı = i.Drink.Name,
                İçecekSayısı = i.DrinkPiece,
                İçecekÜcreti = i.DrinkPrice,
                ToplamFiyat = i.TotalPrice,
                ÖdenmeDurumu = i.Table.IsPaid,
                İşlemiYapan = i.Employee.NameSurname,
                ÖdenmeŞekli = i.Payment.Name,
                MasaNumarası = i.Table.TableNumber.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                FaturaNo = i.BillNo,
                MüşteriAdSoyad = i.CustomerNameSurname,
                YiyecekAdı = i.Food.Name,
                YiecekSayısı = i.FoodPiece,
                YiyecekÜcreti = i.FoodPrice,
                İçecekAdı = i.Drink.Name,
                İçecekSayısı = i.DrinkPiece,
                İçecekÜcreti = i.DrinkPrice,
                ToplamFiyat = i.TotalPrice,
                ÖdenmeDurumu = i.Table.IsPaid,
                İşlemiYapan = i.Employee.NameSurname,
                ÖdenmeŞekli = i.Payment.Name,
                MasaNumarası = i.Table.TableNumber.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i => i.MasaNumarası.Contains(txtSearch.Text)).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                FaturaNo = i.BillNo,
                MüşteriAdSoyad = i.CustomerNameSurname,
                YiyecekAdı = i.Food.Name,
                YiecekSayısı = i.FoodPiece,
                YiyecekÜcreti = i.FoodPrice,
                İçecekAdı = i.Drink.Name,
                İçecekSayısı = i.DrinkPiece,
                İçecekÜcreti = i.DrinkPrice,
                ToplamFiyat = i.TotalPrice,
                ÖdenmeDurumu = i.Table.IsPaid,
                İşlemiYapan = i.Employee.NameSurname,
                ÖdenmeŞekli = i.Payment.Name,
                MasaNumarası = i.Table.TableNumber.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i => i.FaturaNo.Contains(textBox1.Text)).ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                FaturaNo = i.BillNo,
                MüşteriAdSoyad = i.CustomerNameSurname,
                YiyecekAdı = i.Food.Name,
                YiecekSayısı = i.FoodPiece,
                YiyecekÜcreti = i.FoodPrice,
                İçecekAdı = i.Drink.Name,
                İçecekSayısı = i.DrinkPiece,
                İçecekÜcreti = i.DrinkPrice,
                ToplamFiyat = i.TotalPrice,
                ÖdenmeDurumu = i.Table.IsPaid,
                İşlemiYapan = i.Employee.NameSurname,
                ÖdenmeŞekli = i.Payment.Name,
                MasaNumarası = i.Table.TableNumber.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i => i.MüşteriAdSoyad.Contains(textBox2.Text)).ToList();
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

        private void radioPayStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPayStatus.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).Where(i => i.ÖdenmeDurumu == true).OrderByDescending(i => i.KayıtTarihi).ToList();
            }
        }

        private void radioPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPayment.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.ÖdenmeŞekli).ToList();
            }
        }

        private void radioCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCustomer.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.MüşteriAdSoyad).ToList();
            }
        }

        private void radioBillNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBillNumber.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.FaturaNo).ToList();
            }
        }

        private void radioTableNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTableNo.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.MasaNumarası).ToList();
            }
        }

        private void radioTotalPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTotalPrice.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.ToplamFiyat).ToList();
            }
        }

        private void radioDrinkPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDrinkPrice.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.İçecekÜcreti).ToList();
            }
        }

        private void radioFoodPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFoodPrice.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.YiyecekÜcreti).ToList();
            }
        }

        private void radioEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEmployee.Checked)
            {
                dtGridBillList.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    FaturaNo = i.BillNo,
                    MüşteriAdSoyad = i.CustomerNameSurname,
                    YiyecekAdı = i.Food.Name,
                    YiecekSayısı = i.FoodPiece,
                    YiyecekÜcreti = i.FoodPrice,
                    İçecekAdı = i.Drink.Name,
                    İçecekSayısı = i.DrinkPiece,
                    İçecekÜcreti = i.DrinkPrice,
                    ToplamFiyat = i.TotalPrice,
                    ÖdenmeDurumu = i.Table.IsPaid,
                    İşlemiYapan = i.Employee.NameSurname,
                    ÖdenmeŞekli = i.Payment.Name,
                    MasaNumarası = i.Table.TableNumber.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.İşlemiYapan).ToList();
            }
        }

        private void btnPaidList_Click(object sender, EventArgs e)
        {
            BillPaid paid = new BillPaid();
            this.Hide();
            paid.Show();
        }

        private void bynWillPayList_Click(object sender, EventArgs e)
        {
            BillWillPay willPay = new BillWillPay();
            this.Hide();
            willPay.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BillEdit edit = new BillEdit();
            this.Hide();
            edit.Show();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridBillList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridBillList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridBillList.Rows)
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

        private void BillList_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}

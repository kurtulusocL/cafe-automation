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
    public partial class BillEdit : Form
    {
        ApplicationDbContext _db;
        Bill bill = new Bill();
        Table table = new Table();

        public BillEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtNameSurname.Clear();
            txtBillNo.Clear();
            numDrinkPiece.ResetText();
            numFoodPiece.ResetText();
            cmbDrink.SelectedValue = "";
            cmbDribkPrice.SelectedValue = "";
            cmbEmployee.SelectedValue = "";
            cmbFood.SelectedValue = "";
            cmbFoodPrice.SelectedValue = "";
            cmbPayment.SelectedValue = "";
            cmbTable.SelectedValue = "";
            lblDrinkPiece.ResetText();
            lblDrinkPrice.ResetText();
            lblFoodPiece.ResetText();
            lblFoodPrice.ResetText();
            btnTotalPrice.Text = "Toplam Fiyatı Görmek İçin Tıklayınız";
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                i.Id,
                i.BillNo,
                i.CustomerNameSurname,
                i.FoodPiece,
                i.FoodPrice,
                i.DrinkPiece,
                i.DrinkPrice,
                i.TotalPrice,
                i.Table.IsPaid,
                i.Employee.NameSurname,
                i.Drink.Name,
                FoodName = i.Food.Name,
                PaymentStyle = i.Payment.Name,
                TableNo= i.Table.TableNumber.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.PaymentId,
                i.DrinkId,
                i.FoodId,
                i.TableId,
                i.EmployeeId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                i.Id,
                i.BillNo,
                i.CustomerNameSurname,
                i.FoodPiece,
                i.FoodPrice,
                i.DrinkPiece,
                i.DrinkPrice,
                i.TotalPrice,
                i.Table.IsPaid,
                i.Employee.NameSurname,
                i.Drink.Name,
                FoodName = i.Food.Name,
                PaymentStyle = i.Payment.Name,
                TableNo = i.Table.TableNumber.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.PaymentId,
                i.DrinkId,
                i.FoodId,
                i.TableId,
                i.EmployeeId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToShortDateString()).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
            {
                i.Id,
                i.BillNo,
                i.CustomerNameSurname,
                i.FoodPiece,
                i.FoodPrice,
                i.DrinkPiece,
                i.DrinkPrice,
                i.TotalPrice,
                i.Table.IsPaid,
                i.Employee.NameSurname,
                i.Drink.Name,
                FoodName = i.Food.Name,
                PaymentStyle = i.Payment.Name,
                TableNo = i.Table.TableNumber.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.PaymentId,
                i.DrinkId,
                i.FoodId,
                i.TableId,
                i.EmployeeId
            }).Where(i => i.CustomerNameSurname.Contains(txtSearch.Text)).ToList();
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
                dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    i.Id,
                    i.BillNo,
                    i.CustomerNameSurname,
                    i.FoodPiece,
                    i.FoodPrice,
                    i.DrinkPiece,
                    i.DrinkPrice,
                    i.TotalPrice,
                    i.Table.IsPaid,
                    i.Employee.NameSurname,
                    i.Drink.Name,
                    FoodName = i.Food.Name,
                    PaymentStyle = i.Payment.Name,
                    TableNo = i.Table.TableNumber.Name,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.PaymentId,
                    i.DrinkId,
                    i.FoodId,
                    i.TableId,
                    i.EmployeeId
                }).Where(i => i.IsPaid == true).OrderByDescending(i => i.CreatedDate).ToList();
            }
        }

        private void radioTotalPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTotalPrice.Checked)
            {
                dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    i.Id,
                    i.BillNo,
                    i.CustomerNameSurname,
                    i.FoodPiece,
                    i.FoodPrice,
                    i.DrinkPiece,
                    i.DrinkPrice,
                    i.TotalPrice,
                    i.Table.IsPaid,
                    i.Employee.NameSurname,
                    i.Drink.Name,
                    FoodName = i.Food.Name,
                    PaymentStyle = i.Payment.Name,
                    TableNo = i.Table.TableNumber.Name,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.PaymentId,
                    i.DrinkId,
                    i.FoodId,
                    i.TableId,
                    i.EmployeeId
                }).OrderBy(i => i.TotalPrice).ToList();
            }
        }

        private void radioPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPayment.Checked)
            {
                dtGridBill.DataSource = _db.Bills.Include("Food").Include("Drink").Include("Table").Include("Employee").Include("Payment").Select(i => new
                {
                    i.Id,
                    i.BillNo,
                    i.CustomerNameSurname,
                    i.FoodPiece,
                    i.FoodPrice,
                    i.DrinkPiece,
                    i.DrinkPrice,
                    i.TotalPrice,
                    i.Table.IsPaid,
                    i.Employee.NameSurname,
                    i.Drink.Name,
                    FoodName = i.Food.Name,
                    PaymentStyle = i.Payment.Name,
                    TableNo = i.Table.TableNumber.Name,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.PaymentId,
                    i.DrinkId,
                    i.FoodId,
                    i.TableId,
                    i.EmployeeId
                }).OrderBy(i => i.PaymentStyle).ToList();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridBill.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridBill.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridBill.Rows)
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

        private void bynWillPayList_Click(object sender, EventArgs e)
        {
            BillWillPay willPay = new BillWillPay();
            this.Hide();
            willPay.Show();
        }

        private void btnPaidList_Click(object sender, EventArgs e)
        {
            BillPaid paid = new BillPaid();
            this.Hide();
            paid.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BillAdd add = new BillAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            BillList list = new BillList();
            this.Hide();
            list.Show();
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            bill.TotalPrice = ((Convert.ToInt32(lblDrinkPiece.Text) * Convert.ToDecimal(lblDrinkPrice.Text)) + ((Convert.ToInt32(lblFoodPiece.Text) * Convert.ToDecimal(lblFoodPrice.Text))));
            btnTotalPrice.Text = bill.TotalPrice.ToString();
        }

        private void numFoodPiece_ValueChanged(object sender, EventArgs e)
        {
            lblFoodPiece.Text = Convert.ToInt32(numFoodPiece.Value).ToString();
            lblFoodPiece.ForeColor = Color.Green;
        }

        private void cmbFoodPrice_TextChanged(object sender, EventArgs e)
        {
            lblFoodPrice.Text = cmbFoodPrice.Text;
            lblFoodPrice.ForeColor = Color.Green;
        }

        private void numDrinkPiece_ValueChanged(object sender, EventArgs e)
        {
            lblDrinkPiece.Text = Convert.ToInt32(numDrinkPiece.Value).ToString();
            lblDrinkPiece.ForeColor = Color.Green;
        }

        private void cmbDribkPrice_TextChanged(object sender, EventArgs e)
        {
            lblDrinkPrice.Text = cmbDribkPrice.Text;
            lblDrinkPrice.ForeColor = Color.Green;
        }

        private void dtGridBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridBill.CurrentRow;
            txtBillNo.Text = row.Cells["BillNo"].Value.ToString();
            txtBillNo.Tag = row.Cells["Id"].Value;
            txtNameSurname.Text = row.Cells["CustomerNameSurname"].Value.ToString();
            numDrinkPiece.Value = Convert.ToInt32(row.Cells["DrinkPiece"].Value);
            numFoodPiece.Value = Convert.ToInt32(row.Cells["FoodPiece"].Value);

            cmbDribkPrice.SelectedValue = Convert.ToDecimal(row.Cells["DrinkId"].Value);
            cmbFoodPrice.SelectedValue= Convert.ToDecimal(row.Cells["FoodId"].Value);
            cmbDrink.SelectedValue = row.Cells["DrinkId"].Value;
            cmbFood.SelectedValue = row.Cells["FoodId"].Value;
            cmbEmployee.SelectedValue = row.Cells["EmployeeId"].Value;
            cmbPayment.SelectedValue = row.Cells["PaymentId"].Value;
            cmbTable.SelectedValue = row.Cells["TableId"].Value;
            if (table.IsPaid = checkPaidYes.Checked)
            {
                checkPaidYes.Checked = Convert.ToBoolean(row.Cells["IsPaid"].Value.ToString());
            }
            else
            {
                checkPaidNo.Checked = Convert.ToBoolean(row.Cells["IsPaid"].Value.ToString());
            }
            btnTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var billId = (int)txtBillNo.Tag;
            bill = _db.Bills.FirstOrDefault(i => i.Id == billId);

            bill.BillNo = txtBillNo.Text;
            bill.CustomerNameSurname = txtNameSurname.Text;
            bill.DrinkPiece = Convert.ToInt32(numDrinkPiece.Value);
            bill.FoodPiece = Convert.ToInt32(numFoodPiece.Value);
            bill.DrinkId = (int)cmbDrink.SelectedValue;
            bill.FoodId = (int)cmbFood.SelectedValue;
            bill.DrinkId = (int)cmbDribkPrice.SelectedValue;
            bill.FoodId = (int)cmbFoodPrice.SelectedValue;
            bill.EmployeeId = (int)cmbEmployee.SelectedValue;
            bill.TableId = (int)cmbTable.SelectedValue;
            bill.TotalPrice = Convert.ToDecimal(btnTotalPrice.Text);
            bill.PaymentId = (int)cmbPayment.SelectedValue;
            if (table.IsPaid = checkPaidYes.Checked)
            {
                checkPaidYes.Text = table.IsPaid.ToString();
            }
            else
            {
                checkPaidNo.Text = table.IsPaid.ToString();
            }

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var billId = (int)dtGridBill.CurrentRow.Cells["Id"].Value;
            bill = _db.Bills.FirstOrDefault(i => i.Id == billId);

            _db.Bills.Remove(bill);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void BillEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Müşteri Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();

            cmbDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbDrink.ValueMember = "Id";
            cmbDrink.DisplayMember = "Name";

            cmbDribkPrice.DataSource = _db.Drinks.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbDribkPrice.ValueMember = "Id";
            cmbDribkPrice.DisplayMember = "Price";

            cmbFood.DataSource = _db.Foods.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbFood.ValueMember = "Id";
            cmbFood.DisplayMember = "Name";

            cmbFoodPrice.DataSource = _db.Foods.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).Where(i => i.Id > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbFoodPrice.ValueMember = "Id";
            cmbFoodPrice.DisplayMember = "Price";

            cmbEmployee.DataSource = _db.Employees.Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "NameSurname";

            cmbPayment.DataSource = _db.Payments.Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbPayment.ValueMember = "Id";
            cmbPayment.DisplayMember = "Name";

            cmbTable.DataSource = _db.TableNumbers.Include("Tables").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Tables.Count()).ToList();
            cmbTable.ValueMember = "Id";
            cmbTable.DisplayMember = "Name";
        }
    }
}

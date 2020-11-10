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
    public partial class TableCustomerRegisterEdit : Form
    {
        ApplicationDbContext _db;
        Table table = new Table();

        public TableCustomerRegisterEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            dtPicArriving.ResetText();
            dtPicLeaving.ResetText();
            cmbDrink.SelectedValue = "";
            cmbFood.SelectedValue = "";
            cmbTableNo.SelectedValue = "";
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                i.Id,
                i.CustomerArriving,
                i.CustomerLeaving,
                FoodName = i.Food.Name,
                DrinkName = i.Drink.Name,
                TableNo = i.TableNumber.Name,
                i.IsEmpty,
                i.IsPaid,
                i.IsRezervation,
                i.CreatedDate,
                i.UpdatedDate,
                i.FoodId,
                i.DrinkId,
                i.TableNumberId
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                i.Id,
                i.CustomerArriving,
                i.CustomerLeaving,
                FoodName = i.Food.Name,
                DrinkName = i.Drink.Name,
                TableNo = i.TableNumber.Name,
                i.IsEmpty,
                i.IsPaid,
                i.IsRezervation,
                i.CreatedDate,
                i.UpdatedDate,
                i.FoodId,
                i.DrinkId,
                i.TableNumberId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void masaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableList list = new TableList();
            this.Hide();
            list.Show();
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

        private void TableCustomerRegisterEdit_Load(object sender, EventArgs e)
        {
            cmbDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbDrink.ValueMember = "Id";
            cmbDrink.DisplayMember = "Name";

            cmbFood.DataSource = _db.Foods.Include("Category").Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbFood.ValueMember = "Id";
            cmbFood.DisplayMember = "Name";

            cmbTableNo.DataSource = _db.TableNumbers.Include("Tables").OrderBy(i => i.Tables.Count()).ToList();
            cmbTableNo.ValueMember = "Id";
            cmbTableNo.DisplayMember = "Name";

            FormLoad();

            toolTip1.SetToolTip(txtSearch, "Masa numarası ile arama yapabilirsiniz");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
            {
                i.Id,
                i.CustomerArriving,
                i.CustomerLeaving,
                FoodName = i.Food.Name,
                DrinkName = i.Drink.Name,
                TableNo = i.TableNumber.Name,
                i.IsEmpty,
                i.IsPaid,
                i.IsRezervation,
                i.CreatedDate,
                i.UpdatedDate,
                i.FoodId,
                i.DrinkId,
                i.TableNumberId
            }).Where(i => i.TableNo.Contains(txtSearch.Text)).ToList();
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
                    i.Id,
                    i.CustomerArriving,
                    i.CustomerLeaving,
                    FoodName = i.Food.Name,
                    DrinkName = i.Drink.Name,
                    TableNo = i.TableNumber.Name,
                    i.IsEmpty,
                    i.IsPaid,
                    i.IsRezervation,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.FoodId,
                    i.DrinkId,
                    i.TableNumberId
                }).OrderBy(i => i.TableNo).ToList();
            }
        }

        private void radioStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStatus.Checked)
            {
                dtGridTable.DataSource = _db.Tables.Include("Drink").Include("Food").Include("TableNumber").Include("Bills").Select(i => new
                {
                    i.Id,
                    i.CustomerArriving,
                    i.CustomerLeaving,
                    FoodName = i.Food.Name,
                    DrinkName = i.Drink.Name,
                    TableNo = i.TableNumber.Name,
                    i.IsEmpty,
                    i.IsPaid,
                    i.IsRezervation,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.FoodId,
                    i.DrinkId,
                    i.TableNumberId
                }).Where(i => i.IsEmpty == true).OrderByDescending(i => i.CreatedDate).ToList();
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

        private void btnFullTable_Click(object sender, EventArgs e)
        {
            TableFull full = new TableFull();
            this.Hide();
            full.Show();
        }

        private void btnEmptyTable_Click(object sender, EventArgs e)
        {
            TableEmpty empty = new TableEmpty();
            this.Hide();
            empty.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            TableList list = new TableList();
            this.Hide();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TableCustomerRegister register = new TableCustomerRegister();
            this.Hide();
            register.Show();
        }

        private void dtGridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridTable.CurrentRow;

            cmbTableNo.SelectedValue = row.Cells["TableNumberId"].Value;
            cmbTableNo.Tag = row.Cells["Id"].Value;
            cmbFood.SelectedValue = row.Cells["FoodId"].Value;
            cmbDrink.SelectedValue = row.Cells["DrinkId"].Value;
            dtPicArriving.Value = Convert.ToDateTime(row.Cells["CustomerArriving"].Value.ToString());
            dtPicLeaving.Value = Convert.ToDateTime(row.Cells["CustomerLeaving"].Value.ToString());
            if (table.IsPaid = checkPaidYes.Checked)
            {
                checkPaidYes.Checked = Convert.ToBoolean(row.Cells["IsPaid"].Value.ToString());
            }
            else
            {
                checkPaidNo.Checked = Convert.ToBoolean(row.Cells["IsPaid"].Value.ToString());
            }
            if (table.IsRezervation = checkRezervYes.Checked)
            {
                checkRezervYes.Checked = Convert.ToBoolean(row.Cells["IsRezervation"].Value.ToString());
            }
            else
            {
                checkRezervNo.Checked = Convert.ToBoolean(row.Cells["IsRezervation"].Value.ToString());
            }
            if (table.IsEmpty = checkTableOk.Checked)
            {
                checkTableOk.Checked = Convert.ToBoolean(row.Cells["IsEmpty"].Value.ToString());
            }
            else
            {
                checkTableNo.Checked = Convert.ToBoolean(row.Cells["IsEmpty"].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var tableId = (int)cmbTableNo.Tag;
            table = _db.Tables.FirstOrDefault(i => i.Id == tableId);

            table.CustomerArriving = Convert.ToDateTime(dtPicArriving.Value.ToLongDateString());
            table.CustomerLeaving = Convert.ToDateTime(dtPicLeaving.Value.ToLongDateString());
            table.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            table.DrinkId = (int)cmbDrink.SelectedValue;
            table.FoodId = (int)cmbFood.SelectedValue;
            table.TableNumberId = (int)cmbTableNo.SelectedValue;
            if (table.IsPaid = checkPaidYes.Checked)
            {
                checkPaidYes.Text = table.IsPaid.ToString();
            }
            else
            {
                checkPaidNo.Text = table.IsPaid.ToString();
            }
            if (table.IsRezervation = checkRezervYes.Checked)
            {
                checkRezervYes.Text = table.IsRezervation.ToString();
            }
            else
            {
                checkRezervNo.Text = table.IsRezervation.ToString();
            }
            if (table.IsEmpty = checkTableOk.Checked)
            {
                checkTableOk.Text = table.IsEmpty.ToString();
            }
            else
            {
                checkTableNo.Text = table.IsEmpty.ToString();
            }

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var tableId = (int)dtGridTable.CurrentRow.Cells["Id"].Value;
            table = _db.Tables.FirstOrDefault(i => i.Id == tableId);

            _db.Tables.Remove(table);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}

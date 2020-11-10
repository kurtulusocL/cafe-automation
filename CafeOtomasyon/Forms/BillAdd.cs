using CafeOtomasyon.Data;
using CafeOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Forms
{
    public partial class BillAdd : Form
    {
        ApplicationDbContext _db;
        Bill bill = new Bill();
        Table table = new Table();

        public BillAdd()
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
            cmbDrinkPrice.SelectedValue = "";
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
        }

        private void btmEdit_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bill.BillNo = txtBillNo.Text;
            bill.CustomerNameSurname = txtNameSurname.Text;
            bill.DrinkPiece = Convert.ToInt32(numDrinkPiece.Value);
            bill.FoodPiece = Convert.ToInt32(numFoodPiece.Value);
            bill.DrinkId = (int)cmbDrink.SelectedValue;
            bill.FoodId = (int)cmbFood.SelectedValue;
            bill.DrinkId = (int)cmbDrinkPrice.SelectedValue;
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

            _db.Bills.Add(bill);
            _db.SaveChanges();
            Clear();
        }

        private void numFoodPiece_ValueChanged(object sender, EventArgs e)
        {
            lblFoodPiece.Text = Convert.ToInt32(numFoodPiece.Value).ToString();
            lblFoodPiece.ForeColor = Color.Green;
        }

        private void numDrinkPiece_ValueChanged(object sender, EventArgs e)
        {
            lblDrinkPiece.Text = Convert.ToInt32(numDrinkPiece.Value).ToString();
            lblDrinkPiece.ForeColor = Color.Green;
        }

        private void BillAdd_Load(object sender, EventArgs e)
        {
            cmbDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbDrink.ValueMember = "Id";
            cmbDrink.DisplayMember = "Name";

            cmbDrinkPrice.DataSource = _db.Drinks.Include("Category").Include("Bills").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Bills.Count()).ToList();
            cmbDrinkPrice.ValueMember = "Id";
            cmbDrinkPrice.DisplayMember = "Price";

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

        private void cmbFoodPrice_TextChanged(object sender, EventArgs e)
        {
            lblFoodPrice.Text = cmbFoodPrice.Text;
            lblFoodPrice.ForeColor = Color.Green;
        }

        private void cmbDrinkPrice_TextChanged(object sender, EventArgs e)
        {
            lblDrinkPrice.Text = cmbDrinkPrice.Text;
            lblDrinkPrice.ForeColor = Color.Green;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            bill.TotalPrice = ((Convert.ToInt32(lblDrinkPiece.Text) * Convert.ToDecimal(lblDrinkPrice.Text)) + ((Convert.ToInt32(lblFoodPiece.Text) * Convert.ToDecimal(lblFoodPrice.Text))));
            btnTotalPrice.Text = bill.TotalPrice.ToString();
        }
    }
}

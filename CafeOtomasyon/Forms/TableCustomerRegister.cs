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
    public partial class TableCustomerRegister : Form
    {
        ApplicationDbContext _db;
        Table table = new Table();

        public TableCustomerRegister()
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
        }

        private void TableCustomerRegister_Load(object sender, EventArgs e)
        {
            cmbDrink.DataSource = _db.Drinks.Include("Category").Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbDrink.ValueMember = "Id";
            cmbDrink.DisplayMember = "Name";

            cmbFood.DataSource = _db.Foods.Include("Category").Include("Bills").OrderBy(i => i.Bills.Count()).ToList();
            cmbFood.ValueMember = "Id";
            cmbFood.DisplayMember = "Name";

            cmbTableNo.DataSource = _db.TableNumbers.Include("Tables").Where(i => i.Tables.Count() > 0).OrderBy(i => i.Tables.Count()).ToList();
            cmbTableNo.ValueMember = "Id";
            cmbTableNo.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.CustomerArriving = Convert.ToDateTime(dtPicArriving.Value.ToLongDateString());
            table.CustomerLeaving = Convert.ToDateTime(dtPicLeaving.Value.ToLongDateString());
            table.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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

            _db.Tables.Add(table);
            _db.SaveChanges();
            Clear();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            TableCustomerRegisterEdit edit = new TableCustomerRegisterEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }
    }
}

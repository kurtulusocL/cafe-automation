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
    public partial class DrinkAdd : Form
    {
        ApplicationDbContext _db;
        Drink drink = new Drink();

        public DrinkAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtPrice.Clear();
            txtName.Clear();
            cmbCategory.SelectedValue = "";
        }

        private void DrinkAdd_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _db.Categories.Include("Drinks").Include("Foods").OrderBy(i => i.Drinks.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            drink.Name = txtName.Text;
            drink.Price = Convert.ToDecimal(txtPrice.Text);
            drink.CategoryId = (int)cmbCategory.SelectedValue;
            drink.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Drinks.Add(drink);
            _db.SaveChanges();
            Clear();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            DrinkEdit edit = new DrinkEdit();
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

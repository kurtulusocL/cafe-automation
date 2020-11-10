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
    public partial class FoodAdd : Form
    {
        ApplicationDbContext _db;
        Food food = new Food();

        public FoodAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedValue = "";
        }

        private void FoodAdd_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _db.Categories.Include("Drinks").Include("Foods").OrderBy(i => i.Drinks.Count()).ToList();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            food.Name = txtName.Text;
            food.Price = Convert.ToDecimal(txtPrice.Text);
            food.CategoryId = (int)cmbCategory.SelectedValue;
            food.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Foods.Add(food);
            _db.SaveChanges();
            Clear();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            FoodEdit edit = new FoodEdit();
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

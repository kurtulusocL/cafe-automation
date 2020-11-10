using CafeOtomasyon.Data;
using CafeOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Forms
{
    public partial class CategoryEdit : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtCategory.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void CategoryEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCategoryList.DataSource = _db.Categories.Include("Foods").Include("Drinks").Select(i => new
            {
                i.Id,
                i.Name,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i => i.Name.Contains(txtSearch.Text)).ToList();
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
            CategoryList list = new CategoryList();
            this.Hide();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd add = new CategoryAdd();
            this.Hide();
            add.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void dtGridCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridCategoryList.CurrentRow;

            txtCategory.Text = row.Cells["Name"].Value.ToString();
            txtCategory.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cateId = (int)txtCategory.Tag;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            cate.Name = txtCategory.Text;
            cate.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            UpdatedDate();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cateId = (int)dtGridCategoryList.CurrentRow.Cells["Id"].Value;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            _db.Categories.Remove(cate);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }
    }
}

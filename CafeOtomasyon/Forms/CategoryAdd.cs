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
    public partial class CategoryAdd : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cate.Name = txtCategory.Text;
            cate.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Categories.Add(cate);
            _db.SaveChanges();
            txtCategory.Clear();
        }
    }
}

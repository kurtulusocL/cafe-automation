using CafeOtomasyon.Data;
using CafeOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.Forms
{
    public partial class EmployeeAdd : Form
    {
        ApplicationDbContext _db;
        Employee emp = new Employee();

        public EmployeeAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }
        
        void Clear()
        {
            txtNameSurname.Clear();
            picPhoto.ResetText();
            txtPhoto.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picPhoto.ImageLocation = openFileDialog1.FileName;
            txtPhoto.Text = openFileDialog1.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            emp.NameSurname = txtNameSurname.Text;
            emp.Photo = txtPhoto.Text;
            emp.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Employees.Add(emp);
            _db.SaveChanges();
            Clear();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            EmployeeEdit edit = new EmployeeEdit();
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

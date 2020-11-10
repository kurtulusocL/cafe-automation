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
    public partial class EmployeeEdit : Form
    {
        ApplicationDbContext _db;
        Employee emp = new Employee();

        public EmployeeEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtNameSurname.Clear();
            picPhoto.ResetText();
            txtPhoto.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Bills").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Bills").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridEmployee.DataSource = _db.Employees.Include("Bills").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.Photo,
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.NameSurname.Contains(txtSearch.Text)).ToList();
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
            EmployeeList list = new EmployeeList();
            this.Hide();
            list.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            this.Hide();
            add.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void dtGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridEmployee.CurrentRow;

            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag = row.Cells["Id"].Value;
            picPhoto.ImageLocation = row.Cells["Photo"].Value.ToString();
            txtPhoto.Text = row.Cells["Photo"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var empId = (int)txtNameSurname.Tag;
            emp = _db.Employees.FirstOrDefault(i => i.Id == empId);

            emp.NameSurname = txtNameSurname.Text;
            emp.Photo = txtPhoto.Text;
            emp.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var empId = (int)dtGridEmployee.CurrentRow.Cells["Id"].Value;
            emp = _db.Employees.FirstOrDefault(i => i.Id == empId);

            _db.Employees.Remove(emp);
            _db.SaveChanges();
            FormLoad();
            Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picPhoto.ImageLocation = openFileDialog1.FileName;
            txtPhoto.Text = openFileDialog1.FileName;
        }
    }
}

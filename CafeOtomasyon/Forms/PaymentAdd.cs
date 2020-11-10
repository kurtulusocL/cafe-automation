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
    public partial class PaymentAdd : Form
    {
        ApplicationDbContext _db;
        Payment pyment = new Payment();

        public PaymentAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pyment.Name = txtName.Text;
            pyment.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Payments.Add(pyment);
            _db.SaveChanges();
            txtName.Clear();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            PaymentEdit edit = new PaymentEdit();
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

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
    public partial class TableNumberAdd : Form
    {
        ApplicationDbContext _db;
        TableNumber number = new TableNumber();

        public TableNumberAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }
        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            number.Name = txtNumber.Text;
            number.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.TableNumbers.Add(number);
            _db.SaveChanges();
            txtNumber.Clear();
        }
    }
}

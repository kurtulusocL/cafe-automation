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
    public partial class TableAdd : Form
    {
        ApplicationDbContext _db;

        TableCustomerRegister register = new TableCustomerRegister();
        TableNumber number = new TableNumber();

        public TableAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void TableAdd_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _db.TableNumbers.Count(); i++)
            {
                Button btn = new Button();

                btn.BackColor = Color.Aqua;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Microsoft Sans Serif", 8.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                btn.Width = 80;
                btn.Height = 85;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Text = i.ToString() + " " + "Numaralı Masa";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(this.TableCustomerRegister_Load);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void TableCustomerRegister_Load(object sender, EventArgs e)
        {
            register.Show();
            this.Hide();
        }
    }
}

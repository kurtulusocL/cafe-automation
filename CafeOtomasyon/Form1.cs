using CafeOtomasyon.Data;
using CafeOtomasyon.Forms;
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

namespace CafeOtomasyon
{
    public partial class Form1 : Form
    {
        ApplicationDbContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormRefresh()
        {
            lblBill.Text = Convert.ToString(_db.Bills.Count());
            lblCategory.Text = Convert.ToString(_db.Categories.Count());
            lblDrink.Text = Convert.ToString(_db.Drinks.Count());
            lblEmployee.Text = Convert.ToString(_db.Employees.Count());
            lblFood.Text = Convert.ToString(_db.Foods.Count());
            lblPayment.Text = Convert.ToString(_db.Payments.Count());
            lblTable.Text = Convert.ToString(_db.Tables.Count());
            lblNumber.Text = Convert.ToString(_db.TableNumbers.Count());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            FormRefresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void içecekListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DrinkList dList = new DrinkList();
            dList.Show();
        }

        private void içecekleriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrinkEdit dEdit = new DrinkEdit();
            dEdit.Show();
        }

        private void yiyecekListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodList fList = new FoodList();
            fList.Show();
        }

        private void yiyecekleriGücelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodEdit fEdit = new FoodEdit();
            fEdit.Show();
        }

        private void kategoriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryList cList = new CategoryList();
            cList.Show();
        }

        private void kategoriyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEdit cEdit = new CategoryEdit();
            cEdit.Show();
        }

        private void ödemeSistemiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentList pList = new PaymentList();
            pList.Show();
        }

        private void ödemeSisteminiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentEdit pEdit = new PaymentEdit();
            pEdit.Show();
        }

        private void çalışanListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList eList = new EmployeeList();
            eList.Show();                
        }

        private void çalışanBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEdit empEdit = new EmployeeEdit();
            empEdit.Show();
        }

        private void faturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillList bList = new BillList();
            bList.Show();
        }

        private void ödenmemişFaturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillWillPay willPay = new BillWillPay();
            willPay.Show();
        }

        private void ödenmişFaturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillPaid paid = new BillPaid();
            paid.Show();
        }

        private void faturaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillEdit bEdit = new BillEdit();
            bEdit.Show();
        }

        private void masaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableList tList = new TableList();
            tList.Show();
        }

        private void boşMasaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableEmpty empty = new TableEmpty();
            empty.Show();
        }

        private void doluMasaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableFull full = new TableFull();
            full.Show();
        }

        private void rezerveEdilenMasalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableRezervation rezerv = new TableRezervation();
            rezerv.Show();
        }

        private void masaBilgisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableCustomerRegisterEdit tEDit = new TableCustomerRegisterEdit();
            tEDit.Show();
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void faturaListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BillList bill = new BillList();
            bill.Show();
        }

        private void kategoriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryList cate = new CategoryList();
            cate.Show();
        }

        private void içecekListesiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DrinkList drink = new DrinkList();
            drink.Show();
        }

        private void yiyecekListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FoodList food = new FoodList();
            food.Show();
        }

        private void çalışanListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeList employee = new EmployeeList();
            employee.Show();
        }

        private void ödemeSistemleriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentList payment = new PaymentList();
            payment.Show();
        }

        private void masaListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableList table = new TableList();
            table.Show();
        }

        private void hakkımızdaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FoodAdd fAdd = new FoodAdd();
            fAdd.Show();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            DrinkAdd dAdd = new DrinkAdd();
            dAdd.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryAdd cAdd = new CategoryAdd();
            cAdd.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAdd empAdd = new EmployeeAdd();
            empAdd.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentAdd payAdd = new PaymentAdd();
            payAdd.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableAdd tAdd = new TableAdd();
            tAdd.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillAdd bAdd = new BillAdd();
            bAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableNumberAdd numberAdd = new TableNumberAdd();
            numberAdd.Show();
        }

        private void masaBilgisiGücelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNumberEdit numberEdit = new TableNumberEdit();
            numberEdit.Show();
        }

        private void masaListesiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TableNumberList numberList = new TableNumberList();
            numberList.Show();
        }
    }
}

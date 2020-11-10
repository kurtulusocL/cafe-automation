namespace CafeOtomasyon.Forms
{
    partial class BillEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillEdit));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtGridBill = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDrinkPiece = new System.Windows.Forms.Label();
            this.lblDrinkPrice = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodPiece = new System.Windows.Forms.Label();
            this.numDrinkPiece = new System.Windows.Forms.NumericUpDown();
            this.numFoodPiece = new System.Windows.Forms.NumericUpDown();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.cmbDribkPrice = new System.Windows.Forms.ComboBox();
            this.cmbFoodPrice = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnPaidList = new System.Windows.Forms.Button();
            this.bynWillPayList = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPayment = new System.Windows.Forms.RadioButton();
            this.radioTotalPrice = new System.Windows.Forms.RadioButton();
            this.radioPayStatus = new System.Windows.Forms.RadioButton();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.checkPaidNo = new System.Windows.Forms.CheckBox();
            this.checkPaidYes = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodPiece)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Uyarı";
            // 
            // dtGridBill
            // 
            this.dtGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridBill.Location = new System.Drawing.Point(0, 0);
            this.dtGridBill.Name = "dtGridBill";
            this.dtGridBill.Size = new System.Drawing.Size(887, 313);
            this.dtGridBill.TabIndex = 0;
            this.dtGridBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridBill_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(853, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDrinkPiece
            // 
            this.lblDrinkPiece.AutoSize = true;
            this.lblDrinkPiece.Location = new System.Drawing.Point(248, 491);
            this.lblDrinkPiece.Name = "lblDrinkPiece";
            this.lblDrinkPiece.Size = new System.Drawing.Size(10, 13);
            this.lblDrinkPiece.TabIndex = 37;
            this.lblDrinkPiece.Text = ":";
            // 
            // lblDrinkPrice
            // 
            this.lblDrinkPrice.AutoSize = true;
            this.lblDrinkPrice.Location = new System.Drawing.Point(248, 520);
            this.lblDrinkPrice.Name = "lblDrinkPrice";
            this.lblDrinkPrice.Size = new System.Drawing.Size(10, 13);
            this.lblDrinkPrice.TabIndex = 36;
            this.lblDrinkPrice.Text = ":";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(248, 437);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(10, 13);
            this.lblFoodPrice.TabIndex = 35;
            this.lblFoodPrice.Text = ":";
            // 
            // lblFoodPiece
            // 
            this.lblFoodPiece.AutoSize = true;
            this.lblFoodPiece.Location = new System.Drawing.Point(248, 408);
            this.lblFoodPiece.Name = "lblFoodPiece";
            this.lblFoodPiece.Size = new System.Drawing.Size(10, 13);
            this.lblFoodPiece.TabIndex = 34;
            this.lblFoodPiece.Text = ":";
            // 
            // numDrinkPiece
            // 
            this.numDrinkPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numDrinkPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDrinkPiece.Location = new System.Drawing.Point(114, 487);
            this.numDrinkPiece.Name = "numDrinkPiece";
            this.numDrinkPiece.Size = new System.Drawing.Size(128, 21);
            this.numDrinkPiece.TabIndex = 33;
            this.numDrinkPiece.ValueChanged += new System.EventHandler(this.numDrinkPiece_ValueChanged);
            // 
            // numFoodPiece
            // 
            this.numFoodPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numFoodPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numFoodPiece.Location = new System.Drawing.Point(114, 404);
            this.numFoodPiece.Name = "numFoodPiece";
            this.numFoodPiece.Size = new System.Drawing.Size(128, 21);
            this.numFoodPiece.TabIndex = 32;
            this.numFoodPiece.ValueChanged += new System.EventHandler(this.numFoodPiece_ValueChanged);
            // 
            // cmbTable
            // 
            this.cmbTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(114, 346);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(187, 23);
            this.cmbTable.TabIndex = 30;
            // 
            // cmbDrink
            // 
            this.cmbDrink.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(114, 458);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(187, 23);
            this.cmbDrink.TabIndex = 29;
            // 
            // cmbDribkPrice
            // 
            this.cmbDribkPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbDribkPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDribkPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDribkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDribkPrice.FormattingEnabled = true;
            this.cmbDribkPrice.Location = new System.Drawing.Point(114, 514);
            this.cmbDribkPrice.Name = "cmbDribkPrice";
            this.cmbDribkPrice.Size = new System.Drawing.Size(128, 23);
            this.cmbDribkPrice.TabIndex = 31;
            this.cmbDribkPrice.TextChanged += new System.EventHandler(this.cmbDribkPrice_TextChanged);
            // 
            // cmbFoodPrice
            // 
            this.cmbFoodPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbFoodPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFoodPrice.FormattingEnabled = true;
            this.cmbFoodPrice.Location = new System.Drawing.Point(114, 431);
            this.cmbFoodPrice.Name = "cmbFoodPrice";
            this.cmbFoodPrice.Size = new System.Drawing.Size(128, 23);
            this.cmbFoodPrice.TabIndex = 28;
            this.cmbFoodPrice.TextChanged += new System.EventHandler(this.cmbFoodPrice_TextChanged);
            // 
            // cmbFood
            // 
            this.cmbFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(114, 375);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(187, 23);
            this.cmbFood.TabIndex = 27;
            // 
            // txtBillNo
            // 
            this.txtBillNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillNo.Location = new System.Drawing.Point(114, 319);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(187, 21);
            this.txtBillNo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Masa No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "İçecek Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "İçecekler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Yiyecek Adet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "İçecek Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Yiyecek Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Yiyecekler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fatura No.";
            // 
            // cmbPayment
            // 
            this.cmbPayment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(415, 380);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(187, 23);
            this.cmbPayment.TabIndex = 44;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(415, 409);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(187, 23);
            this.cmbEmployee.TabIndex = 45;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(415, 350);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(187, 21);
            this.txtNameSurname.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(313, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Ödeme Yöntemi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(314, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Müşteri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(313, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "İşlemi Yapan";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(530, 518);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 50;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(530, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 43);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Location = new System.Drawing.Point(471, 469);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(53, 43);
            this.btnList.TabIndex = 48;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(412, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 43);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(353, 469);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 43);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(471, 518);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 51;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnPaidList
            // 
            this.btnPaidList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaidList.BackgroundImage")));
            this.btnPaidList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaidList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaidList.Location = new System.Drawing.Point(353, 518);
            this.btnPaidList.Name = "btnPaidList";
            this.btnPaidList.Size = new System.Drawing.Size(53, 43);
            this.btnPaidList.TabIndex = 51;
            this.btnPaidList.UseVisualStyleBackColor = true;
            this.btnPaidList.Click += new System.EventHandler(this.btnPaidList_Click);
            // 
            // bynWillPayList
            // 
            this.bynWillPayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bynWillPayList.BackgroundImage")));
            this.bynWillPayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bynWillPayList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bynWillPayList.Location = new System.Drawing.Point(412, 518);
            this.bynWillPayList.Name = "bynWillPayList";
            this.bynWillPayList.Size = new System.Drawing.Size(53, 43);
            this.bynWillPayList.TabIndex = 51;
            this.bynWillPayList.UseVisualStyleBackColor = true;
            this.bynWillPayList.Click += new System.EventHandler(this.bynWillPayList_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(645, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "Arama Yap";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(669, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPayment);
            this.groupBox1.Controls.Add(this.radioTotalPrice);
            this.groupBox1.Controls.Add(this.radioPayStatus);
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(648, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 165);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama İşlemleri";
            // 
            // radioPayment
            // 
            this.radioPayment.AutoSize = true;
            this.radioPayment.ForeColor = System.Drawing.Color.Black;
            this.radioPayment.Location = new System.Drawing.Point(6, 135);
            this.radioPayment.Name = "radioPayment";
            this.radioPayment.Size = new System.Drawing.Size(178, 19);
            this.radioPayment.TabIndex = 1;
            this.radioPayment.TabStop = true;
            this.radioPayment.Text = "Ödeme Yöntemine Göre";
            this.radioPayment.UseVisualStyleBackColor = true;
            this.radioPayment.CheckedChanged += new System.EventHandler(this.radioPayment_CheckedChanged);
            // 
            // radioTotalPrice
            // 
            this.radioTotalPrice.AutoSize = true;
            this.radioTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.radioTotalPrice.Location = new System.Drawing.Point(6, 110);
            this.radioTotalPrice.Name = "radioTotalPrice";
            this.radioTotalPrice.Size = new System.Drawing.Size(150, 19);
            this.radioTotalPrice.TabIndex = 1;
            this.radioTotalPrice.TabStop = true;
            this.radioTotalPrice.Text = "Toplam Fiyata Göre";
            this.radioTotalPrice.UseVisualStyleBackColor = true;
            this.radioTotalPrice.CheckedChanged += new System.EventHandler(this.radioTotalPrice_CheckedChanged);
            // 
            // radioPayStatus
            // 
            this.radioPayStatus.AutoSize = true;
            this.radioPayStatus.ForeColor = System.Drawing.Color.Black;
            this.radioPayStatus.Location = new System.Drawing.Point(6, 85);
            this.radioPayStatus.Name = "radioPayStatus";
            this.radioPayStatus.Size = new System.Drawing.Size(185, 19);
            this.radioPayStatus.TabIndex = 1;
            this.radioPayStatus.TabStop = true;
            this.radioPayStatus.Text = "Ödenme Durumuna Göre";
            this.radioPayStatus.UseVisualStyleBackColor = true;
            this.radioPayStatus.CheckedChanged += new System.EventHandler(this.radioPayStatus_CheckedChanged);
            // 
            // radioUpdated
            // 
            this.radioUpdated.AutoSize = true;
            this.radioUpdated.ForeColor = System.Drawing.Color.Black;
            this.radioUpdated.Location = new System.Drawing.Point(6, 60);
            this.radioUpdated.Name = "radioUpdated";
            this.radioUpdated.Size = new System.Drawing.Size(202, 19);
            this.radioUpdated.TabIndex = 1;
            this.radioUpdated.TabStop = true;
            this.radioUpdated.Text = "Güncellenme Tarihine Göre";
            this.radioUpdated.UseVisualStyleBackColor = true;
            this.radioUpdated.CheckedChanged += new System.EventHandler(this.radioUpdated_CheckedChanged);
            // 
            // radioCreate
            // 
            this.radioCreate.AutoSize = true;
            this.radioCreate.ForeColor = System.Drawing.Color.Black;
            this.radioCreate.Location = new System.Drawing.Point(6, 35);
            this.radioCreate.Name = "radioCreate";
            this.radioCreate.Size = new System.Drawing.Size(173, 19);
            this.radioCreate.TabIndex = 0;
            this.radioCreate.TabStop = true;
            this.radioCreate.Text = "Eklenme Tarihine Göre";
            this.radioCreate.UseVisualStyleBackColor = true;
            this.radioCreate.CheckedChanged += new System.EventHandler(this.radioCreate_CheckedChanged);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTotalPrice.Location = new System.Drawing.Point(319, 321);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(283, 23);
            this.btnTotalPrice.TabIndex = 53;
            this.btnTotalPrice.Text = "Toplam Fiyatı Görmek İçin Tıklayınız";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // checkPaidNo
            // 
            this.checkPaidNo.AutoSize = true;
            this.checkPaidNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPaidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkPaidNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkPaidNo.Location = new System.Drawing.Point(206, 552);
            this.checkPaidNo.Name = "checkPaidNo";
            this.checkPaidNo.Size = new System.Drawing.Size(52, 19);
            this.checkPaidNo.TabIndex = 55;
            this.checkPaidNo.Text = "Hayır";
            this.checkPaidNo.UseVisualStyleBackColor = true;
            // 
            // checkPaidYes
            // 
            this.checkPaidYes.AutoSize = true;
            this.checkPaidYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPaidYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkPaidYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkPaidYes.Location = new System.Drawing.Point(120, 552);
            this.checkPaidYes.Name = "checkPaidYes";
            this.checkPaidYes.Size = new System.Drawing.Size(47, 19);
            this.checkPaidYes.TabIndex = 54;
            this.checkPaidYes.Text = "Evet";
            this.checkPaidYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ödeme Yaptı Mı?";
            // 
            // BillEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(886, 576);
            this.Controls.Add(this.checkPaidNo);
            this.Controls.Add(this.checkPaidYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bynWillPayList);
            this.Controls.Add(this.btnPaidList);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDrinkPiece);
            this.Controls.Add(this.lblDrinkPrice);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodPiece);
            this.Controls.Add(this.numDrinkPiece);
            this.Controls.Add(this.numFoodPiece);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.cmbDribkPrice);
            this.Controls.Add(this.cmbFoodPrice);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgi Görüntüleme ve Düzenleme Sayfası";
            this.Load += new System.EventHandler(this.BillEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodPiece)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtGridBill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDrinkPiece;
        private System.Windows.Forms.Label lblDrinkPrice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodPiece;
        private System.Windows.Forms.NumericUpDown numDrinkPiece;
        private System.Windows.Forms.NumericUpDown numFoodPiece;
        public System.Windows.Forms.ComboBox cmbTable;
        public System.Windows.Forms.ComboBox cmbDrink;
        public System.Windows.Forms.ComboBox cmbDribkPrice;
        public System.Windows.Forms.ComboBox cmbFoodPrice;
        public System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbPayment;
        public System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnPaidList;
        private System.Windows.Forms.Button bynWillPayList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.RadioButton radioPayment;
        private System.Windows.Forms.RadioButton radioTotalPrice;
        private System.Windows.Forms.RadioButton radioPayStatus;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.CheckBox checkPaidNo;
        private System.Windows.Forms.CheckBox checkPaidYes;
        private System.Windows.Forms.Label label8;
    }
}
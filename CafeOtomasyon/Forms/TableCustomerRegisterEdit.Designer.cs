namespace CafeOtomasyon.Forms
{
    partial class TableCustomerRegisterEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCustomerRegisterEdit));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtGridTable = new System.Windows.Forms.DataGridView();
            this.dtPicLeaving = new System.Windows.Forms.DateTimePicker();
            this.dtPicArriving = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkTableNo = new System.Windows.Forms.CheckBox();
            this.checkTableOk = new System.Windows.Forms.CheckBox();
            this.checkPaidNo = new System.Windows.Forms.CheckBox();
            this.checkPaidYes = new System.Windows.Forms.CheckBox();
            this.checkRezervNo = new System.Windows.Forms.CheckBox();
            this.checkRezervYes = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioStatus = new System.Windows.Forms.RadioButton();
            this.radioTableNo = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnEmptyTable = new System.Windows.Forms.Button();
            this.btnFullTable = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşMasaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluMasaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            // dtGridTable
            // 
            this.dtGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTable.Location = new System.Drawing.Point(1, 0);
            this.dtGridTable.Name = "dtGridTable";
            this.dtGridTable.Size = new System.Drawing.Size(881, 273);
            this.dtGridTable.TabIndex = 0;
            this.dtGridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTable_CellClick);
            // 
            // dtPicLeaving
            // 
            this.dtPicLeaving.Location = new System.Drawing.Point(117, 334);
            this.dtPicLeaving.Name = "dtPicLeaving";
            this.dtPicLeaving.Size = new System.Drawing.Size(179, 20);
            this.dtPicLeaving.TabIndex = 7;
            // 
            // dtPicArriving
            // 
            this.dtPicArriving.Location = new System.Drawing.Point(117, 308);
            this.dtPicArriving.Name = "dtPicArriving";
            this.dtPicArriving.Size = new System.Drawing.Size(179, 20);
            this.dtPicArriving.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ayrılış Zamanı";
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.Location = new System.Drawing.Point(117, 279);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(179, 23);
            this.cmbTableNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geliş Zamanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Masa Numarası";
            // 
            // checkTableNo
            // 
            this.checkTableNo.AutoSize = true;
            this.checkTableNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTableNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkTableNo.Location = new System.Drawing.Point(227, 409);
            this.checkTableNo.Name = "checkTableNo";
            this.checkTableNo.Size = new System.Drawing.Size(52, 19);
            this.checkTableNo.TabIndex = 18;
            this.checkTableNo.Text = "Hayır";
            this.checkTableNo.UseVisualStyleBackColor = true;
            // 
            // checkTableOk
            // 
            this.checkTableOk.AutoSize = true;
            this.checkTableOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkTableOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTableOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkTableOk.Location = new System.Drawing.Point(141, 410);
            this.checkTableOk.Name = "checkTableOk";
            this.checkTableOk.Size = new System.Drawing.Size(47, 19);
            this.checkTableOk.TabIndex = 17;
            this.checkTableOk.Text = "Evet";
            this.checkTableOk.UseVisualStyleBackColor = true;
            // 
            // checkPaidNo
            // 
            this.checkPaidNo.AutoSize = true;
            this.checkPaidNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPaidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkPaidNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkPaidNo.Location = new System.Drawing.Point(227, 384);
            this.checkPaidNo.Name = "checkPaidNo";
            this.checkPaidNo.Size = new System.Drawing.Size(52, 19);
            this.checkPaidNo.TabIndex = 16;
            this.checkPaidNo.Text = "Hayır";
            this.checkPaidNo.UseVisualStyleBackColor = true;
            // 
            // checkPaidYes
            // 
            this.checkPaidYes.AutoSize = true;
            this.checkPaidYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkPaidYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkPaidYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkPaidYes.Location = new System.Drawing.Point(141, 384);
            this.checkPaidYes.Name = "checkPaidYes";
            this.checkPaidYes.Size = new System.Drawing.Size(47, 19);
            this.checkPaidYes.TabIndex = 15;
            this.checkPaidYes.Text = "Evet";
            this.checkPaidYes.UseVisualStyleBackColor = true;
            // 
            // checkRezervNo
            // 
            this.checkRezervNo.AutoSize = true;
            this.checkRezervNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkRezervNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkRezervNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkRezervNo.Location = new System.Drawing.Point(227, 360);
            this.checkRezervNo.Name = "checkRezervNo";
            this.checkRezervNo.Size = new System.Drawing.Size(52, 19);
            this.checkRezervNo.TabIndex = 14;
            this.checkRezervNo.Text = "Hayır";
            this.checkRezervNo.UseVisualStyleBackColor = true;
            // 
            // checkRezervYes
            // 
            this.checkRezervYes.AutoSize = true;
            this.checkRezervYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkRezervYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkRezervYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkRezervYes.Location = new System.Drawing.Point(141, 360);
            this.checkRezervYes.Name = "checkRezervYes";
            this.checkRezervYes.Size = new System.Drawing.Size(47, 19);
            this.checkRezervYes.TabIndex = 13;
            this.checkRezervYes.Text = "Evet";
            this.checkRezervYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Masa Uygun Mu?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ödeme Yaptı Mı?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rezerve Mi?";
            // 
            // cmbDrink
            // 
            this.cmbDrink.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(117, 464);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(179, 23);
            this.cmbDrink.TabIndex = 22;
            // 
            // cmbFood
            // 
            this.cmbFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(117, 435);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(179, 23);
            this.cmbFood.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "İçecek Sipariş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Yiyecek Sipariş";
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(405, 438);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 79;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(464, 438);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 80;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(492, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 43);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Location = new System.Drawing.Point(374, 389);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(53, 43);
            this.btnList.TabIndex = 77;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(433, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 43);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(374, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 43);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(845, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(367, 311);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 82;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(337, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 83;
            this.label13.Text = "Arama Yap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioStatus);
            this.groupBox1.Controls.Add(this.radioTableNo);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(614, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 144);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama İşlemleri";
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
            // radioStatus
            // 
            this.radioStatus.AutoSize = true;
            this.radioStatus.ForeColor = System.Drawing.Color.Black;
            this.radioStatus.Location = new System.Drawing.Point(6, 110);
            this.radioStatus.Name = "radioStatus";
            this.radioStatus.Size = new System.Drawing.Size(190, 19);
            this.radioStatus.TabIndex = 0;
            this.radioStatus.TabStop = true;
            this.radioStatus.Text = "Uygunluk Durumuna Göre";
            this.radioStatus.UseVisualStyleBackColor = true;
            this.radioStatus.CheckedChanged += new System.EventHandler(this.radioStatus_CheckedChanged);
            // 
            // radioTableNo
            // 
            this.radioTableNo.AutoSize = true;
            this.radioTableNo.ForeColor = System.Drawing.Color.Black;
            this.radioTableNo.Location = new System.Drawing.Point(6, 85);
            this.radioTableNo.Name = "radioTableNo";
            this.radioTableNo.Size = new System.Drawing.Size(177, 19);
            this.radioTableNo.TabIndex = 0;
            this.radioTableNo.TabStop = true;
            this.radioTableNo.Text = "Masa Numarasına Göre";
            this.radioTableNo.UseVisualStyleBackColor = true;
            this.radioTableNo.CheckedChanged += new System.EventHandler(this.radioTableNo_CheckedChanged);
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
            // btnEmptyTable
            // 
            this.btnEmptyTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmptyTable.BackgroundImage")));
            this.btnEmptyTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmptyTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmptyTable.Location = new System.Drawing.Point(433, 390);
            this.btnEmptyTable.Name = "btnEmptyTable";
            this.btnEmptyTable.Size = new System.Drawing.Size(53, 43);
            this.btnEmptyTable.TabIndex = 77;
            this.btnEmptyTable.UseVisualStyleBackColor = true;
            this.btnEmptyTable.Click += new System.EventHandler(this.btnEmptyTable_Click);
            // 
            // btnFullTable
            // 
            this.btnFullTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullTable.BackgroundImage")));
            this.btnFullTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFullTable.Location = new System.Drawing.Point(492, 389);
            this.btnFullTable.Name = "btnFullTable";
            this.btnFullTable.Size = new System.Drawing.Size(53, 43);
            this.btnFullTable.TabIndex = 77;
            this.btnFullTable.UseVisualStyleBackColor = true;
            this.btnFullTable.Click += new System.EventHandler(this.btnFullTable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaListesiToolStripMenuItem,
            this.boşMasaListesiToolStripMenuItem,
            this.doluMasaListesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // masaListesiToolStripMenuItem
            // 
            this.masaListesiToolStripMenuItem.Name = "masaListesiToolStripMenuItem";
            this.masaListesiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masaListesiToolStripMenuItem.Text = "Masa Listesi";
            this.masaListesiToolStripMenuItem.Click += new System.EventHandler(this.masaListesiToolStripMenuItem_Click);
            // 
            // boşMasaListesiToolStripMenuItem
            // 
            this.boşMasaListesiToolStripMenuItem.Name = "boşMasaListesiToolStripMenuItem";
            this.boşMasaListesiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.boşMasaListesiToolStripMenuItem.Text = "Boş Masa Listesi";
            this.boşMasaListesiToolStripMenuItem.Click += new System.EventHandler(this.boşMasaListesiToolStripMenuItem_Click);
            // 
            // doluMasaListesiToolStripMenuItem
            // 
            this.doluMasaListesiToolStripMenuItem.Name = "doluMasaListesiToolStripMenuItem";
            this.doluMasaListesiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.doluMasaListesiToolStripMenuItem.Text = "Dolu Masa Listesi";
            this.doluMasaListesiToolStripMenuItem.Click += new System.EventHandler(this.doluMasaListesiToolStripMenuItem_Click);
            // 
            // TableCustomerRegisterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 493);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFullTable);
            this.Controls.Add(this.btnEmptyTable);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkTableNo);
            this.Controls.Add(this.checkTableOk);
            this.Controls.Add(this.checkPaidNo);
            this.Controls.Add(this.checkPaidYes);
            this.Controls.Add(this.checkRezervNo);
            this.Controls.Add(this.checkRezervYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPicLeaving);
            this.Controls.Add(this.dtPicArriving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTableNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableCustomerRegisterEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Müşteri Listesi ve Bilgi Düzeleme Formu";
            this.Load += new System.EventHandler(this.TableCustomerRegisterEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridTable;
        private System.Windows.Forms.DateTimePicker dtPicLeaving;
        private System.Windows.Forms.DateTimePicker dtPicArriving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkTableNo;
        private System.Windows.Forms.CheckBox checkTableOk;
        private System.Windows.Forms.CheckBox checkPaidNo;
        private System.Windows.Forms.CheckBox checkPaidYes;
        private System.Windows.Forms.CheckBox checkRezervNo;
        private System.Windows.Forms.CheckBox checkRezervYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.RadioButton radioStatus;
        private System.Windows.Forms.RadioButton radioTableNo;
        private System.Windows.Forms.Button btnEmptyTable;
        private System.Windows.Forms.Button btnFullTable;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşMasaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doluMasaListesiToolStripMenuItem;
    }
}
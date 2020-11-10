﻿namespace CafeOtomasyon.Forms
{
    partial class BillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillList));
            this.dtGridBillList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPayment = new System.Windows.Forms.RadioButton();
            this.radioTotalPrice = new System.Windows.Forms.RadioButton();
            this.radioPayStatus = new System.Windows.Forms.RadioButton();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioFoodPrice = new System.Windows.Forms.RadioButton();
            this.radioDrinkPrice = new System.Windows.Forms.RadioButton();
            this.radioEmployee = new System.Windows.Forms.RadioButton();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.radioTableNo = new System.Windows.Forms.RadioButton();
            this.radioBillNumber = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bynWillPayList = new System.Windows.Forms.Button();
            this.btnPaidList = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBillList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridBillList
            // 
            this.dtGridBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridBillList.Location = new System.Drawing.Point(0, 1);
            this.dtGridBillList.Name = "dtGridBillList";
            this.dtGridBillList.Size = new System.Drawing.Size(900, 313);
            this.dtGridBillList.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(32, 338);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(8, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 15);
            this.label13.TabIndex = 43;
            this.label13.Text = "Masa Araması Yap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fatura Araması Yap";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(32, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 21);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Müşteri Araması Yap";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(32, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 21);
            this.textBox2.TabIndex = 44;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPayment);
            this.groupBox1.Controls.Add(this.radioTotalPrice);
            this.groupBox1.Controls.Add(this.radioPayStatus);
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioFoodPrice);
            this.groupBox1.Controls.Add(this.radioDrinkPrice);
            this.groupBox1.Controls.Add(this.radioEmployee);
            this.groupBox1.Controls.Add(this.radioCustomer);
            this.groupBox1.Controls.Add(this.radioTableNo);
            this.groupBox1.Controls.Add(this.radioBillNumber);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(254, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 192);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama İşlemleri";
            // 
            // radioPayment
            // 
            this.radioPayment.AutoSize = true;
            this.radioPayment.ForeColor = System.Drawing.Color.Black;
            this.radioPayment.Location = new System.Drawing.Point(6, 112);
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
            this.radioTotalPrice.Location = new System.Drawing.Point(291, 87);
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
            this.radioPayStatus.Location = new System.Drawing.Point(6, 87);
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
            this.radioUpdated.Location = new System.Drawing.Point(6, 62);
            this.radioUpdated.Name = "radioUpdated";
            this.radioUpdated.Size = new System.Drawing.Size(202, 19);
            this.radioUpdated.TabIndex = 1;
            this.radioUpdated.TabStop = true;
            this.radioUpdated.Text = "Güncellenme Tarihine Göre";
            this.radioUpdated.UseVisualStyleBackColor = true;
            this.radioUpdated.CheckedChanged += new System.EventHandler(this.radioUpdated_CheckedChanged);
            // 
            // radioFoodPrice
            // 
            this.radioFoodPrice.AutoSize = true;
            this.radioFoodPrice.ForeColor = System.Drawing.Color.Black;
            this.radioFoodPrice.Location = new System.Drawing.Point(291, 137);
            this.radioFoodPrice.Name = "radioFoodPrice";
            this.radioFoodPrice.Size = new System.Drawing.Size(162, 19);
            this.radioFoodPrice.TabIndex = 0;
            this.radioFoodPrice.TabStop = true;
            this.radioFoodPrice.Text = "Yiyecek Fiyatına Göre";
            this.radioFoodPrice.UseVisualStyleBackColor = true;
            this.radioFoodPrice.CheckedChanged += new System.EventHandler(this.radioFoodPrice_CheckedChanged);
            // 
            // radioDrinkPrice
            // 
            this.radioDrinkPrice.AutoSize = true;
            this.radioDrinkPrice.ForeColor = System.Drawing.Color.Black;
            this.radioDrinkPrice.Location = new System.Drawing.Point(291, 112);
            this.radioDrinkPrice.Name = "radioDrinkPrice";
            this.radioDrinkPrice.Size = new System.Drawing.Size(155, 19);
            this.radioDrinkPrice.TabIndex = 0;
            this.radioDrinkPrice.TabStop = true;
            this.radioDrinkPrice.Text = "İçecek Fiyatına Göre";
            this.radioDrinkPrice.UseVisualStyleBackColor = true;
            this.radioDrinkPrice.CheckedChanged += new System.EventHandler(this.radioDrinkPrice_CheckedChanged);
            // 
            // radioEmployee
            // 
            this.radioEmployee.AutoSize = true;
            this.radioEmployee.ForeColor = System.Drawing.Color.Black;
            this.radioEmployee.Location = new System.Drawing.Point(151, 162);
            this.radioEmployee.Name = "radioEmployee";
            this.radioEmployee.Size = new System.Drawing.Size(180, 19);
            this.radioEmployee.TabIndex = 0;
            this.radioEmployee.TabStop = true;
            this.radioEmployee.Text = "Çalışan Ad-Soyada Göre";
            this.radioEmployee.UseVisualStyleBackColor = true;
            this.radioEmployee.CheckedChanged += new System.EventHandler(this.radioEmployee_CheckedChanged);
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.ForeColor = System.Drawing.Color.Black;
            this.radioCustomer.Location = new System.Drawing.Point(6, 137);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(180, 19);
            this.radioCustomer.TabIndex = 0;
            this.radioCustomer.TabStop = true;
            this.radioCustomer.Text = "Müşteri Ad-Soyada Göre";
            this.radioCustomer.UseVisualStyleBackColor = true;
            this.radioCustomer.CheckedChanged += new System.EventHandler(this.radioCustomer_CheckedChanged);
            // 
            // radioTableNo
            // 
            this.radioTableNo.AutoSize = true;
            this.radioTableNo.ForeColor = System.Drawing.Color.Black;
            this.radioTableNo.Location = new System.Drawing.Point(291, 62);
            this.radioTableNo.Name = "radioTableNo";
            this.radioTableNo.Size = new System.Drawing.Size(135, 19);
            this.radioTableNo.TabIndex = 0;
            this.radioTableNo.TabStop = true;
            this.radioTableNo.Text = "Masa No\'ya Göre";
            this.radioTableNo.UseVisualStyleBackColor = true;
            this.radioTableNo.CheckedChanged += new System.EventHandler(this.radioTableNo_CheckedChanged);
            // 
            // radioBillNumber
            // 
            this.radioBillNumber.AutoSize = true;
            this.radioBillNumber.ForeColor = System.Drawing.Color.Black;
            this.radioBillNumber.Location = new System.Drawing.Point(291, 37);
            this.radioBillNumber.Name = "radioBillNumber";
            this.radioBillNumber.Size = new System.Drawing.Size(141, 19);
            this.radioBillNumber.TabIndex = 0;
            this.radioBillNumber.TabStop = true;
            this.radioBillNumber.Text = "Fatura No\'ya Göre";
            this.radioBillNumber.UseVisualStyleBackColor = true;
            this.radioBillNumber.CheckedChanged += new System.EventHandler(this.radioBillNumber_CheckedChanged);
            // 
            // radioCreate
            // 
            this.radioCreate.AutoSize = true;
            this.radioCreate.ForeColor = System.Drawing.Color.Black;
            this.radioCreate.Location = new System.Drawing.Point(6, 37);
            this.radioCreate.Name = "radioCreate";
            this.radioCreate.Size = new System.Drawing.Size(173, 19);
            this.radioCreate.TabIndex = 0;
            this.radioCreate.TabStop = true;
            this.radioCreate.Text = "Eklenme Tarihine Göre";
            this.radioCreate.UseVisualStyleBackColor = true;
            this.radioCreate.CheckedChanged += new System.EventHandler(this.radioCreate_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bynWillPayList
            // 
            this.bynWillPayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bynWillPayList.BackgroundImage")));
            this.bynWillPayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bynWillPayList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bynWillPayList.Location = new System.Drawing.Point(784, 350);
            this.bynWillPayList.Name = "bynWillPayList";
            this.bynWillPayList.Size = new System.Drawing.Size(53, 43);
            this.bynWillPayList.TabIndex = 60;
            this.bynWillPayList.UseVisualStyleBackColor = true;
            this.bynWillPayList.Click += new System.EventHandler(this.bynWillPayList_Click);
            // 
            // btnPaidList
            // 
            this.btnPaidList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaidList.BackgroundImage")));
            this.btnPaidList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaidList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaidList.Location = new System.Drawing.Point(725, 350);
            this.btnPaidList.Name = "btnPaidList";
            this.btnPaidList.Size = new System.Drawing.Size(53, 43);
            this.btnPaidList.TabIndex = 61;
            this.btnPaidList.UseVisualStyleBackColor = true;
            this.btnPaidList.Click += new System.EventHandler(this.btnPaidList_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(812, 399);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 62;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(753, 399);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 59;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(843, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 43);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(900, 542);
            this.Controls.Add(this.bynWillPayList);
            this.Controls.Add(this.btnPaidList);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtGridBillList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Bilgileri Listesi";
            this.Load += new System.EventHandler(this.BillList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBillList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridBillList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPayment;
        private System.Windows.Forms.RadioButton radioTotalPrice;
        private System.Windows.Forms.RadioButton radioPayStatus;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bynWillPayList;
        private System.Windows.Forms.Button btnPaidList;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton radioTableNo;
        private System.Windows.Forms.RadioButton radioBillNumber;
        private System.Windows.Forms.RadioButton radioEmployee;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.RadioButton radioFoodPrice;
        private System.Windows.Forms.RadioButton radioDrinkPrice;
    }
}
namespace CafeOtomasyon.Forms
{
    partial class CategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFoods = new System.Windows.Forms.RadioButton();
            this.radioDrinks = new System.Windows.Forms.RadioButton();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridCategoryList = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFoods);
            this.groupBox1.Controls.Add(this.radioDrinks);
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(644, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama İşlemleri";
            // 
            // radioFoods
            // 
            this.radioFoods.AutoSize = true;
            this.radioFoods.ForeColor = System.Drawing.Color.Black;
            this.radioFoods.Location = new System.Drawing.Point(6, 110);
            this.radioFoods.Name = "radioFoods";
            this.radioFoods.Size = new System.Drawing.Size(166, 19);
            this.radioFoods.TabIndex = 3;
            this.radioFoods.TabStop = true;
            this.radioFoods.Text = "Yiyecek Sayısına Göre";
            this.radioFoods.UseVisualStyleBackColor = true;
            this.radioFoods.CheckedChanged += new System.EventHandler(this.radioFoods_CheckedChanged);
            // 
            // radioDrinks
            // 
            this.radioDrinks.AutoSize = true;
            this.radioDrinks.ForeColor = System.Drawing.Color.Black;
            this.radioDrinks.Location = new System.Drawing.Point(6, 85);
            this.radioDrinks.Name = "radioDrinks";
            this.radioDrinks.Size = new System.Drawing.Size(159, 19);
            this.radioDrinks.TabIndex = 2;
            this.radioDrinks.TabStop = true;
            this.radioDrinks.Text = "İçecek Sayısına Göre";
            this.radioDrinks.UseVisualStyleBackColor = true;
            this.radioDrinks.CheckedChanged += new System.EventHandler(this.radioDrinks_CheckedChanged);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(827, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(666, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 43);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(706, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 21);
            this.txtSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(633, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arama Yap";
            // 
            // dtGridCategoryList
            // 
            this.dtGridCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCategoryList.Location = new System.Drawing.Point(0, 4);
            this.dtGridCategoryList.Name = "dtGridCategoryList";
            this.dtGridCategoryList.Size = new System.Drawing.Size(631, 466);
            this.dtGridCategoryList.TabIndex = 7;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(725, 226);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(784, 226);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGridCategoryList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Listesi Sayfası";
            this.Load += new System.EventHandler(this.CategoryList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGridCategoryList;
        private System.Windows.Forms.RadioButton radioFoods;
        private System.Windows.Forms.RadioButton radioDrinks;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
    }
}
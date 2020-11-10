namespace CafeOtomasyon.Forms
{
    partial class EmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.dtGridEmployeeList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBillCount = new System.Windows.Forms.RadioButton();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridEmployeeList
            // 
            this.dtGridEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmployeeList.Location = new System.Drawing.Point(1, 0);
            this.dtGridEmployeeList.Name = "dtGridEmployeeList";
            this.dtGridEmployeeList.Size = new System.Drawing.Size(756, 312);
            this.dtGridEmployeeList.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(32, 367);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(8, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "Arama Yap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBillCount);
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(283, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 114);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama İşlemleri";
            // 
            // radioBillCount
            // 
            this.radioBillCount.AutoSize = true;
            this.radioBillCount.ForeColor = System.Drawing.Color.Black;
            this.radioBillCount.Location = new System.Drawing.Point(6, 85);
            this.radioBillCount.Name = "radioBillCount";
            this.radioBillCount.Size = new System.Drawing.Size(153, 19);
            this.radioBillCount.TabIndex = 1;
            this.radioBillCount.TabStop = true;
            this.radioBillCount.Text = "İşlem Sayısına Göre";
            this.radioBillCount.UseVisualStyleBackColor = true;
            this.radioBillCount.CheckedChanged += new System.EventHandler(this.radioBillCount_CheckedChanged);
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
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(617, 349);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 60;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(588, 398);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 61;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(558, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 43);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridEmployeeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Listesi Formu";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridEmployeeList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBillCount;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}
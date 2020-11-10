namespace CafeOtomasyon.Forms
{
    partial class TableList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableList));
            this.dtGridTable = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUpdated = new System.Windows.Forms.RadioButton();
            this.radioStatus = new System.Windows.Forms.RadioButton();
            this.radioTableNo = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioDrink = new System.Windows.Forms.RadioButton();
            this.radioRezerve = new System.Windows.Forms.RadioButton();
            this.radioPaid = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFullTable = new System.Windows.Forms.Button();
            this.btnEmptyTable = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boşMasaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluMasaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDüzenlemeSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridTable
            // 
            this.dtGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTable.Location = new System.Drawing.Point(1, 0);
            this.dtGridTable.Name = "dtGridTable";
            this.dtGridTable.Size = new System.Drawing.Size(901, 330);
            this.dtGridTable.TabIndex = 1;
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
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(33, 396);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 21);
            this.txtSearch.TabIndex = 84;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 85;
            this.label13.Text = "Arama Yap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUpdated);
            this.groupBox1.Controls.Add(this.radioStatus);
            this.groupBox1.Controls.Add(this.radioTableNo);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioDrink);
            this.groupBox1.Controls.Add(this.radioRezerve);
            this.groupBox1.Controls.Add(this.radioPaid);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(264, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 144);
            this.groupBox1.TabIndex = 86;
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(223, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yiyeceklere Göre";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioDrink
            // 
            this.radioDrink.AutoSize = true;
            this.radioDrink.ForeColor = System.Drawing.Color.Black;
            this.radioDrink.Location = new System.Drawing.Point(223, 84);
            this.radioDrink.Name = "radioDrink";
            this.radioDrink.Size = new System.Drawing.Size(126, 19);
            this.radioDrink.TabIndex = 0;
            this.radioDrink.TabStop = true;
            this.radioDrink.Text = "İçeceklere Göre";
            this.radioDrink.UseVisualStyleBackColor = true;
            this.radioDrink.CheckedChanged += new System.EventHandler(this.radioDrink_CheckedChanged);
            // 
            // radioRezerve
            // 
            this.radioRezerve.AutoSize = true;
            this.radioRezerve.ForeColor = System.Drawing.Color.Black;
            this.radioRezerve.Location = new System.Drawing.Point(223, 59);
            this.radioRezerve.Name = "radioRezerve";
            this.radioRezerve.Size = new System.Drawing.Size(183, 19);
            this.radioRezerve.TabIndex = 0;
            this.radioRezerve.TabStop = true;
            this.radioRezerve.Text = "Rezerve Durumuna Göre";
            this.radioRezerve.UseVisualStyleBackColor = true;
            this.radioRezerve.CheckedChanged += new System.EventHandler(this.radioRezerve_CheckedChanged);
            // 
            // radioPaid
            // 
            this.radioPaid.AutoSize = true;
            this.radioPaid.ForeColor = System.Drawing.Color.Black;
            this.radioPaid.Location = new System.Drawing.Point(223, 34);
            this.radioPaid.Name = "radioPaid";
            this.radioPaid.Size = new System.Drawing.Size(177, 19);
            this.radioPaid.TabIndex = 0;
            this.radioPaid.TabStop = true;
            this.radioPaid.Text = "Ödeme Durumuna Göre";
            this.radioPaid.UseVisualStyleBackColor = true;
            this.radioPaid.CheckedChanged += new System.EventHandler(this.radioPaid_CheckedChanged);
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
            this.pictureBox1.Location = new System.Drawing.Point(865, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(735, 395);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(53, 43);
            this.btnPdf.TabIndex = 94;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(794, 395);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 43);
            this.btnHome.TabIndex = 95;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFullTable
            // 
            this.btnFullTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullTable.BackgroundImage")));
            this.btnFullTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFullTable.Location = new System.Drawing.Point(764, 346);
            this.btnFullTable.Name = "btnFullTable";
            this.btnFullTable.Size = new System.Drawing.Size(53, 43);
            this.btnFullTable.TabIndex = 90;
            this.btnFullTable.UseVisualStyleBackColor = true;
            this.btnFullTable.Click += new System.EventHandler(this.btnFullTable_Click);
            // 
            // btnEmptyTable
            // 
            this.btnEmptyTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmptyTable.BackgroundImage")));
            this.btnEmptyTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmptyTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmptyTable.Location = new System.Drawing.Point(705, 346);
            this.btnEmptyTable.Name = "btnEmptyTable";
            this.btnEmptyTable.Size = new System.Drawing.Size(53, 43);
            this.btnEmptyTable.TabIndex = 91;
            this.btnEmptyTable.UseVisualStyleBackColor = true;
            this.btnEmptyTable.Click += new System.EventHandler(this.btnEmptyTable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boşMasaListesiToolStripMenuItem,
            this.doluMasaListesiToolStripMenuItem,
            this.masaDüzenlemeSayfasıToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 70);
            // 
            // boşMasaListesiToolStripMenuItem
            // 
            this.boşMasaListesiToolStripMenuItem.Name = "boşMasaListesiToolStripMenuItem";
            this.boşMasaListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.boşMasaListesiToolStripMenuItem.Text = "Boş Masa Listesi";
            this.boşMasaListesiToolStripMenuItem.Click += new System.EventHandler(this.boşMasaListesiToolStripMenuItem_Click);
            // 
            // doluMasaListesiToolStripMenuItem
            // 
            this.doluMasaListesiToolStripMenuItem.Name = "doluMasaListesiToolStripMenuItem";
            this.doluMasaListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.doluMasaListesiToolStripMenuItem.Text = "Dolu Masa Listesi";
            this.doluMasaListesiToolStripMenuItem.Click += new System.EventHandler(this.doluMasaListesiToolStripMenuItem_Click);
            // 
            // masaDüzenlemeSayfasıToolStripMenuItem
            // 
            this.masaDüzenlemeSayfasıToolStripMenuItem.Name = "masaDüzenlemeSayfasıToolStripMenuItem";
            this.masaDüzenlemeSayfasıToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.masaDüzenlemeSayfasıToolStripMenuItem.Text = "Masa Düzenleme Sayfası";
            this.masaDüzenlemeSayfasıToolStripMenuItem.Click += new System.EventHandler(this.masaDüzenlemeSayfasıToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(823, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 43);
            this.btnEdit.TabIndex = 90;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(902, 492);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFullTable);
            this.Controls.Add(this.btnEmptyTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtGridTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa ve Müşteri Listesi";
            this.Load += new System.EventHandler(this.TableList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridTable;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdated;
        private System.Windows.Forms.RadioButton radioStatus;
        private System.Windows.Forms.RadioButton radioTableNo;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioRezerve;
        private System.Windows.Forms.RadioButton radioPaid;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioDrink;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFullTable;
        private System.Windows.Forms.Button btnEmptyTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boşMasaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doluMasaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaDüzenlemeSayfasıToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
    }
}
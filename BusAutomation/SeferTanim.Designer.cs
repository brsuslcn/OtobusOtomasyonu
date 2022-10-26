namespace OtobusFirmasi
{
    partial class SeferTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeferTanim));
            this.cmbBaslaBit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtoTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDurakBit = new System.Windows.Forms.ComboBox();
            this.SeferTbt = new System.Windows.Forms.Button();
            this.DTime1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBaslaBit
            // 
            this.cmbBaslaBit.BackColor = System.Drawing.Color.Black;
            this.cmbBaslaBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBaslaBit.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbBaslaBit.FormattingEnabled = true;
            this.cmbBaslaBit.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbBaslaBit.Location = new System.Drawing.Point(106, 42);
            this.cmbBaslaBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaslaBit.Name = "cmbBaslaBit";
            this.cmbBaslaBit.Size = new System.Drawing.Size(225, 26);
            this.cmbBaslaBit.Sorted = true;
            this.cmbBaslaBit.TabIndex = 0;
            this.cmbBaslaBit.SelectedIndexChanged += new System.EventHandler(this.cmbBaslaBit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlanacak Durak";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOtoTip
            // 
            this.cmbOtoTip.BackColor = System.Drawing.Color.Black;
            this.cmbOtoTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOtoTip.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbOtoTip.FormattingEnabled = true;
            this.cmbOtoTip.Items.AddRange(new object[] {
            "Neoplan",
            "Setra",
            "Mercedes Benz 403",
            "Mercedes Benz SHD15",
            "Mercedes Benz SHD17"});
            this.cmbOtoTip.Location = new System.Drawing.Point(107, 226);
            this.cmbOtoTip.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOtoTip.Name = "cmbOtoTip";
            this.cmbOtoTip.Size = new System.Drawing.Size(225, 26);
            this.cmbOtoTip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(101, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanımlanacak Araç";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbSeans
            // 
            this.cmbSeans.BackColor = System.Drawing.Color.Black;
            this.cmbSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSeans.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "09:00",
            "10:00",
            "11:30",
            "12:00",
            "12:30",
            "13:30",
            "14:30",
            "15:00",
            "16:00",
            "18:00",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "22:30",
            "23:00"});
            this.cmbSeans.Location = new System.Drawing.Point(107, 404);
            this.cmbSeans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(225, 26);
            this.cmbSeans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(102, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sefer Saati";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(101, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitecek Durak";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbDurakBit
            // 
            this.cmbDurakBit.BackColor = System.Drawing.Color.Black;
            this.cmbDurakBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurakBit.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbDurakBit.FormattingEnabled = true;
            this.cmbDurakBit.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbDurakBit.Location = new System.Drawing.Point(107, 126);
            this.cmbDurakBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDurakBit.Name = "cmbDurakBit";
            this.cmbDurakBit.Size = new System.Drawing.Size(225, 26);
            this.cmbDurakBit.Sorted = true;
            this.cmbDurakBit.TabIndex = 8;
            // 
            // SeferTbt
            // 
            this.SeferTbt.BackColor = System.Drawing.Color.Black;
            this.SeferTbt.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeferTbt.ForeColor = System.Drawing.SystemColors.Control;
            this.SeferTbt.Location = new System.Drawing.Point(625, 149);
            this.SeferTbt.Margin = new System.Windows.Forms.Padding(4);
            this.SeferTbt.Name = "SeferTbt";
            this.SeferTbt.Size = new System.Drawing.Size(271, 159);
            this.SeferTbt.TabIndex = 10;
            this.SeferTbt.Text = "Seferi Tanımla";
            this.SeferTbt.UseVisualStyleBackColor = false;
            this.SeferTbt.Click += new System.EventHandler(this.SeferTbt_Click);
            // 
            // DTime1
            // 
            this.DTime1.CustomFormat = "";
            this.DTime1.Location = new System.Drawing.Point(107, 322);
            this.DTime1.Name = "DTime1";
            this.DTime1.Size = new System.Drawing.Size(215, 22);
            this.DTime1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(102, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sefer Tarihi";
            // 
            // SeferTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTime1);
            this.Controls.Add(this.SeferTbt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDurakBit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSeans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOtoTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaslaBit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeferTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Tanımlama Paneli";
            this.Load += new System.EventHandler(this.SeferTanim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBaslaBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtoTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDurakBit;
        private System.Windows.Forms.Button SeferTbt;
        private System.Windows.Forms.DateTimePicker DTime1;
        private System.Windows.Forms.Label label4;
    }
}
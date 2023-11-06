namespace PlakDukkaniiUI
{
    partial class FormMainPage
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
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Musician = new Label();
            label1 = new Label();
            txt_AlbumName = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_Discounted = new Button();
            btn_Top10 = new Button();
            btn_OnSale = new Button();
            btn_NotForSale = new Button();
            btn_GetAll = new Button();
            btn_delete = new Button();
            rdb_notsale = new RadioButton();
            rdb_onsale = new RadioButton();
            nud_dsc = new NumericUpDown();
            dtp_rlsdate = new DateTimePicker();
            txt_musiciannn = new TextBox();
            txt_price = new TextBox();
            txt_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_dsc).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 65);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 262);
            dataGridView1.TabIndex = 29;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 248);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 28;
            label7.Text = "Satış Durumu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 211);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 27;
            label6.Text = "İndirim Oranı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 135);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 26;
            label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 165);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 25;
            label4.Text = "Fiyat";
            // 
            // txt_Musician
            // 
            txt_Musician.AutoSize = true;
            txt_Musician.Location = new Point(26, 86);
            txt_Musician.Name = "txt_Musician";
            txt_Musician.Size = new Size(57, 15);
            txt_Musician.TabIndex = 24;
            txt_Musician.Text = "Müzisyen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(460, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 23;
            label1.Text = "Albümler";
            // 
            // txt_AlbumName
            // 
            txt_AlbumName.AutoSize = true;
            txt_AlbumName.Location = new Point(26, 54);
            txt_AlbumName.Name = "txt_AlbumName";
            txt_AlbumName.Size = new Size(64, 15);
            txt_AlbumName.TabIndex = 22;
            txt_AlbumName.Text = "Albüm Adi";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(78, 305);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(82, 22);
            btn_add.TabIndex = 20;
            btn_add.Text = "Ekle";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(182, 305);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(82, 22);
            btn_update.TabIndex = 19;
            btn_update.Text = "Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Discounted
            // 
            btn_Discounted.Location = new Point(903, 339);
            btn_Discounted.Margin = new Padding(3, 2, 3, 2);
            btn_Discounted.Name = "btn_Discounted";
            btn_Discounted.Size = new Size(111, 41);
            btn_Discounted.TabIndex = 21;
            btn_Discounted.Text = "İndirimli Albümler";
            btn_Discounted.UseVisualStyleBackColor = true;
            btn_Discounted.Click += btn_Discounted_Click;
            // 
            // btn_Top10
            // 
            btn_Top10.Location = new Point(790, 339);
            btn_Top10.Margin = new Padding(3, 2, 3, 2);
            btn_Top10.Name = "btn_Top10";
            btn_Top10.Size = new Size(108, 41);
            btn_Top10.TabIndex = 18;
            btn_Top10.Text = "En Yeni 10 Albüm";
            btn_Top10.UseVisualStyleBackColor = true;
            btn_Top10.Click += btn_Top10_Click;
            // 
            // btn_OnSale
            // 
            btn_OnSale.Location = new Point(682, 339);
            btn_OnSale.Margin = new Padding(3, 2, 3, 2);
            btn_OnSale.Name = "btn_OnSale";
            btn_OnSale.Size = new Size(102, 41);
            btn_OnSale.TabIndex = 17;
            btn_OnSale.Text = "Satışı Devam Eden Albümler";
            btn_OnSale.UseVisualStyleBackColor = true;
            btn_OnSale.Click += btn_OnSale_Click;
            // 
            // btn_NotForSale
            // 
            btn_NotForSale.Location = new Point(568, 339);
            btn_NotForSale.Margin = new Padding(3, 2, 3, 2);
            btn_NotForSale.Name = "btn_NotForSale";
            btn_NotForSale.Size = new Size(108, 41);
            btn_NotForSale.TabIndex = 16;
            btn_NotForSale.Text = "Satışı Duran Albümler";
            btn_NotForSale.UseVisualStyleBackColor = true;
            btn_NotForSale.Click += btn_NotForSale_Click;
            // 
            // btn_GetAll
            // 
            btn_GetAll.Location = new Point(460, 339);
            btn_GetAll.Margin = new Padding(3, 2, 3, 2);
            btn_GetAll.Name = "btn_GetAll";
            btn_GetAll.Size = new Size(100, 41);
            btn_GetAll.TabIndex = 15;
            btn_GetAll.Text = "Tümünü Göster";
            btn_GetAll.UseVisualStyleBackColor = true;
            btn_GetAll.Click += btn_GetAll_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(291, 305);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(82, 22);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // rdb_notsale
            // 
            rdb_notsale.AutoSize = true;
            rdb_notsale.Location = new Point(293, 245);
            rdb_notsale.Margin = new Padding(3, 2, 3, 2);
            rdb_notsale.Name = "rdb_notsale";
            rdb_notsale.Size = new Size(89, 19);
            rdb_notsale.TabIndex = 13;
            rdb_notsale.TabStop = true;
            rdb_notsale.Text = "Satışta Değil";
            rdb_notsale.UseVisualStyleBackColor = true;
            // 
            // rdb_onsale
            // 
            rdb_onsale.AutoSize = true;
            rdb_onsale.Location = new Point(147, 245);
            rdb_onsale.Margin = new Padding(3, 2, 3, 2);
            rdb_onsale.Name = "rdb_onsale";
            rdb_onsale.Size = new Size(59, 19);
            rdb_onsale.TabIndex = 12;
            rdb_onsale.TabStop = true;
            rdb_onsale.Text = "Satışta";
            rdb_onsale.UseVisualStyleBackColor = true;
            // 
            // nud_dsc
            // 
            nud_dsc.Location = new Point(154, 206);
            nud_dsc.Margin = new Padding(3, 2, 3, 2);
            nud_dsc.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nud_dsc.Name = "nud_dsc";
            nud_dsc.Size = new Size(131, 23);
            nud_dsc.TabIndex = 11;
            // 
            // dtp_rlsdate
            // 
            dtp_rlsdate.Location = new Point(154, 130);
            dtp_rlsdate.Margin = new Padding(3, 2, 3, 2);
            dtp_rlsdate.Name = "dtp_rlsdate";
            dtp_rlsdate.Size = new Size(219, 23);
            dtp_rlsdate.TabIndex = 10;
            // 
            // txt_musiciannn
            // 
            txt_musiciannn.Location = new Point(155, 86);
            txt_musiciannn.Margin = new Padding(3, 2, 3, 2);
            txt_musiciannn.Name = "txt_musiciannn";
            txt_musiciannn.Size = new Size(110, 23);
            txt_musiciannn.TabIndex = 8;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(155, 165);
            txt_price.Margin = new Padding(3, 2, 3, 2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(110, 23);
            txt_price.TabIndex = 9;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(155, 54);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(110, 23);
            txt_name.TabIndex = 7;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 442);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_Musician);
            Controls.Add(label1);
            Controls.Add(txt_AlbumName);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_Discounted);
            Controls.Add(btn_Top10);
            Controls.Add(btn_OnSale);
            Controls.Add(btn_NotForSale);
            Controls.Add(btn_GetAll);
            Controls.Add(btn_delete);
            Controls.Add(rdb_notsale);
            Controls.Add(rdb_onsale);
            Controls.Add(nud_dsc);
            Controls.Add(dtp_rlsdate);
            Controls.Add(txt_musiciannn);
            Controls.Add(txt_price);
            Controls.Add(txt_name);
            Name = "FormMainPage";
            Text = "FormMainPage";
            Load += FormMainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_dsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label txt_Musician;
        private Label label1;
        private Label txt_AlbumName;
        private Button btn_add;
        private Button btn_update;
        private Button btn_Discounted;
        private Button btn_Top10;
        private Button btn_OnSale;
        private Button btn_NotForSale;
        private Button btn_GetAll;
        private Button btn_delete;
        private RadioButton rdb_notsale;
        private RadioButton rdb_onsale;
        private NumericUpDown nud_dsc;
        private DateTimePicker dtp_rlsdate;
        private TextBox txt_musiciannn;
        private TextBox txt_price;
        private TextBox txt_name;
    }
}
namespace web_veri_cekme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listUrl = new System.Windows.Forms.ListBox();
            this.txtUrlEkle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnUrlEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGIlan = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.web_botDataSet = new web_veri_cekme.web_botDataSet();
            this.dataGData = new System.Windows.Forms.DataGridView();
            this.ilanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goruntulenmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdatailanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ilanTableAdapter = new web_veri_cekme.web_botDataSetTableAdapters.ilanTableAdapter();
            this.dataTableAdapter = new web_veri_cekme.web_botDataSetTableAdapters.dataTableAdapter();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtGonderici = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGIlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_botDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdatailanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUrl
            // 
            this.listUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.listUrl.FormattingEnabled = true;
            this.listUrl.Items.AddRange(new object[] {
            "https://www.arabam.com/ilan/galeriden-satilik-volkswagen-golf-1-4-tsi-allstar/vol" +
                "kswagen-golf-1-4-tsi-allstar-cam-tavan/15704962",
            "https://www.arabam.com/ilan/galeriden-satilik-jeep-grand-cherokee-4-7-limited/fal" +
                "sh-auto-guvencesiyle-grand-cherokee-4-7-limited/15761731",
            resources.GetString("listUrl.Items")});
            this.listUrl.Location = new System.Drawing.Point(3, 16);
            this.listUrl.Name = "listUrl";
            this.listUrl.Size = new System.Drawing.Size(903, 82);
            this.listUrl.TabIndex = 3;
            // 
            // txtUrlEkle
            // 
            this.txtUrlEkle.Location = new System.Drawing.Point(6, 102);
            this.txtUrlEkle.Name = "txtUrlEkle";
            this.txtUrlEkle.Size = new System.Drawing.Size(583, 20);
            this.txtUrlEkle.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikar);
            this.groupBox1.Controls.Add(this.btnUrlEkle);
            this.groupBox1.Controls.Add(this.txtUrlEkle);
            this.groupBox1.Controls.Add(this.listUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAKİP EDİLECEK ADRESLER";
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(676, 102);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 5;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnUrlEkle
            // 
            this.btnUrlEkle.Location = new System.Drawing.Point(595, 102);
            this.btnUrlEkle.Name = "btnUrlEkle";
            this.btnUrlEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrlEkle.TabIndex = 5;
            this.btnUrlEkle.Text = "EKLE";
            this.btnUrlEkle.UseVisualStyleBackColor = true;
            this.btnUrlEkle.Click += new System.EventHandler(this.btnUrlEkle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGIlan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 324);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 258);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dataGIlan
            // 
            this.dataGIlan.AutoGenerateColumns = false;
            this.dataGIlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGIlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.tarihiDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.seriDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.yakitDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn});
            this.dataGIlan.DataSource = this.ilanBindingSource;
            this.dataGIlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGIlan.Location = new System.Drawing.Point(3, 3);
            this.dataGIlan.Name = "dataGIlan";
            this.dataGIlan.Size = new System.Drawing.Size(903, 123);
            this.dataGIlan.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // tarihiDataGridViewTextBoxColumn
            // 
            this.tarihiDataGridViewTextBoxColumn.DataPropertyName = "tarihi";
            this.tarihiDataGridViewTextBoxColumn.HeaderText = "tarihi";
            this.tarihiDataGridViewTextBoxColumn.Name = "tarihiDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // seriDataGridViewTextBoxColumn
            // 
            this.seriDataGridViewTextBoxColumn.DataPropertyName = "seri";
            this.seriDataGridViewTextBoxColumn.HeaderText = "seri";
            this.seriDataGridViewTextBoxColumn.Name = "seriDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "yil";
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            // 
            // yakitDataGridViewTextBoxColumn
            // 
            this.yakitDataGridViewTextBoxColumn.DataPropertyName = "yakit";
            this.yakitDataGridViewTextBoxColumn.HeaderText = "yakit";
            this.yakitDataGridViewTextBoxColumn.Name = "yakitDataGridViewTextBoxColumn";
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "km";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            // 
            // ilanBindingSource
            // 
            this.ilanBindingSource.DataMember = "ilan";
            this.ilanBindingSource.DataSource = this.web_botDataSet;
            // 
            // web_botDataSet
            // 
            this.web_botDataSet.DataSetName = "web_botDataSet";
            this.web_botDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGData
            // 
            this.dataGData.AutoGenerateColumns = false;
            this.dataGData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilanidDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.goruntulenmeDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGData.DataSource = this.fKdatailanBindingSource;
            this.dataGData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGData.Location = new System.Drawing.Point(3, 132);
            this.dataGData.Name = "dataGData";
            this.dataGData.Size = new System.Drawing.Size(903, 123);
            this.dataGData.TabIndex = 1;
            // 
            // ilanidDataGridViewTextBoxColumn
            // 
            this.ilanidDataGridViewTextBoxColumn.DataPropertyName = "ilan_id";
            this.ilanidDataGridViewTextBoxColumn.HeaderText = "ilan_id";
            this.ilanidDataGridViewTextBoxColumn.Name = "ilanidDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // goruntulenmeDataGridViewTextBoxColumn
            // 
            this.goruntulenmeDataGridViewTextBoxColumn.DataPropertyName = "goruntulenme";
            this.goruntulenmeDataGridViewTextBoxColumn.HeaderText = "goruntulenme";
            this.goruntulenmeDataGridViewTextBoxColumn.Name = "goruntulenmeDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // fKdatailanBindingSource
            // 
            this.fKdatailanBindingSource.DataMember = "FK_data_ilan";
            this.fKdatailanBindingSource.DataSource = this.ilanBindingSource;
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ilanTableAdapter
            // 
            this.ilanTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // txtYuzde
            // 
            this.txtYuzde.Location = new System.Drawing.Point(62, 131);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(100, 20);
            this.txtYuzde.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "YÜZDE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBilgi);
            this.groupBox2.Controls.Add(this.txtAlici);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Controls.Add(this.txtGonderici);
            this.groupBox2.Location = new System.Drawing.Point(197, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 137);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MAİL GÖNDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "BİLGİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ALICI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GÖNDERİCİ:";
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(82, 97);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(100, 20);
            this.txtBilgi.TabIndex = 0;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(82, 73);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(100, 20);
            this.txtAlici.TabIndex = 0;
            this.txtAlici.Text = "robot.bk16@gmail.com";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(82, 47);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 0;
            // 
            // txtGonderici
            // 
            this.txtGonderici.Location = new System.Drawing.Point(82, 21);
            this.txtGonderici.Name = "txtGonderici";
            this.txtGonderici.Size = new System.Drawing.Size(100, 20);
            this.txtGonderici.TabIndex = 0;
            this.txtGonderici.Text = "bunyaminkuru32@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGIlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_botDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdatailanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listUrl;
        private System.Windows.Forms.TextBox txtUrlEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUrlEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGIlan;
        private System.Windows.Forms.DataGridView dataGData;
        private web_botDataSet web_botDataSet;
        private System.Windows.Forms.BindingSource ilanBindingSource;
        private web_botDataSetTableAdapters.ilanTableAdapter ilanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKdatailanBindingSource;
        private web_botDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goruntulenmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.TextBox txtGonderici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
    }
}


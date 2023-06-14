﻿
namespace Tatil_Rezervasyon_Otomasyonu
{
    partial class DemirciOtel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirciOtel));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişiSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ücretTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klimaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jakuziDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.demirciOtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yeni_Microsoft_Access_VeritabanıDataSet12 = new Tatil_Rezervasyon_Otomasyonu.Yeni_Microsoft_Access_VeritabanıDataSet12();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.demirci_OtelTableAdapter = new Tatil_Rezervasyon_Otomasyonu.Yeni_Microsoft_Access_VeritabanıDataSet12TableAdapters.Demirci_OtelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirciOtelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeni_Microsoft_Access_VeritabanıDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(882, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "DEMİRCİ OTEL ODALARI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaSayısıDataGridViewTextBoxColumn,
            this.odaTipiDataGridViewTextBoxColumn,
            this.kişiSayısıDataGridViewTextBoxColumn,
            this.ücretTLDataGridViewTextBoxColumn,
            this.klimaDataGridViewCheckBoxColumn,
            this.jakuziDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.demirciOtelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 339);
            this.dataGridView1.TabIndex = 38;
            // 
            // odaSayısıDataGridViewTextBoxColumn
            // 
            this.odaSayısıDataGridViewTextBoxColumn.DataPropertyName = "Oda Sayısı";
            this.odaSayısıDataGridViewTextBoxColumn.HeaderText = "Oda Sayısı";
            this.odaSayısıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaSayısıDataGridViewTextBoxColumn.Name = "odaSayısıDataGridViewTextBoxColumn";
            this.odaSayısıDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaTipiDataGridViewTextBoxColumn
            // 
            this.odaTipiDataGridViewTextBoxColumn.DataPropertyName = "Oda Tipi";
            this.odaTipiDataGridViewTextBoxColumn.HeaderText = "Oda Tipi";
            this.odaTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaTipiDataGridViewTextBoxColumn.Name = "odaTipiDataGridViewTextBoxColumn";
            this.odaTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kişiSayısıDataGridViewTextBoxColumn
            // 
            this.kişiSayısıDataGridViewTextBoxColumn.DataPropertyName = "Kişi Sayısı";
            this.kişiSayısıDataGridViewTextBoxColumn.HeaderText = "Kişi Sayısı";
            this.kişiSayısıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kişiSayısıDataGridViewTextBoxColumn.Name = "kişiSayısıDataGridViewTextBoxColumn";
            this.kişiSayısıDataGridViewTextBoxColumn.Width = 125;
            // 
            // ücretTLDataGridViewTextBoxColumn
            // 
            this.ücretTLDataGridViewTextBoxColumn.DataPropertyName = "Ücret (TL)";
            this.ücretTLDataGridViewTextBoxColumn.HeaderText = "Ücret (TL)";
            this.ücretTLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ücretTLDataGridViewTextBoxColumn.Name = "ücretTLDataGridViewTextBoxColumn";
            this.ücretTLDataGridViewTextBoxColumn.Width = 125;
            // 
            // klimaDataGridViewCheckBoxColumn
            // 
            this.klimaDataGridViewCheckBoxColumn.DataPropertyName = "Klima";
            this.klimaDataGridViewCheckBoxColumn.HeaderText = "Klima";
            this.klimaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.klimaDataGridViewCheckBoxColumn.Name = "klimaDataGridViewCheckBoxColumn";
            this.klimaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // jakuziDataGridViewCheckBoxColumn
            // 
            this.jakuziDataGridViewCheckBoxColumn.DataPropertyName = "Jakuzi";
            this.jakuziDataGridViewCheckBoxColumn.HeaderText = "Jakuzi";
            this.jakuziDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.jakuziDataGridViewCheckBoxColumn.Name = "jakuziDataGridViewCheckBoxColumn";
            this.jakuziDataGridViewCheckBoxColumn.Width = 125;
            // 
            // demirciOtelBindingSource
            // 
            this.demirciOtelBindingSource.DataMember = "Demirci Otel";
            this.demirciOtelBindingSource.DataSource = this.yeni_Microsoft_Access_VeritabanıDataSet12;
            // 
            // yeni_Microsoft_Access_VeritabanıDataSet12
            // 
            this.yeni_Microsoft_Access_VeritabanıDataSet12.DataSetName = "Yeni_Microsoft_Access_VeritabanıDataSet12";
            this.yeni_Microsoft_Access_VeritabanıDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(1025, 53);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(54, 57);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 235;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Click += new System.EventHandler(this.pictureBox28_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1085, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 234;
            this.label2.Text = "Çıkış Yap";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(71, 27);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(112, 83);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 231;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.pictureBox26_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(189, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 32);
            this.label10.TabIndex = 233;
            this.label10.Text = "VocationLocation.com";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(49, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1140, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 232;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(67, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 236;
            this.label14.Text = "<<Geri";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // demirci_OtelTableAdapter
            // 
            this.demirci_OtelTableAdapter.ClearBeforeFill = true;
            // 
            // DemirciOtel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1275, 604);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DemirciOtel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DemirciOtel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirciOtelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeni_Microsoft_Access_VeritabanıDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        private Yeni_Microsoft_Access_VeritabanıDataSet12 yeni_Microsoft_Access_VeritabanıDataSet12;
        private System.Windows.Forms.BindingSource demirciOtelBindingSource;
        private Yeni_Microsoft_Access_VeritabanıDataSet12TableAdapters.Demirci_OtelTableAdapter demirci_OtelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişiSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ücretTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn klimaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jakuziDataGridViewCheckBoxColumn;
    }
}
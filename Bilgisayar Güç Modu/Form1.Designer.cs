namespace Bilgisayar_Güç_Modu
{
    partial class BilgisayarGucModu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgisayarGucModu));
            this.lstIslem = new System.Windows.Forms.ListBox();
            this.lstDakika = new System.Windows.Forms.ListBox();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.lblBilgi1 = new System.Windows.Forms.Label();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.lblBilgi3 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblIsaret1 = new System.Windows.Forms.Label();
            this.lblIsaret2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpSaat = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpSaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIslem
            // 
            this.lstIslem.BackColor = System.Drawing.Color.ForestGreen;
            this.lstIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIslem.ForeColor = System.Drawing.Color.White;
            this.lstIslem.FormattingEnabled = true;
            this.lstIslem.ItemHeight = 16;
            this.lstIslem.Items.AddRange(new object[] {
            "Bilgisayarı Kapat",
            "Uykuya Al",
            "Oturumu Kilitle",
            "Yeniden Başlat"});
            this.lstIslem.Location = new System.Drawing.Point(38, 37);
            this.lstIslem.Name = "lstIslem";
            this.lstIslem.Size = new System.Drawing.Size(123, 68);
            this.lstIslem.TabIndex = 1;
            this.lstIslem.SelectedValueChanged += new System.EventHandler(this.lstIslem_SelectedValueChanged);
            // 
            // lstDakika
            // 
            this.lstDakika.BackColor = System.Drawing.Color.ForestGreen;
            this.lstDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDakika.ForeColor = System.Drawing.Color.White;
            this.lstDakika.FormattingEnabled = true;
            this.lstDakika.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDakika.ItemHeight = 16;
            this.lstDakika.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "60"});
            this.lstDakika.Location = new System.Drawing.Point(201, 37);
            this.lstDakika.Name = "lstDakika";
            this.lstDakika.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstDakika.Size = new System.Drawing.Size(45, 116);
            this.lstDakika.TabIndex = 2;
            this.lstDakika.SelectedIndexChanged += new System.EventHandler(this.lstDakika_SelectedIndexChanged);
            // 
            // txtDakika
            // 
            this.txtDakika.BackColor = System.Drawing.Color.ForestGreen;
            this.txtDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDakika.ForeColor = System.Drawing.Color.White;
            this.txtDakika.Location = new System.Drawing.Point(88, 180);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(73, 24);
            this.txtDakika.TabIndex = 0;
            this.txtDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDakika.TextChanged += new System.EventHandler(this.txtDakika_TextChanged);
            this.txtDakika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDakika_KeyPress);
            // 
            // lblBilgi1
            // 
            this.lblBilgi1.AutoSize = true;
            this.lblBilgi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi1.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi1.Location = new System.Drawing.Point(35, 19);
            this.lblBilgi1.Name = "lblBilgi1";
            this.lblBilgi1.Size = new System.Drawing.Size(149, 15);
            this.lblBilgi1.TabIndex = 4;
            this.lblBilgi1.Text = "Yapmak istediğiniz işlem :";
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.lblBilgi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi2.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi2.Location = new System.Drawing.Point(198, 19);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(213, 15);
            this.lblBilgi2.TabIndex = 5;
            this.lblBilgi2.Text = "Kaç dakika sonra işlem gerçekleşsin?";
            // 
            // lblBilgi3
            // 
            this.lblBilgi3.AutoSize = true;
            this.lblBilgi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi3.ForeColor = System.Drawing.Color.Maroon;
            this.lblBilgi3.Location = new System.Drawing.Point(35, 162);
            this.lblBilgi3.Name = "lblBilgi3";
            this.lblBilgi3.Size = new System.Drawing.Size(213, 15);
            this.lblBilgi3.TabIndex = 6;
            this.lblBilgi3.Text = "Kendi dakikanızı belirlemek için girin :";
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(65, 29);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(30, 29);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaat.UseCompatibleTextRendering = true;
            this.lblSaat.UseMnemonic = false;
            // 
            // lblDakika
            // 
            this.lblDakika.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(114, 29);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(30, 29);
            this.lblDakika.TabIndex = 8;
            this.lblDakika.Text = "00";
            this.lblDakika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDakika.UseCompatibleTextRendering = true;
            // 
            // lblSaniye
            // 
            this.lblSaniye.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(163, 29);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(30, 29);
            this.lblSaniye.TabIndex = 9;
            this.lblSaniye.Text = "00";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaniye.UseCompatibleTextRendering = true;
            // 
            // lblIsaret1
            // 
            this.lblIsaret1.AutoSize = true;
            this.lblIsaret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsaret1.Location = new System.Drawing.Point(98, 35);
            this.lblIsaret1.Name = "lblIsaret1";
            this.lblIsaret1.Size = new System.Drawing.Size(13, 17);
            this.lblIsaret1.TabIndex = 10;
            this.lblIsaret1.Text = ":";
            // 
            // lblIsaret2
            // 
            this.lblIsaret2.AutoSize = true;
            this.lblIsaret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsaret2.Location = new System.Drawing.Point(147, 35);
            this.lblIsaret2.Name = "lblIsaret2";
            this.lblIsaret2.Size = new System.Drawing.Size(13, 17);
            this.lblIsaret2.TabIndex = 11;
            this.lblIsaret2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpSaat
            // 
            this.grpSaat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpSaat.Controls.Add(this.lblSaat);
            this.grpSaat.Controls.Add(this.lblIsaret2);
            this.grpSaat.Controls.Add(this.lblDakika);
            this.grpSaat.Controls.Add(this.lblIsaret1);
            this.grpSaat.Controls.Add(this.lblSaniye);
            this.grpSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSaat.Location = new System.Drawing.Point(38, 218);
            this.grpSaat.Name = "grpSaat";
            this.grpSaat.Size = new System.Drawing.Size(259, 69);
            this.grpSaat.TabIndex = 12;
            this.grpSaat.TabStop = false;
            this.grpSaat.Text = "İşlemin gerçekleşmesine kalan süre";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(314, 162);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(45, 125);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İ\r\nP\r\nT\r\nA\r\nL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 400;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(365, 37);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 250);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Ç\r\nI\r\nK\r\nI\r\nŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // BilgisayarGucModu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(421, 319);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.grpSaat);
            this.Controls.Add(this.lblBilgi3);
            this.Controls.Add(this.lblBilgi2);
            this.Controls.Add(this.lblBilgi1);
            this.Controls.Add(this.txtDakika);
            this.Controls.Add(this.lstDakika);
            this.Controls.Add(this.lstIslem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BilgisayarGucModu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Güç Modu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpSaat.ResumeLayout(false);
            this.grpSaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIslem;
        private System.Windows.Forms.ListBox lstDakika;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.Label lblBilgi1;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.Label lblBilgi3;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblIsaret1;
        private System.Windows.Forms.Label lblIsaret2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpSaat;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


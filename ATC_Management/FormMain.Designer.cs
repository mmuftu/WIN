namespace ATC_Management
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            komutlarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_CihazBilgileriSorgula = new ToolStripMenuItem();
            ıPPortSorgulaToolStripMenuItem = new ToolStripMenuItem();
            sunucuSifreBilgileriGönderToolStripMenuItem = new ToolStripMenuItem();
            apnAyariGonderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { komutlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip_ATC";
            // 
            // komutlarToolStripMenuItem
            // 
            komutlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_CihazBilgileriSorgula, ıPPortSorgulaToolStripMenuItem, sunucuSifreBilgileriGönderToolStripMenuItem, apnAyariGonderToolStripMenuItem });
            komutlarToolStripMenuItem.Name = "komutlarToolStripMenuItem";
            komutlarToolStripMenuItem.Size = new Size(68, 20);
            komutlarToolStripMenuItem.Text = "Komutlar";
            // 
            // toolStripMenuItem_CihazBilgileriSorgula
            // 
            toolStripMenuItem_CihazBilgileriSorgula.Name = "toolStripMenuItem_CihazBilgileriSorgula";
            toolStripMenuItem_CihazBilgileriSorgula.Size = new Size(224, 22);
            toolStripMenuItem_CihazBilgileriSorgula.Text = "Cihaz Bilgileri Sorgula";
            toolStripMenuItem_CihazBilgileriSorgula.Click += toolStripMenuItem_CihazBilgileriSorgula_Click;
            // 
            // ıPPortSorgulaToolStripMenuItem
            // 
            ıPPortSorgulaToolStripMenuItem.Name = "ıPPortSorgulaToolStripMenuItem";
            ıPPortSorgulaToolStripMenuItem.Size = new Size(224, 22);
            ıPPortSorgulaToolStripMenuItem.Text = "IP Port Sorgula";
            ıPPortSorgulaToolStripMenuItem.Click += ıPPortSorgulaToolStripMenuItem_Click;
            // 
            // sunucuSifreBilgileriGönderToolStripMenuItem
            // 
            sunucuSifreBilgileriGönderToolStripMenuItem.Name = "sunucuSifreBilgileriGönderToolStripMenuItem";
            sunucuSifreBilgileriGönderToolStripMenuItem.Size = new Size(224, 22);
            sunucuSifreBilgileriGönderToolStripMenuItem.Text = "Sunucu Şifre Bilgileri Gönder";
            sunucuSifreBilgileriGönderToolStripMenuItem.Click += sunucuSifreBilgileriGönderToolStripMenuItem_Click;
            // 
            // apnAyariGonderToolStripMenuItem
            // 
            apnAyariGonderToolStripMenuItem.Name = "apnAyariGonderToolStripMenuItem";
            apnAyariGonderToolStripMenuItem.Size = new Size(224, 22);
            apnAyariGonderToolStripMenuItem.Text = "Apn Ayarı Gönder";
            apnAyariGonderToolStripMenuItem.Click += apnAyariGonderToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "ATC_Management";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem komutlarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_CihazBilgileriSorgula;
        private ToolStripMenuItem ıPPortSorgulaToolStripMenuItem;
        private ToolStripMenuItem sunucuSifreBilgileriGönderToolStripMenuItem;
        private ToolStripMenuItem apnAyariGonderToolStripMenuItem;
    }
}

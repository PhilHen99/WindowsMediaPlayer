namespace WindowsMediaPlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbPlaylist = new System.Windows.Forms.ListBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldur = new System.Windows.Forms.Label();
            this.tmrWMP = new System.Windows.Forms.Timer(this.components);
            this.WinMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinMP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCarpetaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarCarpetaToolStripMenuItem
            // 
            this.cargarCarpetaToolStripMenuItem.Name = "cargarCarpetaToolStripMenuItem";
            this.cargarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cargarCarpetaToolStripMenuItem.Text = "Cargar carpeta";
            this.cargarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.MStrpLoadFolderEvent);
            // 
            // LbPlaylist
            // 
            this.LbPlaylist.FormattingEnabled = true;
            this.LbPlaylist.Location = new System.Drawing.Point(887, 12);
            this.LbPlaylist.Name = "LbPlaylist";
            this.LbPlaylist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbPlaylist.Size = new System.Drawing.Size(231, 667);
            this.LbPlaylist.TabIndex = 2;
            this.LbPlaylist.SelectedIndexChanged += new System.EventHandler(this.PlaylistChg);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 693);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(50, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Nombre: ";
            // 
            // lbldur
            // 
            this.lbldur.AutoSize = true;
            this.lbldur.Location = new System.Drawing.Point(884, 693);
            this.lbldur.Name = "lbldur";
            this.lbldur.Size = new System.Drawing.Size(65, 13);
            this.lbldur.TabIndex = 4;
            this.lbldur.Text = "Duración:  0";
            // 
            // tmrWMP
            // 
            this.tmrWMP.Tick += new System.EventHandler(this.TmrEvent);
            // 
            // WinMP
            // 
            this.WinMP.Enabled = true;
            this.WinMP.Location = new System.Drawing.Point(12, 27);
            this.WinMP.Name = "WinMP";
            this.WinMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMP.OcxState")));
            this.WinMP.Size = new System.Drawing.Size(869, 652);
            this.WinMP.TabIndex = 1;
            this.WinMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MPStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 715);
            this.Controls.Add(this.lbldur);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.LbPlaylist);
            this.Controls.Add(this.WinMP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCarpetaToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer WinMP;
        private System.Windows.Forms.ListBox LbPlaylist;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldur;
        private System.Windows.Forms.Timer tmrWMP;
    }
}


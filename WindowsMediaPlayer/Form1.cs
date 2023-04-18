using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsMediaPlayer
{
    public partial class Form1 : Form
    {
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void MStrpLoadFolderEvent(object sender, EventArgs e)
        {
            WinMP.Ctlcontrols.stop();
            if (filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;
                LbPlaylist.Items.Clear();
                currentFile = 0;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm") || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv") || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();
                LoadPlaylist();
            }
        }

        private void MPStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 0)
            {
                // undefined loaded
                lbldur.Text = "El reproductor está listo para ser usado";
            }
            else if (e.newState == 1)
            {
                // video stopped
                lbldur.Text = "El reproductor se ha detenido";
            }
            else if (e.newState == 3)
            {
                // media playing currently
                lbldur.Text = "Duración : " + WinMP.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // end of queue of videos
                if (currentFile >= filteredFiles.Count - 1)
                {
                    currentFile = 0;
                }
                else
                {
                    currentFile += 1;
                }
                LbPlaylist.SelectedIndex = currentFile;
                FileName(lblname);
            }
            else if (e.newState == 9)
            {
                // message for video charging
                lbldur.Text = "Cargando video";
            }
            else if (e.newState == 10)
            {
                // With this you can restart the current file playing
                tmrWMP.Start();
            }
        }

        private void PlaylistChg(object sender, EventArgs e)
        {
            currentFile = LbPlaylist.SelectedIndex;
            PlayArchive(LbPlaylist.SelectedItem.ToString());
            FileName(lblname);
        }

        private void TmrEvent(object sender, EventArgs e)
        {
            WinMP.Ctlcontrols.play();
            tmrWMP.Stop();
        }
        private void LoadPlaylist()
        {
            WinMP.currentPlaylist = WinMP.newPlaylist("PlayList", "");

            foreach (string videos in filteredFiles)
            {
                WinMP.currentPlaylist.appendItem(WinMP.newMedia(videos));
                LbPlaylist.Items.Add(videos);
            }
            if (filteredFiles.Count > 0)
            {
                lblname.Text = "Archivos encontrados" + filteredFiles.Count;
                LbPlaylist.SelectedIndex = currentFile;
                PlayArchive(LbPlaylist.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No hay videos en esta carpeta");
            }
        }
        private void PlayArchive(string url)
        {
            WinMP.URL = url;
        }
        private void FileName(Label name)
        {
            string file = Path.GetFileName(LbPlaylist.SelectedItem.ToString());
            name.Text = "Reproduciendo: " + file;
        }
    }
}

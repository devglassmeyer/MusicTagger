using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTagger
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// True if we are loading data into controls; check if we don't want to do any processing while loading
        /// </summary>
        bool _loading_data = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGetAlbumDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the parent folder folder";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    txtAlbumDir.Text = selectedPath;
                    get_songs_in_dir(selectedPath);
                }
            }
        }
        private void lstSongs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_loading_data) return;

            if (lstSongs.SelectedItem != null)
            {
                get_song_details();
            }
        }

        private void get_song_details()
        {
            string full_song_path = get_selected_filename();
            if ((full_song_path == null) || (full_song_path.Trim() == "")) return;

            txtSongDetails.Text = "";

            txtSongDetails.Text = "Song: " + full_song_path + "\r\n";
        }

        private void get_songs_in_dir(string song_dir)
        {
            if ((song_dir == null) || (song_dir.Trim() == "")) return;
            if (System.IO.Path.Exists(song_dir))
            {
                _loading_data = true;
                lstSongs.Items.Clear();
                string[] files_in_dir = Directory.GetFiles(song_dir);
                if (files_in_dir.Length > 0)
                {
                    foreach (string a_file in files_in_dir)
                    {
                        if (a_file.ToLower().EndsWith(".flac"))
                        {
                            lstSongs.Items.Add(Path.GetFileName(a_file));
                        }
                    }
                }
                _loading_data = false;
            }

        }

        private string get_selected_filename()
        {
            if (lstSongs.SelectedItems.Count == 0) return "";

            string full_file_name = System.IO.Path.Combine(txtAlbumDir.Text, lstSongs.SelectedItem.ToString());

            if (System.IO.File.Exists(full_file_name))
            {
                return full_file_name;
            }
            return "";
        }


    }
}

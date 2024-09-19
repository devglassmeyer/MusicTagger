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
using TagLib;

namespace MusicTagger
{
    public partial class frmFindMissingArt : Form
    {
        private bool is_song(string song_path)
        {
            return song_path.ToLower().EndsWith(".flac");
        }
        private bool has_art(string song_path)
        {
            TagLib.File tag_file;

            try
            {
                tag_file = TagLib.File.Create(song_path);
            }
            catch (UnsupportedFormatException)
            {
                throw new Exception("Invalid song file: " + song_path);
            }
            IPicture[] pictures = tag_file.Tag.Pictures;
            return pictures.Length > 0;
        }
        private void find_missing_art()
        {
            lstArtistAlbumsMissingArt.Items.Clear();
            txtOutput.Text = "";
            if (!Directory.Exists(txtAlbumDir.Text)) return;

            string[] artist_dirs = Directory.GetDirectories(txtAlbumDir.Text);

            if (artist_dirs.Length == 0) return;

            foreach (string an_artist_dir in artist_dirs)
            {
                string[] album_dirs_for_artist = Directory.GetDirectories(an_artist_dir);
                if (album_dirs_for_artist.Length == 0) continue;

                DirectoryInfo artist_dir = new DirectoryInfo(an_artist_dir);
                string name_of_artist = artist_dir.Name;
                foreach (var album_dir in album_dirs_for_artist)
                {
                    DirectoryInfo album_di = new DirectoryInfo(album_dir);
                    string name_of_album = album_di.Name;
                    string[] songs_in_dir = Directory.GetFiles(album_dir);
                    foreach (var a_song in songs_in_dir)
                    {
                        if (is_song(a_song) && !has_art(a_song))
                        {
                            lstArtistAlbumsMissingArt.Items.Add(album_dir);
                            if (lstArtistAlbumsMissingArt.Items.Count > 1)
                            {
                                txtOutput.Text += "\r\n" + album_dir;
                            }
                            else
                            {
                                txtOutput.Text = album_dir;
                            }
                            break;
                        }
                    }
                }
            }
        }

        public frmFindMissingArt()
        {
            InitializeComponent();
        }

        private void btnGetAlbumDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the folder containing artists\\albums\\songs sub-folders";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    txtAlbumDir.Text = selectedPath;
                    find_missing_art();
                }
            }
        }

        private void set_art_for_album(string album_path, string art_file)
        {
            string[] song_files = Directory.GetFiles(album_path, "*.flac");
            TagLib.Picture album_art_pic = new TagLib.Picture(art_file);
            TagLib.Picture[] pics = new Picture[1];
            pics[0] = album_art_pic;

            foreach (string a_song_file in song_files)
            {
                TagLib.File tag_file;
                try
                {
                    tag_file = TagLib.File.Create(a_song_file);
                }
                catch (UnsupportedFormatException)
                {
                    throw new Exception("Invalid song file: " + a_song_file);
                }
                if (tag_file.Tag.Pictures.Length == 0)
                {
                    tag_file.Tag.Pictures = pics;
                    tag_file.Save();
                }
            }
            

        }

        private void btnFixMissingArt_Click(object sender, EventArgs e)
        {
            if (lstArtistAlbumsMissingArt.Items.Count == 0) return;

            foreach (string album_path in lstArtistAlbumsMissingArt.Items)
            {
                string[] art_files = Directory.GetFiles(album_path, "*.jpg");
                if (art_files.Length > 0)
                {
                    set_art_for_album(album_path, art_files[0]);
                }
            }
        }
    }
}

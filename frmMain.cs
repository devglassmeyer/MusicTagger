using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Matroska;

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

            paint_file_info("Song: " + full_song_path);
            TagLib.File tag_file;

            try
            {
                tag_file = TagLib.File.Create(full_song_path);
            }
            catch (UnsupportedFormatException)
            {
                paint_file_info("ERROR!");
                paint_file_info("");
                paint_file_info("UNSUPPORTED FILE");
                return;
            }

            paint_file_info("");
            paint_file_info($"Tags on disk: {tag_file.TagTypesOnDisk}");
            paint_file_info($"Tags in object: {tag_file.TagTypes}");
            paint_file_info("Grouping " + tag_file.Tag.Grouping);
            paint_file_info("Title " + tag_file.Tag.Title);
            paint_file_info("TitleSort " + tag_file.Tag.TitleSort);
            paint_file_info("Album Artists " + tag_file.Tag.AlbumArtists);
            paint_file_info("Album Artists Sort " + tag_file.Tag.AlbumArtistsSort);
            paint_file_info("Performers " + tag_file.Tag.Performers);
            paint_file_info("Performers Sort " + tag_file.Tag.PerformersSort);
            paint_file_info("Composers " + tag_file.Tag.Composers);
            paint_file_info("Composers Sort " + tag_file.Tag.ComposersSort);
            paint_file_info("Conductor " + tag_file.Tag.Conductor);
            paint_file_info("Album " + tag_file.Tag.Album);
            paint_file_info("Album Sort " + tag_file.Tag.AlbumSort);
            paint_file_info("Comment " + tag_file.Tag.Comment);
            paint_file_info("Copyright " + tag_file.Tag.Copyright);
            paint_file_info("Genres " + tag_file.Tag.Genres);
            paint_file_info("BPM " + tag_file.Tag.BeatsPerMinute);
            paint_file_info("Year " + tag_file.Tag.Year);
            paint_file_info("Track " + tag_file.Tag.Track);
            paint_file_info("TrackCount " + tag_file.Tag.TrackCount);
            paint_file_info("Disc " + tag_file.Tag.Disc);
            paint_file_info("DiscCount " + tag_file.Tag.DiscCount);

            paint_file_info($"Lyrics:\n{tag_file.Tag.Lyrics}");
            paint_file_info($"Media Types: {tag_file.Properties.MediaTypes}");

            foreach (var codec in tag_file.Properties.Codecs)
            {

                if (codec is IAudioCodec acodec && (acodec.MediaTypes & MediaTypes.Audio) != MediaTypes.None)
                {
                    paint_file_info($"Audio Properties : {acodec.Description}");
                    paint_file_info($"Bitrate:    {acodec.AudioBitrate}");
                    paint_file_info($"SampleRate: {acodec.AudioSampleRate}");
                    paint_file_info($"Channels:   {acodec.AudioChannels}");
                }

                if (codec is IVideoCodec vcodec && (vcodec.MediaTypes & MediaTypes.Video) != MediaTypes.None)
                {
                    paint_file_info($"Video Properties : {vcodec.Description}");
                    paint_file_info($"Width:      {vcodec.VideoWidth}");
                    paint_file_info($"Height:     {vcodec.VideoHeight}\n");
                }
            }
            IPicture[] pictures = tag_file.Tag.Pictures;
            paint_file_info($"Embedded Pictures: {pictures.Length}");
            foreach (var picture in pictures)
            {
                paint_file_info(picture.Description);
                paint_file_info($"   MimeType: {picture.MimeType}");
                paint_file_info($"   Size:     {picture.Data.Count}");
                paint_file_info($"   Type:     {picture.Type}");
            }
        }

        private void paint_file_info(string line_to_paint)
        {
            txtSongDetails.Text += line_to_paint + "\r\n";
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

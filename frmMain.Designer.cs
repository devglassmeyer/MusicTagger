namespace MusicTagger
{
    partial class frmMain
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
            label1 = new Label();
            txtAlbumDir = new TextBox();
            btnGetAlbumDir = new Button();
            lstSongs = new ListBox();
            label2 = new Label();
            txtSongDetails = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Directory";
            // 
            // txtAlbumDir
            // 
            txtAlbumDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlbumDir.Location = new Point(10, 43);
            txtAlbumDir.Name = "txtAlbumDir";
            txtAlbumDir.Size = new Size(892, 23);
            txtAlbumDir.TabIndex = 1;
            // 
            // btnGetAlbumDir
            // 
            btnGetAlbumDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAlbumDir.Location = new Point(908, 43);
            btnGetAlbumDir.Name = "btnGetAlbumDir";
            btnGetAlbumDir.Size = new Size(26, 23);
            btnGetAlbumDir.TabIndex = 2;
            btnGetAlbumDir.Text = "...";
            btnGetAlbumDir.UseVisualStyleBackColor = true;
            btnGetAlbumDir.Click += btnGetAlbumDir_Click;
            // 
            // lstSongs
            // 
            lstSongs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstSongs.FormattingEnabled = true;
            lstSongs.ItemHeight = 15;
            lstSongs.Location = new Point(10, 107);
            lstSongs.Name = "lstSongs";
            lstSongs.Size = new Size(908, 229);
            lstSongs.TabIndex = 3;
            lstSongs.SelectedValueChanged += lstSongs_SelectedValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(10, 89);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Songs";
            // 
            // txtSongDetails
            // 
            txtSongDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSongDetails.Location = new Point(10, 363);
            txtSongDetails.Multiline = true;
            txtSongDetails.Name = "txtSongDetails";
            txtSongDetails.Size = new Size(908, 287);
            txtSongDetails.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 662);
            Controls.Add(txtSongDetails);
            Controls.Add(label2);
            Controls.Add(lstSongs);
            Controls.Add(btnGetAlbumDir);
            Controls.Add(txtAlbumDir);
            Controls.Add(label1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Music Tagger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAlbumDir;
        private Button btnGetAlbumDir;
        private ListBox lstSongs;
        private Label label2;
        private TextBox txtSongDetails;
    }
}
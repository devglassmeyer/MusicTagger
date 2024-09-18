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
            picAlbumCover = new PictureBox();
            menuStrip1 = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            findMissingToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picAlbumCover).BeginInit();
            menuStrip1.SuspendLayout();
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
            txtSongDetails.ScrollBars = ScrollBars.Vertical;
            txtSongDetails.Size = new Size(489, 287);
            txtSongDetails.TabIndex = 5;
            // 
            // picAlbumCover
            // 
            picAlbumCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            picAlbumCover.Location = new Point(512, 365);
            picAlbumCover.Name = "picAlbumCover";
            picAlbumCover.Size = new Size(406, 285);
            picAlbumCover.SizeMode = PictureBoxSizeMode.CenterImage;
            picAlbumCover.TabIndex = 6;
            picAlbumCover.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(946, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findMissingToolStripMenuItem, exitToolStripMenuItem });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(37, 20);
            fToolStripMenuItem.Text = "File";
            // 
            // findMissingToolStripMenuItem
            // 
            findMissingToolStripMenuItem.Name = "findMissingToolStripMenuItem";
            findMissingToolStripMenuItem.Size = new Size(180, 22);
            findMissingToolStripMenuItem.Text = "Find &Missing";
            findMissingToolStripMenuItem.Click += findMissingToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 662);
            Controls.Add(picAlbumCover);
            Controls.Add(txtSongDetails);
            Controls.Add(label2);
            Controls.Add(lstSongs);
            Controls.Add(btnGetAlbumDir);
            Controls.Add(txtAlbumDir);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Music Tagger";
            ((System.ComponentModel.ISupportInitialize)picAlbumCover).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private PictureBox picAlbumCover;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem findMissingToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
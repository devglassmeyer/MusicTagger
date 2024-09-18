namespace MusicTagger
{
    partial class frmFindMissingArt
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
            txtAlbumDir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGetAlbumDir = new Button();
            label3 = new Label();
            lstArtistAlbumsMissingArt = new ListBox();
            SuspendLayout();
            // 
            // txtAlbumDir
            // 
            txtAlbumDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAlbumDir.Location = new Point(12, 57);
            txtAlbumDir.Name = "txtAlbumDir";
            txtAlbumDir.Size = new Size(926, 23);
            txtAlbumDir.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Music Directory";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(781, 15);
            label2.TabIndex = 4;
            label2.Text = "Find all songs that have no album art in the FLAC file. Supply the misic directory in which contains the sub-directory structure of artist/album/song";
            // 
            // btnGetAlbumDir
            // 
            btnGetAlbumDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetAlbumDir.Location = new Point(944, 56);
            btnGetAlbumDir.Name = "btnGetAlbumDir";
            btnGetAlbumDir.Size = new Size(26, 23);
            btnGetAlbumDir.TabIndex = 5;
            btnGetAlbumDir.Text = "...";
            btnGetAlbumDir.UseVisualStyleBackColor = true;
            btnGetAlbumDir.Click += btnGetAlbumDir_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 7;
            label3.Text = "Artist and Albums Missing Art";
            // 
            // lstArtistAlbumsMissingArt
            // 
            lstArtistAlbumsMissingArt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstArtistAlbumsMissingArt.FormattingEnabled = true;
            lstArtistAlbumsMissingArt.ItemHeight = 15;
            lstArtistAlbumsMissingArt.Location = new Point(12, 110);
            lstArtistAlbumsMissingArt.Name = "lstArtistAlbumsMissingArt";
            lstArtistAlbumsMissingArt.Size = new Size(926, 229);
            lstArtistAlbumsMissingArt.TabIndex = 6;
            // 
            // frmFindMissingArt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 435);
            Controls.Add(label3);
            Controls.Add(lstArtistAlbumsMissingArt);
            Controls.Add(btnGetAlbumDir);
            Controls.Add(label2);
            Controls.Add(txtAlbumDir);
            Controls.Add(label1);
            Name = "frmFindMissingArt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find Missing Album Art";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlbumDir;
        private Label label1;
        private Label label2;
        private Button btnGetAlbumDir;
        private Label label3;
        private ListBox lstArtistAlbumsMissingArt;
    }
}
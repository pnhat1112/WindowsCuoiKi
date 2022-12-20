namespace UICuoiKi
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TrackBar volumeTrackbar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backImageList = new System.Windows.Forms.ImageList(this.components);
            this.playImageList = new System.Windows.Forms.ImageList(this.components);
            this.stopImageList = new System.Windows.Forms.ImageList(this.components);
            this.nextImageList = new System.Windows.Forms.ImageList(this.components);
            this.volumeImagList = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.musicBar = new System.Windows.Forms.TrackBar();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.playlistGridView = new System.Windows.Forms.DataGridView();
            this.albumArtBox = new System.Windows.Forms.PictureBox();
            this.songsGridView = new System.Windows.Forms.DataGridView();
            volumeTrackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(volumeTrackbar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeTrackbar
            // 
            volumeTrackbar.AutoSize = false;
            volumeTrackbar.Location = new System.Drawing.Point(216, 59);
            volumeTrackbar.Maximum = 100;
            volumeTrackbar.Name = "volumeTrackbar";
            volumeTrackbar.Size = new System.Drawing.Size(123, 23);
            volumeTrackbar.TabIndex = 5;
            volumeTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            volumeTrackbar.Value = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playBackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSongToolStripMenuItem.Text = "Add song";
            // 
            // playBackToolStripMenuItem
            // 
            this.playBackToolStripMenuItem.Name = "playBackToolStripMenuItem";
            this.playBackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playBackToolStripMenuItem.Text = "Playback";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // backImageList
            // 
            this.backImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.backImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backImageList.ImageStream")));
            this.backImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.backImageList.Images.SetKeyName(0, "back.png");
            this.backImageList.Images.SetKeyName(1, "back.png");
            // 
            // playImageList
            // 
            this.playImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.playImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playImageList.ImageStream")));
            this.playImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.playImageList.Images.SetKeyName(0, "play.png");
            // 
            // stopImageList
            // 
            this.stopImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.stopImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stopImageList.ImageStream")));
            this.stopImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.stopImageList.Images.SetKeyName(0, "stop.png");
            // 
            // nextImageList
            // 
            this.nextImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.nextImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nextImageList.ImageStream")));
            this.nextImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.nextImageList.Images.SetKeyName(0, "next.png");
            // 
            // volumeImagList
            // 
            this.volumeImagList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.volumeImagList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("volumeImagList.ImageStream")));
            this.volumeImagList.TransparentColor = System.Drawing.Color.Transparent;
            this.volumeImagList.Images.SetKeyName(0, "voice.png");
            // 
            // btnBack
            // 
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.backImageList;
            this.btnBack.Location = new System.Drawing.Point(12, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.ImageIndex = 0;
            this.btnPlayPause.ImageList = this.playImageList;
            this.btnPlayPause.Location = new System.Drawing.Point(77, 49);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(59, 36);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageIndex = 0;
            this.btnNext.ImageList = this.nextImageList;
            this.btnNext.Location = new System.Drawing.Point(142, 49);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // musicBar
            // 
            this.musicBar.AutoSize = false;
            this.musicBar.LargeChange = 0;
            this.musicBar.Location = new System.Drawing.Point(368, 70);
            this.musicBar.Maximum = 1000;
            this.musicBar.Name = "musicBar";
            this.musicBar.Size = new System.Drawing.Size(437, 15);
            this.musicBar.SmallChange = 0;
            this.musicBar.TabIndex = 12;
            this.musicBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(370, 52);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(28, 15);
            this.currentTimeLabel.TabIndex = 13;
            this.currentTimeLabel.Text = "0:00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "0:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(373, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title Music";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchBox.Location = new System.Drawing.Point(853, 57);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(132, 23);
            this.searchBox.TabIndex = 16;
            this.searchBox.Text = "Search Libary";
            // 
            // playlistGridView
            // 
            this.playlistGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistGridView.Location = new System.Drawing.Point(17, 107);
            this.playlistGridView.Name = "playlistGridView";
            this.playlistGridView.ReadOnly = true;
            this.playlistGridView.RowTemplate.Height = 25;
            this.playlistGridView.Size = new System.Drawing.Size(184, 303);
            this.playlistGridView.TabIndex = 17;
            // 
            // albumArtBox
            // 
            this.albumArtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.albumArtBox.Image = ((System.Drawing.Image)(resources.GetObject("albumArtBox.Image")));
            this.albumArtBox.Location = new System.Drawing.Point(20, 429);
            this.albumArtBox.Name = "albumArtBox";
            this.albumArtBox.Size = new System.Drawing.Size(181, 156);
            this.albumArtBox.TabIndex = 18;
            this.albumArtBox.TabStop = false;
            // 
            // songsGridView
            // 
            this.songsGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.songsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsGridView.Location = new System.Drawing.Point(224, 108);
            this.songsGridView.Name = "songsGridView";
            this.songsGridView.ReadOnly = true;
            this.songsGridView.RowTemplate.Height = 25;
            this.songsGridView.Size = new System.Drawing.Size(761, 477);
            this.songsGridView.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.songsGridView);
            this.Controls.Add(this.albumArtBox);
            this.Controls.Add(this.playlistGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.musicBar);
            this.Controls.Add(volumeTrackbar);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mucsic Timeee";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(volumeTrackbar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList backImageList;
        private System.Windows.Forms.ImageList playImageList;
        private System.Windows.Forms.ImageList stopImageList;
        private System.Windows.Forms.ImageList nextImageList;
        private System.Windows.Forms.ImageList volumeImagList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar musicBar;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView playlistGridView;
        private System.Windows.Forms.PictureBox albumArtBox;
        private System.Windows.Forms.DataGridView songsGridView;
    }
}

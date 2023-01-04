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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backImageList = new System.Windows.Forms.ImageList(this.components);
            this.playImageList = new System.Windows.Forms.ImageList(this.components);
            this.stopImageList = new System.Windows.Forms.ImageList(this.components);
            this.nextImageList = new System.Windows.Forms.ImageList(this.components);
            this.volumeImagList = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.musicBar = new System.Windows.Forms.TrackBar();
            this.lbl_currentTime = new System.Windows.Forms.Label();
            this.lbl_fixedTime = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.playlistGridView = new System.Windows.Forms.DataGridView();
            this.albumArtBox = new System.Windows.Forms.PictureBox();
            this.dtgrv_songs = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlist_table_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_songs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.playlist_table_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addSongToolStripMenuItem.Text = "Add song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.addSongToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addFolderToolStripMenuItem.Text = "Add folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // musicBar
            // 
            this.musicBar.AutoSize = false;
            this.musicBar.LargeChange = 0;
            this.musicBar.Location = new System.Drawing.Point(355, 80);
            this.musicBar.Maximum = 1000;
            this.musicBar.Name = "musicBar";
            this.musicBar.Size = new System.Drawing.Size(437, 15);
            this.musicBar.SmallChange = 0;
            this.musicBar.TabIndex = 12;
            this.musicBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicBar.ValueChanged += new System.EventHandler(this.musicBar_ValueChanged);
            this.musicBar.CursorChanged += new System.EventHandler(this.musicBar_CursorChanged);
            this.musicBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicBar_MouseDown);
            this.musicBar.MouseEnter += new System.EventHandler(this.musicBar_MouseEnter);
            // 
            // lbl_currentTime
            // 
            this.lbl_currentTime.AutoSize = true;
            this.lbl_currentTime.Location = new System.Drawing.Point(357, 62);
            this.lbl_currentTime.Name = "lbl_currentTime";
            this.lbl_currentTime.Size = new System.Drawing.Size(28, 15);
            this.lbl_currentTime.TabIndex = 13;
            this.lbl_currentTime.Text = "0:00";
            this.lbl_currentTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_fixedTime
            // 
            this.lbl_fixedTime.AutoSize = true;
            this.lbl_fixedTime.Location = new System.Drawing.Point(764, 62);
            this.lbl_fixedTime.Name = "lbl_fixedTime";
            this.lbl_fixedTime.Size = new System.Drawing.Size(28, 15);
            this.lbl_fixedTime.TabIndex = 14;
            this.lbl_fixedTime.Text = "0:00";
            this.lbl_fixedTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(360, 28);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(432, 34);
            this.lb_title.TabIndex = 15;
            this.lb_title.Text = "Title Music";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.playlistGridView.AllowUserToAddRows = false;
            this.playlistGridView.AllowUserToDeleteRows = false;
            this.playlistGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistGridView.Location = new System.Drawing.Point(17, 107);
            this.playlistGridView.Name = "playlistGridView";
            this.playlistGridView.ReadOnly = true;
            this.playlistGridView.RowTemplate.Height = 25;
            this.playlistGridView.Size = new System.Drawing.Size(184, 303);
            this.playlistGridView.TabIndex = 17;
            this.playlistGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playlistGridView_CellContentClick);
            this.playlistGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playlistGridView_MouseDown);
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
            // dtgrv_songs
            // 
            this.dtgrv_songs.AllowUserToAddRows = false;
            this.dtgrv_songs.AllowUserToDeleteRows = false;
            this.dtgrv_songs.AllowUserToOrderColumns = true;
            this.dtgrv_songs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrv_songs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrv_songs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrv_songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_songs.Location = new System.Drawing.Point(224, 108);
            this.dtgrv_songs.Name = "dtgrv_songs";
            this.dtgrv_songs.ReadOnly = true;
            this.dtgrv_songs.RowTemplate.Height = 25;
            this.dtgrv_songs.Size = new System.Drawing.Size(761, 477);
            this.dtgrv_songs.TabIndex = 19;
            this.dtgrv_songs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_songs_CellContentClick);
            this.dtgrv_songs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgrv_songs_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assToolStripMenuItem,
            this.asToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // assToolStripMenuItem
            // 
            this.assToolStripMenuItem.Name = "assToolStripMenuItem";
            this.assToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.assToolStripMenuItem.Text = "Update";
            this.assToolStripMenuItem.Click += new System.EventHandler(this.assToolStripMenuItem_Click);
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.asToolStripMenuItem.Text = "Remove";
            this.asToolStripMenuItem.Click += new System.EventHandler(this.asToolStripMenuItem_Click);
            // 
            // playlist_table_menu
            // 
            this.playlist_table_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.addNewPlaylistToolStripMenuItem});
            this.playlist_table_menu.Name = "playlist_table_menu";
            this.playlist_table_menu.Size = new System.Drawing.Size(160, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.removeToolStripMenuItem.Text = "remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.renameToolStripMenuItem.Text = "rename";
            // 
            // addNewPlaylistToolStripMenuItem
            // 
            this.addNewPlaylistToolStripMenuItem.Name = "addNewPlaylistToolStripMenuItem";
            this.addNewPlaylistToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addNewPlaylistToolStripMenuItem.Text = "add new playlist";
            this.addNewPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addNewPlaylistToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.dtgrv_songs);
            this.Controls.Add(this.albumArtBox);
            this.Controls.Add(this.playlistGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lbl_fixedTime);
            this.Controls.Add(this.lbl_currentTime);
            this.Controls.Add(this.musicBar);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mucsic Timeee";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_songs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.playlist_table_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ImageList backImageList;
        private System.Windows.Forms.ImageList playImageList;
        private System.Windows.Forms.ImageList stopImageList;
        private System.Windows.Forms.ImageList nextImageList;
        private System.Windows.Forms.ImageList volumeImagList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar musicBar;
        private System.Windows.Forms.Label lbl_currentTime;
        private System.Windows.Forms.Label lbl_fixedTime;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView playlistGridView;
        private System.Windows.Forms.PictureBox albumArtBox;
        private System.Windows.Forms.DataGridView dtgrv_songs;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip playlist_table_menu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPlaylistToolStripMenuItem;
    }
}

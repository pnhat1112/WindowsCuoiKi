using BUS;
using NAudio.Wave;
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
using TagLib.Mpeg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UICuoiKi
{
    public partial class MainForm : Form
    {
        private BusSong bs = new BusSong();
        private DataTable data;
        AudioFileReader audioFile = null;
        private IWavePlayer player = new WaveOut();
        List<int> history= new List<int>();
        int clickedSongIndex;
        int curentHis = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtgrv_songs.AutoGenerateColumns = false;

            DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.DataPropertyName = "name";
            titleColumn.HeaderText = "Name";
            dtgrv_songs.Columns.Add(titleColumn);
            dtgrv_songs.Columns[0].Width = 300;


            DataGridViewColumn artistColumn = new DataGridViewTextBoxColumn();
            artistColumn.DataPropertyName = "artist";
            artistColumn.HeaderText = "Artist";
            dtgrv_songs.Columns.Add(artistColumn);
            dtgrv_songs.Columns[1].Width = 210;

            DataGridViewColumn pathColumn = new DataGridViewTextBoxColumn();
            pathColumn.DataPropertyName = "path";
            pathColumn.HeaderText = "Path";
            dtgrv_songs.Columns.Add(pathColumn);
            dtgrv_songs.Columns[2].Width = 210;
            data = bs.getAll();
            dtgrv_songs.DataSource = data;
            
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.ImageList == playImageList)
            {
                btnPlayPause.ImageList = stopImageList;
                player.Play();
            } else
            {
                btnPlayPause.ImageList = playImageList;
                player.Pause();
            }
        }
        private void addSongFromPath(string filePath)
        {
            String title = Path.GetFileName(filePath);
            TagLib.File file = TagLib.File.Create(filePath);
            string artist = file.Tag.FirstPerformer;

            data.Rows.Add(title, artist, filePath.Replace(@"\", "[]"));
        }
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            NuGet\Install - Package taglib - Version 2.1.0
*/            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Select a folder to load songs";

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folder_path = folderBrowserDialog.SelectedPath;
                try
                {
                    foreach (string filePath in Directory.EnumerateFiles(folder_path, "*.mp3", SearchOption.AllDirectories))
                    {
                        addSongFromPath(filePath);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                // The user cancelled the dialog
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs.saveSong(data);
        }

        private void dtgrv_songs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtgrv_songs.CurrentCell.RowIndex;
            playSong(rowIndex);
        }
        private void playSong(int rowIndex)
        {
            DataRow row = data.Rows[rowIndex];
            string a = (String)row["path"];
            string path = a.Replace("[]", @"\");
            /*            MessageBox.Show(path);
            */
            try
            {
                player.Stop();
                audioFile = new AudioFileReader(path);
                string crr = audioFile.CurrentTime.ToString();
                /*                audioFile.CurrentTime = TimeSpan.FromSeconds(10.0);
                */
                TimeSpan time = audioFile.TotalTime;
                string str = time.ToString(@"mm\:ss\ ");
                musicBar.Minimum = 0;
                musicBar.Maximum = (int)time.TotalSeconds;
                lbl_fixedTime.Text = str;
                history.Add(rowIndex);
                timer1.Start();
                player.Init(audioFile);
                player.Play();
                lb_title.Text = (String)row["name"];
                btnPlayPause.ImageList = stopImageList;

            }
            catch (Exception ex)
            {
                // If there's a problem with the MP3 file, display an error message
                string message = "MP3 could not be played. Check file path:\n\n";
                string caption = "Error";
                MessageBox.Show(ex.ToString(), message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // Do something with the file path
                    addSongFromPath(filePath);
                }
            }
        }

        private void musicBar_ValueChanged(object sender, EventArgs e)
        {
            double sec = (double)musicBar.Value;
            audioFile.CurrentTime = TimeSpan.FromSeconds(sec);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = audioFile.CurrentTime;
            string str = time.ToString(@"mm\:ss\ ");
            lbl_currentTime.Text = str;
            musicBar.Value = (int)time.TotalSeconds;

        }

        private void musicBar_CursorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("sss");
        }

        private void musicBar_MouseEnter(object sender, EventArgs e)
        {
        }

        private void musicBar_MouseDown(object sender, MouseEventArgs e)
        {
        }
/*        private ContextMenuStrip CreateSongRightClickMen()
        {
            ContextMenuStrip cm = new ContextMenuStrip();
            cm.MenuItems.Add(CreateMenuItem("Play Song"));
            cm.MenuItems.Add(CreateMenuItem("Queue next in shuffle queue"));
            cm.MenuItems.Add(CreateMenuItem("Add songs to shuffle queue"));
            return cm;
        }*/
        private void dtgrv_songs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                clickedSongIndex = dtgrv_songs.HitTest(e.X, e.Y).RowIndex;
                if (clickedSongIndex >= 0)
                {
                    if (dtgrv_songs.Rows[clickedSongIndex].Cells[0].Selected != true)
                        dtgrv_songs.ClearSelection();
                    dtgrv_songs.Rows[clickedSongIndex].Cells[0].Selected = true;

                    /*   ContextMenuStrip cm = CreateSongRightClickMen();
                       cm.Show(this, this.PointToClient(Cursor.Position));*/
                    contextMenuStrip1.Show(MousePosition);

                }
            }
        }

        private void assToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = data.Rows[clickedSongIndex];
            string name = row[0].ToString();
            string artist = row[1].ToString();
            string path = row[2].ToString();

            using (var frsong = new SongForm(name, artist, path))
            {
                var result = frsong.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Update successfully");
                    data.Rows[clickedSongIndex][0] = frsong.name;
                    data.Rows[clickedSongIndex][1] = frsong.artist;
                    data.Rows[clickedSongIndex][2] = frsong.path;
                }
            }
        }

        private void asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Rows.RemoveAt(clickedSongIndex);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (history.Count() > 0)
            {
                if (curentHis == 0)
                {

                }
                else if (curentHis == -1)
                {
                    curentHis = history.Count();
                    curentHis = curentHis - 1;
                    playSong(history[curentHis]);
                }
                else
                {
                    curentHis = curentHis - 1;
                    playSong(history[curentHis]);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(history.Count>0 && curentHis != -1&&curentHis<history.Count)
            {
                curentHis = curentHis + 1;
                playSong(history[curentHis]);
            }
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace SimpleSoundboard2
{
    public partial class Form1 : Form
    {
        // ########### Global Variables ###############################################################################

        string configfile = "";
        string soundfolder = "";
        int listsize = 11;

        public Form1()
        {
            InitializeComponent();
        }

        // ####################################################################################################################
        // ########### M E T H O D S ##########################################################################################
        // ####################################################################################################################

        public void readConfigFile()
        {
            // D E V E L O P M E N T
            string myFile = "C:\\Users\\ea-da\\Documents\\GitHub\\SimpleSoundboard2\\config.cfg";

            // F I N I S H E D
            //string myFile = Directory.GetCurrentDirectory() + "\\config.cfg";

            // https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
            StreamReader sr = new StreamReader(myFile);

            string line;
            int i = 1;
            line = sr.ReadLine();

            while (line != null)
            {

                if (i == 1)
                {
                    soundfolder = line;
                    line = sr.ReadLine();
                }

                if (i == 2)
                {
                    listsize = Int32.Parse(line);
                    line = sr.ReadLine();
                }

                i++;
            }

            sr.Close();

        }

        private void fillSoundList()
        {
            listbox_soundlist.Items.Clear();

            DirectoryInfo soundList = new DirectoryInfo(soundfolder);

            foreach (var files in soundList.GetFiles())
            {
                listbox_soundlist.Items.Add(files.Name);
            }
        }

        private void playSound(int linenumber)
        {
            listbox_soundlist.SelectedIndex = linenumber - 1;
            SoundPlayer simpleSound = new SoundPlayer(soundfolder + "\\" + listbox_soundlist.SelectedItem.ToString());
            simpleSound.Play();
        }

        private void setConfig()
        {
            int HEIGHT = this.Height;
            int WIDTH = this.Width;
            int WIDTH_LIST = listbox_soundlist.Width;

            if (textBox_soundfolder.Visible == true)
            {
                label_soundfolder.Visible = false;
                textBox_soundfolder.Visible = false;
                label_fontsize.Visible = false;
                comboBox_fontsize.Visible = false;
                btn_saveconfig.Visible = false;

                listbox_soundlist.Size = new Size(WIDTH - 40, HEIGHT - 88);
            }
            else
            {
                label_soundfolder.Visible = true;
                textBox_soundfolder.Visible = true;
                label_fontsize.Visible = true;
                comboBox_fontsize.Visible = true;
                btn_saveconfig.Visible = true;

                listbox_soundlist.Size = new Size(WIDTH_LIST, HEIGHT / 2);
            }
        }

        private void loadSettings()
        {
            readConfigFile();
            fillSoundList();
            setConfig();

            listbox_soundlist.Font = new Font("Segoe UI", listsize);
            listbox_soundlist.Location = new Point(12, 12);
            listbox_soundlist.Size = new Size(360, 500);

            textBox_soundfolder.Text = soundfolder;

            for (int i = 9; i < 65; i++)
            {
                comboBox_fontsize.Items.Add(i.ToString());
            }

            comboBox_fontsize.SelectedItem = listsize.ToString();
        }

        private void saveSettings()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ea-da\\Documents\\GitHub\\SimpleSoundboard2\\config.cfg");
                sw.WriteLine(textBox_soundfolder.Text);
                sw.WriteLine(comboBox_fontsize.SelectedItem.ToString());
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Fehler. Daten konnten nicht gespeichert werden!");
            }

            setConfig();
        }
        // ####################################################################################################################
        // ########### E L E M E N T S ########################################################################################
        // ####################################################################################################################

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void listbox_soundlist_KeyDown(object sender, KeyEventArgs e)
        {
            // ########## Change Font Size ######################################################################

            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                if (listsize < 64)
                {
                    listsize++;
                    listbox_soundlist.Font = new Font("Segoe UI", listsize);
                }
            }

            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                if (listsize > 9)
                {
                    listsize--;
                    listbox_soundlist.Font = new Font("Segoe UI", listsize);
                }

            }

            if (e.KeyCode == Keys.D1)
            {
                playSound(1);
            }

            if (e.KeyCode == Keys.D2)
            {
                playSound(2);
            }

            if (e.KeyCode == Keys.D3)
            {
                playSound(3);
            }

            if (e.KeyCode == Keys.D4)
            {
                playSound(4);
            }

            if (e.KeyCode == Keys.D5)
            {
                playSound(5);
            }

            if (e.KeyCode == Keys.D6)
            {
                playSound(6);
            }

            if (e.KeyCode == Keys.D7)
            {
                playSound(7);
            }

            if (e.KeyCode == Keys.D8)
            {
                playSound(8);
            }

            if (e.KeyCode == Keys.D9)
            {
                playSound(9);
            }

            if (e.KeyCode == Keys.D0)
            {
                playSound(10);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int HEIGHT = this.Height;
            int WIDTH = this.Width;

            listbox_soundlist.Location = new Point(12, 12);
            listbox_soundlist.Size = new Size(WIDTH - 40, HEIGHT - 88);

            btn_config.Location = new Point(12, HEIGHT - 75);
            btn_openfolder.Location = new Point(WIDTH / 2 - 70, HEIGHT - 75);
            btn_help.Location = new Point(WIDTH / 2 + 30, HEIGHT - 75);
            btn_quit.Location = new Point(WIDTH - 103, HEIGHT - 75);

            label_soundfolder.Location = new Point(50, HEIGHT / 2 + 30);
            textBox_soundfolder.Location = new Point(50, HEIGHT / 2 + 50);
            label_fontsize.Location = new Point(50, HEIGHT / 2 + 80);
            comboBox_fontsize.Location = new Point(50, HEIGHT / 2 + 100);
            btn_saveconfig.Location = new Point(250, HEIGHT / 2 + 100);
        }

        private void listbox_soundlist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(soundfolder + "\\" + listbox_soundlist.SelectedItem.ToString());
                simpleSound.Play();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Soundwiedergabe. Ist die Datei im WAV-Format?");
            }
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            playSound(1);
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            playSound(2);
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            playSound(3);
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            playSound(4);
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            playSound(5);
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            playSound(6);
        }

        private void menu7_Click(object sender, EventArgs e)
        {
            playSound(7);
        }

        private void menu8_Click(object sender, EventArgs e)
        {
            playSound(8);
        }

        private void menu9_Click(object sender, EventArgs e)
        {
            playSound(9);
        }

        private void menu0_Click(object sender, EventArgs e)
        {
            playSound(10);
        }

        private void btn_openfolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", soundfolder);
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            setConfig();
        }

        private void comboBox_fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Int32.Parse(comboBox_fontsize.SelectedItem.ToString());
            listbox_soundlist.Font = new Font("Segoe UI", size);
            //listbox_soundlist.Font = new Font("Segoe UI", listsize);
        }

        private void btn_saveconfig_Click(object sender, EventArgs e)
        {
            saveSettings();
            setConfig();
            loadSettings();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            try
            {
                // https://stackoverflow.com/a/18276042
                // Solutions for different Systems:
                // https://github.com/dotnet/runtime/issues/17938#issuecomment-235502080

                ProcessStartInfo goToLink = new ProcessStartInfo()
                {
                    FileName = "https://github.com/itsnice2/SimpleSoundboard2",
                    UseShellExecute = true
                };
                Process.Start(goToLink);
            }
            catch
            {
                MessageBox.Show("Browser konnte nicht geöffnet werden. Besuchen Sie \n\n\thttps://github.com/itsnice2/SimpleSoundboard2\n\n für die Hilfe.");
            }
        }

        private void listbox_soundlist_Click(object sender, EventArgs e)
        {
            try
            {
                playSound(listbox_soundlist.SelectedIndex + 1);
            }
            catch
            {
                MessageBox.Show("Fehler bei der Soundwiedergabe. Ist die Datei im WAV-Format?");
            }
        }
    }
}

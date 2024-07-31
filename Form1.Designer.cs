namespace SimpleSoundboard2
{
    partial class Form1
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
            listbox_soundlist = new ListBox();
            btn_config = new Button();
            btn_quit = new Button();
            btn_openfolder = new Button();
            btn_help = new Button();
            menuStrip1 = new MenuStrip();
            shortcutsToolStripMenuItem = new ToolStripMenuItem();
            menu1 = new ToolStripMenuItem();
            menu2 = new ToolStripMenuItem();
            menu3 = new ToolStripMenuItem();
            menu4 = new ToolStripMenuItem();
            menu5 = new ToolStripMenuItem();
            menu6 = new ToolStripMenuItem();
            menu7 = new ToolStripMenuItem();
            menu8 = new ToolStripMenuItem();
            menu9 = new ToolStripMenuItem();
            menu0 = new ToolStripMenuItem();
            label_soundfolder = new Label();
            textBox_soundfolder = new TextBox();
            label_fontsize = new Label();
            comboBox_fontsize = new ComboBox();
            btn_saveconfig = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listbox_soundlist
            // 
            listbox_soundlist.AllowDrop = true;
            listbox_soundlist.FormattingEnabled = true;
            listbox_soundlist.ItemHeight = 15;
            listbox_soundlist.Items.AddRange(new object[] { "Baum", "Auto", "Straße", "Kinder", "Rinder", "Finder" });
            listbox_soundlist.Location = new Point(12, 72);
            listbox_soundlist.Name = "listbox_soundlist";
            listbox_soundlist.ScrollAlwaysVisible = true;
            listbox_soundlist.Size = new Size(360, 214);
            listbox_soundlist.TabIndex = 0;
            listbox_soundlist.DoubleClick += listbox_soundlist_DoubleClick;
            listbox_soundlist.KeyDown += listbox_soundlist_KeyDown;
            // 
            // btn_config
            // 
            btn_config.Location = new Point(12, 526);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(90, 23);
            btn_config.TabIndex = 1;
            btn_config.Text = "&Einstellungen";
            btn_config.UseVisualStyleBackColor = true;
            btn_config.Click += btn_config_Click;
            // 
            // btn_quit
            // 
            btn_quit.Location = new Point(297, 526);
            btn_quit.Name = "btn_quit";
            btn_quit.Size = new Size(75, 23);
            btn_quit.TabIndex = 2;
            btn_quit.Text = "&Beenden";
            btn_quit.UseVisualStyleBackColor = true;
            btn_quit.Click += btn_quit_Click;
            // 
            // btn_openfolder
            // 
            btn_openfolder.Location = new Point(127, 526);
            btn_openfolder.Name = "btn_openfolder";
            btn_openfolder.Size = new Size(94, 23);
            btn_openfolder.TabIndex = 3;
            btn_openfolder.Text = "&Ordner öffnen";
            btn_openfolder.UseVisualStyleBackColor = true;
            btn_openfolder.Click += btn_openfolder_Click;
            // 
            // btn_help
            // 
            btn_help.Location = new Point(227, 526);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(41, 23);
            btn_help.TabIndex = 4;
            btn_help.Text = "&Hilfe";
            btn_help.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { shortcutsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // shortcutsToolStripMenuItem
            // 
            shortcutsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu0 });
            shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            shortcutsToolStripMenuItem.Size = new Size(69, 20);
            shortcutsToolStripMenuItem.Text = "Shortcuts";
            shortcutsToolStripMenuItem.Visible = false;
            // 
            // menu1
            // 
            menu1.Name = "menu1";
            menu1.ShortcutKeyDisplayString = "";
            menu1.ShortcutKeys = Keys.Control | Keys.D1;
            menu1.Size = new Size(122, 22);
            menu1.Text = "1";
            menu1.Click += menu1_Click;
            // 
            // menu2
            // 
            menu2.Name = "menu2";
            menu2.ShortcutKeys = Keys.Control | Keys.D2;
            menu2.Size = new Size(122, 22);
            menu2.Text = "2";
            menu2.Click += menu2_Click;
            // 
            // menu3
            // 
            menu3.Name = "menu3";
            menu3.ShortcutKeys = Keys.Control | Keys.D3;
            menu3.Size = new Size(122, 22);
            menu3.Text = "3";
            menu3.Click += menu3_Click;
            // 
            // menu4
            // 
            menu4.Name = "menu4";
            menu4.ShortcutKeys = Keys.Control | Keys.D4;
            menu4.Size = new Size(122, 22);
            menu4.Text = "4";
            menu4.Click += menu4_Click;
            // 
            // menu5
            // 
            menu5.Name = "menu5";
            menu5.ShortcutKeys = Keys.Control | Keys.D5;
            menu5.Size = new Size(122, 22);
            menu5.Text = "5";
            menu5.Click += menu5_Click;
            // 
            // menu6
            // 
            menu6.Name = "menu6";
            menu6.ShortcutKeys = Keys.Control | Keys.D6;
            menu6.Size = new Size(122, 22);
            menu6.Text = "6";
            menu6.Click += menu6_Click;
            // 
            // menu7
            // 
            menu7.Name = "menu7";
            menu7.ShortcutKeys = Keys.Control | Keys.D7;
            menu7.Size = new Size(122, 22);
            menu7.Text = "7";
            menu7.Click += menu7_Click;
            // 
            // menu8
            // 
            menu8.Name = "menu8";
            menu8.ShortcutKeys = Keys.Control | Keys.D8;
            menu8.Size = new Size(122, 22);
            menu8.Text = "8";
            menu8.Click += menu8_Click;
            // 
            // menu9
            // 
            menu9.Name = "menu9";
            menu9.ShortcutKeys = Keys.Control | Keys.D9;
            menu9.Size = new Size(122, 22);
            menu9.Text = "9";
            menu9.Click += menu9_Click;
            // 
            // menu0
            // 
            menu0.Name = "menu0";
            menu0.ShortcutKeys = Keys.Control | Keys.D0;
            menu0.Size = new Size(122, 22);
            menu0.Text = "0";
            menu0.Click += menu0_Click;
            // 
            // label_soundfolder
            // 
            label_soundfolder.AutoSize = true;
            label_soundfolder.Location = new Point(45, 336);
            label_soundfolder.Name = "label_soundfolder";
            label_soundfolder.Size = new Size(76, 15);
            label_soundfolder.TabIndex = 6;
            label_soundfolder.Text = "Soundordner";
            // 
            // textBox_soundfolder
            // 
            textBox_soundfolder.Location = new Point(45, 354);
            textBox_soundfolder.Name = "textBox_soundfolder";
            textBox_soundfolder.Size = new Size(277, 23);
            textBox_soundfolder.TabIndex = 7;
            // 
            // label_fontsize
            // 
            label_fontsize.AutoSize = true;
            label_fontsize.Location = new Point(45, 384);
            label_fontsize.Name = "label_fontsize";
            label_fontsize.Size = new Size(72, 15);
            label_fontsize.TabIndex = 8;
            label_fontsize.Text = "Schriftgröße";
            // 
            // comboBox_fontsize
            // 
            comboBox_fontsize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fontsize.FormattingEnabled = true;
            comboBox_fontsize.Location = new Point(45, 402);
            comboBox_fontsize.Name = "comboBox_fontsize";
            comboBox_fontsize.Size = new Size(108, 23);
            comboBox_fontsize.TabIndex = 9;
            comboBox_fontsize.SelectedIndexChanged += comboBox_fontsize_SelectedIndexChanged;
            // 
            // btn_saveconfig
            // 
            btn_saveconfig.Location = new Point(247, 402);
            btn_saveconfig.Name = "btn_saveconfig";
            btn_saveconfig.Size = new Size(75, 23);
            btn_saveconfig.TabIndex = 10;
            btn_saveconfig.Text = "&Speichern";
            btn_saveconfig.UseVisualStyleBackColor = true;
            btn_saveconfig.Click += btn_saveconfig_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(btn_saveconfig);
            Controls.Add(comboBox_fontsize);
            Controls.Add(label_fontsize);
            Controls.Add(textBox_soundfolder);
            Controls.Add(label_soundfolder);
            Controls.Add(btn_help);
            Controls.Add(btn_openfolder);
            Controls.Add(btn_quit);
            Controls.Add(btn_config);
            Controls.Add(listbox_soundlist);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(400, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleSoundboard2";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_soundlist;
        private Button btn_config;
        private Button btn_quit;
        private Button btn_openfolder;
        private Button btn_help;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem shortcutsToolStripMenuItem;
        private ToolStripMenuItem menu1;
        private ToolStripMenuItem menu2;
        private ToolStripMenuItem menu3;
        private ToolStripMenuItem menu4;
        private ToolStripMenuItem menu5;
        private ToolStripMenuItem menu6;
        private ToolStripMenuItem menu7;
        private ToolStripMenuItem menu8;
        private ToolStripMenuItem menu9;
        private ToolStripMenuItem menu0;
        private Label label_soundfolder;
        private TextBox textBox_soundfolder;
        private Label label_fontsize;
        private ComboBox comboBox_fontsize;
        private Button btn_saveconfig;
    }
}

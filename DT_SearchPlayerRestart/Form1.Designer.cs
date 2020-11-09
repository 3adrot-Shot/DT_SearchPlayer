namespace DT_SearchPlayerRestart
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddEnable2Disable = new System.Windows.Forms.Button();
            this.AddDisable2Enable = new System.Windows.Forms.Button();
            this.label_S_DisableLB = new System.Windows.Forms.Label();
            this.label_S_EnableLB = new System.Windows.Forms.Label();
            this.ListBoxDisable = new System.Windows.Forms.ListBox();
            this.ListBoxEnabled = new System.Windows.Forms.ListBox();
            this.panel_Server = new System.Windows.Forms.Panel();
            this.Button_DelServer = new System.Windows.Forms.Button();
            this.label_Game = new System.Windows.Forms.Label();
            this.label_Players = new System.Windows.Forms.Label();
            this.Button_AddServer = new System.Windows.Forms.Button();
            this.label_S_PlayerList = new System.Windows.Forms.Label();
            this.label_S_Game = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_S_Players = new System.Windows.Forms.Label();
            this.ListBoxPlayersSS = new System.Windows.Forms.ListBox();
            this.label_Map = new System.Windows.Forms.Label();
            this.label_S_Info = new System.Windows.Forms.Label();
            this.label_S_Map = new System.Windows.Forms.Label();
            this.ComboBox_Servers = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Panel();
            this.HeadName = new System.Windows.Forms.Label();
            this.HeadLogo = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.SmallWindows = new System.Windows.Forms.Panel();
            this.PictureBox_Small = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Panel();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.Panel_Line = new System.Windows.Forms.Panel();
            this.Panel_OnlinePlayers = new System.Windows.Forms.Panel();
            this.ListBox_OnlinePlayers = new System.Windows.Forms.ListBox();
            this.Panel_Line2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_S_Info2 = new System.Windows.Forms.Label();
            this.label_S_Info3 = new System.Windows.Forms.LinkLabel();
            this.MainPanel.SuspendLayout();
            this.panel_Server.SuspendLayout();
            this.Header.SuspendLayout();
            this.HeadLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SmallWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Small)).BeginInit();
            this.ExitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.Panel_OnlinePlayers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MainPanel.Controls.Add(this.Panel_Line);
            this.MainPanel.Controls.Add(this.AddEnable2Disable);
            this.MainPanel.Controls.Add(this.AddDisable2Enable);
            this.MainPanel.Controls.Add(this.label_S_DisableLB);
            this.MainPanel.Controls.Add(this.label_S_EnableLB);
            this.MainPanel.Controls.Add(this.ListBoxDisable);
            this.MainPanel.Controls.Add(this.ListBoxEnabled);
            this.MainPanel.Controls.Add(this.panel_Server);
            this.MainPanel.Controls.Add(this.ButtonAdd);
            this.MainPanel.Controls.Add(this.ButtonDel);
            this.MainPanel.Controls.Add(this.textBoxNick);
            this.MainPanel.Controls.Add(this.Header);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(664, 337);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            // 
            // AddEnable2Disable
            // 
            this.AddEnable2Disable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.AddEnable2Disable.CausesValidation = false;
            this.AddEnable2Disable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEnable2Disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEnable2Disable.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.AddEnable2Disable.Location = new System.Drawing.Point(118, 189);
            this.AddEnable2Disable.Name = "AddEnable2Disable";
            this.AddEnable2Disable.Size = new System.Drawing.Size(23, 21);
            this.AddEnable2Disable.TabIndex = 8;
            this.AddEnable2Disable.TabStop = false;
            this.AddEnable2Disable.Text = "▼";
            this.AddEnable2Disable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEnable2Disable.UseVisualStyleBackColor = false;
            this.AddEnable2Disable.Click += new System.EventHandler(this.AddEnable2Disable_Click);
            // 
            // AddDisable2Enable
            // 
            this.AddDisable2Enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.AddDisable2Enable.CausesValidation = false;
            this.AddDisable2Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDisable2Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDisable2Enable.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.AddDisable2Enable.Location = new System.Drawing.Point(88, 189);
            this.AddDisable2Enable.Name = "AddDisable2Enable";
            this.AddDisable2Enable.Size = new System.Drawing.Size(23, 21);
            this.AddDisable2Enable.TabIndex = 8;
            this.AddDisable2Enable.TabStop = false;
            this.AddDisable2Enable.Text = "▲";
            this.AddDisable2Enable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDisable2Enable.UseVisualStyleBackColor = false;
            this.AddDisable2Enable.Click += new System.EventHandler(this.AddDisable2Enable_Click);
            // 
            // label_S_DisableLB
            // 
            this.label_S_DisableLB.AutoSize = true;
            this.label_S_DisableLB.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_DisableLB.Location = new System.Drawing.Point(12, 200);
            this.label_S_DisableLB.Name = "label_S_DisableLB";
            this.label_S_DisableLB.Size = new System.Drawing.Size(64, 13);
            this.label_S_DisableLB.TabIndex = 7;
            this.label_S_DisableLB.Text = "Disable List:";
            // 
            // label_S_EnableLB
            // 
            this.label_S_EnableLB.AutoSize = true;
            this.label_S_EnableLB.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_EnableLB.Location = new System.Drawing.Point(12, 59);
            this.label_S_EnableLB.Name = "label_S_EnableLB";
            this.label_S_EnableLB.Size = new System.Drawing.Size(62, 13);
            this.label_S_EnableLB.TabIndex = 7;
            this.label_S_EnableLB.Text = "Enabel List:";
            // 
            // ListBoxDisable
            // 
            this.ListBoxDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ListBoxDisable.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ListBoxDisable.FormattingEnabled = true;
            this.ListBoxDisable.Items.AddRange(new object[] {
            "Seton",
            "AnTonyRex"});
            this.ListBoxDisable.Location = new System.Drawing.Point(12, 216);
            this.ListBoxDisable.Name = "ListBoxDisable";
            this.ListBoxDisable.Size = new System.Drawing.Size(205, 108);
            this.ListBoxDisable.TabIndex = 6;
            this.ListBoxDisable.SelectedIndexChanged += new System.EventHandler(this.ListBoxDisable_SelectedIndexChanged);
            // 
            // ListBoxEnabled
            // 
            this.ListBoxEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ListBoxEnabled.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ListBoxEnabled.FormattingEnabled = true;
            this.ListBoxEnabled.Items.AddRange(new object[] {
            "3adrot-Shot",
            "Gh[0]st"});
            this.ListBoxEnabled.Location = new System.Drawing.Point(12, 75);
            this.ListBoxEnabled.Name = "ListBoxEnabled";
            this.ListBoxEnabled.Size = new System.Drawing.Size(205, 108);
            this.ListBoxEnabled.TabIndex = 6;
            this.ListBoxEnabled.SelectedIndexChanged += new System.EventHandler(this.ListBoxEnabled_SelectedIndexChanged);
            // 
            // panel_Server
            // 
            this.panel_Server.Controls.Add(this.Panel_Line2);
            this.panel_Server.Controls.Add(this.Panel_OnlinePlayers);
            this.panel_Server.Controls.Add(this.Button_DelServer);
            this.panel_Server.Controls.Add(this.label_Game);
            this.panel_Server.Controls.Add(this.label_Players);
            this.panel_Server.Controls.Add(this.Button_AddServer);
            this.panel_Server.Controls.Add(this.label_S_PlayerList);
            this.panel_Server.Controls.Add(this.label_S_Game);
            this.panel_Server.Controls.Add(this.label_Name);
            this.panel_Server.Controls.Add(this.label_S_Players);
            this.panel_Server.Controls.Add(this.ListBoxPlayersSS);
            this.panel_Server.Controls.Add(this.label_Map);
            this.panel_Server.Controls.Add(this.label_S_Map);
            this.panel_Server.Controls.Add(this.ComboBox_Servers);
            this.panel_Server.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Server.Location = new System.Drawing.Point(223, 30);
            this.panel_Server.Name = "panel_Server";
            this.panel_Server.Size = new System.Drawing.Size(441, 307);
            this.panel_Server.TabIndex = 5;
            this.panel_Server.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Server_Paint);
            // 
            // Button_DelServer
            // 
            this.Button_DelServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Button_DelServer.CausesValidation = false;
            this.Button_DelServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DelServer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Button_DelServer.Location = new System.Drawing.Point(128, 6);
            this.Button_DelServer.Name = "Button_DelServer";
            this.Button_DelServer.Size = new System.Drawing.Size(83, 20);
            this.Button_DelServer.TabIndex = 7;
            this.Button_DelServer.Text = "Delete Server";
            this.Button_DelServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DelServer.UseVisualStyleBackColor = false;
            this.Button_DelServer.Click += new System.EventHandler(this.Button_DelServer_Click);
            // 
            // label_Game
            // 
            this.label_Game.AutoSize = true;
            this.label_Game.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Game.Location = new System.Drawing.Point(36, 91);
            this.label_Game.Name = "label_Game";
            this.label_Game.Size = new System.Drawing.Size(29, 13);
            this.label_Game.TabIndex = 1;
            this.label_Game.Text = "NaN";
            // 
            // label_Players
            // 
            this.label_Players.AutoSize = true;
            this.label_Players.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Players.Location = new System.Drawing.Point(42, 78);
            this.label_Players.Name = "label_Players";
            this.label_Players.Size = new System.Drawing.Size(29, 13);
            this.label_Players.TabIndex = 1;
            this.label_Players.Text = "NaN";
            // 
            // Button_AddServer
            // 
            this.Button_AddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Button_AddServer.CausesValidation = false;
            this.Button_AddServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddServer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Button_AddServer.Location = new System.Drawing.Point(6, 6);
            this.Button_AddServer.Name = "Button_AddServer";
            this.Button_AddServer.Size = new System.Drawing.Size(116, 20);
            this.Button_AddServer.TabIndex = 7;
            this.Button_AddServer.Text = "Add Server";
            this.Button_AddServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_AddServer.UseVisualStyleBackColor = false;
            this.Button_AddServer.Click += new System.EventHandler(this.Button_AddServer_Click);
            // 
            // label_S_PlayerList
            // 
            this.label_S_PlayerList.AutoSize = true;
            this.label_S_PlayerList.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_PlayerList.Location = new System.Drawing.Point(3, 108);
            this.label_S_PlayerList.Name = "label_S_PlayerList";
            this.label_S_PlayerList.Size = new System.Drawing.Size(54, 13);
            this.label_S_PlayerList.TabIndex = 1;
            this.label_S_PlayerList.Text = "Player list:";
            // 
            // label_S_Game
            // 
            this.label_S_Game.AutoSize = true;
            this.label_S_Game.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_Game.Location = new System.Drawing.Point(3, 91);
            this.label_S_Game.Name = "label_S_Game";
            this.label_S_Game.Size = new System.Drawing.Size(38, 13);
            this.label_S_Game.TabIndex = 1;
            this.label_S_Game.Text = "Game:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Name.Location = new System.Drawing.Point(36, 52);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "NaN";
            // 
            // label_S_Players
            // 
            this.label_S_Players.AutoSize = true;
            this.label_S_Players.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_Players.Location = new System.Drawing.Point(3, 78);
            this.label_S_Players.Name = "label_S_Players";
            this.label_S_Players.Size = new System.Drawing.Size(47, 13);
            this.label_S_Players.TabIndex = 1;
            this.label_S_Players.Text = "Players: ";
            // 
            // ListBoxPlayersSS
            // 
            this.ListBoxPlayersSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ListBoxPlayersSS.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ListBoxPlayersSS.FormattingEnabled = true;
            this.ListBoxPlayersSS.Location = new System.Drawing.Point(6, 121);
            this.ListBoxPlayersSS.Name = "ListBoxPlayersSS";
            this.ListBoxPlayersSS.Size = new System.Drawing.Size(205, 173);
            this.ListBoxPlayersSS.TabIndex = 6;
            this.ListBoxPlayersSS.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlayersSS_SelectedIndexChanged);
            // 
            // label_Map
            // 
            this.label_Map.AutoSize = true;
            this.label_Map.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_Map.Location = new System.Drawing.Point(29, 65);
            this.label_Map.Name = "label_Map";
            this.label_Map.Size = new System.Drawing.Size(29, 13);
            this.label_Map.TabIndex = 1;
            this.label_Map.Text = "NaN";
            // 
            // label_S_Info
            // 
            this.label_S_Info.AutoSize = true;
            this.label_S_Info.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_Info.Location = new System.Drawing.Point(50, 270);
            this.label_S_Info.Name = "label_S_Info";
            this.label_S_Info.Size = new System.Drawing.Size(125, 13);
            this.label_S_Info.TabIndex = 1;
            this.label_S_Info.Text = "Creator: Ajnur Karachurin\r\n";
            this.label_S_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_S_Map
            // 
            this.label_S_Map.AutoSize = true;
            this.label_S_Map.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_Map.Location = new System.Drawing.Point(3, 65);
            this.label_S_Map.Name = "label_S_Map";
            this.label_S_Map.Size = new System.Drawing.Size(34, 13);
            this.label_S_Map.TabIndex = 1;
            this.label_S_Map.Text = "Map: ";
            // 
            // ComboBox_Servers
            // 
            this.ComboBox_Servers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ComboBox_Servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Servers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_Servers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboBox_Servers.FormattingEnabled = true;
            this.ComboBox_Servers.Location = new System.Drawing.Point(6, 26);
            this.ComboBox_Servers.Name = "ComboBox_Servers";
            this.ComboBox_Servers.Size = new System.Drawing.Size(205, 21);
            this.ComboBox_Servers.Sorted = true;
            this.ComboBox_Servers.TabIndex = 0;
            this.ComboBox_Servers.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Servers_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ButtonAdd.CausesValidation = false;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ButtonAdd.Location = new System.Drawing.Point(140, 36);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(34, 20);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ButtonDel.Location = new System.Drawing.Point(180, 36);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(37, 20);
            this.ButtonDel.TabIndex = 4;
            this.ButtonDel.Text = "Del";
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // textBoxNick
            // 
            this.textBoxNick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.textBoxNick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNick.ForeColor = System.Drawing.Color.White;
            this.textBoxNick.Location = new System.Drawing.Point(12, 36);
            this.textBoxNick.MaxLength = 300;
            this.textBoxNick.Multiline = true;
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(122, 20);
            this.textBoxNick.TabIndex = 3;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Header.Controls.Add(this.HeadName);
            this.Header.Controls.Add(this.HeadLogo);
            this.Header.Controls.Add(this.SmallWindows);
            this.Header.Controls.Add(this.ExitButton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(664, 30);
            this.Header.TabIndex = 2;
            // 
            // HeadName
            // 
            this.HeadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.HeadName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.HeadName.Location = new System.Drawing.Point(30, 0);
            this.HeadName.Name = "HeadName";
            this.HeadName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.HeadName.Size = new System.Drawing.Size(574, 30);
            this.HeadName.TabIndex = 4;
            this.HeadName.Text = "DeletedTest - SearchServerPlayer";
            this.HeadName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeadName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Down);
            this.HeadName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Move);
            // 
            // HeadLogo
            // 
            this.HeadLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeadLogo.Controls.Add(this.pictureBox_Logo);
            this.HeadLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeadLogo.Location = new System.Drawing.Point(0, 0);
            this.HeadLogo.Name = "HeadLogo";
            this.HeadLogo.Size = new System.Drawing.Size(30, 30);
            this.HeadLogo.TabIndex = 3;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = global::DT_SearchPlayerRestart.Properties.Resources.logo_haivan_cricle;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Down);
            this.pictureBox_Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Move);
            // 
            // SmallWindows
            // 
            this.SmallWindows.Controls.Add(this.PictureBox_Small);
            this.SmallWindows.Dock = System.Windows.Forms.DockStyle.Right;
            this.SmallWindows.Location = new System.Drawing.Point(604, 0);
            this.SmallWindows.Name = "SmallWindows";
            this.SmallWindows.Size = new System.Drawing.Size(30, 30);
            this.SmallWindows.TabIndex = 1;
            this.SmallWindows.Click += new System.EventHandler(this.OneButton_Click);
            this.SmallWindows.MouseLeave += new System.EventHandler(this.OneButton_ColorWhile);
            this.SmallWindows.MouseHover += new System.EventHandler(this.OneButton_ColorRed);
            // 
            // PictureBox_Small
            // 
            this.PictureBox_Small.Enabled = false;
            this.PictureBox_Small.Image = global::DT_SearchPlayerRestart.Properties.Resources.header_minimaze_white;
            this.PictureBox_Small.Location = new System.Drawing.Point(6, 15);
            this.PictureBox_Small.Name = "PictureBox_Small";
            this.PictureBox_Small.Size = new System.Drawing.Size(18, 1);
            this.PictureBox_Small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Small.TabIndex = 3;
            this.PictureBox_Small.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Controls.Add(this.pictureBox_Exit);
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Location = new System.Drawing.Point(634, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_ColorWhile);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_ColorRed);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Enabled = false;
            this.pictureBox_Exit.Image = global::DT_SearchPlayerRestart.Properties.Resources.header_exit_white;
            this.pictureBox_Exit.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 3;
            this.pictureBox_Exit.TabStop = false;
            // 
            // Panel_Line
            // 
            this.Panel_Line.BackColor = System.Drawing.Color.Black;
            this.Panel_Line.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Line.Location = new System.Drawing.Point(222, 30);
            this.Panel_Line.Name = "Panel_Line";
            this.Panel_Line.Size = new System.Drawing.Size(1, 307);
            this.Panel_Line.TabIndex = 9;
            // 
            // Panel_OnlinePlayers
            // 
            this.Panel_OnlinePlayers.Controls.Add(this.label_S_Info3);
            this.Panel_OnlinePlayers.Controls.Add(this.panel2);
            this.Panel_OnlinePlayers.Controls.Add(this.panel1);
            this.Panel_OnlinePlayers.Controls.Add(this.label_S_Info2);
            this.Panel_OnlinePlayers.Controls.Add(this.label_S_Info);
            this.Panel_OnlinePlayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_OnlinePlayers.Location = new System.Drawing.Point(217, 0);
            this.Panel_OnlinePlayers.Name = "Panel_OnlinePlayers";
            this.Panel_OnlinePlayers.Size = new System.Drawing.Size(224, 307);
            this.Panel_OnlinePlayers.TabIndex = 8;
            // 
            // ListBox_OnlinePlayers
            // 
            this.ListBox_OnlinePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ListBox_OnlinePlayers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ListBox_OnlinePlayers.FormattingEnabled = true;
            this.ListBox_OnlinePlayers.Location = new System.Drawing.Point(7, 26);
            this.ListBox_OnlinePlayers.Name = "ListBox_OnlinePlayers";
            this.ListBox_OnlinePlayers.Size = new System.Drawing.Size(205, 173);
            this.ListBox_OnlinePlayers.TabIndex = 6;
            this.ListBox_OnlinePlayers.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlayersSS_SelectedIndexChanged);
            // 
            // Panel_Line2
            // 
            this.Panel_Line2.BackColor = System.Drawing.Color.Black;
            this.Panel_Line2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Line2.Location = new System.Drawing.Point(216, 0);
            this.Panel_Line2.Name = "Panel_Line2";
            this.Panel_Line2.Size = new System.Drawing.Size(1, 307);
            this.Panel_Line2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListBox_OnlinePlayers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 204);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online player list:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 1);
            this.panel2.TabIndex = 8;
            // 
            // label_S_Info2
            // 
            this.label_S_Info2.AutoSize = true;
            this.label_S_Info2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_S_Info2.Location = new System.Drawing.Point(54, 283);
            this.label_S_Info2.Name = "label_S_Info2";
            this.label_S_Info2.Size = new System.Drawing.Size(24, 13);
            this.label_S_Info2.TabIndex = 1;
            this.label_S_Info2.Text = "VK:";
            this.label_S_Info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_S_Info3
            // 
            this.label_S_Info3.AutoSize = true;
            this.label_S_Info3.Location = new System.Drawing.Point(73, 283);
            this.label_S_Info3.Name = "label_S_Info3";
            this.label_S_Info3.Size = new System.Drawing.Size(97, 13);
            this.label_S_Info3.TabIndex = 9;
            this.label_S_Info3.TabStop = true;
            this.label_S_Info3.Text = "vk.com/3adrotshot";
            this.label_S_Info3.Click += new System.EventHandler(this.label_S_Info3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletedTest";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel_Server.ResumeLayout(false);
            this.panel_Server.PerformLayout();
            this.Header.ResumeLayout(false);
            this.HeadLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.SmallWindows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Small)).EndInit();
            this.ExitButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.Panel_OnlinePlayers.ResumeLayout(false);
            this.Panel_OnlinePlayers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SmallWindows;
        private System.Windows.Forms.Panel ExitButton;
        private System.Windows.Forms.Label HeadName;
        private System.Windows.Forms.Panel HeadLogo;
        private System.Windows.Forms.PictureBox PictureBox_Small;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Panel panel_Server;
        private System.Windows.Forms.ListBox ListBoxEnabled;
        public System.Windows.Forms.Button AddEnable2Disable;
        public System.Windows.Forms.Button AddDisable2Enable;
        private System.Windows.Forms.Label label_S_EnableLB;
        private System.Windows.Forms.ListBox ListBoxDisable;
        private System.Windows.Forms.Label label_S_DisableLB;
        private System.Windows.Forms.Label label_S_Game;
        private System.Windows.Forms.Label label_S_Players;
        private System.Windows.Forms.Label label_S_Info;
        private System.Windows.Forms.Label label_S_Map;
        private System.Windows.Forms.Label label_S_PlayerList;
        private System.Windows.Forms.Button Button_DelServer;
        private System.Windows.Forms.Button Button_AddServer;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        public System.Windows.Forms.Label label_Map;
        public System.Windows.Forms.Label label_Game;
        public System.Windows.Forms.Label label_Players;
        public System.Windows.Forms.Label label_Name;
        public System.Windows.Forms.ComboBox ComboBox_Servers;
        public System.Windows.Forms.ListBox ListBoxPlayersSS;
        private System.Windows.Forms.Panel Panel_Line;
        private System.Windows.Forms.Panel Panel_Line2;
        private System.Windows.Forms.Panel Panel_OnlinePlayers;
        public System.Windows.Forms.ListBox ListBox_OnlinePlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel label_S_Info3;
        private System.Windows.Forms.Label label_S_Info2;
    }
}
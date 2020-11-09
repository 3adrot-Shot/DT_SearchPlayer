namespace DT_SearchPlayerRestart
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderName = new System.Windows.Forms.Label();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.Label_S_Status = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.TextBox_Ip = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.Label_S_Name = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.HeaderPanel.Controls.Add(this.HeaderName);
            this.HeaderPanel.Controls.Add(this.ExitPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(236, 30);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderName
            // 
            this.HeaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.HeaderName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.HeaderName.Location = new System.Drawing.Point(0, 0);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(206, 30);
            this.HeaderName.TabIndex = 1;
            this.HeaderName.Text = "Add Server";
            this.HeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Down);
            this.HeaderName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Move);
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.pictureBox_Exit);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPanel.Location = new System.Drawing.Point(206, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(30, 30);
            this.ExitPanel.TabIndex = 0;
            this.ExitPanel.Click += new System.EventHandler(this.ExitPanel_Click);
            this.ExitPanel.MouseLeave += new System.EventHandler(this.ExitButton_ColorWhile);
            this.ExitPanel.MouseHover += new System.EventHandler(this.ExitButton_ColorRed);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Enabled = false;
            this.pictureBox_Exit.Image = global::DT_SearchPlayerRestart.Properties.Resources.header_exit_white;
            this.pictureBox_Exit.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 4;
            this.pictureBox_Exit.TabStop = false;
            // 
            // Label_S_Status
            // 
            this.Label_S_Status.AutoSize = true;
            this.Label_S_Status.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_S_Status.Location = new System.Drawing.Point(12, 62);
            this.Label_S_Status.Name = "Label_S_Status";
            this.Label_S_Status.Size = new System.Drawing.Size(40, 13);
            this.Label_S_Status.TabIndex = 3;
            this.Label_S_Status.Text = "Status:";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Status.Location = new System.Drawing.Point(47, 62);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(101, 13);
            this.Label_Status.TabIndex = 3;
            this.Label_Status.Text = "Please press Check";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ButtonCheck.CausesValidation = false;
            this.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheck.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ButtonCheck.Location = new System.Drawing.Point(178, 40);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(46, 20);
            this.ButtonCheck.TabIndex = 5;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.UseVisualStyleBackColor = false;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // TextBox_Ip
            // 
            this.TextBox_Ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TextBox_Ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Ip.ForeColor = System.Drawing.Color.White;
            this.TextBox_Ip.Location = new System.Drawing.Point(15, 40);
            this.TextBox_Ip.MaxLength = 25;
            this.TextBox_Ip.Multiline = true;
            this.TextBox_Ip.Name = "TextBox_Ip";
            this.TextBox_Ip.Size = new System.Drawing.Size(157, 20);
            this.TextBox_Ip.TabIndex = 6;
            this.TextBox_Ip.Text = "62.122.213.145:27777";
            this.TextBox_Ip.TextChanged += new System.EventHandler(this.TextBox_Ip_TextChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ButtonAdd.CausesValidation = false;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ButtonAdd.Location = new System.Drawing.Point(12, 94);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(209, 20);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add server";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Label_S_Name
            // 
            this.Label_S_Name.AutoSize = true;
            this.Label_S_Name.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Label_S_Name.Location = new System.Drawing.Point(14, 77);
            this.Label_S_Name.Name = "Label_S_Name";
            this.Label_S_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_S_Name.TabIndex = 3;
            this.Label_S_Name.Text = "Name:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Label_Name.Location = new System.Drawing.Point(47, 77);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(29, 13);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "NaN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(236, 124);
            this.Controls.Add(this.TextBox_Ip);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_S_Name);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_S_Status);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add server";
            this.HeaderPanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label HeaderName;
        private System.Windows.Forms.Label Label_S_Status;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.TextBox TextBox_Ip;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label Label_S_Name;
        private System.Windows.Forms.Label Label_Name;
    }
}
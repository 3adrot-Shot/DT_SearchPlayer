using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DT_SearchPlayerRestart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.DarkRed;
            Application.Exit();
        }
        private void ExitButton_ColorRed(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.DarkRed;
        }
        private void ExitButton_ColorWhile(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(37, 37, 38);
        }
        // 1 Button
        private void OneButton_Click(object sender, EventArgs e)
        {
            Program.Form1.WindowState = FormWindowState.Minimized;
        }
        private void OneButton_ColorRed(object sender, EventArgs e)
        {
            SmallWindows.BackColor = Color.FromArgb(28, 28, 28);
        }
        private void OneButton_ColorWhile(object sender, EventArgs e)
        {
            SmallWindows.BackColor = Color.FromArgb(37, 37, 38);
        }
        // Header move
        Point point;
        private void Panel_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Panel_Down(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNick.Text.Length != 0) {
                if (!ListBoxEnabled.Items.Contains(textBoxNick.Text) && !ListBoxDisable.Items.Contains(textBoxNick.Text))
                {
                    ListBoxEnabled.Items.Add(textBoxNick.Text);
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            ListBoxDisable.Items.Remove(textBoxNick.Text);
            ListBoxEnabled.Items.Remove(textBoxNick.Text);
        }

        private void ListBoxEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEnabled.SelectedItem != null)
            {
                if (ListBoxDisable.SelectedItem != null) 
                {
                    ListBoxDisable.SelectedItem = null;
                }
                if (ListBoxPlayersSS.SelectedItem != null)
                {
                    ListBoxPlayersSS.SelectedItem = null;
                }
                textBoxNick.Text = ListBoxEnabled.SelectedItem.ToString();
            }
        }

        private void ListBoxDisable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDisable.SelectedItem != null)
            {
                if (ListBoxEnabled.SelectedItem != null) 
                {
                    ListBoxEnabled.SelectedItem = null;
                }
                if (ListBoxPlayersSS.SelectedItem != null)
                {
                    ListBoxPlayersSS.SelectedItem = null;
                }
                textBoxNick.Text = ListBoxDisable.SelectedItem.ToString();
            }
        }
        private void ListBoxPlayersSS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPlayersSS.SelectedItem != null)
            {
                if (ListBoxEnabled.SelectedItem != null)
                {
                    ListBoxEnabled.SelectedItem = null;
                }
                if (ListBoxDisable.SelectedItem != null)
                {
                    ListBoxDisable.SelectedItem = null;
                }
                textBoxNick.Text = ListBoxPlayersSS.SelectedItem.ToString();

            }
        }

        private void AddDisable2Enable_Click(object sender, EventArgs e)
        {
            if (ListBoxDisable.SelectedItem != null)
            {
                ListBoxEnabled.Items.Add(ListBoxDisable.SelectedItem.ToString());
                ListBoxEnabled.SelectedItem = ListBoxDisable.SelectedItem.ToString();
                ListBoxDisable.Items.Remove(ListBoxEnabled.SelectedItem.ToString());
            }
        }

        private void AddEnable2Disable_Click(object sender, EventArgs e)
        {
            if (ListBoxEnabled.SelectedItem != null)
            {
                ListBoxDisable.Items.Add(ListBoxEnabled.SelectedItem.ToString());
                ListBoxDisable.SelectedItem = ListBoxEnabled.SelectedItem.ToString();
                ListBoxEnabled.Items.Remove(ListBoxDisable.SelectedItem.ToString());
            }
        }


        private void MainPanel_Click(object sender, EventArgs e)
        {
            ListBoxEnabled.SelectedItem = null;
            ListBoxDisable.SelectedItem = null;
        }

        private void Button_AddServer_Click(object sender, EventArgs e)
        {
            Program.f2.Show();
        }

        private void Button_DelServer_Click(object sender, EventArgs e)
        {
            Program.Connector.ScanerServerList();
        }

        private void ComboBox_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Header.Focus();
            if (ComboBox_Servers.SelectedItem != null)
            {
                Program.Connector.ServerIp = ComboBox_Servers.SelectedItem.ToString();
            }
        }

        private void Panel_Server_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_S_Info3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vk.com/id140052588");
        }

        private void Label_S_Info4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/3adrot-Shot/DT_SearchPlayer");
        }

        private void Label_S_Info7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://3s.deletedtest.space/DT_SearchServerPlayer");

        }
    }
}

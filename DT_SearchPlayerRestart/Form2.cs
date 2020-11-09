using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DT_SearchPlayerRestart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Access = false;
        }

        string ServerName;
        private HtmlWeb web = new HtmlWeb()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.GetEncoding("utf-8"),
        };
        private HtmlAgilityPack.HtmlDocument HtmlDoc { get; set; }
        private const string XPathHostName = "//div[@class='col-sm-6'][1]/table[@class='table table-bordered table-striped']/tbody/tr[2]/td[2]";
        public bool Access = false;
        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlDoc = web.Load("https://3s.deletedtest.space/?serverip=" + TextBox_Ip.Text);
                try
                {
                    if (HtmlDoc.DocumentNode.SelectSingleNode($"{XPathHostName}") != null)
                    {
                        ServerName = HtmlDoc.DocumentNode.SelectSingleNode($"{XPathHostName}").InnerText;

                        Label_Status.Text = "Server found";
                        Label_Status.ForeColor = Color.DarkGreen;
                        Label_S_Status.ForeColor = Color.DarkGreen;
                        Label_Name.Text = ServerName;
                        Access = true;
                    }
                    else
                    {
                        Label_Status.Text = "Server not found";
                        Label_Status.ForeColor = Color.DarkRed;
                        Label_S_Status.ForeColor = Color.DarkRed;
                        Access = false;
                        ServerName = "NaN";
                        Label_Name.Text = ServerName;
                        return;
                    }
                }
                catch (Exception) 
                {
                    Label_Status.Text = "Server not found";
                    Label_Status.ForeColor = Color.DarkRed;
                    Label_S_Status.ForeColor = Color.DarkRed;
                    Access = false;
                }
            }
            catch (Exception)
            {
                Label_Status.Text = "Error, server did not respond";
                Label_Status.ForeColor = Color.DarkRed;
                Label_S_Status.ForeColor = Color.DarkRed;
                Access = false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ButtonCheck_Click(null, null);
            if ((ServerName != null) && (ServerName.Length != 0) && Access)
            {
                Program.Form1.Invoke((MethodInvoker)delegate {
                    if (!Program.Form1.ComboBox_Servers.Items.Contains(TextBox_Ip.Text))
                    {
                        Program.Form1.ComboBox_Servers.Items.Add(TextBox_Ip.Text);
                    }
                    else
                    {
                        Label_Status.Text = "Server has already been added";
                        Label_Status.ForeColor = Color.DarkRed;
                        Label_S_Status.ForeColor = Color.DarkRed;
                        Access = false;
                    }
                });
            }
            else
            {
                Label_Status.Text = "Server not checked";
                Label_Status.ForeColor = Color.DarkRed;
                Label_S_Status.ForeColor = Color.DarkRed;
                Access = false;
            }
        }
        // Exit Button
        private void ExitPanel_Click(object sender, EventArgs e)
        {
            Program.f2.Hide();
        } 
        private void ExitButton_ColorRed(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.DarkRed;
        }
        private void ExitButton_ColorWhile(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(37, 37, 38);
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

        private void TextBox_Ip_TextChanged(object sender, EventArgs e)
        {
            Label_Status.Text = "Server not checked";
            Label_Status.ForeColor = Color.DarkRed;
            Label_S_Status.ForeColor = Color.DarkRed;
            ServerName = "NaN";
            Label_Name.Text = ServerName;
            Access = false;
        }
    }
}

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace DT_SearchPlayerRestart
{
    class Connector
    {
        private const string XPathOnlinePlayers = "//div[@class='col-sm-6'][2]/table[@class='table table-bordered table-striped']/thead/tr/th[1]/span[@class='label label-info']";
        private const string XPathMap = "//div[@class='col-sm-6'][1]/table[@class='table table-bordered table-striped']/tbody/tr[3]/td[2]";
        private const string XPathMaxPlayers = "//div[@class='col-sm-6'][1]/table[@class='table table-bordered table-striped']/tbody/tr[8]/td[2]";
        private const string XPathHostName = "//div[@class='col-sm-6'][1]/table[@class='table table-bordered table-striped']/tbody/tr[2]/td[2]";
        private const string XPathGame = "//div/div[1]/div[1]/table/tbody/tr[4]/td[2]";
        public string ServerIp = "", ServerName, ServerPlayersOM, ServerGame, ServerMap;
        /*public List<> PlayerList = new */
        private HtmlAgilityPack.HtmlDocument HtmlDoc { get; set; }
        int sum;
        string Player;
        //ListBox.ObjectCollection PlayerList = Program.Form1.ListBoxPlayersSS.Items;
        public void Start()
        {
            while (true)
            {
                try
                {
                    HtmlWeb web = new HtmlWeb()
                    {
                        AutoDetectEncoding = false,
                        OverrideEncoding = Encoding.GetEncoding("utf-8")
                    };
                    while (true)
                    {
                        HtmlDoc = web.Load("https://3s.deletedtest.space/?serverip=" + ServerIp);
                        if (HtmlDoc.DocumentNode.SelectSingleNode($"{XPathHostName}") != null)
                        {
                            ServerName = HtmlDoc.DocumentNode.SelectSingleNode($"{XPathHostName}").InnerText;
                            ServerPlayersOM = $"{HtmlDoc.DocumentNode.SelectSingleNode($"{XPathOnlinePlayers}").InnerText}/{HtmlDoc.DocumentNode.SelectSingleNode($"{XPathMaxPlayers}").InnerText}";
                            ServerGame = HtmlDoc.DocumentNode.SelectSingleNode($"{XPathGame}").InnerText;
                            ServerMap = HtmlDoc.DocumentNode.SelectSingleNode($"{XPathMap}").InnerText;
                            SetInfo(ServerMap, ServerName, ServerPlayersOM, ServerGame);
                            sum = 1;
                            Player = "";
                            Program.Form1.Invoke((MethodInvoker)delegate
                            {
                                Program.Form1.ListBoxPlayersSS.Items.Clear();
                            });
                            while (true)
                            {
                                try
                                {
                                    if (HtmlDoc.DocumentNode.SelectSingleNode($"//div[@class='col-sm-6'][2]/table[@class='table table-bordered table-striped']/tbody/tr[{sum}]/td[{1}]") != null)
                                    {
                                        Player = HtmlDoc.DocumentNode.SelectSingleNode($"//div[@class='col-sm-6'][2]/table[@class='table table-bordered table-striped']/tbody/tr[{sum}]/td[{1}]").InnerText;
                                    }
                                    else
                                    {
                                        Player = "";
                                        break;
                                    }
                                    if (Player.Length != 0)
                                    {
                                        Program.Form1.Invoke((MethodInvoker)delegate
                                        {
                                            if (!Program.Form1.ListBoxPlayersSS.Items.Contains(Player))
                                            {
                                                Program.Form1.ListBoxPlayersSS.Items.Add(Player);
                                            }
                                        });
                                    }
                                    sum++;
                                }
                                catch (Exception)
                                {
                                    break;
                                }
                            }
                            Thread.Sleep(5000);
                        }
                        else
                        {
                            if (ServerIp.Length == 0)
                            {
                                SetInfo("NaN", "NaN", "NaN", "NaN");
                            }
                            else
                            {
                                SetInfo("NaN", "NaN", "NaN", "NaN");
                            }
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }
            }
        }
        public void ScanerServerList()
        {

        }
        public void SetInfo(string Map, string Name, string Players, string Game)
        {
            Program.Form1.Invoke((MethodInvoker)delegate {
                Program.Form1.label_Map.Text = Map;
                Program.Form1.label_Name.Text = Name;
                Program.Form1.label_Players.Text = Players;
                Program.Form1.label_Game.Text = Game;
            });
        }
    }
}

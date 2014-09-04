using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Xml.Linq;
using System.Web;
using System.Diagnostics;

namespace Arma_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paths Paths = new Paths();
            Paths.Show();
        }

        private void defaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }

        private void SelectPreviousMods()
        {
            // Read XML Config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            var modStr = doc.SelectSingleNode("/config/mods").InnerText;
            doc.Save(path);

            // Convert mod string into string array
            string[] split = modStr.Split(new Char[] {';'});

            // Loop mod string array and check items matching value
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    int index = modCheckList.Items.IndexOf(s);

                    if (index >= 0)
                    {
                        modCheckList.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadModList();
            SelectPreviousMods();
        }

        public void LoadModList()
        {
			// Clear mod list
            modCheckList.Items.Clear();

			// Read XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            var a2Path = doc.SelectSingleNode("/config/paths/arma2").InnerText;
            var a2OAPath = doc.SelectSingleNode("/config/paths/arma2_oa").InnerText;

			// Check if path entered
            if (a2OAPath.Length > 0)
            {
				// Check if directory exists
                if (Directory.Exists(a2OAPath))
                {
					// Populate mod list
                    foreach (string s in Directory.GetDirectories(a2OAPath))
                    {
                        string dirName = new DirectoryInfo(s).Name;
                        if (dirName[0].ToString() == "@")
                        {
                            modCheckList.Items.Add(dirName);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The path " + a2OAPath + " does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please specify the game paths in Options > Paths.");
            }

            doc.Save(path);
        }

        private string GetCheckedMods()
        {
            string result = "";

			// Loop checked items in mod list and concatenate strings with semicolon for launch parameters
            foreach (object itemChecked in modCheckList.CheckedItems)
            {
                result += itemChecked.ToString() + ";";
            }

            return result;
        }

        private void SaveCheckedMods()
        {
            string mods = GetCheckedMods();

			// Write to XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            doc.SelectSingleNode("/config/mods").InnerText = mods;
            doc.Save(path);
        }

        private void CompileLaunchParams()
        {
            string launchStr = "";

			// Read XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);

			// Store game paths in local vars
            string gamePath_a2 = doc.SelectSingleNode("/config/paths/arma2").InnerText;
            string gamePath_a2oa = doc.SelectSingleNode("/config/paths/arma2_oa").InnerText;

			// Concatenate launch param string with parsed XML values
            launchStr += (doc.SelectSingleNode("/config/settings/no_splash").InnerText == "True") ? "-nosplash " : " ";
            launchStr += (doc.SelectSingleNode("/config/settings/no_pause").InnerText == "True") ? "-nopause " : " ";
            launchStr += (doc.SelectSingleNode("/config/settings/empty_world").InnerText == "True") ? "-world=empty " : " ";
            launchStr += (doc.SelectSingleNode("/config/settings/windowed").InnerText == "True") ? "-window " : " ";
            launchStr += (doc.SelectSingleNode("/config/settings/cts").InnerText == "True") ? "-connect=" + doc.SelectSingleNode("/config/server/ip").InnerText + " -port=" + doc.SelectSingleNode("/config/server/port").InnerText + " " : " ";
            launchStr += "-cpuCount=" + doc.SelectSingleNode("/config/settings/cpu_cores").InnerText + " ";
            launchStr += @"""-mod=" + gamePath_a2 + ";" + gamePath_a2oa + @"\expansion""";
            launchStr += @" ""-mod=" + GetCheckedMods() + @"""";

			// Parse game path
            string filename = Path.Combine(gamePath_a2oa, "ArmA2OA.exe");

			// Start game process as administrator
            ProcessStartInfo info = new ProcessStartInfo(filename);
            info.UseShellExecute = true;
            info.Verb = "runas";
            info.Arguments = launchStr;
            Process.Start(info);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            CompileLaunchParams();
        }

        private void modCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCheckedMods();
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}
    }
}

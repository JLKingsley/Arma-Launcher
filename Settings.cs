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

namespace Arma_Launcher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            // Set local vars (true/false) if checked
            var no_splash = (no_splashCHK != null && no_splashCHK.Checked) ? true : false;
            var no_pause = (no_pauseCHK != null && no_pauseCHK.Checked) ? true : false;
            var empty_world = (empty_worldCHK != null && empty_worldCHK.Checked) ? true : false;
            var windowed = (windowedCHK != null && windowedCHK.Checked) ? true : false;
            var cts = (ctsChk != null && ctsChk.Checked) ? true : false;
            var cpu_cores = cpuCoreCount.SelectedItem;

			// Write to XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            doc.SelectSingleNode("/config/settings/no_splash").InnerText = no_splash.ToString();
            doc.SelectSingleNode("/config/settings/no_pause").InnerText = no_pause.ToString();
            doc.SelectSingleNode("/config/settings/empty_world").InnerText = empty_world.ToString();
            doc.SelectSingleNode("/config/settings/windowed").InnerText = windowed.ToString();
            doc.SelectSingleNode("/config/settings/cpu_cores").InnerText = cpu_cores.ToString();
            doc.SelectSingleNode("/config/settings/cts").InnerText = cts.ToString();
            doc.SelectSingleNode("/config/server/ip").InnerText = serverIP.Text;
            doc.SelectSingleNode("/config/server/port").InnerText = serverPort.Text;
            doc.Save(path);

			// Close Settings form
            this.Close();

			// Create object of main Form1 and call function LoadModList()
            Form1 main = new Form1();
            main.LoadModList();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
			// Read XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);

			// Set program values based on XML values
            no_splashCHK.Checked = (doc.SelectSingleNode("/config/settings/no_splash").InnerText == "True") ? true : false;
            no_pauseCHK.Checked = (doc.SelectSingleNode("/config/settings/no_pause").InnerText == "True") ? true : false;
            empty_worldCHK.Checked = (doc.SelectSingleNode("/config/settings/empty_world").InnerText == "True") ? true : false;
            windowedCHK.Checked = (doc.SelectSingleNode("/config/settings/windowed").InnerText == "True") ? true : false;
            ctsChk.Checked = (doc.SelectSingleNode("/config/settings/cts").InnerText == "True") ? true : false;
            cpuCoreCount.SelectedItem = doc.SelectSingleNode("/config/settings/cpu_cores").InnerText;
            serverIP.Text = doc.SelectSingleNode("/config/server/ip").InnerText;
            serverPort.Text = doc.SelectSingleNode("/config/server/port").InnerText;

            doc.Save(path);
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctsChk_CheckedChanged(object sender, EventArgs e)
        {
			// If "Connect to Server" is checked - enable IP and Port boxes otherwise disable
            var ctsBool = (ctsChk != null && ctsChk.Checked) ? true : false;
            if (ctsBool)
            {
                serverIP.Enabled = true;
                serverPort.Enabled = true;
            }
            else
            {
                serverIP.Enabled = false;
                serverPort.Enabled = false;
            }
        }
    }
}

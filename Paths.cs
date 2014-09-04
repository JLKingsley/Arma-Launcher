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
    public partial class Paths : Form
    {
        public Paths()
        {
            InitializeComponent();
        }

        private void btnPathsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPathsSave_Click(object sender, EventArgs e)
        {
            // Set local vars
            var a2path = arma2Path.Text;
            var a2oapath = arma2OAPath.Text;

			// Write to XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            doc.SelectSingleNode("/config/paths/arma2").InnerText = a2path.ToString();
            doc.SelectSingleNode("/config/paths/arma2_oa").InnerText = a2oapath.ToString();
            doc.Save(path);

            this.Close();

			// Create object of main Form1 and call function LoadModList()
            Form1 main = new Form1();
            main.LoadModList();
        }

        private void Paths_Load(object sender, EventArgs e)
        {
			// Read from XML config
            XmlDocument doc = new XmlDocument();
            string path = core.AppDirectory + @"\config.xml";
            doc.Load(path);
            arma2Path.Text = doc.SelectSingleNode("/config/paths/arma2").InnerText;
            arma2OAPath.Text = doc.SelectSingleNode("/config/paths/arma2_oa").InnerText;
            doc.Save(path);
        }
    }
}

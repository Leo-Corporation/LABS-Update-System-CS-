using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LABS_Custom_Update_System
{
    public partial class MAJ_AV : Form
    {
        public MAJ_AV()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WebClient MAJ2 = new WebClient();
            string downloadLink = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt");
            Process.Start(downloadLink);
        }

        private void MAJ_AV_Load(object sender, EventArgs e)
        {
            WebClient MAJ = new WebClient();
            WebClient Four = new WebClient();
            string derniereVersion = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/ftrj49vyiab1otr/version2.txt");
            string fourMaj = Four.DownloadString("https://dl.dropboxusercontent.com/s/mm42oc10z41na4v/fournisseur.txt");
            label2.Text = "Version : " + derniereVersion;
            label3.Text = "Fournisseur : " + fourMaj;
        }
    }
}

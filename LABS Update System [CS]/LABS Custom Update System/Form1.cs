using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABS_Custom_Update_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            checkUpdateAv();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            checkUpdateUn();
        }
        static void checkUpdateAv()
        {
            WebClient MAJ = new WebClient();
            WebClient Four = new WebClient();
            string derniereVersion = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/ftrj49vyiab1otr/version2.txt");
            string versionActuelle = "1.0";
            string fourMaj = Four.DownloadString("https://dl.dropboxusercontent.com/s/mm42oc10z41na4v/fournisseur.txt");
            if (versionActuelle == derniereVersion)
            {
                MAJ_AV maj = new MAJ_AV();
                maj.Show();
            }
            else
            {
                MAJ_UN unmaj = new MAJ_UN();
                unmaj.Show();
            }
        }
        static void checkUpdateUn()
        {
            WebClient MAJ = new WebClient();
            WebClient Four = new WebClient();
            string derniereVersion = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/fq422itj45dszky/version.txt");
            string versionActuelle = "1.0";
            string fourMaj = Four.DownloadString("https://dl.dropboxusercontent.com/s/mm42oc10z41na4v/fournisseur.txt");
            if (versionActuelle == derniereVersion)
            {
                MAJ_AV maj = new MAJ_AV();
                maj.Show();
            }
            else
            {
                MAJ_UN unmaj = new MAJ_UN();
                unmaj.Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
namespace LABS_Update_System__CS_
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
        static void checkUpdateAv()
        {
            WebClient MAJ = new WebClient();
            WebClient Four = new WebClient();
            string derniereVersion = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/ftrj49vyiab1otr/version2.txt");
            string versionActuelle = "1.1";
            string fourMaj = Four.DownloadString("https://dl.dropboxusercontent.com/s/mm42oc10z41na4v/fournisseur.txt");
            if (versionActuelle == derniereVersion)
            {
                MessageBox.Show("Tout est à jour");
            }
            else
            {
                MessageBox.Show("Des mises à jour sont disponibles. \n La dernière version est : " + derniereVersion + "\n Fournisseur : " + fourMaj);
                WebClient MAJ2 = new WebClient();
                string downloadLink = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt");
                Process.Start(downloadLink);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            checkUpdateUn();
        }
        static void checkUpdateUn()
        {
            WebClient MAJ = new WebClient();
            WebClient Four = new WebClient();
            string derniereVersion = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/fq422itj45dszky/version.txt");
            string versionActuelle = "1.1";
            string fourMaj = Four.DownloadString("https://dl.dropboxusercontent.com/s/mm42oc10z41na4v/fournisseur.txt");
            if (versionActuelle == derniereVersion)
            {
                MessageBox.Show("Tout est à jour");
            }
            else
            {
                MessageBox.Show("Des mises à jour sont disponibles. \n La dernière version est : " + derniereVersion + "\n Fournisseur : " + fourMaj);
                WebClient MAJ2 = new WebClient();
                string downloadLink = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt");
                Process.Start(downloadLink);
            }
        }
    }
}

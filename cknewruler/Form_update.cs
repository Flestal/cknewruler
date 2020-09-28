using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cknewruler
{
    public partial class Form_update : Form
    {
        GitHubClient client = new GitHubClient(new ProductHeaderValue("cknewruler"));
        public Form_update()
        {
            InitializeComponent();
            var release = client.Repository.Release.GetLatest("Flestal", "cknewruler");
            string news= release.Result.Body;
            label1.Text = news;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(client.Repository.Release.GetLatest("Flestal", "cknewruler").Result.HtmlUrl);
            System.Windows.Forms.Application.Exit();
        }
    }
}

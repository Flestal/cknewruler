using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cknewruler
{
    public partial class Form_firststart : Form
    {
        RegistryKey reg = Registry.CurrentUser;
        string val;
        public Form_firststart()
        {
            InitializeComponent();
            reg = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", false);
            val = Convert.ToString(reg.GetValue("Personal"));
            val += "\\CK_CustomKingdom\\CSV";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(val);
            if (!d.Exists)
            {
                d.Create();
            }
            Process.Start(val);
        }

        private void Form_firststart_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

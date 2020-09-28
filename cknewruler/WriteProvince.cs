using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cknewruler
{
    class WriteProvince
    {
        public void Run(ListBox.ObjectCollection provinces, string charNum, int startYear, DirectoryInfo dir)
        {
            string folderName = randomGen.generateFolderName();
            string provincestr = "";
            foreach (string province in provinces)
            {
                provincestr += province + "={" + startYear.ToString() + ".1.1={holder=" + charNum + "}}";
            }
            File.WriteAllText(dir.ToString() + "\\" + folderName+".txt", provincestr, Encoding.UTF8);
        }
    }
}

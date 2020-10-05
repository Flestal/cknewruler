using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Octokit;

namespace cknewruler
{
    public partial class Form1 : Form
    {
        string version = "1.0.0.0";
        RegistryKey reg = Registry.CurrentUser;
        string val;
        DirectoryInfo dir;
        List<string[]> provinces;//[한글이름, 영어이름, 국가코드]
        List<string> kingdoms;
        Dictionary<string, string> cultures;//한글이름 키, 영어이름 값
        Dictionary<string, string> religions;//한글이름 키, 영어이름 값
        Dictionary<string, string> traits;
        public Form1()
        {
            InitializeComponent();
            GitHubClient client = new GitHubClient(new ProductHeaderValue("cknewruler"));
            var release = client.Repository.Release.GetLatest("Flestal", "cknewruler");

            reg = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", false);
            val = Convert.ToString(reg.GetValue("Personal"));
            val += "\\CK_CustomKingdom";
            dir = new DirectoryInfo(val);
            if (!dir.Exists)
            {
                dir.Create();
            }
            try
            {
                comboBox_kingdom.Items.Clear();
                provinces = readProvinces(val);
                foreach(string kingdom in kingdoms)
                {
                    comboBox_kingdom.Items.Add(kingdom);
                }
                refreshCulture(val);
                refreshReligion(val);
                refreshEmblem(val);
                refreshTraits(val);
            }
            catch (DirectoryNotFoundException)
            {
                Form_firststart f = new Form_firststart();
                f.ShowDialog();
            }
            catch (FileNotFoundException)
            {
                Form_firststart f = new Form_firststart();
                f.ShowDialog();
            }
            label26.Text = "현재 버전 : " + version;
            label27.Text = "최신 버전 : " + release.Result.TagName;
            if (release.Result.TagName != version)
            {
                Form_update f = new Form_update();
                f.ShowDialog();
            }
        }
        void refreshCulture(string dir)
        {
            cultures = new Dictionary<string, string>();
            StreamReader SR = new StreamReader(dir + "\\CSV\\cultures.csv");
            string line;
            char sp = ',';
            while ((line = SR.ReadLine()) != null)
            {
                string[] culture = line.Split(sp);
                cultures.Add(culture[1], culture[0]);
            }
            SR.Close();
            comboBox_culture.Items.Clear();
            foreach (KeyValuePair<string, string> item in cultures)
            {
                if (item.Key != "" && item.Value != "")
                {
                    comboBox_culture.Items.Add(item.Value);
                }
            }
        }
        void refreshReligion(string dir)
        {
            religions = new Dictionary<string, string>();
            StreamReader SR = new StreamReader(dir + "\\CSV\\religions.csv");
            string line;
            char sp = ',';
            while ((line = SR.ReadLine()) != null)
            {
                string[] culture = line.Split(sp);
                religions.Add(culture[0], culture[1]);
            }
            SR.Close();
            comboBox_religion.Items.Clear();
            foreach (KeyValuePair<string, string> item in religions)
            {
                if (item.Key != "" && item.Value != "")
                {
                    comboBox_religion.Items.Add(item.Key);
                }
            }
        }
        void refreshEmblem(string dir)
        {
            StreamReader SR = new StreamReader(dir + "\\CSV\\emblems.csv");
            string line;
            char sp = ',';
            comboBox_emblem.Items.Clear();
            comboBox_emblemPattern.Items.Clear();
            while ((line = SR.ReadLine()) != null)
            {
                string[] emblem = line.Split(sp);
                comboBox_emblem.Items.Add(emblem[0]);
            }
            SR.Close();
            SR = new StreamReader(dir + "\\CSV\\patterns.csv");
            while ((line = SR.ReadLine()) != null)
            {
                string[] pattern = line.Split(sp);
                comboBox_emblemPattern.Items.Add(pattern[0]);
            }
        }
        void refreshTraits(string dir)
        {
            traits = new Dictionary<string, string>();//한글 키, 영어 값
            StreamReader SR = new StreamReader(dir + "\\CSV\\traits.csv");
            string line;
            char sp = ',';
            comboBox_Traits.Items.Clear();
            while ((line = SR.ReadLine()) != null)
            {
                string[] split = line.Split(sp);//[0] 영어, [1] 한글
                traits.Add(split[1],split[0]);
                comboBox_Traits.Items.Add(split[1]);
            }
        }
        List<string[]> readProvinces(string dir)
        {
            StreamReader SR = new StreamReader(dir+"\\CSV\\provincelist.csv");
            //Dictionary<string, string[]> returnValue = new Dictionary<string, string[]>();
            List<string[]> returnValue = new List<string[]>();
            kingdoms = new List<string>();
            returnValue.Clear();
            string line;
            char sp = ',';
            while ((line = SR.ReadLine()) != null)
            {
                string[] province = line.Split(sp);
                //returnValue.Add(province[2],temp);
                if (province[0] != "")
                {
                    returnValue.Add(province);
                    if (!kingdoms.Contains(province[2]))
                    {
                        kingdoms.Add(province[2]);
                    }
                }
            }
            SR.Close();
            return returnValue;
        }

        void KingdomSelect(string kingdom)
        {
            comboBox_provinces.Items.Clear();
            foreach(string[] item in provinces)
            {
                if (item[2] == kingdom)
                {
                    comboBox_provinces.Items.Add(item[0]);
                }
            }
        }

        private void btn_tempMake_Click(object sender, EventArgs e)
        {
            string modName = "\\" + textBox_tempName.Text;
            bool isFemale = checkBox_isFemale.Checked;
            DirectoryInfo[] dirs = {
                new DirectoryInfo(val+modName + "\\common"),//dirs[0]
                new DirectoryInfo(val+modName + "\\history"),//dirs[1]
                new DirectoryInfo(val+modName + "\\common\\coat_of_arms"),//dirs[2]
                new DirectoryInfo(val+modName + "\\common\\coat_of_arms\\coat_of_arms"),//dirs[3]
                new DirectoryInfo(val+modName + "\\common\\dna_data"),//dirs[4]
                new DirectoryInfo(val+modName + "\\common\\dynasties"),//dirs[5]
                new DirectoryInfo(val+modName + "\\common\\dynasty_houses"),//dirs[6]
                new DirectoryInfo(val+modName + "\\history\\characters"),//dirs[7]
                new DirectoryInfo(val+modName + "\\history\\titles")//dirs[8]
            };
            foreach (DirectoryInfo d in dirs)
            {
                if (!d.Exists)
                {
                    d.Create();
                }
            }
            makeSign(textBox_tempName.Text);
            //캐릭터 만들기
            writeCharFile(dirs);
            //dna 만들기
            writeDNAFile(dirs);
            //프로빈스 주기
            string province_char = "";
            WriteProvince w = new WriteProvince();
            w.Run(listBox_startProvince.Items, textBox_CharNum.Text,Convert.ToInt32(comboBox_startYear.SelectedItem), dirs[8]);
            //가문 문장 만들기
            writeEmblem(dirs);
            //가문, 집안 만들기
            writeDynastyHouse(dirs);
        }
        void makeSign(string modName_nonDir)
        {
            string modName = "\\" + modName_nonDir;
            string str_modstr = "";
            str_modstr += "version=\"1.0\"";
            str_modstr += Environment.NewLine;
            str_modstr += "tags={";
            str_modstr += Environment.NewLine;
            str_modstr += " \"Gameplay\"";
            str_modstr += Environment.NewLine;
            str_modstr += "}";
            str_modstr += Environment.NewLine;
            str_modstr += "name=\"" + modName_nonDir + "\"";
            str_modstr += Environment.NewLine;
            str_modstr += "supported_version=\"1.1.*\"";
            File.WriteAllText(val + modName + "\\descriptor.mod", str_modstr, Encoding.UTF8);
            str_modstr += Environment.NewLine;
            str_modstr += "path=\"mod/"+modName_nonDir+"\"";
            File.WriteAllText(val + modName + ".mod", str_modstr, Encoding.UTF8);
        }
        
        private void btn_dnaParse_Click(object sender, EventArgs e)
        {
            /*string encrypt = textBox_dna.Text;
            encrypt = Base64Decode(encrypt);
            var decrypt = encrypt.Select(c => Convert.ToString(c, 16)).ToArray();
            textBox_log.Text = decrypt.ToString();*/
            DirectoryInfo[] dirs=new DirectoryInfo[9];
            writeDNAFile(dirs, false);
        }
        
        
        void writeCharFile(DirectoryInfo[] dirs)
        {
            string character = "";
            /*시작연도-나이.1.1={birth=yes}시작연도-나이+70.1.1={death=yes}*/
            character += textBox_CharNum.Text + "={" + Environment.NewLine;
            character += "name = " + textBox_charName.Text + Environment.NewLine;
            if (checkBox_isFemale.Checked) { character += "female = yes"+Environment.NewLine; }
            character += "dynasty = " + textBox_dynNum.Text + Environment.NewLine;
            string selectedReligion = "";
            //character += "religion = " + comboBox_religion.SelectedItem + Environment.NewLine;
            foreach (KeyValuePair<string, string> item in religions)
            {
                if (item.Key == comboBox_religion.SelectedItem)
                {
                    selectedReligion = item.Value;
                    break;
                }
            }
            character += "religion = " + selectedReligion + Environment.NewLine;
            string selectedCulture ="";
            foreach(KeyValuePair<string,string> item in cultures)
            {
                if (item.Value == comboBox_culture.SelectedItem)
                {
                    selectedCulture = item.Key;
                    break;
                }
            }
            //character += "culture = " + comboBox_culture.SelectedItem + Environment.NewLine;
            character += "culture = " + selectedCulture + Environment.NewLine;
            character += "diplomacy = " + textBox_charStat1.Text + Environment.NewLine;
            character += "martial = " + textBox_charStat2.Text + Environment.NewLine;
            character += "stewardship = " + textBox_charStat3.Text + Environment.NewLine;
            character += "intrigue = " + textBox_charStat4.Text + Environment.NewLine;
            character += "learning = " + textBox_charStat5.Text + Environment.NewLine;
            character += "prowess = " + textBox_charStat6.Text + Environment.NewLine;
            foreach (string c in addlist_Traits.Items)
            {
                if (c != "")
                {
                    character += "trait = " + c + Environment.NewLine;
                }
            }
            character += Convert.ToString(Convert.ToInt32(comboBox_startYear.SelectedItem) - Convert.ToInt32(textBox_charAge.Text)) + ".1.1={birth=yes}" + Environment.NewLine;
            character += Convert.ToString(Convert.ToInt32(comboBox_startYear.SelectedItem) - Convert.ToInt32(textBox_charAge.Text) + 70) + ".1.1={death=yes}" + Environment.NewLine;
            character += "dna = " + textBox_tempName.Text + "_dna_entry" + Environment.NewLine;
            character += "}";
            File.WriteAllText(dirs[7].ToString() + "\\" + textBox_tempName.Text + ".txt", character, Encoding.UTF8);
        }
        void writeDNAFile(DirectoryInfo[] dirs,bool write=true)
        {
            textBox_log.Text = DNAGenerator.GenerateDNA(textBox_dna.Text,checkBox_isFemale.Checked,write,dirs[4],textBox_tempName.Text);
        }
        void writeEmblem(DirectoryInfo[] dirs)
        {
           string dynastyEmblem = "";
            dynastyEmblem += textBox_dynNum.Text + "={" + Environment.NewLine;
            dynastyEmblem += "pattern=\"" + comboBox_emblemPattern.SelectedItem + ".dds\""+Environment.NewLine;
            dynastyEmblem += "color1=" + comboBox_PatternColor1.SelectedItem + Environment.NewLine;
            dynastyEmblem += "color2=" + comboBox_PatternColor2.SelectedItem + Environment.NewLine;
            dynastyEmblem += "colored_emblem={" + Environment.NewLine;
            dynastyEmblem += "color1=" + comboBox_emblemColor1.SelectedItem+Environment.NewLine;
            dynastyEmblem += "color2=" + comboBox_emblemColor2.SelectedItem + Environment.NewLine;
            dynastyEmblem += "texture=\"" + comboBox_emblem.SelectedItem + ".dds\""+Environment.NewLine;
            dynastyEmblem += "}"+Environment.NewLine;
            dynastyEmblem += "}";
            File.WriteAllText(dirs[3].ToString() + "\\" + textBox_tempName.Text + "_coa.txt", dynastyEmblem, Encoding.UTF8);
        }
        void writeDynastyHouse(DirectoryInfo[] dirs)
        {
            string dynasty = "";
            string house = "";
            dynasty += textBox_dynNum.Text+"={"+Environment.NewLine;
            dynasty += "name=\"" + textBox_dynName.Text + "\"" + Environment.NewLine;
            dynasty += "found_date=" + Convert.ToString(Convert.ToInt32(comboBox_startYear.SelectedItem) - Convert.ToInt32(textBox_charAge.Text)) + ".1.1" + Environment.NewLine;
            dynasty += "head_of_house=" + textBox_charName.Text + Environment.NewLine;
            dynasty += "dynasty=" + textBox_dynNum.Text + Environment.NewLine;
            dynasty += "historical={ " + textBox_CharNum.Text + " }" + Environment.NewLine;
            dynasty += "coat_of_arms_id=" + textBox_dynNum.Text + Environment.NewLine;
            dynasty += "motto=\"" + textBox_dynMotto.Text + "\"" + Environment.NewLine;
            dynasty += "}";
            house += "house_" + textBox_dynNum.Text + "={"+Environment.NewLine;
            house += "name=\"" + textBox_dynName.Text + "\"" + Environment.NewLine;
            house += "dynasty=" + textBox_dynNum.Text + Environment.NewLine;
            house += "}";
            File.WriteAllText(dirs[5].ToString() + "\\" + textBox_tempName.Text + "_dynasty.txt", dynasty, Encoding.UTF8);
            File.WriteAllText(dirs[6].ToString() + "\\" + textBox_tempName.Text + "_houses.txt", house, Encoding.UTF8);
        }

        private void btn_addTrait_Click(object sender, EventArgs e)
        {
            //addlist_Traits.Items.Add(comboBox_Traits.SelectedItem);
            if (comboBox_Traits.SelectedItem!=null&&traits.ContainsKey(comboBox_Traits.SelectedItem.ToString()))
            {
                addlist_Traits.Items.Add(traits[comboBox_Traits.SelectedItem.ToString()]);
            }
        }

        private void comboBox_kingdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            KingdomSelect(comboBox_kingdom.SelectedItem.ToString());
        }

        private void btn_addProvince_Click(object sender, EventArgs e)
        {
            if (comboBox_provinces.SelectedItem != "")
            {
                foreach(string[] item in provinces)
                {
                    if (item[0] == comboBox_provinces.SelectedItem)
                    {
                        listBox_startProvince.Items.Add(item[1]);
                    }
                }
            }
        }

        private void btn_removeTrait_Click(object sender, EventArgs e)
        {
            if (addlist_Traits.SelectedItem != null)
            {
                addlist_Traits.Items.RemoveAt(addlist_Traits.SelectedIndex);
            }
        }

        private void btn_removeProvince_Click(object sender, EventArgs e)
        {
            if (listBox_startProvince.SelectedItem != null)
            {
                listBox_startProvince.Items.RemoveAt(listBox_startProvince.SelectedIndex);
            }
        }
    }
}

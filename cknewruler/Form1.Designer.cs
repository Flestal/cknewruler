namespace cknewruler
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_Traits = new System.Windows.Forms.ComboBox();
            this.addlist_Traits = new System.Windows.Forms.ListBox();
            this.btn_addTrait = new System.Windows.Forms.Button();
            this.groupBox_startKing = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_culture = new System.Windows.Forms.ComboBox();
            this.comboBox_religion = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_charStat6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_charStat5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_charStat4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_charStat3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_charStat2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_charStat1 = new System.Windows.Forms.TextBox();
            this.checkBox_isFemale = new System.Windows.Forms.CheckBox();
            this.textBox_charName = new System.Windows.Forms.TextBox();
            this.textBox_charAge = new System.Windows.Forms.TextBox();
            this.textBox_dna = new System.Windows.Forms.TextBox();
            this.textBox_CharNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dynNum = new System.Windows.Forms.TextBox();
            this.groupBox_startLand = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Dynasty = new System.Windows.Forms.GroupBox();
            this.comboBox_emblem = new System.Windows.Forms.ComboBox();
            this.comboBox_emblemColor2 = new System.Windows.Forms.ComboBox();
            this.comboBox_PatternColor2 = new System.Windows.Forms.ComboBox();
            this.comboBox_emblemColor1 = new System.Windows.Forms.ComboBox();
            this.comboBox_PatternColor1 = new System.Windows.Forms.ComboBox();
            this.comboBox_emblemPattern = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_dynMotto = new System.Windows.Forms.TextBox();
            this.textBox_dynName = new System.Windows.Forms.TextBox();
            this.groupBox_province = new System.Windows.Forms.GroupBox();
            this.btn_readtitlesFile = new System.Windows.Forms.Button();
            this.btn_addProvince = new System.Windows.Forms.Button();
            this.comboBox_provinces = new System.Windows.Forms.ComboBox();
            this.listBox_startProvince = new System.Windows.Forms.ListBox();
            this.textBox_startYear = new System.Windows.Forms.TextBox();
            this.btn_tempMake = new System.Windows.Forms.Button();
            this.textBox_tempName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.toolTip_readtitlesFile = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.btn_dnaParse = new System.Windows.Forms.Button();
            this.groupBox_startKing.SuspendLayout();
            this.groupBox_startLand.SuspendLayout();
            this.groupBox_Dynasty.SuspendLayout();
            this.groupBox_province.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Traits
            // 
            this.comboBox_Traits.FormattingEnabled = true;
            this.comboBox_Traits.Items.AddRange(new object[] {
            "education_intrigue_1",
            "education_intrigue_2",
            "education_intrigue_3",
            "education_intrigue_4",
            "education_diplomacy_1",
            "education_diplomacy_2",
            "education_diplomacy_3",
            "education_diplomacy_4",
            "education_stewardship_1",
            "education_stewardship_2",
            "education_stewardship_3",
            "education_stewardship_4",
            "education_martial_1",
            "education_martial_2",
            "education_martial_3",
            "education_martial_4",
            "education_learning_1",
            "education_learning_2",
            "education_learning_3",
            "education_learning_4",
            "education_martial_prowess_1",
            "education_martial_prowess_2",
            "education_martial_prowess_3",
            "education_martial_prowess_4",
            "brave",
            "calm",
            "chaste",
            "content",
            "diligent",
            "fickle",
            "forgiving",
            "generous",
            "gregarious",
            "honest",
            "humble",
            "just",
            "patient",
            "temperate",
            "trusting",
            "zealous",
            "compassionate",
            "lustful",
            "gluttonous",
            "greedy",
            "lazy",
            "wrathful",
            "impatient",
            "arrogant",
            "deceitful",
            "craven",
            "shy",
            "ambitious",
            "arbitrary",
            "cynical",
            "paranoid",
            "callous",
            "sadistic",
            "stubborn",
            "vengeful",
            "depressed_1",
            "depressed_genetic",
            "lunatic_1",
            "lunatic_genetic",
            "possessed_1",
            "possessed_genetic",
            "fecund",
            "albino",
            "lisping",
            "stuttering",
            "pure_blooded",
            "giant",
            "scaly",
            "clubfooted",
            "dwarf",
            "hunchbacked",
            "infertile",
            "wheezing",
            "spindly",
            "bleeder",
            "beauty_bad_1",
            "beauty_bad_2",
            "beauty_bad_3",
            "beauty_good_1",
            "beauty_good_2",
            "beauty_good_3",
            "intellect_bad_1",
            "intellect_bad_2",
            "intellect_bad_3",
            "intellect_good_1",
            "intellect_good_2",
            "intellect_good_3",
            "physique_bad_1",
            "physique_bad_2",
            "physique_bad_3",
            "physique_good_1",
            "physique_good_2",
            "physique_good_3",
            "shrewd",
            "strong",
            "scarred",
            "dull",
            "weak",
            "one_eyed",
            "one_legged",
            "disfigured",
            "eunuch",
            "august",
            "diplomat",
            "gallant",
            "overseer",
            "strategist",
            "administrator",
            "architect",
            "avaricious",
            "schemer",
            "seducer",
            "torturer",
            "scholar",
            "theologian",
            "whole_of_body",
            "celibate",
            "family_first",
            "lifestyle_herbalist",
            "physician_1",
            "physician_2",
            "physician_3",
            "blademaster_1",
            "blademaster_2",
            "blademaster_3",
            "hunter_1",
            "hunter_2",
            "hunter_3",
            "mystic_1",
            "mystic_2",
            "mystic_3",
            "reveler_1",
            "reveler_2",
            "reveler_3"});
            this.comboBox_Traits.Location = new System.Drawing.Point(371, 54);
            this.comboBox_Traits.Name = "comboBox_Traits";
            this.comboBox_Traits.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Traits.TabIndex = 0;
            // 
            // addlist_Traits
            // 
            this.addlist_Traits.FormattingEnabled = true;
            this.addlist_Traits.ItemHeight = 20;
            this.addlist_Traits.Location = new System.Drawing.Point(371, 122);
            this.addlist_Traits.Name = "addlist_Traits";
            this.addlist_Traits.Size = new System.Drawing.Size(151, 264);
            this.addlist_Traits.TabIndex = 1;
            // 
            // btn_addTrait
            // 
            this.btn_addTrait.Location = new System.Drawing.Point(371, 88);
            this.btn_addTrait.Name = "btn_addTrait";
            this.btn_addTrait.Size = new System.Drawing.Size(151, 28);
            this.btn_addTrait.TabIndex = 2;
            this.btn_addTrait.Text = "추가";
            this.btn_addTrait.UseVisualStyleBackColor = true;
            // 
            // groupBox_startKing
            // 
            this.groupBox_startKing.Controls.Add(this.label18);
            this.groupBox_startKing.Controls.Add(this.label17);
            this.groupBox_startKing.Controls.Add(this.comboBox_culture);
            this.groupBox_startKing.Controls.Add(this.comboBox_religion);
            this.groupBox_startKing.Controls.Add(this.label16);
            this.groupBox_startKing.Controls.Add(this.label15);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat6);
            this.groupBox_startKing.Controls.Add(this.label14);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat5);
            this.groupBox_startKing.Controls.Add(this.label13);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat4);
            this.groupBox_startKing.Controls.Add(this.label22);
            this.groupBox_startKing.Controls.Add(this.label21);
            this.groupBox_startKing.Controls.Add(this.label12);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat3);
            this.groupBox_startKing.Controls.Add(this.label23);
            this.groupBox_startKing.Controls.Add(this.label24);
            this.groupBox_startKing.Controls.Add(this.label2);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat2);
            this.groupBox_startKing.Controls.Add(this.label1);
            this.groupBox_startKing.Controls.Add(this.textBox_charStat1);
            this.groupBox_startKing.Controls.Add(this.checkBox_isFemale);
            this.groupBox_startKing.Controls.Add(this.textBox_charName);
            this.groupBox_startKing.Controls.Add(this.textBox_charAge);
            this.groupBox_startKing.Controls.Add(this.textBox_dna);
            this.groupBox_startKing.Controls.Add(this.textBox_CharNum);
            this.groupBox_startKing.Controls.Add(this.btn_addTrait);
            this.groupBox_startKing.Controls.Add(this.addlist_Traits);
            this.groupBox_startKing.Controls.Add(this.comboBox_Traits);
            this.groupBox_startKing.Location = new System.Drawing.Point(195, 76);
            this.groupBox_startKing.Name = "groupBox_startKing";
            this.groupBox_startKing.Size = new System.Drawing.Size(528, 392);
            this.groupBox_startKing.TabIndex = 3;
            this.groupBox_startKing.TabStop = false;
            this.groupBox_startKing.Text = "시작 군주 편집";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(248, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "기량";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(233, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "학습력";
            // 
            // comboBox_culture
            // 
            this.comboBox_culture.FormattingEnabled = true;
            this.comboBox_culture.Items.AddRange(new object[] {
            "welsh",
            "norse"});
            this.comboBox_culture.Location = new System.Drawing.Point(57, 359);
            this.comboBox_culture.Name = "comboBox_culture";
            this.comboBox_culture.Size = new System.Drawing.Size(51, 28);
            this.comboBox_culture.TabIndex = 3;
            // 
            // comboBox_religion
            // 
            this.comboBox_religion.FormattingEnabled = true;
            this.comboBox_religion.Items.AddRange(new object[] {
            "insular_celtic",
            "norse_pagan"});
            this.comboBox_religion.Location = new System.Drawing.Point(57, 323);
            this.comboBox_religion.Name = "comboBox_religion";
            this.comboBox_religion.Size = new System.Drawing.Size(51, 28);
            this.comboBox_religion.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 291);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "계책력";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(114, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "관리력";
            // 
            // textBox_charStat6
            // 
            this.textBox_charStat6.Location = new System.Drawing.Point(293, 359);
            this.textBox_charStat6.Name = "textBox_charStat6";
            this.textBox_charStat6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_charStat6.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat6.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "전투력";
            // 
            // textBox_charStat5
            // 
            this.textBox_charStat5.Location = new System.Drawing.Point(293, 323);
            this.textBox_charStat5.Name = "textBox_charStat5";
            this.textBox_charStat5.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat5.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "외교력";
            // 
            // textBox_charStat4
            // 
            this.textBox_charStat4.Location = new System.Drawing.Point(293, 288);
            this.textBox_charStat4.Name = "textBox_charStat4";
            this.textBox_charStat4.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat4.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 362);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "문화";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 326);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 20);
            this.label21.TabIndex = 5;
            this.label21.Text = "종교";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "나이";
            // 
            // textBox_charStat3
            // 
            this.textBox_charStat3.Location = new System.Drawing.Point(174, 359);
            this.textBox_charStat3.Name = "textBox_charStat3";
            this.textBox_charStat3.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat3.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(174, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 20);
            this.label23.TabIndex = 5;
            this.label23.Text = "이름";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 20);
            this.label24.TabIndex = 5;
            this.label24.Text = "DNA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "군주 번호";
            // 
            // textBox_charStat2
            // 
            this.textBox_charStat2.Location = new System.Drawing.Point(174, 323);
            this.textBox_charStat2.Name = "textBox_charStat2";
            this.textBox_charStat2.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "특성";
            // 
            // textBox_charStat1
            // 
            this.textBox_charStat1.Location = new System.Drawing.Point(174, 288);
            this.textBox_charStat1.Name = "textBox_charStat1";
            this.textBox_charStat1.Size = new System.Drawing.Size(51, 27);
            this.textBox_charStat1.TabIndex = 3;
            // 
            // checkBox_isFemale
            // 
            this.checkBox_isFemale.AutoSize = true;
            this.checkBox_isFemale.Location = new System.Drawing.Point(238, 258);
            this.checkBox_isFemale.Name = "checkBox_isFemale";
            this.checkBox_isFemale.Size = new System.Drawing.Size(128, 24);
            this.checkBox_isFemale.TabIndex = 4;
            this.checkBox_isFemale.Text = "여성 군주 여부";
            this.checkBox_isFemale.UseVisualStyleBackColor = true;
            // 
            // textBox_charName
            // 
            this.textBox_charName.Location = new System.Drawing.Point(219, 31);
            this.textBox_charName.Name = "textBox_charName";
            this.textBox_charName.Size = new System.Drawing.Size(74, 27);
            this.textBox_charName.TabIndex = 3;
            // 
            // textBox_charAge
            // 
            this.textBox_charAge.Location = new System.Drawing.Point(57, 288);
            this.textBox_charAge.Name = "textBox_charAge";
            this.textBox_charAge.Size = new System.Drawing.Size(51, 27);
            this.textBox_charAge.TabIndex = 3;
            // 
            // textBox_dna
            // 
            this.textBox_dna.Location = new System.Drawing.Point(15, 96);
            this.textBox_dna.Multiline = true;
            this.textBox_dna.Name = "textBox_dna";
            this.textBox_dna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_dna.Size = new System.Drawing.Size(336, 156);
            this.textBox_dna.TabIndex = 3;
            // 
            // textBox_CharNum
            // 
            this.textBox_CharNum.Location = new System.Drawing.Point(94, 31);
            this.textBox_CharNum.Name = "textBox_CharNum";
            this.textBox_CharNum.Size = new System.Drawing.Size(74, 27);
            this.textBox_CharNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "가문 번호";
            // 
            // textBox_dynNum
            // 
            this.textBox_dynNum.Location = new System.Drawing.Point(90, 30);
            this.textBox_dynNum.Name = "textBox_dynNum";
            this.textBox_dynNum.Size = new System.Drawing.Size(74, 27);
            this.textBox_dynNum.TabIndex = 3;
            // 
            // groupBox_startLand
            // 
            this.groupBox_startLand.Controls.Add(this.label4);
            this.groupBox_startLand.Controls.Add(this.groupBox_Dynasty);
            this.groupBox_startLand.Controls.Add(this.groupBox_province);
            this.groupBox_startLand.Controls.Add(this.groupBox_startKing);
            this.groupBox_startLand.Controls.Add(this.textBox_startYear);
            this.groupBox_startLand.Location = new System.Drawing.Point(12, 12);
            this.groupBox_startLand.Name = "groupBox_startLand";
            this.groupBox_startLand.Size = new System.Drawing.Size(1097, 480);
            this.groupBox_startLand.TabIndex = 4;
            this.groupBox_startLand.TabStop = false;
            this.groupBox_startLand.Text = "시작 국가 편집";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "시작 연도";
            // 
            // groupBox_Dynasty
            // 
            this.groupBox_Dynasty.Controls.Add(this.comboBox_emblem);
            this.groupBox_Dynasty.Controls.Add(this.comboBox_emblemColor2);
            this.groupBox_Dynasty.Controls.Add(this.comboBox_PatternColor2);
            this.groupBox_Dynasty.Controls.Add(this.comboBox_emblemColor1);
            this.groupBox_Dynasty.Controls.Add(this.comboBox_PatternColor1);
            this.groupBox_Dynasty.Controls.Add(this.comboBox_emblemPattern);
            this.groupBox_Dynasty.Controls.Add(this.label10);
            this.groupBox_Dynasty.Controls.Add(this.label8);
            this.groupBox_Dynasty.Controls.Add(this.label9);
            this.groupBox_Dynasty.Controls.Add(this.label7);
            this.groupBox_Dynasty.Controls.Add(this.label6);
            this.groupBox_Dynasty.Controls.Add(this.label5);
            this.groupBox_Dynasty.Controls.Add(this.label19);
            this.groupBox_Dynasty.Controls.Add(this.label11);
            this.groupBox_Dynasty.Controls.Add(this.textBox_dynMotto);
            this.groupBox_Dynasty.Controls.Add(this.textBox_dynName);
            this.groupBox_Dynasty.Controls.Add(this.label3);
            this.groupBox_Dynasty.Controls.Add(this.textBox_dynNum);
            this.groupBox_Dynasty.Location = new System.Drawing.Point(729, 76);
            this.groupBox_Dynasty.Name = "groupBox_Dynasty";
            this.groupBox_Dynasty.Size = new System.Drawing.Size(362, 392);
            this.groupBox_Dynasty.TabIndex = 7;
            this.groupBox_Dynasty.TabStop = false;
            this.groupBox_Dynasty.Text = "시작 가문 편집";
            // 
            // comboBox_emblem
            // 
            this.comboBox_emblem.FormattingEnabled = true;
            this.comboBox_emblem.Items.AddRange(new object[] {
            "ce_wyvern_rising"});
            this.comboBox_emblem.Location = new System.Drawing.Point(90, 284);
            this.comboBox_emblem.Name = "comboBox_emblem";
            this.comboBox_emblem.Size = new System.Drawing.Size(118, 28);
            this.comboBox_emblem.TabIndex = 6;
            // 
            // comboBox_emblemColor2
            // 
            this.comboBox_emblemColor2.FormattingEnabled = true;
            this.comboBox_emblemColor2.Items.AddRange(new object[] {
            "black",
            "blue",
            "blue_light",
            "brown",
            "green",
            "green_light",
            "grey",
            "orange",
            "purple",
            "red",
            "white",
            "yellow",
            "yellow_light"});
            this.comboBox_emblemColor2.Location = new System.Drawing.Point(134, 351);
            this.comboBox_emblemColor2.Name = "comboBox_emblemColor2";
            this.comboBox_emblemColor2.Size = new System.Drawing.Size(74, 28);
            this.comboBox_emblemColor2.TabIndex = 6;
            // 
            // comboBox_PatternColor2
            // 
            this.comboBox_PatternColor2.FormattingEnabled = true;
            this.comboBox_PatternColor2.Items.AddRange(new object[] {
            "black",
            "blue",
            "blue_light",
            "brown",
            "green",
            "green_light",
            "grey",
            "orange",
            "purple",
            "red",
            "white",
            "yellow",
            "yellow_light"});
            this.comboBox_PatternColor2.Location = new System.Drawing.Point(134, 250);
            this.comboBox_PatternColor2.Name = "comboBox_PatternColor2";
            this.comboBox_PatternColor2.Size = new System.Drawing.Size(74, 28);
            this.comboBox_PatternColor2.TabIndex = 6;
            // 
            // comboBox_emblemColor1
            // 
            this.comboBox_emblemColor1.FormattingEnabled = true;
            this.comboBox_emblemColor1.Items.AddRange(new object[] {
            "black",
            "blue",
            "blue_light",
            "brown",
            "green",
            "green_light",
            "grey",
            "orange",
            "purple",
            "red",
            "white",
            "yellow",
            "yellow_light"});
            this.comboBox_emblemColor1.Location = new System.Drawing.Point(134, 318);
            this.comboBox_emblemColor1.Name = "comboBox_emblemColor1";
            this.comboBox_emblemColor1.Size = new System.Drawing.Size(74, 28);
            this.comboBox_emblemColor1.TabIndex = 6;
            // 
            // comboBox_PatternColor1
            // 
            this.comboBox_PatternColor1.FormattingEnabled = true;
            this.comboBox_PatternColor1.Items.AddRange(new object[] {
            "black",
            "blue",
            "blue_light",
            "brown",
            "green",
            "green_light",
            "grey",
            "orange",
            "purple",
            "red",
            "white",
            "yellow",
            "yellow_light"});
            this.comboBox_PatternColor1.Location = new System.Drawing.Point(134, 217);
            this.comboBox_PatternColor1.Name = "comboBox_PatternColor1";
            this.comboBox_PatternColor1.Size = new System.Drawing.Size(74, 28);
            this.comboBox_PatternColor1.TabIndex = 6;
            // 
            // comboBox_emblemPattern
            // 
            this.comboBox_emblemPattern.FormattingEnabled = true;
            this.comboBox_emblemPattern.Items.AddRange(new object[] {
            "pattern_solid"});
            this.comboBox_emblemPattern.Location = new System.Drawing.Point(90, 184);
            this.comboBox_emblemPattern.Name = "comboBox_emblemPattern";
            this.comboBox_emblemPattern.Size = new System.Drawing.Size(118, 28);
            this.comboBox_emblemPattern.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "색상 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "엠블럼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "색상 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "색상 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "색상 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "문장 패턴";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "가훈";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "가문 이름";
            // 
            // textBox_dynMotto
            // 
            this.textBox_dynMotto.Location = new System.Drawing.Point(90, 93);
            this.textBox_dynMotto.Name = "textBox_dynMotto";
            this.textBox_dynMotto.Size = new System.Drawing.Size(266, 27);
            this.textBox_dynMotto.TabIndex = 3;
            // 
            // textBox_dynName
            // 
            this.textBox_dynName.Location = new System.Drawing.Point(250, 30);
            this.textBox_dynName.Name = "textBox_dynName";
            this.textBox_dynName.Size = new System.Drawing.Size(106, 27);
            this.textBox_dynName.TabIndex = 3;
            // 
            // groupBox_province
            // 
            this.groupBox_province.Controls.Add(this.btn_readtitlesFile);
            this.groupBox_province.Controls.Add(this.btn_addProvince);
            this.groupBox_province.Controls.Add(this.comboBox_provinces);
            this.groupBox_province.Controls.Add(this.listBox_startProvince);
            this.groupBox_province.Location = new System.Drawing.Point(6, 76);
            this.groupBox_province.Name = "groupBox_province";
            this.groupBox_province.Size = new System.Drawing.Size(183, 392);
            this.groupBox_province.TabIndex = 6;
            this.groupBox_province.TabStop = false;
            this.groupBox_province.Text = "프로빈스 수정";
            // 
            // btn_readtitlesFile
            // 
            this.btn_readtitlesFile.Location = new System.Drawing.Point(20, 26);
            this.btn_readtitlesFile.Name = "btn_readtitlesFile";
            this.btn_readtitlesFile.Size = new System.Drawing.Size(147, 30);
            this.btn_readtitlesFile.TabIndex = 4;
            this.btn_readtitlesFile.Text = "titles 파일 읽기";
            this.btn_readtitlesFile.UseVisualStyleBackColor = true;
            this.btn_readtitlesFile.MouseHover += new System.EventHandler(this.btn_readtitlesFile_MouseHover);
            // 
            // btn_addProvince
            // 
            this.btn_addProvince.Location = new System.Drawing.Point(20, 99);
            this.btn_addProvince.Name = "btn_addProvince";
            this.btn_addProvince.Size = new System.Drawing.Size(147, 28);
            this.btn_addProvince.TabIndex = 2;
            this.btn_addProvince.Text = "추가";
            this.btn_addProvince.UseVisualStyleBackColor = true;
            // 
            // comboBox_provinces
            // 
            this.comboBox_provinces.FormattingEnabled = true;
            this.comboBox_provinces.Location = new System.Drawing.Point(20, 65);
            this.comboBox_provinces.Name = "comboBox_provinces";
            this.comboBox_provinces.Size = new System.Drawing.Size(147, 28);
            this.comboBox_provinces.TabIndex = 3;
            // 
            // listBox_startProvince
            // 
            this.listBox_startProvince.FormattingEnabled = true;
            this.listBox_startProvince.ItemHeight = 20;
            this.listBox_startProvince.Location = new System.Drawing.Point(20, 133);
            this.listBox_startProvince.Name = "listBox_startProvince";
            this.listBox_startProvince.Size = new System.Drawing.Size(147, 244);
            this.listBox_startProvince.TabIndex = 1;
            // 
            // textBox_startYear
            // 
            this.textBox_startYear.Location = new System.Drawing.Point(102, 40);
            this.textBox_startYear.Name = "textBox_startYear";
            this.textBox_startYear.Size = new System.Drawing.Size(147, 27);
            this.textBox_startYear.TabIndex = 3;
            // 
            // btn_tempMake
            // 
            this.btn_tempMake.Location = new System.Drawing.Point(1115, 403);
            this.btn_tempMake.Name = "btn_tempMake";
            this.btn_tempMake.Size = new System.Drawing.Size(251, 89);
            this.btn_tempMake.TabIndex = 5;
            this.btn_tempMake.Text = "모드 생성";
            this.btn_tempMake.UseVisualStyleBackColor = true;
            this.btn_tempMake.Click += new System.EventHandler(this.btn_tempMake_Click);
            // 
            // textBox_tempName
            // 
            this.textBox_tempName.Location = new System.Drawing.Point(1191, 370);
            this.textBox_tempName.Name = "textBox_tempName";
            this.textBox_tempName.Size = new System.Drawing.Size(175, 27);
            this.textBox_tempName.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1111, 373);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "모드 이름";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(1115, 25);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(251, 190);
            this.textBox_log.TabIndex = 3;
            // 
            // btn_dnaParse
            // 
            this.btn_dnaParse.Location = new System.Drawing.Point(1115, 221);
            this.btn_dnaParse.Name = "btn_dnaParse";
            this.btn_dnaParse.Size = new System.Drawing.Size(251, 51);
            this.btn_dnaParse.TabIndex = 5;
            this.btn_dnaParse.Text = "dna 분석";
            this.btn_dnaParse.UseVisualStyleBackColor = true;
            this.btn_dnaParse.Click += new System.EventHandler(this.btn_dnaParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1378, 501);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_dnaParse);
            this.Controls.Add(this.btn_tempMake);
            this.Controls.Add(this.groupBox_startLand);
            this.Controls.Add(this.textBox_tempName);
            this.Controls.Add(this.textBox_log);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "크킹3 커스텀 국가";
            this.groupBox_startKing.ResumeLayout(false);
            this.groupBox_startKing.PerformLayout();
            this.groupBox_startLand.ResumeLayout(false);
            this.groupBox_startLand.PerformLayout();
            this.groupBox_Dynasty.ResumeLayout(false);
            this.groupBox_Dynasty.PerformLayout();
            this.groupBox_province.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Traits;
        private System.Windows.Forms.ListBox addlist_Traits;
        private System.Windows.Forms.Button btn_addTrait;
        private System.Windows.Forms.GroupBox groupBox_startKing;
        private System.Windows.Forms.CheckBox checkBox_isFemale;
        private System.Windows.Forms.GroupBox groupBox_startLand;
        private System.Windows.Forms.Button btn_tempMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_startProvince;
        private System.Windows.Forms.TextBox textBox_tempName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CharNum;
        private System.Windows.Forms.Button btn_addProvince;
        private System.Windows.Forms.Button btn_readtitlesFile;
        private System.Windows.Forms.ComboBox comboBox_provinces;
        private System.Windows.Forms.TextBox textBox_startYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dynNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_charStat6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_charStat5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_charStat4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_charStat3;
        private System.Windows.Forms.TextBox textBox_charStat2;
        private System.Windows.Forms.TextBox textBox_charStat1;
        private System.Windows.Forms.TextBox textBox_charAge;
        private System.Windows.Forms.GroupBox groupBox_Dynasty;
        private System.Windows.Forms.ComboBox comboBox_emblem;
        private System.Windows.Forms.ComboBox comboBox_emblemColor2;
        private System.Windows.Forms.ComboBox comboBox_PatternColor2;
        private System.Windows.Forms.ComboBox comboBox_emblemColor1;
        private System.Windows.Forms.ComboBox comboBox_PatternColor1;
        private System.Windows.Forms.ComboBox comboBox_emblemPattern;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_dynMotto;
        private System.Windows.Forms.TextBox textBox_dynName;
        private System.Windows.Forms.GroupBox groupBox_province;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolTip toolTip_readtitlesFile;
        private System.Windows.Forms.ComboBox comboBox_culture;
        private System.Windows.Forms.ComboBox comboBox_religion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_charName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_dna;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button btn_dnaParse;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cknewruler
{
    class randomGen
    {
        private static string m_ChoSungTbl = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ";

        private static string m_JungSungTbl = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ";

        private static string m_JongSungTbl = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ";

        private static ushort m_UniCodeHangulBase = 0xAC00;

        private static ushort m_UniCodeHangulLast = 0xD79F;

        public static string generateFolderName(char lang='k')
        {
            int length = 5;
            string msg = "";
            Random r = new Random();
            if (lang=='k')
            {
                for (int i = 0; i < length; i++)
                {
                    int a = r.Next(0, m_ChoSungTbl.Length);
                    int b = r.Next(0, m_JungSungTbl.Length);
                    int c = r.Next(0, m_JongSungTbl.Length);
                    msg += MergeChar(a, b, c);
                }
            }
            if (lang == 'e')
            {

                for (int i = 0; i < length; i++)
                {
                    int a = r.Next(65, 123);
                    msg += Convert.ToChar(a);
                }
            }
            return msg;
        }
        private static string MergeChar(string ch, string j, string jon)
        {
            int ch_pos, j_pos, jon_pos;
            int nUnicode;
            ch_pos = m_ChoSungTbl.IndexOf(ch);
            j_pos = m_JungSungTbl.IndexOf(j);
            jon_pos = m_JongSungTbl.IndexOf(jon);
            nUnicode = m_UniCodeHangulBase + (ch_pos * 21 + j_pos) * 28 + jon_pos;
            char temp = Convert.ToChar(nUnicode);
            return temp.ToString();
        }
        private static string MergeChar(int a, int b, int c)
        {
            int nUnicode;
            nUnicode = m_UniCodeHangulBase + (a * 21 + b) * 28 + c;
            char temp = Convert.ToChar(nUnicode);
            return temp.ToString();
        }
    }
}

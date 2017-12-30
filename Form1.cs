using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void regexCheck(string content) {
            List<string> contentArray = new List<string>();
            Regex rx = new Regex(@"(\S.+?[.!?])(?=\s+|$)");
            foreach (Match match in rx.Matches(content))
            {
                int i = match.Index;
                //  Console.WriteLine(match.Value);
                contentArray.Add(match.Value);
            }
            string[] contentWords = content.Split(' ');

        }

        private void process_Click(object sender, EventArgs e)
        {
            
           
           

            KEA kEA = new KEA(richTextBox1.Text,saveToDocsChckBx.Checked);
            CreateKeyWordDataGridView(kEA.resultList);
            CEA cEA = new CEA(kEA.resultList);
            Catlabel.Text= cEA.finalCategory;
        }

        void CreateKeyWordDataGridView(List<wordClass> list)
        {
            keywordGridView.Rows.Clear();
            keywordGridView.ColumnCount = 4;
            keywordGridView.Columns[0].Name = "کلمه کلیدی";
            keywordGridView.Columns[1].Name = "تکرار در متن";
            keywordGridView.Columns[2].Name = "تراکم در متن";
            keywordGridView.Columns[3].Name = "رتبه";
            for(int i = 0; i < Convert.ToInt32(keyCountTxtbx.Text); i++)
            {
                keywordGridView.Rows.Add(list[i].word, list[i].repeat,list[i].frequency, list[i].TFIDF);
            }
        }
        
    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }
}

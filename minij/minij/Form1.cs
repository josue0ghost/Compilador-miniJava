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

namespace minij
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> reserved = new Dictionary<string, string>()
        {
            { "void", "T_void"},
            { "int", "T_ValueType"},
            { "double", "T_ValueType"},
            { "boolean", "T_ValueType"},
            { "string", "T_ValueType"},
            { "class", "T_ReferenceType"},
            { "const", "T_ValueType"},
            { "interface", "T_ReferenceType"},
            { "null", "T_ValueType"},
            { "this", "T_ReferenceType"},
            { "extends", "T_KeyWord"},
            { "implements", "T_KeyWord"},
            { "for", "T_KeyWord"},
            { "while", "T_KeyWord"},
            { "if", "T_KeyWord"},
            { "else", "T_KeyWord"},
            { "return", "T_KeyWord"},
            { "break", "T_KeyWord"},
            { "New", "T_KeyWord"},
            { "System", "T_JavaLang"},
            { "out", "T_SystemClass"},
            { "println", "T_Method"}
        };

        List<string> operators = new List<string>() 
        { "+", "-", "*", "/", "%", "<", "<=", ">", ">=", "=", "==",
          "!=", "&&", "||", "!", ";", ",", ".", "[]", "()", "{}",
          "[", "]", "(", ")", "{", "}" 
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Frag files (*.frag)|*.frag";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = Read(oFD.FileName);
            }
        }

        public string Read(string path)
        {
            string freaded = "";
            using (StreamReader sr = new StreamReader(path))
            {
                freaded = sr.ReadToEnd();               
            }
            return freaded;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Frag files (*.frag)|*.frag";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFD.OpenFile()))
                {
                    writer.WriteLine(fileTextBox.Text);
                    writer.Dispose();
                }
            }
        }

        private void analizeLex_btn_Click(object sender, EventArgs e)
        {
            string temp = "";            
            string response = "";
            int cont = 1; 
            string input = fileTextBox.Text;                       
            List<string> lines = input.Split('\n').ToList();

            foreach (string item in lines) 
            {                
                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsWhiteSpace(item[i])) {
                        if (temp != "")
                        {
                            response += AnalyzeString(item, temp, cont);
                            temp = "";                            
                        }
                    }
                    else if (operators.Contains(item[i].ToString()))
                    {
                        if (temp != "") 
                        {
                            response += AnalyzeString(item, temp, cont);
                            temp = "";
                            i--;
                        }

                    }
                    else
                    {
                        temp += item[i];
                    }
                }

                cont++;
            }
            MessageBox.Show(response);
        }

        public string AnalyzeString(string line, string input, int cont) {            
            //check the dictionary for reserved words 
            if (reserved.ContainsKey(input))
            {
                int start = line.IndexOf(input) + 1;
                int end = start + input.Length - 1; 
                var result = reserved.Where(pair => pair.Key == input).ToArray();                
                return $"{result[0].Key}\t line {cont} cols {start}-{end} is {result[0].Value}\n";
            }
            return "";
        }

        public string AnalyzeOperator(string input) {
            return "";
        }


    }
}

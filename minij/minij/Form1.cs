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

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "txt files (*.txt)|*.txt";
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
            saveFD.Filter = "txt files (*.txt)|*.txt";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFD.OpenFile()))
                {
                    writer.WriteLine(fileTextBox.Text);
                    writer.Dispose();
                }
            }
        }
    }
}

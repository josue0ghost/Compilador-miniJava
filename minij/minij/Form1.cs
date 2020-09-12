﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace minij
{
    public partial class Form1 : Form
    {
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            //oFD.Filter = "Frag files (*.frag)|*.frag";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = Read(oFD.FileName);
                fileName = Path.GetFileName(oFD.FileName).Replace(Path.GetExtension(oFD.FileName), ".out");
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
            saveFD.Filter = "Frag files (*.frag)|*.frag|(*.txt)|*.txt";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFD.OpenFile()))
                {
                    writer.WriteLine(fileTextBox.Text);
                    writer.Dispose();
                }
                fileName = fileTextBox.Text;
            }
        }

        private void analizeLex_btn_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("GUARDE EL ARCHIVO");
            }
            else
            {
                // create directory on project folder
                string basePath = string.Format(@"{0}Outputs\", AppContext.BaseDirectory);
                DirectoryInfo directory = Directory.CreateDirectory(basePath);

                string noComments = RegularExpressions.replaceCommentsToNothing(fileTextBox.Text);
                string output = Data.Instance.fr.LexicalAnalysis(noComments, fileTextBox.Text.Split('\n').ToList());
                MessageBox.Show(output);

                if (output != "")
                {
                    using (StreamWriter file = new StreamWriter(basePath + fileName))
                    {
                        file.WriteLine(output);
                        file.Close();
                    }
                }

                if (FileReader.errors != "")
                {
                    using (StreamWriter file = new StreamWriter(basePath + "ERRORS-" + fileName))
                    {
                        file.WriteLine(FileReader.errors);
                        file.Close();
                    }
                }
                parser.Enabled = true;
            }
        }

        private void parser_Click(object sender, EventArgs e)
        {
            Data.Instance.rp = new RecursiveParser(Data.Instance.fr.getTokens());
            string output = Data.Instance.rp.Parse();

            if (output == "")
            {
                MessageBox.Show("El archivo es sintácticamente correcto");
            }
            else
            {
                MessageBox.Show(output);
            }
        }
    }
}

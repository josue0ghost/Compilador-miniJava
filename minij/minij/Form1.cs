using System;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LR parser = new LR();

            List<string> input = new List<string>();
            string println = "";
            for (int i = 0; i < FileReader.tokens.Count; i++)
            {
                if (FileReader.tokens[i] == "System")
                {
                    if ((i+4) <= FileReader.tokens.Count)
                    {
                        //-------- System------.----------out----------.------------println
                        println = input[i] + input[i + 1] + input[i + 2] + input[i + 3] + input[i + 4];
                        input.Add(println);

                        i += 4;
                    }
                }
                else
                {
                    input.Add(FileReader.tokens[i]);
                }
            }

            parser.input = input;
            parser.stack.Push(0);
            parser.fooState0(false);
        }
    }
}

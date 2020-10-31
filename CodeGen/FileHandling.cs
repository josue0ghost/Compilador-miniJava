using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeGen
{
    class FileHandling
    {
        public List<string[]> ReadFile(ref string[] head, string path)
        {
            try
            {
                List<string[]> states = new List<string[]>();

                using (var sr = new StreamReader(path))
                {
                    // encabezados
                    head = sr.ReadLine().Split(",");


                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        states.Add(line.Split(","));
                    }
                }

                return states;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public List<string[]> ReadFileProd(string path)
        {
            try
            {
                List<string[]> states = new List<string[]>();

                using (var sr = new StreamReader(path))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        states.Add(line.Split(","));
                    }
                }

                return states;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public void WriteFile(string line, string path)
        {
            try
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

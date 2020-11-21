using System;

namespace CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // paths
            string tablaAnalisis = "C:\\Users\\edanP\\OneDrive\\Escritorio\\TablaAnalisis-Proyecto-SC.csv";
            string producciones = "C:\\Users\\edanP\\OneDrive\\Escritorio\\Reducciones.csv";
            string output = "C:\\Users\\edanP\\OneDrive\\Escritorio\\salida.txt";

            CodeGenerator cg = new CodeGenerator();

            try
            {
                cg.Generate(tablaAnalisis, producciones, output);
                Console.WriteLine("Archivo Generado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al generar el archivo");
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
            
        }
    }
}

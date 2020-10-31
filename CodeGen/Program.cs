using System;

namespace CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // paths
            string tablaAnalisis = "C:\\Users\\llaaj\\OneDrive\\Escritorio\\compis\\tabla de analisis.txt";
            string producciones = "C:\\Users\\llaaj\\OneDrive\\Escritorio\\compis\\producciones.txt";
            string output = "C:\\Users\\llaaj\\OneDrive\\Escritorio\\compis\\salida.txt";

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

using System;

namespace CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // paths
            string tablaAnalisis = "";
            string producciones = "";
            string output = "";

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
                throw;
            }


            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
            
        }
    }
}

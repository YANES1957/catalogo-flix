using System;
using System.Collections.Generic;

namespace CatalogoFlix
{
    public class ListarRegistros
    {
        public void MostrarRegistros(List<Dictionary<string, string>> registros)
        {
            foreach (var registro in registros)
            {
                Console.WriteLine("---- Registro ----");
                foreach (var par in registro)
                {
                    Console.WriteLine($"{par.Key}: {par.Value}");
                }
            }
        }
    }
}

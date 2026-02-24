using System.Collections.Generic;

namespace CatalogoFlix
{
    public class CriarRegistro
    {
        private List<Dictionary<string, string>> registros = new List<Dictionary<string, string>>();

        public void AdicionarRegistro(string titulo, string genero)
        {
            if (string.IsNullOrEmpty(titulo)) titulo = "";
            if (string.IsNullOrEmpty(genero)) genero = "";

            var registro = new Dictionary<string, string>
            {
                ["titulo"] = titulo,
                ["genero"] = genero
            };
            registros.Add(registro);
        }

        public List<Dictionary<string, string>> ObterRegistros()
        {
            return registros;
        }
    }
}

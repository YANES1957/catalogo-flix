using System.Collections.Generic;
using System.Linq;

namespace CatalogoFlix
{
    public class FiltrarRegistro
    {
        private CriarRegistro criador;

        public FiltrarRegistro(CriarRegistro criador)
        {
            this.criador = criador;
        }

        public List<Dictionary<string, string>> FiltrarPorGenero(string genero)
        {
            return criador.ObterRegistros()
                          .Where(r => r["genero"] == genero)
                          .ToList();
        }
    }
}

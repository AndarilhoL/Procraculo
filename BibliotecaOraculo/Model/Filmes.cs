using System.Collections.Generic;

namespace BibliotecaOraculo.Model
{
    public class Filmes
    {
        public int IdFilme { get; set; }
        public string Descricao { get; private set; }
        public bool IsCompleto { get; private set; }
        public List<Generos> Generos { get; private set; }

        public Filmes(string Descricao, Generos generos)
        {
            this.Descricao = Descricao;
            this.IsCompleto = false;
        }

        public Filmes(string Descricao, Generos generos, bool Completo)
        {
            this.Descricao = Descricao;
            this.IsCompleto = Completo;
            
        }
    }
}

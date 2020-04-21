namespace BibliotecaOraculo.Model
{
    public class Genero
    {
        public long? IdGenero { get; private set; }
        public string Descricao { get; private set; }

        public Genero(string descricao, long? idGenero = null)
        {
            this.Descricao = descricao;
            this.IdGenero = idGenero;
        }
    }
}

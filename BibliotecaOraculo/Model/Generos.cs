namespace BibliotecaOraculo.Model
{
    public class Generos
    {
        public int IdGeneros { get; private set; }
        public string Descricao { get; private set; }

        public Generos(string Descricao)
        {
            this.Descricao = Descricao;
        }
    }
}

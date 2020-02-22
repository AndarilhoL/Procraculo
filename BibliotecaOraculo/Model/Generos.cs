namespace BibliotecaOraculo.Model
{
    public class Generos
    {
        public int IdGeneros { get; set; }
        public string Descricao { get; set; }

        public Generos(string Descricao)
        {
            this.Descricao = Descricao;
        }
    }
}

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Cidade : ObjetoComId,ICidade
    {
        public IEstado Estado;
        public Cidade(string nome, IEstado estado)
        {
            Nome = nome;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} Estado: {Estado}";
        }
    }
}

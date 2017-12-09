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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

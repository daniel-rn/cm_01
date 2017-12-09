namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Estado : ObjetoComId, IEstado
    {
        public string Nome { get; set; }

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
            return Nome;
        }
    }
}

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public abstract class Funcionario : ObjetoComId
    {
        public Cargo Cargo { get; set; }

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
